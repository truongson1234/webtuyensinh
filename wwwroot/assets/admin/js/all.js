$(document).ready(function () {
    $(".sidenav-toggler-inner > .sidenav-toggler-line").click(function () {
        $("aside.sidenav").toggleClass("show");
    });
});