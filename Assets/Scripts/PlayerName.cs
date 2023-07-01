using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
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
        string thx = "Player: " + loadedPlayerName;
        TextoThx.text = thx;



    }
}
