using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class EggBase : BaseClass
{
    private int weight;

    public int Weight
    {
        get
        {
            return weight;
        }

        set
        {
            weight = value;
        }
    }

    private int health;

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    private Material color;
    
    public Material Color
    {
        get
        {
               throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public int dmg
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public int startSpeed
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public int payment
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public virtual void ComputeDmg()
    {
        throw new System.NotImplementedException();
    }

    public virtual void CheckDestroy()
    {
        throw new System.NotImplementedException();
    }
}