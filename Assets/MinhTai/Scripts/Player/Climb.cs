using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    public float climbSpeed = 2.5f;
    private bool isClimbing = false; // Kiểm tra Player có đang trèo thang hay không
    private Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder") )
        {
            //Debug.Log("Đã vào thang");
            isClimbing = true;
            rb.gravityScale = 0f;
            // Kích hoạt trigger trong Animator để chuyển đến animation leo lên
            anim.SetBool("isClimbing", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder") )
        {
            //Debug.Log("Đã ra khỏi thang");
            isClimbing = false;
            rb.gravityScale = 3f;
            // Kích hoạt trigger trong Animator để chuyển đến animation leo xuống
            anim.SetBool("isClimbing", false); 
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            float climbInput = Input.GetAxis("Vertical");
            //Debug.Log("Đang trèo với input: " + climbInput);
            rb.velocity = new Vector2(rb.velocity.x, climbInput * climbSpeed);
        }
    }
}
