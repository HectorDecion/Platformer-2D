using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerMove : MonoBehaviour
{
    public Transform PointC;
    public Transform PointD;

    private SpriteRenderer spriteRendererPartner;  //Flip X
    private Transform targetPointPartner;

    // Seek Vars
    public Transform target;
    public float speed = .5f;

    private void Start()
    {
        targetPointPartner = PointC;
        spriteRendererPartner = GetComponent<SpriteRenderer>(); //Flip X
    }

    public void Update()
    {

        MoveToPointsPartner();
     
    }

    void MoveToPointsPartner()
    {
        if (transform.position == targetPointPartner.position)
        {
            // Si el enemigo llega al punto A cambia al B y viceversa
            targetPointPartner = (targetPointPartner == PointC) ? PointD : PointC;

            if (spriteRendererPartner.flipX) //Flip X
            {
                spriteRendererPartner.flipX = false;
            }
            else
                spriteRendererPartner.flipX = true;
        }
        // Mover al enemigo hacia el punto actual
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPointPartner.position, step);
    }


    }

