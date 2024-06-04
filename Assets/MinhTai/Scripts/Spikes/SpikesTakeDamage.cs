using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesTakeDamage : MonoBehaviour
{
    public float damageAmount = 25f; // Số máu bị trừ khi va chạm

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			Health playerHealth = collision.gameObject.GetComponent<Health>();
			if (playerHealth != null)
			{
				playerHealth.TakeDamage(damageAmount); // Gọi hàm TakeDamage để giảm máu người chơi
				Debug.Log("Player hit by Spikes. Current Health: " + playerHealth.currentHealth); // Thông báo va chạm
			}
		}
	}
  
}
