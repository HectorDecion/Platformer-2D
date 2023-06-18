using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZones : MonoBehaviour
{
    public CharacterHealth characterHealth;
    public int damageAmount = 1;
    //private void OnTriggerEnter2D(Collider2D collision)
   // {
    //    if (collision.tag == "Player")
     //   {
        //     private void OnCollisionEnter2D(Collision2D collision)
        //     {
          //         if (collision.gameObject.CompareTag("Player"))
        //         {
      //                 Debug.Log("Muerto");
    //       Destroy(Player, 3f);
          
  //      }
//    }


    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            characterHealth.TakeDamage(damageAmount);
          //  Debug.Log("Haz Muerto");

            //  Destroy(Player, .5f);
        }
    }
}
