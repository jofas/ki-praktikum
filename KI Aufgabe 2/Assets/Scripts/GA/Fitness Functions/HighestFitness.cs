using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighestFitness : IFitnessFunction
{
    public float DetermineFitness(CarState state)
    {


        
        return 10000 - ((state.DistanceFromGoal() * 200
            + state.AngleToGoal() * 250
            + state.NumberOfCollisions() * 500
            + state.CurrentVelocity() * 200));
    }
}
