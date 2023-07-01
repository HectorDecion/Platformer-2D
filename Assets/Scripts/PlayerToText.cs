using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerToText : MonoBehaviour
{
    public TextMeshProUGUI TextoThx;

    // Start is called before the first frame update
    void Start()
    {
        TextoThx = FindObjectOfType<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        changeText();
    }
    private void changeText()
    {
        
        string loadedPlayerName = PlayerPrefs.GetString("PlayerName");
        string thx = "Gracias por jugar <3 " + loadedPlayerName;
        TextoThx.text = thx;

       

    }
}
