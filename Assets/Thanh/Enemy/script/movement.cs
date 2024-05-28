using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float detectRange = 5f;
    private Rigidbody2D _rigidbody2D;

    public GameObject startPoint;
    public GameObject endPoint;
    private Vector3 initPos;
    float direction = 1f;

    private bool isChasing = false;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<Transform>();
        initPos = player.position;
    }

    // Update is called once per frame
    void Update()
    {


  //      direction = transform.position.x - player.transform.position.x;

		//if (Mathf.Abs(direction) < detectRange)
  //      {
  //          //Di player
  //          if(Mathf.Abs(transform.position.y - player.transform.position.y) <= 1)
  //          {
  //              isChasing = true;
  //          }
  //      }

  //      if(isChasing)
  //      {

		//	if (Mathf.Abs(direction) >= 7)
		//	{
		//		isChasing = false;

		//	}

		//	Vector3 newPos = transform.position;
  //          newPos.x += -direction * moveSpeed * Time.deltaTime;

  //          transform.position = newPos;

            
  //      }

  //      else
  //      {
			_rigidbody2D.velocity = new Vector2(x: direction * moveSpeed, y: 0);
		//}

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //neu cham vao 1 trong 2 diem thi quay dau
        if (other.gameObject == startPoint)
            direction = 1;

        if (other.gameObject == endPoint)
            direction = -1; 

        //xoay huong cua slime
        transform.localScale = new Vector2(x: -(Mathf.Sign(_rigidbody2D.velocity.x)), y: 1f);

        
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			player.GetComponent<Health>().TakeDamage(10);
		}
	}
}
