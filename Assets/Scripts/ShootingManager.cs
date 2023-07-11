using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class ShootingManager : MonoBehaviour
{
    ObjectPool bulletPool;
    public Transform bulletSpawnPoint;
    public Transform bulletSpawnPointAtras;
    public float bulletSpeed = 15f;
    public GameObject bulletprefabs; //Agregado
    private Animator animator;
    public float TiempoEspera = 10f;
    private float fixedDeltaTime;
  //  public SpriteRenderer spriteRenderer;  //Flip X
    bool bolSprite;
    public SpriteRenderer spriteRenderer2;  //Flip X

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }
    private void Start()
    {
        //  bulletPool = GameObject.Find("BulletPool").GetComponent<ObjectPool>(); //Regresa esto para clase
        animator = GetComponent<Animator>();
     //   StartCoroutine(ExampleCoroutine());
      //  spriteRenderer2 = GetComponent<SpriteRenderer>(); //Flip X
    }


    private void Update()
    {
        fire();
    }
    void fire()
    {
        if (Input.GetMouseButtonDown(0))// && spriteRenderer2)
        {


            animator.SetBool("isShooting", true);
            animator.SetBool("isIdle", false);
            animator.SetBool("isJumping", false);
            animator.SetBool("isJumping", true);
            Shoot();
            //       Instantiate(bulletprefabs, bulletSpawnPointAtras.position, bulletSpawnPointAtras.rotation);

        }
    //    if (Input.GetMouseButtonDown(0))
      //  {
        //    Shoot();

         //   animator.SetBool("isShooting", true);
          //  animator.SetBool("isIdle", false);
          //  animator.SetBool("isJumping", false);
            // if (Equals(KeyCode.Space))
            // {
            //     animator.SetBool("isJumping", true);

       // }
        else
        {
            animator.SetBool("isShooting", false);
        }
    }
  //  IEnumerator ExampleCoroutine()
 //   {
        //Print the time of when the function is first called.
  //      Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
  //      yield return new WaitForSeconds(10);

        //After we have waited 5 seconds print the time again.
  //      Debug.Log("Finished Coroutine at timestamp : " + Time.time);
 //   }
    private void Shoot()
    
        //regresa esto para estar como estaba todo la clase pasada VVV, menos Insantiate en linea 34
        //     GameObject bullet = bulletPool.GetBulletFromPool();
        //     Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        //     bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;
        //     bulletRigidbody.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
        //     bullet.SetActive(true);

        //SHOOTING MANAGER
  
        {
                Instantiate(bulletprefabs, bulletSpawnPoint.position, bulletSpawnPoint.rotation);


    }



    //    void Espera()
    // IEnumerator Espera()
    //  {
    //    print(Time.time);
    //     yield return new WaitForSeconds(TiempoEspera);
    //     print(Time.time);

    //   }
    // void ExampleCoroutine()


}

