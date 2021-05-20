// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//let $menu; // navigation
//let $navBtn;   // navigation button
//let $hamburger; //hamburger icon in navigation
//let $iks;   //close button in navigation
//let $body;  //body
//let $navShadow; //body shadow when nav is open
let $alertInfoFriend //info displays when there is no friend matching t oletters written
let $ulNewFriends; //ul list with people who added us to friend list and we have to accept them
let $newFriends; //div contains all new friends
let $newFriendsHeader; //header on new friends list
let $allNewFriends; //this integer contains all new friends
let $pendingFriend; //this integer contains all pending friends
let $ourFriend; //this integer contains all our NEW friends
let $newFriendAddTools; //tools allow us to add new friend
let $confirmFriendBtn; //button allowing add user to friend list
let $deleteFriendBtn; //button deletes friend
let $newFriendToAcceptBtn; //button in li with new friend


let $profileFunctions; //div contains profile name and buttons
let $profilePhoto; //div contains profile photo of user
let $userName; //first and last name of user

let $ulOurFriends; //ul with our friends
let $ourFriendAddTools; //tools of our friend li
let $startChatBtn; //button allows us chat with each other
let $deleteOurFriend; //button allows us delete friend from friendlist
let $allOurFriends; //integer contains all our friends
let $alertInfoNoFriends; //info displays when our friend list is empty

let $ourFriendIdNumber = 0; //number of li item contains a friend
let $pendingFriendIdNumber = 0; //number of li item contains a pending friend

const main = () => {
    prepareDOMElements();
    prepareDOMEvents();
};

const prepareDOMElements = () => {
    //$menu = document.querySelector('.nav');
    //$navBtn = document.querySelector('.burger');
    //$hamburger = document.querySelector('.fa-bars');
    //$iks = document.querySelector('.fa-times');
    //$body = document.querySelector('body');
    //$navShadow = document.querySelector('.nav-shadow');
    $alertInfoFriend = document.querySelector('.addfriends__ul-info');
    $addFriendButton = document.querySelector('.addfriends-button');
    $ulNewFriends = document.querySelector('.newfriends__ul');
    $ulOurFriends = document.querySelector('.friends__ul');
    $pendingFriend = document.querySelector('.newfriends__ul-li');
    $profileFunctions = document.querySelector('.profile-functions');
    $newFriendsHeader = document.querySelector('.newfriendsUlText');
    $allNewFriends = $ulNewFriends.getElementsByTagName('li');
    $allOurFriends = $ulOurFriends.getElementsByTagName('li');
    $newFriendToAcceptBtn = $ulNewFriends.getElementsByClassName('.newFriendToAccept');
    $alertInfoNoFriends = document.querySelector('.nofriends');
};

//downloading events
const prepareDOMEvents = () => {
    //$navShadow.addEventListener('click', showing);
    //$navBtn.addEventListener('click', showing);
    $addFriendButton.addEventListener('click', newFriendToAccept);
    // $addFriendButton.addEventListener('click', controllingNewFriends);
    // $ulNewFriends.addEventListener('click', moveChild);
    $ulNewFriends.addEventListener('click', pendingFriendsCheckClick);
    //$ulOurFriends.addEventListener('click', ourFriendsCheckClick);
    // $ulNewFriends.addEventListener('click', addNewFriendsHeader);
    // $deleteFriendBtn.addEventListener('click', controllingNewFriends);
    // $newFriendToAcceptBtn.addEventListener('click', ourFriends)
};
//////////////////////////////////////////////////
// function allows showing nav by clicking button
//const showing = () => {
//    $menu.classList.toggle('active');
//    $navBtn.classList.toggle('active');
//    $navShadow.classList.toggle('activeMax');
//    if ($menu.classList.contains('active')) {
//        $hamburger.classList.add('hide');
//        $iks.classList.remove('hide');
//    }
//    else {
//        $iks.classList.add('hide');
//        $hamburger.classList.remove('hide');
//    };
//    $body.classList.toggle('lock-scroll');
//};
// FRIENDS
// adding li of friends to accept
//////////////////////////////////////////////////////

const newFriendToAccept = () => {
    $pendingFriend = document.createElement('li');
    $pendingFriendIdNumber++;
    $pendingFriend.setAttribute('id', `newfriends-${$pendingFriendIdNumber}`);
    $pendingFriend.classList.add('newfriends__ul-li');
    $ulNewFriends.appendChild($pendingFriend);
    createProfilePhoto();
    createProfileFunctions();
    createProfileUsername();
    createProfileTools();
    createHeaderNewFriends();
};


///////////////////////////////////////////////////////////////////
// NEW FRIEND ADD TO LIST
const createHeaderNewFriends = () => {
    if ($allNewFriends.length === 0) {
        $newFriendsHeader.style.display = 'none';
    }
    else {
        $newFriendsHeader.style.display = 'block';
    };
};

