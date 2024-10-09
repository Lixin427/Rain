using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;  // Import the SceneManager library

public class PlayVideoWithSoundAndSceneControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;      // Reference to the Video Player component
    public AudioSource backgroundMusic;  // Reference to the Audio Source playing the background music

    void Start()
    {
        // Subscribe to the video player event for when the video starts
        videoPlayer.started += OnVideoStarted;

        // Subscribe to the video player event for when the video finishes
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    // Method called when the video starts
    void OnVideoStarted(VideoPlayer vp)
    {
        if (backgroundMusic != null && backgroundMusic.isPlaying)
        {
            backgroundMusic.Pause();  // Pause the background music when the video starts
        }
    }

    // Method called when the video ends
    void OnVideoEnded(VideoPlayer vp)
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.Play();  // Resume the background music after the video ends
        }

        // Load the "Main" scene
        SceneManager.LoadScene("Main");  // Replace "Main" with the exact name of your main scene
    }
}
