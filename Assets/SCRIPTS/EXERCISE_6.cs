using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_6 : MonoBehaviour
{
    public float distanceTraveled = 28f;      //operator decision
    public float distanceTotal = 10f;
    private float distanceLeft;

    private void Start()
    {
        distanceLeft = distanceTotal-distanceTraveled;    //operator conditional

        if (distanceTraveled > distanceTotal)
        {
            Debug.Log($"Congratulations! You have completed the total distance.");

        }else{
            Debug.Log($"Oh… You still have {distanceLeft} meters left to complete the total distance.");

        }
    }
}
