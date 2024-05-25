using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    [Header ("Health")]
    [SerializeField] private float healthLife = 3f;
    public float currentHealth;
    private bool dead;

    [Header("iFrames")]
    [SerializeField] private float iFramesDur;
    [SerializeField] private int numberOfflashes;
    private SpriteRenderer spriteRend;


    private void Awake()
    {
        currentHealth = healthLife;
        spriteRend = GetComponent<SpriteRenderer>();
    }
    public void TakeDamage(float damege)
    {
        currentHealth = Mathf.Clamp(currentHealth - damege,0 , healthLife);
        if (currentHealth > 0)
        {
            //Player bị thương 
            //IFrames
            StartCoroutine(Ivunerability());
        }
        else
        {
            //Player chết 
            if (!dead) //nếu Player chết sẽ tắt code điều khiển 
            {
                GetComponent<PlayerController>().enabled = false;
                dead = true;
                
            }
           
        }
    }

    private IEnumerator Ivunerability()
    {
        Physics2D.IgnoreLayerCollision(6, 9, true);
        for (int i = 0; i < numberOfflashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDur / (numberOfflashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFramesDur / (numberOfflashes * 2));
        }
        Physics2D.IgnoreLayerCollision(6, 9, false);
    }
}
