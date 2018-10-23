using System;
using System.Collections;
using System.Collections.Generic;
public class RandomRecombiner : IRecombiner
{
    private Random rand;
    public string Combine(string parentA, string parentB)
    {
        if (rand == null) rand = new Random();
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        for (int i=0; i<parentA.Length; i++)
        {
            builder.Append(rand.Next(0, 100) < 50 ? parentA[i] : parentB[i]);
        }
        return builder.ToString();
    }
}

