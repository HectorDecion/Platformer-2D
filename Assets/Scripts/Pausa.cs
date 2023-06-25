using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public void ReturnToGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

