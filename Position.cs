using System.Diagnostics.CodeAnalysis;

struct Position
{
    public int horizontal;
    public int vertical;
    public Position(int horizontal, int vertical)
    {
        this.horizontal = horizontal;
        this.vertical = vertical;
    }
    public static bool operator ==(Position a, Position b)
    {
        return a.horizontal == b.horizontal && a.vertical == b.vertical;
    }
    public static bool operator !=(Position a, Position b)
    {
        return a.horizontal != b.horizontal || a.vertical != b.vertical;
    }
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}