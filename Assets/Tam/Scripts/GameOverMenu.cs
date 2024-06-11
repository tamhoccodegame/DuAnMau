using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void Retry()
    {
        FindObjectOfType<UI_HealthBar>().UpdateHealthbar(100); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameObject.Find("UpgradeStatUI").SetActive(false);
        gameObject.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
		gameObject.SetActive(false);
	}
}
