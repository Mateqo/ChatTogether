"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (userId,friendId, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var li = document.createElement("div");
    li.textContent = encodedMsg;
    if (userId < friendId) {
        document.getElementById("messagesList").innerHTML += "<div class=\"chat-textarea__msg chat-textarea__msg-l\">" + msg + "</div>"
    }
    else {
        document.getElementById("messagesList").innerHTML += "<div class=\"chat-textarea__msg chat-textarea__msg-r\">" + msg + "</div>"
    }
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var userId = document.getElementById("userIdVal").value;
    var friendId = document.getElementById("friendIdVal").value;
    var room = "";
    if (userId < friendId) {
        room = userId + "and" + friendId;
    }
    else {
        room = friendId + "and" + userId;
    }

    var message = document.getElementById("messageInput").value;
    console.log(message);
    console.log(userId);
    console.log(friendId);
    console.log(room);
    connection.invoke("SendMessage", userId, friendId, message, room).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});