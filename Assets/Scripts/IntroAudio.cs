using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAudio : MonoBehaviour
{
    public AudioSource backgroundAudio;
    //  public AudioSource buttonFX;

    private void Start()
    {
        PlaySound();

    }
    public void PlaySound()
    {
        //   buttonFX.Play();
        backgroundAudio.playOnAwake = true;
        backgroundAudio.Play();
    }
}
