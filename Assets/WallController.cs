using UnityEngine;

public class WallController : MonoBehaviour
{
    public float raiseHeight = 5f; // height
    public float raiseSpeed = 2f; // speed
    private bool isRaising = false; // up or not
    private Vector3 initialPosition; 

    private void Start()
    {
        initialPosition = transform.position; // save position
    }

    void Update()
    {
        // if up ,as per frame
        if (isRaising)
        {
            RaiseWallSmoothly();
        }
    }

    // up
    [ContextMenu("RaiseWall")]
    public void RaiseWall()
    {
        isRaising = true; // start
    }

    //up

    private void RaiseWallSmoothly()
    {
        Vector3 targetPosition = initialPosition + Vector3.up * raiseHeight;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, raiseSpeed * Time.deltaTime);

        // stop
        if (transform.position == targetPosition)
        {
            isRaising = false;
        }
    }
}
