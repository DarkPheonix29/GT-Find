document.addEventListener("DOMContentLoaded", function () {
    var menuToggle = document.querySelector(".navbar-toggler");
    var menuItems = document.querySelectorAll(".menu-item");

    menuToggle.addEventListener("click", function () {
        menuItems.forEach(function (item) {
            item.classList.toggle("visible");
        });
    });
});
