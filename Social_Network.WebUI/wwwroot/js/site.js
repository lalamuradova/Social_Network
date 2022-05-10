var mainImgPath = "";
var isWriteMainPath = false;

var previewImg = function (event) {
    var result = document.getElementById("mainImg");
    if (!isWriteMainPath) {
        isWriteMainPath = true;
        mainImgPath = result.src.toString();
        console.log(mainImgPath);
        $('#deleteChangedImg').show();
    }
    result.src = URL.createObjectURL(event.target.files[0]);
};

$(document).ready(function () {
    $('#deleteChangedImg').hide();
    
    $('#deleteChangedImg').click(function() {
        $(this).hide();
        var result = document.getElementById("mainImg");
        result.src = mainImgPath;
        isWriteMainPath = false;
    });

    $('#dragDrop').ondrop(function(e) {
        var result = document.getElementById("mainImg");
        if (!isWriteMainPath) {
            isWriteMainPath = true;
            mainImgPath = result.src.toString();
            console.log(mainImgPath);
            $('#deleteChangedImg').show();
        }
        result.src = URL.createObjectURL(e.target.files[0]);
    });

    $('#dragDrop').ondragover = function () {
        $(this).className = "card-body d-flex justify-content-between align-items-end p-0 drop";
        return false;
    }

    $('#dragDrop').ondragleave = function () {

        $(this).className = "card-body d-flex justify-content-between align-items-end p-0";
        return false;
    }
});


//var openedNot = false;


//class STVariable {
//    static isDark = false;
//}

//document.body.reload = function() {
//    if (STVariable.isDark) {
//        console.log(STVariable.isDark);

//        document.getElementById("appModeIcon").classList.add("clicked");
//        document.body.classList.add("theme-dark");
//        STVariable.isDark = true;
//    }
//    else {
//        console.log(STVariable.isDark);

//        document.getElementById("appModeIcon").classList.remove("clicked");
//        document.body.classList.remove("theme-dark");
//        STVariable.isDark = false;
//    }
//}

//document.getElementById("dropdownMenu3").onclick = function () {
//    if (!openedNot) {
//        document.getElementById("dropdownMenu3").classList.add("show");
//        document.getElementById("notificationID").classList.add("show");
//        openedNot = true;
//    }
//    else {
//        document.getElementById("dropdownMenu3").classList.remove("show");
//        document.getElementById("notificationID").classList.remove("show");
//        openedNot = false;
//    }
//}

//document.getElementById("appMode").onclick = function () {
//    if (!STVariable.isDark) {
//        console.log(STVariable.isDark + "   1");

//        document.getElementById("appModeIcon").classList.add("clicked");
//        document.body.classList.add("theme-dark");
//        STVariable.isDark = true;
//    }
//    else {
//        console.log(STVariable.isDark + "   2");

//        document.getElementById("appModeIcon").classList.remove("clicked");
//        document.body.classList.remove("theme-dark");
//        STVariable.isDark = false;
//    }
//}

//document.getElementById('searchPanel').addEventListener("keydown", function (e) {
//    if (e.keyCode === 13) {
//        $.ajax({
//            url: '/home/searchresult?data=' + document.getElementById('searchPanel').value,
//            type: 'POST'
//        });
//        document.getElementById('searchPanel').value = '';
//    }
//});
