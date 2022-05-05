using ConsumerApp.Models;
using System.Text.Json;
namespace ConsumerApp.Converters
{
    public class ClientConverter
    {
        public static Client jsonToString(string jsonString){
            Client cliente = new Client();
            cliente = JsonSerializer.Deserialize<Client>(jsonString);
            return cliente;
        }
    }
}