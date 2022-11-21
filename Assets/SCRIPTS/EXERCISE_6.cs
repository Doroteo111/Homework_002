using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_6 : MonoBehaviour
{
    // : Create two float variables that are supposed to store distances. One will be the distance traveled
    // and the other the total distance to be traveled.Compares the two variables and determines if the
    // total distance has been completed.If it has not been completed, display in the console how much
    // is left to complete the total distance.

    //For example, if we specify that the value of the distance travelled is 25 and the total distance is 20,
    //the following should be displayed: “Congratulations! You have completed the total distance.”

    // For example, if we specify that the value of the distance travelled is 20 and the total distance is 25,
    // the following should be displayed: “Oh… You still have 5 meters left to complete the total distance.”


    public float distanceTraveled = 28f;
    public float distanceTotal = 10f;
    private float distanceLeft;

    private void Strat()
    {
        distanceLeft = distanceTraveled - distanceTotal;

        if (distanceTraveled > distanceTotal)
        {
            Debug.Log($"Congratulations! You have completed the total distance.");

        }else{
            Debug.Log($"Oh… You still have {distanceLeft} meters left to complete the total distance.");

        }
    }
}
