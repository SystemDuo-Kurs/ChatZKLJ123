namespace ChatZKLJ.Data
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Sent { get; set; }
        public ChatUser ChatUser { get; set; } = new();
    }
}