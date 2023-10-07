// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function newColor() {
    document.getElementById("hello_world").style.color = `blue`;
}

function oldColor() {
    document.getElementById("hello_world").style.color = "darkolivegreen";
}

/* Logic for movable text */
const elementToMove = document.querySelector('.movable');

elementToMove.addEventListener('mouseover', () => {
    elementToMove.classList.add('hovered');
});

elementToMove.addEventListener('mouseout', () => {
    elementToMove.classList.remove('hovered');
});