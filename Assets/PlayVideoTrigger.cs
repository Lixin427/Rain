using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoTrigger : MonoBehaviour
{

    public GameObject VideoRenderObj;
    public string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If Ray touch the Rain
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Found Player xD");
            PlayVideo();
        }
    }

    [ContextMenu("Play Video")]
    private void PlayVideo()
    {
        // Play Video
        VideoRenderObj.SetActive(true);
    }
}


