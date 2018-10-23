using System;
using System.Collections;
using System.Collections.Generic;

public class OnePointRecombiner : IRecombiner
{
    private Random rand;
    public string Combine(string parentA, string parentB)
    {
        if (rand == null) rand = new Random();
        int index = rand.Next() % parentA.Length;
        System.Text.StringBuilder builder = new System.Text.StringBuilder(parentA);
        builder[index] = parentB[index];
        return builder.ToString();
    }
}

