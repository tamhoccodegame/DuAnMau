using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

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

    public void     
}
