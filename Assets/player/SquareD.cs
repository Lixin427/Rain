using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SquareD : MonoBehaviour
{
    public Color pink;
    public Color orange;
    public bool isOrange;

    public SquareD SquareC; // Reference to Square C

    private void Start()
    {
        // Initialize the color based on the isOrange flag
        UpdateColor();
    }

    [ContextMenu("Interact")] // Creates a menu item in the inspector
    public void ColourChange()
    {
        Debug.Log("Change Colour");
        // Toggle color based on current state
        isOrange = !isOrange;
        UpdateColor();
    }

    // Make this method public so it can be accessed by other scripts
    public void UpdateColor()
    {
        // Update the color of this square based on isOrange
        GetComponent<SpriteRenderer>().color = isOrange ? orange : pink;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collided with this object
        if (collision.gameObject.CompareTag("Player")) // Ensure the player's tag is "Player"
        {
            // Change the color of SquareC 
            if (SquareC != null)
            {
                SquareC.isOrange = false;
                SquareC.UpdateColor();
            }
          
        }
    }
}

