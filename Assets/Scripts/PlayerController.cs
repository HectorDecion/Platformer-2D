using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float jumpForce = 5f;
    public float playerSpeed = 5f;
    public LayerMask groundMask;
    private Animator animator;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        
    }
    private void Update()
    {
        PlayerMovement();
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
    }
    void Jump()
    {
        
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
        }

    }
}
