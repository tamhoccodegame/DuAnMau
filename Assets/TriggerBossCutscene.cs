using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBossCutscene : MonoBehaviour
{
    public GameObject cutScene;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		cutScene.SetActive(true);
		Destroy(gameObject);
	}
}
