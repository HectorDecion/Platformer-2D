using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    //SHOOTING MANAGER
    public GameObject player;
    public Transform playerTrans; //Todo esto es parte del Shooting Manager VV
    private Rigidbody2D bulletRB; //controla el rigidbody de la bola
    public float bulletSpeed = 10f; //velocidad de la bola
    public float bulletlife = 0.75f; //vida de la bola.
    //public AudioSouce boomSound;
    public static int damage;
    public int damageRef = 50;
    //Termina Shooting Manager

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
    }
    private void OnTriggerEnter2D(Collider2D explo)
    {
        GetComponent<ParticleSystem>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        //BoomSound.Play();
    }
}
