using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BestSelector
{
    float bestPercentage = .1f;
    private Random rand;

    public List<string> SelectFromGeneration(GenerationDB.Generation parentGeneration)
    {
        List<Individual> bestIndividuals = parentGeneration.individuals.GetRange(0, (int)(bestPercentage * parentGeneration.individuals.Count));
        List<string> superAwesomeNewGen = new List<string>();
        if (rand == null) rand = new Random();
        for (int i=0; i<parentGeneration.Individuals.Count*2; i++)
        {
            superAwesomeNewGen.Add(bestIndividuals[rand.Next(0,bestIndividuals.Count)].geneSequence);
        }
        return superAwesomeNewGen;
    }
}