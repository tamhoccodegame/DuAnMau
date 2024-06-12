using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_PlayerStat : MonoBehaviour
{
    private PlayerController player;

    private int healthCount = 2;
    private int damageCount = 2;
    void Start()
    {
        
        SetActive(false);

        transform.Find("Health").GetComponent<Button_UI>().ClickFunc = () =>
        {
            player.SetMaxHealth(healthCount * 100);
            healthCount++;
            SetActive(false);
        };
        transform.Find("Damage").GetComponent<Button_UI>().ClickFunc = () =>
        {
            player.SetDamage(damageCount * 20); 
            damageCount++;
			SetActive(false);
		};
    }

	
	public void SetActive(bool active)
    {
		foreach (Transform child in transform)
		{
			child.gameObject.SetActive(active);
		}
	}

    public void TurnOnOff()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
		if ( index + 1 <= 1)
		{
			SetActive(false);
		}
        else if ( index + 1 >= 5)
        {
			Destroy(GameObject.Find("ScoreKeeper"));
		}
        else
        {
			SetActive(true);
		}
	}

    private void RefreshUI()
    {
        if(healthCount > 1)  
		transform.Find("Health").Find("Text").GetComponent<TextMeshProUGUI>().text = healthCount.ToString();

        if(damageCount > 1)
		transform.Find("Damage").Find("Text").GetComponent<TextMeshProUGUI>().text = damageCount.ToString();
	}

    public void SetPlayerController(PlayerController player)
    {
        this.player = player;
    }
}

