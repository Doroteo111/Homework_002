using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    //Create a float variable. Display in the console whether the number is positive, zero
    // or negative.

    public float x = 4;
    
    private void Start()
    {
        if (x > 0)
        {
            Debug.Log("This number is positive");

        }else if (x < 0) {
            Debug.Log("This number is negative");

        }else {
            Debug.Log("This number is zero");
        }
    }
    
}
