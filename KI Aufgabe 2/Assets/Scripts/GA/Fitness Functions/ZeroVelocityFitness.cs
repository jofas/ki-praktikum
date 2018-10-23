using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroVelocityFitness : IFitnessFunction
{
    public float DetermineFitness(CarState state)
    {
        return (state.DistanceFromGoal() * 20 
            + state.AngleToGoal() * 10 
            + state.NumberOfCollisions() * 2 
            + state.CurrentVelocity() * 100000);
    }
}
