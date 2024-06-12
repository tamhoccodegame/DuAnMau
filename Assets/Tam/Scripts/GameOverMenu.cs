using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void Retry()
    {
        FindObjectOfType<UI_HealthBar>().UpdateHealthbar(100); 
     
        GameObject.Find("UpgradeStatUI").GetComponent<UI_PlayerStat>().SetActive(false); 
        gameObject.SetActive(false);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Destroy(GameObject.Find("ScoreKeeper"));
		gameObject.SetActive(false);
	}
}
