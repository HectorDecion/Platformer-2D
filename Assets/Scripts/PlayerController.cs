using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float jumpForce = 5f;
    public float playerSpeed = 5f;
    public LayerMask groundMask;
    private Animator animator;

    private SpriteRenderer spriteRenderer;  //Flip X

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>(); //Flip X
    }
    private void FixedUpdate()
    {
    }
    private void Update()
    {
        PlayerMovement();
        Jump();
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
            animator.SetBool("isIdle", false);
            // if (Equals(KeyCode.Space))
            // {
            //     animator.SetBool("isJumping", true);

        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }

    void PlayerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");


        Vector2 movement = new Vector2(moveHorizontal, 0);
        playerRB.AddForce(movement * playerSpeed); //movement * speed * Time.deltaTime;
        if (moveHorizontal != 0f)
        {
           animator.SetBool("isRunning", true);

        }
        else
        {
            animator.SetBool("isRunning", false);
            spriteRenderer.flipX = false; // Hace que gire a la derecha con FLIP X
        }

  //      if (spriteRenderer.flipX) //Flip X
   //     {
            spriteRenderer.flipX = false;
   //     }
  //      else
  //          spriteRenderer.flipX = true;

    }

}
