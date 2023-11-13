namespace FriendlyEnum;

public abstract class FriendlyEnum
{
    protected FriendlyEnum(string value) { Value = value; }
    public string Value { get; protected set; }
    
    public override string ToString() { return Value; }

    public static bool operator ==(FriendlyEnum x, FriendlyEnum y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null || y is null) return false;
        return x.Equals(y);
    }

    public static bool operator !=(FriendlyEnum x, FriendlyEnum y)
    {
        return !( x == y );
    }
    public override bool Equals(object obj)
    {
        if (obj is FriendlyEnum other)
        {
            return Value == other.Value;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}