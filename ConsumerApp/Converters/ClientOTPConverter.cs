using ConsumerApp.Models;
using System.Text.Json;
namespace ConsumerApp.Converters
{
    public class ClientOTPConverter
    {
        public static ClientOTP jsonToClientOTP(string jsonString){
            ClientOTP clienteOTP = new ClientOTP();
            clienteOTP = JsonSerializer.Deserialize<ClientOTP>(jsonString);
            return clienteOTP;
        }
    }
}