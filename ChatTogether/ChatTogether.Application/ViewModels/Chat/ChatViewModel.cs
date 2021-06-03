using System.Collections.Generic;

namespace ChatTogether.Application.ViewModels.Chat
{
    public class ChatViewModel
    {
        public int UserId { get; set; }
        public string UserNick { get; set; }
        public int FriendId { get; set; }
        public string FriendFullName { get; set; }
        public string FriendNick { get; set; }

        public IEnumerable<MessagesListItem> MessageList { get; set; }
    }
}
