using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class ClourChangeAC : MonoBehaviour
{
    public Color pink;
    public Color orange;
    public bool isOrange;

    public ClourChangeAC SquareB; // Reference to Square B
    public ClourChangeAC SquareD; // Reference to Square d

    private void Start()
    {
        // Initialize the color based on the isOrange flag
        UpdateColor();
    }

    [ContextMenu("Interact")] // This creates a menu item in the inspector
    public void ColourChange()
    {
        Debug.Log("Change Colour");
        // Toggle color based on current state
        isOrange = !isOrange;
        UpdateColor();
    }

    public void UpdateColor()
    {
        // Update the color of this square based on isOrange
        GetComponent<SpriteRenderer>().color = isOrange ? orange : pink;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collided with this object
        if (collision.gameObject.CompareTag("Player")) // Ensure you set the player's tag to "Player"
        {
            // Change the color of SquareB and SquareD
            if (SquareB != null)
            {
                SquareB.isOrange = true;
                SquareB.UpdateColor();
            }
            if (SquareD != null)
            {
                SquareD.isOrange = true;
                SquareD.UpdateColor();
            }
        }
    }
}

