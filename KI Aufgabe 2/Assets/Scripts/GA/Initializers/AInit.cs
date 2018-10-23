using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AInit : IInitializer
{
    private List<char> genes;
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
        double stepSize = Math.Pow(genes.Count, individualSize) / generationSize;
        List<Individual> list = new List<Individual>();
        for (int i = 0; i < generationSize; i++)
        {
            list.Add(GenerateIndividual(individualSize, (int)(i * stepSize)));
        }
        return list;
    }

    private Individual GenerateIndividual(int individualSize, int individualID)
    {
        Individual ind = new Individual();
        System.Text.StringBuilder builder = new System.Text.StringBuilder(individualSize);
        int max = genes.Count;
        for (int i = 0; i < individualSize; i++)
        {
            builder.Append(genes[individualID % max]);
            individualID = individualID / max;
        }
        // Auf das Umdrehen des Strings für eine "korrekte" umrechnung in ein anderes Zahlensystem wird verzichtet, da der "gegen"-String (reversed) in der Regel auch immer vorkommt 
        ind.GeneSequence = builder.ToString();
        return ind;
    }
}
