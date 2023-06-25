using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZones : MonoBehaviour
{
    public CharacterHealth characterHealth;
    public int damageAmount = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
        //     private void OnCollisionEnter2D(Collision2D collision)
        //     {
                   if (collision.gameObject.CompareTag("Player"))
                 {
                characterHealth.TakeDamage(damageAmount);
                       Debug.Log("Muerto");
    //       Destroy(Player, 3f);
          
        }
      }
    }

  //  public GameObject Player;              ///////USALO SI NO ACABAS, MATA AL TOQUE///////
 //   private void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.CompareTag("Player"))
 //       {
       //     characterHealth.TakeDamage(damageAmount);
            //  Debug.Log("Haz Muerto");

            //  Destroy(Player, .5f);
  //          SceneManager.LoadScene(3);
//        }
//    }  
}
