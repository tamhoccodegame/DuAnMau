using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			FindObjectOfType<UI_HealthBar>().UpdateHealthbar(100);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
		}
	}
}
