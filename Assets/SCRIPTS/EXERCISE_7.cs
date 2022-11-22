using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_7 : MonoBehaviour
{
   public string operation = "sum";

    public float x = 4f;
    public float y = 10f;

    private void Start()       //operator decision and conditionals
    {
        if (operation == "sum")
        {
            Debug.Log($"{x}+{y}= {x + y}");

        }
        else if (operation == "subtraction")
        {
            Debug.Log($"{x}-{y}= {x - y}");

        }
        else if (operation == "product")
        {
            Debug.Log($"{x}*{y}= {x * y}");

        }
        else if (operation == "division")
        {
            Debug.Log($"{x}/{y}= {x / y}");
        }

    }    
}
