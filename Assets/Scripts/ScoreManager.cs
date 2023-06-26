using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score = 100;
    int Health = 3;
    string playerN; // <<<<Nombre>>>>>

        public void SafeData()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.GetString("PlayerName", playerN);
        PlayerPrefs.SetInt("Health", Health);
    }

    public void PrintData()
    {
        int loadedScore = PlayerPrefs.GetInt("Score");
        string loadedPlayerName = PlayerPrefs.GetString("PlayerName");
        int loadedHealth = PlayerPrefs.GetInt("Health");
        Debug.Log("Player Points: " + loadedScore);
        Debug.Log("Name: "+ loadedPlayerName);
        Debug.Log("Health: " + loadedHealth);
    }

    public void Start()
    {
        SafeData();
        PrintData();
    }
}
