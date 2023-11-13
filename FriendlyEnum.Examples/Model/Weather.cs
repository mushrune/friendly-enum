using FriendlyEnum;

namespace FriendlyEnum.Examples.Model;

public class Weather: FriendlyEnum
{
    private Weather( string value ): base( value ) { }

    public Weather Cloudy => new Weather("cloudy");
    public Weather Rainy => new Weather("rainy");
    public Weather Sunny => new Weather("sunny");
    public Weather Foggy => new Weather("foggy");
}