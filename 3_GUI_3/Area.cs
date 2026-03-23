using System;
using System.Collections.Generic;

public class Area
{
    public double ValueInSquareMeters { get; private set; }

    private static Dictionary<string, double> ToSquareMeters = new()
    {
        ["м²"] = 1,
        ["сотка"] = 100,
        ["гектар"] = 10000,
        ["десятина"] = 10925
    };

    public Area(double value, string unit)
    {
        ValueInSquareMeters = value * ToSquareMeters[unit];
    }
}