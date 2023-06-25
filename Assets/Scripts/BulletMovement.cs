using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    //SHOOTING MANAGER
    public GameObject player;
    public Transform playerTrans; //Todo esto es parte del Shooting Manager VV
    private Rigidbody2D bulletRB; //controla el rigidbody de la bola
    public float bulletSpeed = 5f; //velocidad de la bola
    public float bulletlife = 1f; //vida de la bola.
    //public AudioSouce boomSound;
    public static int damage;
    public int damageRef = 1;
    //Termina Shooting Manager

    public LayerMask EnemyMask;
    public bool grounded;

    private void Awake()
    {
        //Shooting Manager
        damage = damageRef;
        bulletRB = GetComponent<Rigidbody2D>();//Llamamos a la componente del rigidbody de la bala.
        //boomSound = GetComponent<AudioSouce<();
        player = GameObject.FindGameObjectWithTag("Player"); //encontrar el jugador
        playerTrans = playerTrans.transform;
    }
    private void Start()
    {
        //SHOOTING MANAGER
        if (playerTrans.localScale.x > 0) //valor positivo el jugador derecha, negativo izq
        {
            bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y); //velocidad de la bala
            transform.localScale = new Vector3(1, 1, 1); // para que la bola mire segun el personaje
        }
        else
        {
            bulletRB.velocity = new Vector2(-bulletSpeed, bulletRB.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    private void Update()
    {
        Destroy(gameObject, bulletlife); //destruccion de la bala
        Debug.DrawRay(this.transform.position, Vector2.one * 1f, Color.yellow);
        IsTouchingAnEnemy();
    }
    private void OnTriggerEnter2D(Collider2D explo)
    {
      //  GetComponent<ParticleSystem>().Play();
      //  GetComponent<SpriteRenderer>().enabled = false;
      //  GetComponent<Collider2D>().enabled = false;
        //BoomSound.Play();
    }

    bool IsTouchingAnEnemy()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.one , 6f, EnemyMask))
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
    private void OnCollisionEnter2D(Collision2D coll)
    {
        {
            if (coll.gameObject.tag == "Enemy" && IsTouchingAnEnemy())
              //  if (collision.gameObject.CompareTag("Enemy"))
           {
                Destroy(GameObject.FindGameObjectWithTag("Enemy"));
                //      Destroy(GameObject.Find("Batri"));
                //      Destroy(GameObject.FindGameObjectWithTag("Enemy"));
                //    Destroy(GameObject.FindGameObjectWithTag("Enemy2"));
                Debug.Log("Enemigo Muerto");
                //Estaba OnTriggerEnter2D.
                GetComponent<ParticleSystem>().Play();
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<Collider2D>().enabled = false;
                //BoomSound.Play();
            }
        }
        if (coll.gameObject.tag == "Enemy1" && IsTouchingAnEnemy())
        //  if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemy1"));
            //      Destroy(GameObject.Find("Batri"));
            //      Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            //    Destroy(GameObject.FindGameObjectWithTag("Enemy2"));
            Debug.Log("Enemigo1 Muerto");
            //Estaba OnTriggerEnter2D.
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            //BoomSound.Play();
        }
    }
}

