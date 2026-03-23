namespace knightmoves;

public class Car
{
    public string Make { get; }
    public string Model { get; }

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public override bool Equals(object obj)
    {
        if (obj is Car other)
        {
            return Make == other.Make && Model == other.Model;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Make, Model);
    }

    public static bool operator ==(Car first, Car second)
    {
        if (ReferenceEquals(first, second))
            return true;

        if (first is null || second is null)
            return false;

        return first.Make == second.Make && first.Model == second.Model;
    }

    public static bool operator !=(Car first, Car second)
    {
        return !(first == second);
    }
}
