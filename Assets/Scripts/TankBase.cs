using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class TankBase : BaseClass
{
    
    private int movementSpeed;

    public int MovementSpeed
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    private int gun;

    public int Gun
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    private int health;

    public int Health
    {
        get
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public virtual void CheckArea()
    {
        throw new System.NotImplementedException();
    }
}