using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighestFitness : IFitnessFunction
{
    public float DetermineFitness(CarState state)
    {

        if(state.NumberOfCollisions() != 0) { return 0; }
        
        return 10000 - ((state.DistanceFromGoal() * 200
            + state.AngleToGoal() * 2000
            + state.CurrentVelocity() * 400));
    }
}
