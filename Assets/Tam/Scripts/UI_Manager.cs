using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    private Transform gameOverUI;
    void Start()
    {
        gameOverUI = transform.Find("GameOverUI");
        gameOverUI.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameOverUI.gameObject.SetActive(true);
    }
}
