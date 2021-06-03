using ChatTogether.Application.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

public class Chat : Hub
{
    private readonly IUserService _userService;
    public Chat(IUserService userService)
    {
        _userService = userService;
    }

    public async Task SendMessage(string userId, string userNick, string friendId,string friendNick, string message, string room)
    {
        await _userService.SendMessage(Convert.ToInt32(userId), Convert.ToInt32(friendId), message);
        //await JoinRoom(room);
        await Clients.Group(room).SendAsync("ReceiveMessage", Convert.ToInt32(userId), userNick, Convert.ToInt32(friendId), friendId, message);
    }

    public Task JoinRoom(string roomName)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, roomName);
    }

    public Task LeaveRoom(string roomName)
    {
        return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
    }
}
