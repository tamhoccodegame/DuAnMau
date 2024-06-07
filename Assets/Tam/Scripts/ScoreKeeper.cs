using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour  
{

    private int score;
    private TextMeshProUGUI scoreText;

    public static ScoreKeeper instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
			instance = this;
			DontDestroyOnLoad(gameObject);
        }
		score = 0;
		scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
	}

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString("000000");
    }

    public int GetScored()
    {
        return score;
    }

   
}
