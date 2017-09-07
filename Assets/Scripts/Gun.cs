using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Gun : BaseClass
{
    private int bulletDmg;

    public int BulletDmg
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    private int gunLvl;

    public int GunLvl
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    private string gunType;

    public string GunType
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    private int cost;

    public int Cost
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }



    public virtual void Fire()
    {
        throw new System.NotImplementedException();
    }
}