using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneV : IGene
{

    private CarController controller;
    public char ID
    {
        get
        {
            return 'V';
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
        controller.ApplySteering(-1);
        controller.ApplyMotorTorque(1);
    }
}
