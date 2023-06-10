using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    //  public GameObject bulletPreFab;


    public ObjectPool BulletPool;

    private void Start()
    {
        BulletPool = GameObject.Find("BulletPool").GetComponent<ObjectPool>();
    }

    public Transform bulletSpawnPoint;
    public float bulletSpeed = 5f;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        GameObject bullet = BulletPool.GetBulletFromPool();
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;
        bulletRigidbody.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
        bullet.SetActive(true);
    }
}
