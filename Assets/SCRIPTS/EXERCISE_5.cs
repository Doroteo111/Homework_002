using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_5 : MonoBehaviour
{
    public int legalAge = 16;   //decision operator

    private void Start()
    {
        if (legalAge > 18)
        {
            Debug.Log($"Hello, you are { legalAge } years old, so you ar of legal age");

        }else {
            Debug.Log($"Hello, you are { legalAge } years old, so you are NOT of legal age");

        }
    }
}
