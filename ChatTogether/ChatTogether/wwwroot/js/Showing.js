let $menu; // navigation
let $navBtn;   // navigation button
let $hamburger; //hamburger icon in navigation
let $iks;   //close button in navigation
let $body;  //body
let $navShadow; //body shadow when nav is open

$menu = document.querySelector('.nav');
$navBtn = document.querySelector('.burger');
$hamburger = document.querySelector('.fa-bars');
$iks = document.querySelector('.fa-times');
$body = document.querySelector('body');
$navShadow = document.querySelector('.nav-shadow');

const showing = () => {
    $menu.classList.toggle('active');
    $navBtn.classList.toggle('active');
    $navShadow.classList.toggle('activeMax');
    if ($menu.classList.contains('active')) {
        $hamburger.classList.add('hide');
        $iks.classList.remove('hide');
    }
    else {
        $iks.classList.add('hide');
        $hamburger.classList.remove('hide');
    };
    $body.classList.toggle('lock-scroll');
};

var logOut = document.getElementById('logOut');
    logOut.addEventListener('click', function () {
    var logOut = document.getElementById('logOutClick');
    logOut.click();
}, false);

var friends = document.getElementById('friends');
friends.addEventListener('click', function () {
    var friends = document.getElementById('friendClick');
    friends.click();
}, false);

var edit = document.getElementById('edit');
    edit.addEventListener('click', function () {
    var edit = document.getElementById('editClick');
    edit.click();
    }, false);



$navShadow.addEventListener('click', showing);
$navBtn.addEventListener('click', showing);