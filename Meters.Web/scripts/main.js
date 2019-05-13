window.onload = function () {
    var delButtons = document.getElementsByClassName("delete-button");
    for (var i = 0; i < delButtons.length; i++) {
        delButtons[i].addEventListener("click", DeleteConfirm, false);
    }
}

function DeleteConfirm() {
    alert("tets");
};