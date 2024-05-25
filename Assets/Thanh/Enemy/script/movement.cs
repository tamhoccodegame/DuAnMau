using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 1f;
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = new Vector2(x: moveSpeed, y: 0);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed *= -1;
        //xoay huong cua slime
        transform.localScale = new Vector2(x: -(Mathf.Sign(_rigidbody2D.velocity.x)),y:1f);
    }
}
