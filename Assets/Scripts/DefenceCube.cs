using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class DefenceCube : BaseClass
{
    private int health;

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health += value;
        }
    }

    private int cost;

    public int Cost
    {
        get
        {
            return cost;
        }

        set
        {

        }
    }

    private Material color;

    public Material Color
    {
        get
        {
            return color;
        }

        set
        {
        }
    }

    public virtual void CheckDestroy()
    {
        throw new System.NotImplementedException();
    }
}