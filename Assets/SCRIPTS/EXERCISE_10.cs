using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_10 : MonoBehaviour
{

    public int year = 2016;    //module + operator decision
    private int result;
    private int result1;
    private int result2;

    private void Start()
    {
        result = year % 4;
        result1 = year % 100;
        result2 = year % 400;

        if (result == 0 || result1 == 0 || result2 == 0)
        {
            Debug.Log($"This year {year} is a leap year");

        }
        else
        {
            Debug.Log($"This year {year} isn't a leap year");

        }
    }


}
