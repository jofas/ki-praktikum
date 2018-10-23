using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualHigherThan : ITerminator
{
    private readonly float maxFitness = 9900;

    public bool JudgementDay(GenerationDB.Generation generation)
    {
            

        if (generation.Fittest.Fitness > maxFitness)
        {
            Debug.Log("ITS OVER NINETHOUUUSAAAAAND!!!!!!");
            return true;
        }
        else
        {

            Debug.Log("The end is nigh."+ generation.Fittest.Fitness);
            return false;
        }
    }
}
