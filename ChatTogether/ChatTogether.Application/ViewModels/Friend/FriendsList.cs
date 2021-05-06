using System.Collections.Generic;

namespace ChatTogether.Application.ViewModels.Friend
{
    public class FriendsList
    {
        public IEnumerable<FriendItem> Friends { get; set; }
        public IEnumerable<FriendItem> PendingFriends { get; set; }
    }
}
