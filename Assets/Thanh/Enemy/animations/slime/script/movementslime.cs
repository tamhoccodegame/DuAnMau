using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementslime : MonoBehaviour
{
    public int LeftTotal = 3;
    public int EnemySpeed = 1;
    public Rigidbody2D _rigibody;

    void Start()
    {
        _rigibody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rigibody.velocity = transform.right * EnemySpeed;    
    }

    public void OnDeath()
    {
        Destroy(gameObject);
    }
}
