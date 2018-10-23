using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformCrossover : IRecombiner {

    // We do not seperate the sequence into segements, we just flip a coin for each sequence entry, which part will be included within the offspring.
    public string Combine(string parentA, string parentB)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        for(int i = 0; i < parentA.Length; i++)
        {
            if (UnityEngine.Random.value >= 0.5)
            {
                builder.Append(parentA[i]);
            }
            else
            {
                builder.Append(parentB[i]);
            }
        }
        return builder.ToString();
    }
}
