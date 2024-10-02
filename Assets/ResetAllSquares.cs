using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllSquares : MonoBehaviour
{
    // Reference to all square scripts
    public ClourChangeAC[] squares;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // When the player touches the reset block
        {
            ResetColors();
        }
    }

    // Reset all squares' color to pink
    private void ResetColors()
    {
        foreach (ClourChangeAC square in squares)
        {
            square.isOrange = false; // Set to false to indicate pink color
            square.UpdateColor();
        }
    }
}