const createProfilePhoto = () => {
    $profilePhoto = document.createElement('img');
    $profilePhoto.classList.add('profile-photo');
    $profilePhoto.src = '/img/deafultphoto.jpg';
    $pendingFriend.appendChild($profilePhoto);
};
const createProfileFunctions = () => {
    $profileFunctions = document.createElement('div');
    $profileFunctions.classList.add('profile-functions');
    $pendingFriend.appendChild($profileFunctions);
};
const createProfileUsername = () => {
    $userName = document.createElement('p');
    $userName.classList.add('friends-name');
    $userName.style.marginBottom = '0.3em';
    $userName.innerText = 'Bartosz Adamczyk';
    $profileFunctions.appendChild($userName);
};
const createProfileTools = () => {
    $newFriendAddTools = document.createElement('div');
    $newFriendAddTools.classList.add('friends-buttons');

    $confirmFriendBtn = document.createElement('button');
    $confirmFriendBtn.classList.add('friends-button');
    $confirmFriendBtn.classList.add('btn-style');
    $confirmFriendBtn.innerHTML = '<i class="fas fa-user-plus"></i>';
    $confirmFriendBtn.classList.add('newFriendToAccept');
    $confirmFriendBtn.classList.add('deletebtn');
    $confirmFriendBtn.addEventListener('click', ourFriends);

    $deleteFriendBtn = document.createElement('button');
    $deleteFriendBtn.classList.add('friends-button');
    $deleteFriendBtn.classList.add('btn-style');
    $deleteFriendBtn.classList.add('deletebtn');
    $deleteFriendBtn.innerHTML = '<i class="fas fa-times"></i>';

    $newFriendAddTools.appendChild($confirmFriendBtn);
    $newFriendAddTools.appendChild($deleteFriendBtn);
    $profileFunctions.appendChild($newFriendAddTools);
};
const pendingFriendsCheckClick = (e) => {

    //here I have to create adding pending friends to friendlist
    if (e.target.closest('button').classList.contains('deletebtn')) {
        deleteNewFriend(e);
    }
};

const deleteNewFriend = (e) => {
    const deletePendingUser = e.target.closest('li');
    deletePendingUser.remove();
    createHeaderNewFriends();
};

//////////////////////////////////////////////////////////////////////
//Friendlist
const ourFriends = () => {
    $ourFriend = document.createElement('li');
    $ourFriendIdNumber++;
    $ourFriend.setAttribute('id', `friends-${$ourFriendIdNumber}`);
    $ourFriend.classList.add('friends__ul-li');
    $ulOurFriends.appendChild($ourFriend);
    friendProfilePhoto();
    friendProfileFunctions();
    friendProfileUsername();
    friendProfileTools();
    alertInfoFriendControl();

};
const friendProfilePhoto = () => {
    $profilePhoto = document.createElement('img');
    $profilePhoto.classList.add('profile-photo');
    $profilePhoto.src = '/img/deafultphoto.jpg';
    $ourFriend.appendChild($profilePhoto);
};

const friendProfileFunctions = () => {
    $profileFunctions = document.createElement('div');
    $profileFunctions.classList.add('profile-functions');
    $ourFriend.appendChild($profileFunctions);
};

const friendProfileUsername = () => {
    $userName = document.createElement('p');
    $userName.classList.add('friends-name');
    $userName.style.marginBottom = '0.3em';
    $userName.innerText = 'Bartosz Adamczyk';
    $profileFunctions.appendChild($userName);
};
const friendProfileTools = () => {
    $ourFriendAddTools = document.createElement('div');
    $ourFriendAddTools.classList.add('friends-buttons');

    $startChatBtn = document.createElement('button');
    $startChatBtn.classList.add('friends-button');
    $startChatBtn.classList.add('btn-style');
    $startChatBtn.innerHTML = '<i class="fas fa-comment"></i>';

    $deleteFriendBtn = document.createElement('button');
    $deleteFriendBtn.classList.add('friends-button');
    $deleteFriendBtn.classList.add('btn-style');
    $deleteFriendBtn.innerHTML = '<i class="fas fa-users-slash"></i>';
    $deleteFriendBtn.classList.add('deletebtn');


    $ourFriendAddTools.appendChild($startChatBtn);
    $ourFriendAddTools.appendChild($deleteFriendBtn);
    $profileFunctions.appendChild($ourFriendAddTools);
};

//const ourFriendsCheckClick = (e) => {

//    //here I have to create adding pending friends to friendlist
//    if (e.target.closest('button').classList.contains('deletebtn')) {
//        deleteOurFriend(e);
//    }
//};

//const deleteOurFriend = (e) => {
//    const deleteUser = e.target.closest('li');
//    deleteUser.remove();
//    alertInfoFriendControl();
//};

const alertInfoFriendControl = () => {
    if ($allOurFriends.length === 0) {
        $alertInfoNoFriends.style.display = 'block';
    }
    else {
        $alertInfoNoFriends.style.display = 'none';
    };
};
// console.log($allOurFriends.length);

document.addEventListener('DOMContentLoaded', main);