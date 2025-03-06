using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed; //for movement

    public float jumpingPower; //for jump

    private bool isGrounded;    //for jump

    public bool isFacingRight; //for flip

    public float horizontal;

    public Transform groundCheck;   //for jump

    public LayerMask groundLayer;   //for jump

    public Animator animator;
    public bool isWalking;
    public bool isJumping;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        Flip();
        HandleAnimation();

    }


    void PlayerMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded()) //if button hit and is player grounded
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower); //jump
            isJumping = true;
        }
        if (IsGrounded() && rb.velocity.y == 0)
        {
            isJumping = false;
        }
        isWalking = horizontal != 0 ? true : false;
    }


    private void FixedUpdate() //execution order
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y); //how long button pressed or hold(left/right)


    }

    void HandleAnimation()
    {

        animator.SetBool("isWalking", isWalking);
        animator.SetBool("isJumping", isJumping);

    }


    void Flip()
    {           //Flip to Left                      //Flip to Right
        if (isFacingRight && horizontal > 0f || !isFacingRight && horizontal < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector2 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    private void LateUpdate() //late reading 
    {

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

}
