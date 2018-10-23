using System;
using System.Collections;
using System.Collections.Generic;

class RandomSelector : ISelector
{
    Random rand;
    public List<string> SelectFromGeneration(GenerationDB.Generation parentGeneration)
    {
        List<string> superAwesomeNewGen = new List<string>();
        if (rand == null) rand = new Random();
        for (int i=0; i<parentGeneration.Individuals.Count*2; i++)
        {
            superAwesomeNewGen.Add(parentGeneration.Individuals[rand.Next(0,parentGeneration.Individuals.Count)].geneSequence);
        }
        return superAwesomeNewGen;
    }
}
