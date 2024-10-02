using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BoxColourChange : MonoBehaviour
{
    public Color pink;
    public Color orange;
    public bool isOrange;

    public BoxColourChange SquareA; // Reference to Square B
    public BoxColourChange SquareC; // Reference to Square D

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

    private void UpdateColor()
    {
        // Update the color of this square based on isOrange
        GetComponent<SpriteRenderer>().color = isOrange ? orange : pink;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collided with Square C
        if (collision.gameObject.CompareTag("Player")) // Ensure you set the player's tag to "Player"
        {
            // Change the color of SquareB and SquareD
            if (SquareA != null)
            {
                SquareA.isOrange = true;
                SquareA.UpdateColor();
            }
            if (SquareC != null)
            {
                SquareC.isOrange = true;
                SquareC.UpdateColor();
            }
        }
    }
}
