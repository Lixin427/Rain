using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    fade fade;

    private void Start()
    {
        fade = FindAnyObjectByType<fade>();

    }

    public  IEnumerator ChangeScene()
    {
        fade.Fadein();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Scene2");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check player go to the arae
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(ChangeScene());
        }
    }
}

   

