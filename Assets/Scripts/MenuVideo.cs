using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Video;

public class MenuVideo : MonoBehaviour
{
    private VideoPlayer.FrameReadyEventHandler videoPlayerEvent;
    public VideoPlayer videoPlayer;
    //  public AudioSource buttonFX;
    private double time;


    private void Start()
    {
          StartVideo();

       
    }

    private void Update()
    {
        StartVideos();


}
    void StartVideo()
    {
        bool playOnAwake = videoPlayer.playOnAwake;
        videoPlayer.playOnAwake = true;
        videoPlayer.waitForFirstFrame = true;
        videoPlayer.time = time;

        StartVideos();
        videoPlayer.Stop();
        videoPlayer.Prepare();
        if (videoPlayer != null)
        {
            videoPlayer.Play();
            Debug.Log("Playback started");
     
        }
        else
        {
            videoPlayer.Stop();
            Debug.Log("Playback stopped");
        }
       bool sendFrameReadyEvents = videoPlayer.sendFrameReadyEvents;
        if (sendFrameReadyEvents)
        {
            videoPlayer.waitForFirstFrame = true;
        }
        else
        {
            videoPlayer.waitForFirstFrame = false;
        }
        

        //RenderTexture = 2;
    }
   void StartVideos()
    {
        


        //  videoPlayer.time = time;
           //  WaitForSeconds.ReferenceEquals(time, 20);
        //    Debug.Log(videoPlayer.time);

    }
}


