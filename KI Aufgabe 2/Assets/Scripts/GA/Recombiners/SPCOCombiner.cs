using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPCOCombiner :IRecombiner
{
    /*
     * 1-Point-Crossover Recombiner
     * */
    public string Combine(string parentA, string parentB)
    {
        int crossover = UnityEngine.Random.Range(1, parentA.Length - 1);
        string retVal = "";
        for (int i = 0; i < parentA.Length; i++)
        {
            if (i < crossover)
            {
                retVal += parentA[i];
            }
            else
            {
                retVal += parentB[i];
            }
        }
        return retVal;
    }
}
