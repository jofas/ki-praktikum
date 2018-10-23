using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyFitness : IFitnessFunction
{
    private float fitnessdetermined;
    public float DetermineFitness(CarState state)
    {
        fitnessdetermined = (state.DistanceFromGoal() * 2000
            + state.AngleToGoal() * 1000
            + state.NumberOfCollisions() * 2
            + state.CurrentVelocity() * 2000);
        //return UnityEngine.Random.value * 1000;
        return fitnessdetermined;
    }
}
