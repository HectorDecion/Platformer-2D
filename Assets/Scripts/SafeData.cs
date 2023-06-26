using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SafeData : MonoBehaviour
{
    //   public int maxHealth;
    public int score = 100;
    public int health = 10;
    public int decremento = 20;

    public static SafeData sharedInstance;

   // private int currentHealth;

    private void Awake()
    {
        if (sharedInstance == null)
            sharedInstance = this;
        //        currentHealth = maxHealth;
        //Debug.Log(currentHealth);
    }
    private void Start()
    {
    PlayerPrefs.SetInt("Score", score);
    PlayerPrefs.SetInt("Health", health);

   //     public void TakeDamage(int damageAmount)
     //   {
       //     currentHealth -= damageAmount;
         //   SafeData.sharedInstance.health -= damageAmount;

          //  Debug.Log("Haz Muerto");
          //      Debug.Log(currentHealth);
            //Comprobar si el personaje murio, reproducir sonidos.

        }

private void OnDestroy()
{
    PlayerPrefs.SetInt("Score", score);
    PlayerPrefs.SetInt("Health", health);

    Debug.Log("Score Final: " + score);
    Debug.Log("Health Final: " + health);
    }

    private void Update()
    {

        watchDog();

        //    public void Heal(int damageAmount) 
        //   {
        //Limitamos la vida maxima, reproducir sonidos.
        // if(currentHealth < 10)
        //   {
        //     currentHealth += healAmount;
        //  }
        //        }
        // }
    void watchDog()
        { 
     if (health >= 0)
        {
  
        }
        else
{

    Debug.Log("Haz Muerto");
                PlayerPrefs.GetInt("Score", score);
                score -= decremento;
                PlayerPrefs.Save();
                SceneManager.LoadScene(3);
                Debug.Log("Score" + score);
            }
}
    }
}
