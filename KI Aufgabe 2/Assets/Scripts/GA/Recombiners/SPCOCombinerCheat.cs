using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPCOCombinerCheat : IRecombiner
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
                if (i == parentA.Length - 1)
                {
                    retVal += "U";
                }
                else
                {
                    retVal += parentA[i];
                }
                    
            }
            else 
            {
                if (i == parentA.Length - 1)
                {
                    retVal += "U";
                }
                else
                {
                    retVal += parentB[i];
                }
            }
        }
        return retVal;
    }
}
