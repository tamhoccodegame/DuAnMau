using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowbow : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launhPoint;

    public float shootTime; // cooldown giua projectiles
    public float shootCounter; // cooldown timer
    // Start is called before the first frame update
    void Start()
    {
        shootCounter = shootTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && shootCounter <= 0)
        {
            Instantiate(projectilePrefab, launhPoint.position, Quaternion.identity);
            shootCounter = shootTime;
        }
        shootCounter -= Time.deltaTime;
    }
        
}
