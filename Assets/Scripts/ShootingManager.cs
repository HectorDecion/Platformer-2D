using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    ObjectPool bulletPool;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 15f;
    public GameObject bulletprefabs; //Agregado
    private Animator animator;
    private void Start()
    {
        //  bulletPool = GameObject.Find("BulletPool").GetComponent<ObjectPool>(); //Regresa esto para clase
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
            animator.SetBool("isShooting", true);
            animator.SetBool("isIdle", false);
            animator.SetBool("isJumping", false);
            // if (Equals(KeyCode.Space))
            // {
            //     animator.SetBool("isJumping", true);

        }
        else
        {
            animator.SetBool("isShooting", false);
    }
    }
    private void Shoot()
    {
        //regresa esto para estar como estaba todo la clase pasada VVV, menos Insantiate en linea 34
        //     GameObject bullet = bulletPool.GetBulletFromPool();
        //     Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        //     bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;
        //     bulletRigidbody.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
        //     bullet.SetActive(true);

        //SHOOTING MANAGER
        Instantiate(bulletprefabs, bulletSpawnPoint.position, bulletSpawnPoint.rotation); //agregado para ver si funciona junto con public GameObject bulletprefabs;
    }
}
