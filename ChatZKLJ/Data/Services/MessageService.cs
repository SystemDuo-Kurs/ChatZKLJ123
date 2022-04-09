using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace ChatZKLJ.Data.Services
{
    public class MessageService
    {
        private ApplicationDbContext _db;
        private IHubContext<ChatHub> _chatHubContext;

        public MessageService(ApplicationDbContext db, IHubContext<ChatHub> chatHubContext)
        {
            _db = db;
            _chatHubContext = chatHubContext;
        }

        public List<Message> GetAll()
            => _db.Messages.Include(m => m.ChatUser).ToList();
        

        public List<Message> GetAllByUser(ChatUser user)
            => _db.Messages.Where(m => m.ChatUser == user).ToList();

        public async Task SaveMessageAsync(Message message, string user)
        {
            message.ChatUser = _db.ChatUsers.Where(c => c.UserName == user).First();
            message.Sent = DateTime.Now;
            _db.Add(message);
            await _db.SaveChangesAsync();
            await _chatHubContext.Clients.All.SendAsync("NewMessage", message);
        }
    }
}