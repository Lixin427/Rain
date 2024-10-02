using UnityEngine;

public class SquareManager : MonoBehaviour
{
    public ClourChangeAC[] squares; // Square data
    public WallController wall; // WallController
    private bool wallHasRaised = false; // up or not

    void Update()
    {
        // check if is orange
        if (CheckAllSquaresAreOrange() && !wallHasRaised)
        {
            wall.RaiseWall(); // if orange, up
            wallHasRaised = true; // only once up
        }
    }

    // check orange
    bool CheckAllSquaresAreOrange()
    {
        foreach (ClourChangeAC square in squares)
        {
            if (!square.isOrange)
            {
                return false; // if not orange ,false
            }
        }
        return true; // if all orange, ture
    }
}
