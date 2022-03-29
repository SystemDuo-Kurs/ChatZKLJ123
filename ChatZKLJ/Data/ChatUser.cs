using Microsoft.AspNetCore.Identity;

namespace ChatZKLJ.Data
{
    public class ChatUser : IdentityUser
    {
        public List<Message> Messages { get; set; } = new();
    }
}