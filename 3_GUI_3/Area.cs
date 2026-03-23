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

    public Area Add(Area other)
    {
        double result = this.ValueInSquareMeters + other.ValueInSquareMeters;
        return new Area(result, "м²");
    }

    public Area Subtract(Area other)
    {
        double result = this.ValueInSquareMeters - other.ValueInSquareMeters;
        return new Area(result, "м²");
    }

    public Area Multiply(double number)
    {
        double result = this.ValueInSquareMeters * number;
        return new Area(result, "м²");
    }

    public int CompareTo(Area other)
    {
        return this.ValueInSquareMeters.CompareTo(other.ValueInSquareMeters);
    }

    public double ConvertTo(string unit)
    {
        return this.ValueInSquareMeters / ToSquareMeters[unit];
    }
}