using System.Collections.Generic;

namespace ChatTogether.Application.ViewModels.Chat
{
    public class ChatViewModel
    {
        public int UserId { get; set; }
        public int FriendId { get; set; }

        public IEnumerable<MessagesListItem> MessageList { get; set; }
    }
}
