using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mutatotron = UnityEngine.Random;

public class SwapMutationWithRRs : IMutator
{


    private float mutationRateSwap = .02f;
    private float mutationRateRR = .01f;
    private List<Char> geneIDs;




    public void AssignGene(char ID)
    {
        if (geneIDs == null)
            geneIDs = new List<char>();
        geneIDs.Add(ID);
    }

    /*
     * 
     * */
    public string Mutate(string original)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();

        if (UnityEngine.Random.value <= mutationRateSwap)
        {
            // zwei unterschiedliche Indexe aussuchen
            int randomStringIndexS = UnityEngine.Random.Range(0, original.Length);
            int randomStringIndexS2 = UnityEngine.Random.Range(0, original.Length);

            while (randomStringIndexS == randomStringIndexS2)
            {
                randomStringIndexS2 = UnityEngine.Random.Range(0, original.Length);
            }

            // Stringbuilder benutzen, um die Gene zusammenzuführen
            for (int i = 0; i < original.Length; i++)
            {
                if (i == randomStringIndexS) { builder.Append(original[randomStringIndexS2]); }
                else if (i == randomStringIndexS2) { builder.Append(original[randomStringIndexS]); }
                else { builder.Append(original[i]); }
            }
            return MutateRandom(builder.ToString());
        }
        return MutateRandom(original);
        
    }

    // Each gene has a chance of 1 percent to mutate randomly.
    private string MutateRandom(string ori)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        for (int i = 0; i < ori.Length; i++)
        {
            if (UnityEngine.Random.value <= mutationRateRR)
            {
                builder.Append(geneIDs[Mutatotron.Range(0, geneIDs.Count)]); 

            }
            else
            {
                builder.Append(ori[i]);
            }
        }
        return builder.ToString(); ;


    }


 
}
