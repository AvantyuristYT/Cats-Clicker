using System.Collections;
using System.Collections.Generic;
using BreakInfinity;

public class Data
{
    private double _happyCount;

    public Data()
    {
        _happyCount = 0;
    }

    public double GetHappyCount()
    {
        return _happyCount;
    }

    public void AddHappyCount(double value)
    {
        _happyCount += value;
    }
}
