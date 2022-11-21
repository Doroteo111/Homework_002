using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_4 : MonoBehaviour
{
    // Create two float variables. Name the first variable base and the second variable 'height.'
    // The area of a triangle is base x height divided by 2.
    // If the variables 'base' and 'height' are greater than 0 (are positive), display in the
    // console the area of the triangle with base 'base' and height height.In case any of the variables
    // is 0 or negative, display in the console that the area cannot be calculated.

    public float base1 = 4f;
    public float height = 10f;
    private float resultArea;

    private void Start()
    {
       resultArea = base1 * height;
        if (resultArea > 0)
        {
            Debug.Log($"The area of this tirangle is{resultArea}.");

        }else{

            Debug.Log($"he area cannot be calculated");
        }
    }
}
