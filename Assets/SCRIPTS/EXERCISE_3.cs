using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3 : MonoBehaviour
{
    
    public int x = 10;
    private int y = 5;

    private int result;     //Module operation

    private void Start()      //Decision operation to have two answer
    {
        result = x % y;
        if (result == 0)
        {
            Debug.Log($"This number is disible from {y}");
      
        }else{
            Debug.Log($"This number is not disible from {y}");
        }


    }


}
