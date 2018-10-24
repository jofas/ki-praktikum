using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mutatotron = UnityEngine.Random;

class RandomMutatorCheat : IMutator
{
    private List<char> geneIDs;
    private float mutationRate = 0.01f;

    public void AssignGene(char ID)
    {
        if (geneIDs == null)
            geneIDs = new List<char>();
        geneIDs.Add(ID);
    }

    public string Mutate(string original)
    {
       
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        for (int i = 0; i < original.Length; i++)
        {
            
            if(i == original.Length-1)
            {
                builder.Append("U");

            }
            else
            {
                if (Mutatotron.value > mutationRate)
                {

                    builder.Append(geneIDs[Mutatotron.Range(0, geneIDs.Count)]);
                }
                else
                {
                    builder.Append(original[i]);
                }
            }
            
            
        }
        return (builder.ToString());
    }
}

