using FriendlyEnum;
using Newtonsoft.Json;

namespace FriendlyEnum.Examples.Model;

[JsonConverter(typeof(FriendlyEnumConverter<Weather>))]
public class Weather: FriendlyEnum
{
    private Weather( string value ): base( value ) { }
    public static Weather Cloudy => new("cloudy");
    public static Weather Rainy => new("rainy");
    public static Weather Sunny => new("sunny");
    public static Weather Foggy => new("foggy");
}