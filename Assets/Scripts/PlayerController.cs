using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float jumpForce = 5f;
    public float playerSpeed = 5f;
    public LayerMask groundMask;
    private Animator animator;
    public bool grounded; //Raycast para evitar doble salto con grounded

    private SpriteRenderer spriteRenderer;  //Flip X


  //  public float SegEspera = 5f; //Corutina para espera
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
        Debug.DrawRay(this.transform.position, Vector2.down * 20f, Color.red);
      IsTouchingTheGround();
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
    //   IEnumerator Espera()
    //   {
    //       yield return new WaitForSeconds(SegEspera);
    //  }

    bool IsTouchingTheGround()
        {
            if (Physics2D.Raycast(this.transform.position, Vector2.down, 20.0f, groundMask))
            {
                grounded = true;
                return true;
        }
            else
           {
                grounded = false;
                return false;
        }
        }
   //     IEnumerator Esperar()
   // {
   //     float Espera = 1f;
   //     yield return new WaitForSeconds(Espera);
   // }
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
