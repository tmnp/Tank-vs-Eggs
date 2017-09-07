using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EggBase : BaseClass
{
    public int weight
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public int health
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public int color
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