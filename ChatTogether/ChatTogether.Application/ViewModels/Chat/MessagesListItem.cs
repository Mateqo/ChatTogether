using System;

namespace ChatTogether.Application.ViewModels.Chat
{
    public class MessagesListItem
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderNick { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverNick { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ReceivementDate { get; set; }
        public string Content { get; set; }
    }
}
