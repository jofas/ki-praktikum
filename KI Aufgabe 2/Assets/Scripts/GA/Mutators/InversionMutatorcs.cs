using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mutatotron = UnityEngine.Random;

class InversionMutatorcs : IMutator
{
    private List<char> geneIDs;
    private float mutationRate = .02f;

    public void AssignGene(char ID)
    {
        if (geneIDs == null)
            geneIDs = new List<char>();
        geneIDs.Add(ID);
    }

    public string Mutate(string original)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        for(int i=0;i<original.Length; i++)
        {
            if (Mutatotron.value > mutationRate)
            {
                builder.Append(original[i]);
                continue;
            }
            int gene = 0;
            for(int n=0; n<geneIDs.Count; n++)
            {
                if (original[i] == geneIDs[n]) gene = n;
            }
            gene = geneIDs.Count-1 - gene;
            builder.Append(geneIDs[gene]);
        }
        return (builder.ToString());
    }
}

