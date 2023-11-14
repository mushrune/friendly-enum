using FriendlyEnum.Examples.Model;
using Newtonsoft.Json;

namespace FriendlyEnum.Examples;

class Program
{
    static void Main(string[] args)
    {
        
        var today = new Day()
        {
            Weather = Weather.Cloudy,
            Date = DateTime.Today
        };

        var yesterday = new Day()
        {
            Weather = Weather.Sunny,
            Date = DateTime.Today.AddDays( -1 )
        };
        
        Day result = today;
        
        if ( today.Weather != yesterday.Weather )
        {
            result = yesterday;
        }

        var serializedDay = JsonConvert.SerializeObject( result, Formatting.Indented );
        
        Console.Write( serializedDay );
    }
}