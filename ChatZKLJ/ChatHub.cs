using Microsoft.AspNetCore.SignalR;

namespace ChatZKLJ
{
    public class ChatHub : Hub
    {
        public void Ping(string saKlijenta)
        {
            Console.WriteLine($"Klijent salje {saKlijenta}");
        }
    }
}