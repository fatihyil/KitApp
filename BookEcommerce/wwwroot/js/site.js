// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(".card-footer").mouseover(function () {
    $(this).removeClass("bg-dark");
    $(this).addClass("bg-success");
});
$(".card-footer").mouseleave(function () {
    $(this).addClass("bg-dark");
    $(this).removeClass("bg-success");
});



