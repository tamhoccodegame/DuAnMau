using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDamage : MonoBehaviour
{
	private Dictionary<string, AudioClip> soundClips = new Dictionary<string, AudioClip>();
	public AudioClip[] audioClips;
	private float damage;
	// Start is called before the first frame update
	void Start()
    {
		soundClips.Add("hit", audioClips[0]);
		damage = FindObjectOfType<PlayerController>().GetDamage();
	}

	
	public void PlaySound(string soundName)
	{
		if (soundClips.ContainsKey(soundName))
		{
			AudioSource.PlayClipAtPoint(soundClips[soundName], transform.position);
		}
	}

	// Update is called once per frame
	void Update()
    {
        
    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "enemy")
        {
            collision.gameObject?.GetComponent<bossHealth>()?.TakeDamage(damage);
			collision.gameObject?.GetComponent<EnemyHealth>()?.TakeDamage(damage);
			Debug.Log((bool)gameObject.GetComponent<EnemyHealth>());
			PlaySound("hit");
            Destroy(gameObject); 
        }
	}
}
