using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoTrigger : MonoBehaviour
{

    public VideoPlayer VideoPlayer; // PlayVideo
    public string playerTag = "Player"; // RAY TAG

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If Ray touch the Rain
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Found Player xD");
            PlayVideo();
        }
    }

    private void PlayVideo()
    {
        // Play Video
            VideoPlayer.enabled = true;
    }
}


