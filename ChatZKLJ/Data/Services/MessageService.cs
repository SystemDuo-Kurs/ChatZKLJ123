namespace ChatZKLJ.Data.Services
{
    public class MessageService
    {
        private ApplicationDbContext _db;

        public MessageService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Message> GetAll()
            => _db.Messages.ToList();

        public List<Message> GetAllByUser(ChatUser user)
            => _db.Messages.Where(m => m.ChatUser == user).ToList();

        public async Task SaveMessageAsync(Message message)
        {
            message.Sent = DateTime.Now;
            _db.Add(message);
            await _db.SaveChangesAsync();
        }
    }
}