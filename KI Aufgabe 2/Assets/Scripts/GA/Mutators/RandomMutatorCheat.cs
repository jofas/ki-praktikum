using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mutatotron = UnityEngine.Random;

class RandomMutatorCheat : IMutator
{
    private List<char> geneIDs;
    private float mutationRate = 1.0f;

    public void AssignGene(char ID)
    {
        if (geneIDs == null)
            geneIDs = new List<char>();
        geneIDs.Add(ID);
    }

    public string Mutate(string original)
    {
        if (Mutatotron.value > mutationRate) return (original);
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        for (int i = 0; i < original.Length; i++)
        {
            if(i == original.Length-1)
            {
                for(int z = 0; z < geneIDs.Count; z++)
                {
                    if(geneIDs[z].ID == 'U')
                    {
                        builder.Append(geneIDs[z]);
                    }
                    else
                    {
                        builder.Append(geneIDs[Mutatotron.Range(0, geneIDs.Count)]);
                    }
                }
                
            }
            else
            {
                builder.Append(geneIDs[Mutatotron.Range(0, geneIDs.Count)]);
            }
            //setzt eine zufälliges Gen an ein neuen String, bis die gleiche Länge wie das originale Gen erreicht ist.
            builder.Append(geneIDs[Mutatotron.Range(0, geneIDs.Count)]);
        }
        return (builder.ToString());
    }
}

