using System;
using System.Collections;
using System.Collections.Generic;

public class TwoPointRecombiner : IRecombiner
{
    private Random rand;
    public string Combine(string parentA, string parentB)
    {
        if (rand == null) rand = new Random();
        int min = rand.Next(0, parentA.Length);
        int max = rand.Next(min+1, parentA.Length+1); // +1 Da Obergrenze bei Rand.Next() exklusiv ist und in der folgenden Schleife <max geprüft wird

        System.Text.StringBuilder builder = new System.Text.StringBuilder(parentA);
        for( int i=min; i<max; i++ )
        {
            builder[i] = parentB[i];
        }
        return builder.ToString();
    }
}

