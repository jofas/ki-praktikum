using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitRecursive : IInitializer
{
    private List<char> genes;
    private Random rand;

    public void AssignGene(char ID)
    {
        if (genes == null)
        {
            genes = new List<char>();
        }
        genes.Add(ID);
    }

    public List<Individual> CreateInitialGeneration(int generationSize, int individualSize)
    {
        List<Individual> list = new List<Individual>();
        for (int i = 0; i < generationSize; i++)
        {
            list.Add(GenerateIndividual(individualSize));
        }
        return list;
    }

    private Individual GenerateIndividual(int individualSize)
    {
        Individual ind = new Individual();

        System.Text.StringBuilder builder = new System.Text.StringBuilder(individualSize);
        builder.Append(CreateSequence(individualSize));
        ind.GeneSequence = builder.ToString();
        return ind;
    }


    string CreateSequence(int indisize)
    {
        if (indisize == 0) { return ""; }
        else
        {
            return genes[UnityEngine.Random.Range(0, genes.Count)] + CreateSequence(indisize - 1);
        }
    }

}