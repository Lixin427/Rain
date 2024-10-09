using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerVideo : MonoBehaviour
{
    public GameObject videoTexture;
    public string playerTag = "Player";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Found Player xD");
            PlayVideo();
        }
    }

    [ContextMenu("Play video")]

    private void PlayVideo()
    {

        //Play Video
        videoTexture.SetActive(true);
    }
}
