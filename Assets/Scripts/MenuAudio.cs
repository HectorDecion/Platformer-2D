using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class MenuAudio : MonoBehaviour
{
    public AudioSource backgroundAudio;

    //  public AudioSource buttonFX;


    private void Start()
    {
        PlaySound();

    }
    public void PlaySound()
    {
        backgroundAudio.Play();
        //   buttonFX.Play();
    }
}

