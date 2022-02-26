public class Point
{
    public int X { get; set; } = 1;
    public int Y { get; set; } = 1;

    public override bool Equals(object obj)
    {
        Point point = (Point)obj;

        return (X == point.X && Y == point.Y);
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    public override string ToString()
    {
        return $"Point({X}, {Y})";
    }
}