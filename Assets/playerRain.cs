using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRain : MonoBehaviour
{
    //Colloision - Touches the edge of a collider
    //Triggers - goes through a collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Rain"))
        {
            Destroy(collision.gameObject);
        }

        
    }
}
