using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoTrigger : MonoBehaviour
{


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
    }
}


