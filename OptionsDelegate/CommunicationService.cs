using System.Text.Json;

namespace OptionsDelegate
{
    public class CommunicationService
    {
        public CommunicationOptions? Options { get; set; }
        public void SendMessage(string message)
        {
            Console.WriteLine($"Options: {JsonSerializer.Serialize(Options)}. Message: {message}");
        }

    }

}
