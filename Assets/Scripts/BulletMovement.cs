using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMovement : MonoBehaviour
{
    //SHOOTING MANAGER
    public GameObject player;
    public Transform playerTrans; //Todo esto es parte del Shooting Manager VV
    private Rigidbody2D bulletRB; //controla el rigidbody de la bola
    public float bulletSpeed = 5f; //velocidad de la bola
    public float bulletlife = 1f; //vida de la bola.
    public AudioSource boomSound;
    public AudioSource boomSound2;
    public static int damage;
    public int damageRef = 1;
    //Termina Shooting Manager

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        //Shooting Manager
        damage = damageRef;
        bulletRB = GetComponent<Rigidbody2D>();//Llamamos a la componente del rigidbody de la bala.
        player = GameObject.FindGameObjectWithTag("Player"); //encontrar el jugador
        playerTrans = playerTrans.transform;
    }
    private void Start()
    {
        //SHOOTING MANAGER
        if (playerTrans.localScale.x > 0 || spriteRenderer.flipX) //valor positivo el jugador derecha, negativo izq
        {
            bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y); //velocidad de la bala
            transform.localScale = new Vector3(1, 1, 1); // para que la bola mire segun el personaje
        }
        else
        {
            bulletRB.velocity = new Vector2(-bulletSpeed, bulletRB.velocity.y);
            transform.localScale = new Vector3(11, 11, 1);
        }
    }
    private void Update()
    {
        Destroy(gameObject, bulletlife); //destruccion de la bala
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
       
        {
            if (coll.gameObject.tag == "Enemy")
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
                boomSound.Play();
            }
            else
            {
                boomSound2.Play();
        }
    }
        if (coll.gameObject.tag == "Enemy1")
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
            boomSound.Play();
        }
        else
        {
            boomSound2.Play();
    }
        if (coll.gameObject.tag == "Boss")
        //  if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Boss"));
            //      Destroy(GameObject.Find("Batri"));
            //      Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            //    Destroy(GameObject.FindGameObjectWithTag("Enemy2"));
            Debug.Log("Boss Muerto");
            //Estaba OnTriggerEnter2D.
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            SceneManager.LoadScene(4);
            boomSound.Play();
        }
        else
            {
                boomSound2.Play();
           
        }
}
}
