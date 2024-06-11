using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBossCutscene : MonoBehaviour
{
    public GameObject cutScene;
	public GameObject platformer;
	public GameObject spike;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(!collision.CompareTag("Player")) return;
		cutScene.SetActive(true);
		platformer.SetActive(true);
		spike.SetActive(true);
		Destroy(gameObject);
	}
}
