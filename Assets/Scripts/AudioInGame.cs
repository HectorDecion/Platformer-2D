using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class AudioInGame : MonoBehaviour
{
    public AudioSource backgroundAudio;
public AudioSource Hit;
public AudioSource MissHit;
public AudioSource DeadZone;
//  public AudioSource buttonFX;

private void Start()
{
    backgroundAudio.Play();
    Hit.Stop();
    MissHit.Stop();
    DeadZone.Stop();

}
public void PlaySound()
{
    //   buttonFX.Play();
}
}

