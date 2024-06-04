using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionScript : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			Health playerHealth = collision.GetComponent<Health>();
			if (playerHealth != null)
			{
				playerHealth.RecoverHealth(30); 
			}
			Destroy(gameObject);
		}
	}
}
