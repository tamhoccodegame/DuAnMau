using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour  
{

    private int score;

    public ScoreKeeper instance;
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
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public int GetScored()
    {
        return score;
    }

   
}
