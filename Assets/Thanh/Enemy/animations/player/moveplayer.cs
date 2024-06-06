using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class moveplayer : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    private BoxCollider2D _boxcoll;
    private float direction = 0f;

    [SerializeField]
    private LayerMask groundLayers;

    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float jumpSpeed = 5f;

    public bool flipedLeft;
    public bool flipedRight;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _boxcoll = GetComponent<BoxCollider2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        _rigidbody.velocity = new Vector2(direction * speed,_rigidbody.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x,jumpSpeed);
        }
    }

    bool isGrounded()
    {
        return Physics2D.BoxCast(_boxcoll.bounds.center, _boxcoll.bounds.size, 0f, Vector2.down, .1f, groundLayers);
    }



}
