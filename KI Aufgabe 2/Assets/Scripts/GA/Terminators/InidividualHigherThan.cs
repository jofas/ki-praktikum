using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualHigherThan : ITerminator
{
    private readonly float maxFitness = 9800;

    public bool JudgementDay(GenerationDB.Generation generation)
    {
            

        if (generation.Fittest.Fitness >= maxFitness)
        {
            return true;
        }
        else
        { 
            return false;
        }
    }
}
