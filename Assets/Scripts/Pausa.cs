using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UIElements;

public class Pausa : MonoBehaviour
{
    private string playerName;



    public void ReturnToGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ReturnToIntro()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        int loadedScore = PlayerPrefs.GetInt("Score");
        string loadedPlayerName = PlayerPrefs.GetString("PlayerName");
        Debug.Log("Player Points: " + loadedScore);
        Debug.Log("Name: " + loadedPlayerName);
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    //Nombre en barra de Texto al inicio
    public void ReadStringInput(string PlayerName)
    {
        
        if (PlayerName != null) 
        { 
        playerName = PlayerName;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
        Debug.Log("Nuevo Nombre: " + playerName);
            
        
        }
        else
        {
        }
    }
}



