using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeBehavior : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float fleeDistance = 2.5f;

    private void Update()
    {
        Flee();
    }
    private void Flee()
    {
        Vector3 fleeVector = transform.position - target.position;

        if(fleeVector.magnitude < fleeDistance)
        {
            fleeVector = fleeVector.normalized * fleeDistance;
            Vector3 fleePosition = target.position + fleeVector;
        
        transform.position = fleePosition;
        }
        //Calcular la direccion de huir
      //  Vector3 direction = transform.position - target.position;
        //Normalizar la direccion
       // direction.Normalize();

        //Calcular la velocidad de movimiento
       // Vector3 fleeVelocity = direction * speed;

        //Mover el objecto en la direccion opuesta al objetivo
      //  transform.position += fleeVelocity * Time.deltaTime;
    }
}
