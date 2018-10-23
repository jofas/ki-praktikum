using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCollisionFitness : IFitnessFunction
{
    public float DetermineFitness(CarState state)
    {
        return (state.DistanceFromGoal() * 20 
            + state.AngleToGoal() * 10 
            + state.NumberOfCollisions() * 100000 
            + state.CurrentVelocity() * 20);
    }
}
