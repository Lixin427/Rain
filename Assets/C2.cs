using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CloudMover : MonoBehaviour
{
    public float speed = 2f; 
    public float leftBoundary = -10f; 
    public float rightBoundary = 10f; 
    public bool moveRight = true; 

    void Update()
    {
       
        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
           
            if (transform.position.x > rightBoundary)
            {
                ResetPositionToLeft();
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            
            if (transform.position.x < leftBoundary)
            {
                ResetPositionToRight();
            }
        }
    }

   
    void ResetPositionToLeft()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = leftBoundary;
        transform.position = newPosition;
    }

    
    void ResetPositionToRight()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = rightBoundary;
        transform.position = newPosition;
    }
}
