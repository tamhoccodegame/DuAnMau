using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public Rigidbody2D _rigibody;
    public float speed;
    public float projectileLife;
    public float projectileCount;
    // Start is called before the first frame update
    void Start()
    {
        projectileCount = projectileLife;
    }

    // Update is called once per frame
    void Update()
    {
        projectileCount -= Time.deltaTime;
        if (projectileCount <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        _rigibody.velocity = new Vector2(speed, _rigibody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);

        if(collision.gameObject.tag == "boss")
        {
            bossHealth bosshealth = collision.gameObject.GetComponent<bossHealth>();
            bosshealth.TakeDamage(10);            
        }
    }
}
