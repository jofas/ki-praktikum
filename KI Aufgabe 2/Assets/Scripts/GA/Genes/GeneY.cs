using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneY : IGene
{

    private CarController controller;
    public char ID
    {
        get
        {
            return 'Y';
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
        controller.ApplySteering(1);
        controller.ApplyMotorTorque(-1);
    }
}