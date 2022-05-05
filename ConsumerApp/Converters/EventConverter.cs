using EventNamespace;
using System.Text.Json;
namespace ConsumerApp.Converters
{
    public class EventConverter
    {
        public static Event jsonToEvent(string jsonString){
            Event evento = new Event();
            evento = JsonSerializer.Deserialize<Event>(jsonString);
            return evento;
        }
    }
}