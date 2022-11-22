using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_4 : MonoBehaviour
{
    public float base1 = 4f;
    public float height = 10f;
    private float resultArea;

    private void Start()
    {
       resultArea = base1 * height; //operator decision + arithmetic
        if (resultArea > 0)
        {
            Debug.Log($"The area of this tirangle is{resultArea}.");

        }else{

            Debug.Log($"he area cannot be calculated");
        }
    }
}
