// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showNotification(type, message) {
    var notificationArea = document.getElementById('notification-area');
    var alertDiv = document.createElement('div');
    alertDiv.classList.add('alert');
    if (type === 'success') {
        alertDiv.classList.add('alert-success');
    } else if (type === 'error') {
        alertDiv.classList.add('alert-danger');
    }
    alertDiv.textContent = message;
    notificationArea.appendChild(alertDiv);
    setTimeout(function () {
        alertDiv.classList.add('fade');
        setTimeout(function () {
            alertDiv.style.display = 'none';
            alertDiv.remove();
        }, 1000);
    }, 5000);
}

function toggleUserDropdown() {     //***Layout user dropdown icin***
    var userDropdownMenu = document.getElementById("userDropdownMenu");
    userDropdownMenu.classList.toggle("show");
}