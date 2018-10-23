using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardFitness : IFitnessFunction
{
    private float dfg;
    private float atg;
    private float noc;
    private float cv;
    private float fitnessDetermined;

    public float DetermineFitness(CarState state)
    {
        dfg = state.DistanceFromGoal();
        atg = state.AngleToGoal();
        noc = state.NumberOfCollisions();
        cv = state.CurrentVelocity();

        Debug.Log("BULLSHITTEST in FITTNESSFUNC");
        Debug.Log("DistanceFromGoal:  " + dfg);
        Debug.Log("AngleToGoal:  " + atg);
        Debug.Log("NumberOfCollisions:  " + noc);
        Debug.Log("CurrentVelocity:  " + cv);

       
        fitnessDetermined = (state.DistanceFromGoal()*20 
            + state.AngleToGoal()*10 
            + state.NumberOfCollisions()*2 
            + state.CurrentVelocity()*20);

        Debug.Log("CAR: " + state + "BERECHNETE FITNESS: " + fitnessDetermined);

        return fitnessDetermined;
    }
}
