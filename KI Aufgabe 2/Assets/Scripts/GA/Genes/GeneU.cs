using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneU : IGene
{

    private CarController controller;
    public char ID
    {
        get
        {
            return 'U';
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
        controller.ApplyBrakes();
    }
}