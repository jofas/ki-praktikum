using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverNineThousand : ITerminator
{
    private readonly float maxFitness = 9000;

    public bool JudgementDay(GenerationDB.Generation generation)
    {
            

        if (generation.Fittest.fitnessValue > maxFitness)
        {
            Debug.Log("ITS OVER NINETHOUUUSAAAAAND!!!!!!");
            return true;
        }
        else
        {
            Debug.Log("The end is nigh.");
            return false;
        }
    }
}
