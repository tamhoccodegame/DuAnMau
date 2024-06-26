using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
{
	UI_PlayerStat stat;

	private void Start()
	{
		stat = GameObject.Find("UpgradeStatUI").GetComponent<UI_PlayerStat>();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			FindObjectOfType<UI_HealthBar>().UpdateHealthbar(100);
			
			Debug.Log(stat != null);

			StartCoroutine(LoadScene()); 
			
		}
	}

	public IEnumerator LoadScene()
	{
		yield return new WaitForSeconds(.2f); stat.TurnOnOff();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		
		
	}
}
