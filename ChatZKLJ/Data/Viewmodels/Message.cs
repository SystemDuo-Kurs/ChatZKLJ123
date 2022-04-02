using Microsoft.AspNetCore.SignalR.Client;

namespace ChatZKLJ.Data.Viewmodels
{
    public interface IMessageVM
    {
        List<Data.Message> Messages { get; set; }
        Data.Message MessageEditor { get; set; }

        void GetAll();

        void Add(Data.Message m);

        Task SaveMessageAsync();
    }

    public class Message : IMessageVM
    {
        public List<Data.Message> Messages { get; set; } = new();
        public Data.Message MessageEditor { get; set; } = new();

        private Services.MessageService MessageService { init; get; }
        private Services.SignalRService SignalRService { init; get; }

        // private readonly int _broj;  ovo je istoooooo
        // private int Broj { init; get; }
        public Message(Services.MessageService messageService, Services.SignalRService signalRService)
        {
            SignalRService = signalRService;
            MessageService = messageService;
        }

        public void GetAll()
            => Messages = MessageService.GetAll();

        public void Add(Data.Message m)
            => Messages.Add(m);

        public async Task SaveMessageAsync()
        {
            await MessageService.SaveMessageAsync(MessageEditor);
            MessageEditor = new();
        }
    }
}