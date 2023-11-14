using FriendlyEnum.Examples.Model;
using Newtonsoft.Json;

namespace FriendlyEnum.Examples;

class Program
{
    static void Main(string[] args)
    {
        string todayJson = """
           { 
               "weather": "rainy", 
               "date": "2023-11-12T00:00:00-08:00"
           }
        """;

        var today = JsonConvert.DeserializeObject<Day>( todayJson );
        if ( today is null ) { throw new Exception("Could not serialize JSON for today's date and weather."); }

        var yesterday = new Day()
        {
            Weather = Weather.Rainy,
            Date = DateTime.Today.AddDays( -1 )
        };

        Console.WriteLine( today.Weather == yesterday.Weather
            ? "The weather was the same today and yesterday."
            : "The weather was different yesterday." );

        var serializedResult = JsonConvert.SerializeObject( today, Formatting.Indented );
        
        Console.Write( serializedResult );
    }
}