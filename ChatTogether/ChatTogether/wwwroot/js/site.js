// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const menu = document.querySelector('.nav');
const btn = document.querySelector('.burger');
const hamburger = document.querySelector('.fa-bars');
const iks = document.querySelector('.fa-times');
const body = document.querySelector('body');
const main = document.querySelector('.main');
const navShadow = document.querySelector('.nav-shadow')



const showing = () => {
    menu.classList.toggle('active');
    btn.classList.toggle('active');
    navShadow.classList.toggle('activeMax');
    if (menu.classList.contains('active')) {
        hamburger.classList.add('hide');
        iks.classList.remove('hide');
    }
    else {
        iks.classList.add('hide');
        hamburger.classList.remove('hide');
    };
    document.body.classList.toggle('lock-scroll');
    // document.body.classList.toggle('background-shadow');
};
// const hideNavOnClickElseWhere = () => {

// }

navShadow.addEventListener('click', showing);
btn.addEventListener('click', showing);