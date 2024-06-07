using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	private float maxHealth = 60f;
    private float currentHealth;

    public ParticleSystem hitEffect;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        hitEffect.Play();
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die(); 
        }
    }

    private void Die()
    {
        FindObjectOfType<ScoreKeeper>().AddScore(20); 
        Destroy(gameObject);
    }
}
