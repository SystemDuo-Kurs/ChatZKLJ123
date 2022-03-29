namespace ChatZKLJ.Data.Viewmodels
{
    public class Message
    {
        public List<Data.Message> Messages { get; set; } = new();
        public Data.Message MessageEditor { get; set; } = new();

        private Services.MessageService MessageService { init; get; }

        // private readonly int _broj;  ovo je istoooooo
        // private int Broj { init; get; }
        public Message(Services.MessageService messageService)
        {
            MessageService = messageService;
        }

        public void GetAll()
            => Messages = MessageService.GetAll();

        public async Task SaveMessageAsync()
        {
            await MessageService.SaveMessageAsync(MessageEditor);
            MessageEditor = new();
        }
    }
}