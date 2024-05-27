using UnityEngine;

public class Monster_TakeDamage : MonoBehaviour
{
    public float damageAmount = 10f; // Số máu bị trừ khi va chạm

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount); // Gọi hàm TakeDamage để giảm máu người chơi
                Debug.Log("Player hit by monster. Current Health: " + playerHealth.currentHealth); // Thông báo va chạm
            }
        }
    }
}
