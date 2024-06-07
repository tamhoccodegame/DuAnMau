using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    private Animator anim;
    private bool dead;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float _damage)
    {
            if (!dead)
            {
                anim.SetTrigger("dead");
                dead = true;
            }
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
