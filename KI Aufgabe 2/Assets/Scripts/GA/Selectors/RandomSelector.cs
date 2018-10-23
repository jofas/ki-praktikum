using System;
using System.Collections;
using System.Collections.Generic;

class RandomSelector : ISelector
{
    public List<string> SelectFromGeneration(GenerationDB.Generation parentGeneration)
    {
        List<string> superAwesomeNewGen = new List<string>();
        for (int i=0; i<parentGeneration.Individuals.Count*2; i++)
        {
            superAwesomeNewGen.Add(parentGeneration.Individuals[UnityEngine.Random.Range(0,parentGeneration.Individuals.Count)].GeneSequence);
            superAwesomeNewGen.Add(parentGeneration.Individuals[UnityEngine.Random.Range(0, parentGeneration.Individuals.Count)].GeneSequence);
        }
        return superAwesomeNewGen;
    }
}
