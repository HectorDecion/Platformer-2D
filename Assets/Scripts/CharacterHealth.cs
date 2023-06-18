using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        Debug.Log(currentHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        //Comprobar si el personaje murio, reproducir sonidos.
        Debug.Log(currentHealth);
        if(currentHealth <= 0)
        {
            currentHealth -= damageAmount;
        }
        else
        {
            Debug.Log("Haz Muerto");
        }
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
    //Limitamos la vida maxima, reproducir sonidos.
    if(currentHealth < 10)
        {
            currentHealth += healAmount;
        }
    }
}
