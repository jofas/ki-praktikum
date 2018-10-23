using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RRSelector : ISelector
{
    /*
     * Random Rejection Selector
     * creating an random integer for the index of the population and one for the probability in the range of the fitness.
     * The Population will be the same each generation.
     * */
    public List<string> SelectFromGeneration(GenerationDB.Generation parentGeneration)
    {
        List<string> superAwesomeNewGen = new List<string>();
        for (int i = 0; i < parentGeneration.Individuals.Count; i++)
        {
            superAwesomeNewGen.Add(SelectionProcess(parentGeneration));
            superAwesomeNewGen.Add(SelectionProcess(parentGeneration));
        }
        return superAwesomeNewGen;
    }

    /*
     * returns the geneSequence
     * */
    string SelectionProcess(GenerationDB.Generation parentGeneration)
    {
        while (true)
        {
            int randIndex = UnityEngine.Random.Range(0, parentGeneration.Individuals.Count);
            float fitness = UnityEngine.Random.Range((int)parentGeneration.NotFittest.Fitness, (int)parentGeneration.Fittest.Fitness);
            if (parentGeneration.Individuals[randIndex].Fitness >= fitness) { return parentGeneration.Individuals[randIndex].GeneSequence; }
        }
    }
}