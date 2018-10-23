using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneT : IGene
{

    private CarController controller;
    public char ID
    {
        get
        {
            return 'T';
        }
    }

    public CarController Controller
    {
        get
        {
            return controller;
        }
        set
        {
            controller = value;
        }
    }
    public void Execute()
    {
        controller.ApplySteering(0);
        controller.ApplyMotorTorque(-1);
    }
}