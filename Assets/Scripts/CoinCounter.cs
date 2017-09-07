using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CoinMaster : BaseClass
{
    private int coinScore;

    public int CoinScore
    {
        get
        {
            return coinScore;
        }

        set
        {
            coinScore = value;
        }
    }

    public void CoinCounter(int coin)
    {
        CoinScore += coin;
    }
}