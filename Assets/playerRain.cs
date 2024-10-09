using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class playerRain : MonoBehaviour
{
    public int raindropAmount = 8;
    public GameObject orangeBox;


    //Colloision - Touches the edge of a collider
    //Triggers - goes through a collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Rain"))
        {
            Destroy(collision.gameObject);
            removeRaindrops();

        }
    }

    //raindrop amount -1. and if the total raindrop amount =0. then set boxCollider2D for gamebjet "orangeBox" ON
    public void removeRaindrops()
    {

        raindropAmount--;

        if (raindropAmount == 0)
        {
            //things to do when drops ==0
            orangeBox.GetComponent<BoxCollider2D>().enabled = true;

        }
    }
}
