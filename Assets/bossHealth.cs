using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;
    private Animator anim;
    public float currentHealth { get; private set; }
    private bool dead;

    public GameObject winCutscene;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, maxHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("gethit");
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("Ondead");
                dead = true;
                winCutscene.SetActive(true);
            }
        }
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
