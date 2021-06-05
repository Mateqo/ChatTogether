"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

function getCookie(name) {
    const value = `; ${document.cookie}`;
    const parts = value.split(`; ${name}=`);
    if (parts.length === 2) return parts.pop().split(';').shift();
}


connection.on("ReceiveMessage", function (userId, userNick, friendId, friendNick, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var li = document.createElement("div");
    li.textContent = encodedMsg;
    var currentUser = getCookie("UserId");
    if (userId != currentUser) {
        document.getElementById("messagesList").innerHTML += "<div class=\"msg msg-l\"><div class=\"msg-content msg-content-l\"><img src=\"/img/deafultphoto.jpg\" alt=\"profile photo\" class=\"msg-photo\" /><div class=\"msg-text msg-text-l\">" + msg + "</div></div><span class=\"msg-author\">" + userNick + "</span></div>"
    }
    else {
        document.getElementById("messagesList").innerHTML += "<div class=\"msg msg-r\"><div class=\"msg-content msg-content-r\"><img src=\"/img/deafultphoto.jpg\" alt=\"profile photo\" class=\"msg-photo\" /><div class=\"msg-text msg-text-r\">" + msg + "</div></div><span class=\"msg-author\">" + userNick + "</span></div>"
    }
    $(".chat-textarea").animate({ scrollTop: $("#messagesList").height() }, "fast");

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
    $(".chat-textarea").animate({ scrollTop: $("#messagesList").height() }, "fast");


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
        connection.invoke("SendMessage", userId, userNick, friendId, friendNick, message, room).catch(function (err) {
            return console.error(err.toString());
        });
        document.getElementById("messageInput").value = "";
        event.preventDefault();
    }
});