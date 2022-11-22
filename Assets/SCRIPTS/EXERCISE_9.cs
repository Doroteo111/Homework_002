using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_9 : MonoBehaviour
{
    public bool wantsVegetarianOption;

    private void Start()  //operator decision (negative form)
    {
        if (wantsVegetarianOption == false) {
            Debug.Log("“Non-vegetarian option coming soon");

        }else{
            Debug.Log("Vegetarian option coming soon");
        }
    }

}
