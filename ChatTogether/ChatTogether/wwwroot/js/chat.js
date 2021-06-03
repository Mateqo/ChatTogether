"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (userId, userNick, friendId, friendNick, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var li = document.createElement("div");
    li.textContent = encodedMsg;
    if (userId < friendId) {
        document.getElementById("messagesList").innerHTML += "<div class=\"msg msg-l\"><div class=\"msg-content msg-content-l\"><img src=\"/img/deafultphoto.jpg\" alt=\"profile photo\" class=\"msg-photo\" /><div class=\"msg-text msg-text-l\">" + msg + "</div></div><span class=\"msg-author\">" + userNick + "</span></div>"
    }
    else {
        document.getElementById("messagesList").innerHTML += "<div class=\"msg msg-r\"><div class=\"msg-content msg-content-r\"><img src=\"/img/deafultphoto.jpg\" alt=\"profile photo\" class=\"msg-photo\" /><div class=\"msg-text msg-text-r\">" + msg + "</div></div><span class=\"msg-author\">" + userNick + "</span></div>"
    }
    window.scrollTo(0, document.getElementsById("messagesList").scrollHeight);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    var userId = document.getElementById("userIdVal").value;
    var friendId = document.getElementById("friendIdVal").value;
    var room = "";
    if (userId < friendId) {
        room = userId + "and" + friendId;
    }
    else {
        room = friendId + "and" + userId;
    }
    connection.invoke("JoinRoom", room).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var userId = document.getElementById("userIdVal").value;
    var friendId = document.getElementById("friendIdVal").value;
    var userNick = document.getElementById("userNickVal").value;
    var friendNick = document.getElementById("friendNickVal").value;
    var room = "";
    if (userId < friendId) {
        room = userId + "and" + friendId;
    }
    else {
        room = friendId + "and" + userId;
    }

    var message = document.getElementById("messageInput").value;
    if (message.length > 0 && message.match(/^ *$/) === null) {
        console.log(message);
        console.log(userId);
        console.log(friendId);
        console.log(room);
        connection.invoke("SendMessage", userId, userNick, friendId, friendNick, message, room).catch(function (err) {
            return console.error(err.toString());
        });
        document.getElementById("messageInput").value = "";
        event.preventDefault();
    }
});