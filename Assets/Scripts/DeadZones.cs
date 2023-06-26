using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class DeadZones : MonoBehaviour
{
    int pbHealth;
    int score;
    int decremento = 20;
    private Rigidbody2D playerRB;
    public GameObject SpawnPoint;

    public CharacterHealth characterHealth;
    public int damageAmount = 1;
    public AudioSource damagePlayer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
         
        SafeData.sharedInstance.health = pbHealth;
        if (collision.gameObject.CompareTag("Player"))
        {
        
        //     private void OnCollisionEnter2D(Collision2D collision)
        //     {
        if (collision.gameObject.CompareTag("Player"))
                 {
                characterHealth.TakeDamage(damageAmount);
                playerRB.gameObject.transform.position = SpawnPoint.transform.position;

                //       Destroy(Player, 3f);

                damagePlayer.Play();
            }
      }
        if (pbHealth >= 0)
        {
            
            Debug.Log("Vidas: " + pbHealth);
            PlayerPrefs.GetInt("Score", score);
            score -= decremento;
            PlayerPrefs.Save();
            Debug.Log("Score" + score);
        }
        else
        {
            SceneManager.LoadScene(3);
            Debug.Log("Haz Muerto");
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
}
