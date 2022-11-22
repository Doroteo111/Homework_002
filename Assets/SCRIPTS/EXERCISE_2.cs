using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_2 : MonoBehaviour
{
   
    public int birthYear = 2000;  //operator decision

    private void Start()
    {
        if(birthYear == 2020 || birthYear == 2008|| birthYear == 1996|| birthYear == 1984|| birthYear == 1972|| birthYear == 1960) {
            Debug.Log("Your chinese sign is the Rat.");
        
        }else if (birthYear == 2021|| birthYear == 2009|| birthYear ==1997|| birthYear == 1985|| birthYear == 1973|| birthYear == 1961) {
            Debug.Log("Your chinese sign is the Ox.");

        }else if (birthYear == 2022|| birthYear == 2010|| birthYear == 1998|| birthYear == 1974|| birthYear == 1986|| birthYear == 1962) {
            Debug.Log("Your chinese sign is the Tiger.");

        }else if (birthYear == 2023|| birthYear == 2011|| birthYear == 1999|| birthYear == 1987|| birthYear == 1975|| birthYear == 1963) {
            Debug.Log("Your chinese sign is the Rabbit.");

        }else if (birthYear == 2024|| birthYear == 2012|| birthYear == 2000|| birthYear == 1988|| birthYear == 1976||birthYear == 1964) { 
         Debug.Log("Your chinese sign is the Dragon.");
        
        }else if (birthYear == 2025|| birthYear == 2013|| birthYear == 2001|| birthYear == 1989|| birthYear == 1977|| birthYear == 1965) { 
         Debug.Log("Your chinese sign is the Snake.");
        
        }else if (birthYear == 2026|| birthYear == 2014|| birthYear == 2002|| birthYear == 1990|| birthYear == 1978|| birthYear == 1966) {
            Debug.Log("Your chinese sign is the Horse.");

        }else if (birthYear == 2027|| birthYear == 2015|| birthYear == 2003|| birthYear == 1991|| birthYear == 1979|| birthYear == 1967) {
            Debug.Log("Your chinese sign is the Goat.");

        }else if (birthYear == 2028|| birthYear == 2016|| birthYear == 2004|| birthYear == 1992|| birthYear == 1980|| birthYear == 1968) { 
            Debug.Log("Your chinese sign is the Monkey.");
        
        }else if (birthYear == 2029|| birthYear == 2017|| birthYear == 2005|| birthYear == 1993|| birthYear == 1981|| birthYear == 1969) { 
            Debug.Log("Your chinese sign is the Rooster.");
        
        }else if (birthYear == 2030|| birthYear == 2010|| birthYear == 2006|| birthYear == 1994|| birthYear == 1982|| birthYear == 1970) { 
            Debug.Log("Your chinese sign is the Dog.");
        
        }else if (birthYear == 2031|| birthYear == 2019|| birthYear == 2007|| birthYear == 1995|| birthYear == 1983|| birthYear == 1971) {
            Debug.Log("Your chinese sign is the Pig.");

        }



    }
}
