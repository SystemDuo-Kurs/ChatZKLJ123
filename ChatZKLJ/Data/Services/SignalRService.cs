using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatZKLJ.Data.Services
{
    public class SignalRService
    {
        public HubConnection _conn;
        public bool ConnectionOK { get; set; }

        public SignalRService()
        {
            HubConnectionBuilder b = new();
            b.WithUrl("https://localhost:7150/" + "chatHub");
            _conn = b.Build();

            Start();
        }

        private async Task Start()
        {
            await _conn.StartAsync();
            ConnectionOK = true;
        }
    }
}