using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTerm : ITerminator
{
    private readonly float minFitness = 2000;
    public GenerationDB generations;
    public int generationSize = 0;

    public bool JudgementDay(GenerationDB.Generation generation)
    {
        generationSize += 1;
        // Wenn min. ein Individuum vorhanden und Value unsere minFitness unterschreitet,
        // dann Endegelände
        if ((generation.Individuals.Count > 0 
            && generation.Fittest.fitnessValue <= minFitness) 
            || generationSize > 29)
        {
            Debug.Log("The end is now");
            return true;
        }
        else
        {
            Debug.Log("The end is nigh.");
            return false;
        }
    }
}
