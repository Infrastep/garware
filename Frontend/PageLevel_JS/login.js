jQuery(document).on('click', '#btnlog', function (e) {


    e.preventDefault();
    if (e.isDefaultPrevented()) {
        // handle the invalid form...
    } else {
        // everything looks good!
    }
    var email = jQuery("#email").val();

    var psw = jQuery("#psw").val();

    var urlToHandler = "/Handler/LoginHandler.ashx";
    var jsonData = '{ "Method": "LoginUser","uname":"' + email + '","psw":"' + psw + '"}';

    var datax;
    jQuery.ajax({
        url: urlToHandler,
        data: jsonData,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            datax = msg;

            if (msg != 0) {
                jQuery("#dverror").html("");
                window.location.href = "Profile.aspx";
            }
            else {
                jQuery("#dverror").html("Invalid Login!");
                //mmsgnew("error", "Invalid Login!");
            }
            //alert("Successfully Verified.");
            //EmployeeViewModel.init();
        }
    });
});
$(document).on('click', '#btnregister', function (e) {

    e.preventDefault();
    var fname = jQuery("#fname").val();

    var mname = jQuery("#mname").val();

    var lname = jQuery("#lname").val();

    var cdc = jQuery("#cdcnum").val();

    var psw = jQuery("#upsw").val();

    var email = jQuery("#uemail").val();



    var urlToHandler = "/Handler/LoginHandler.ashx";
    var jsonData = '{ "Method": "RegisterUser","fname":"' + fname + '","mname":"' + mname + '","lname":"' + lname + '","cdc":"' + cdc + '","psw":"' + psw + '","email":"' + email + '"}';

    var datax;
    jQuery.ajax({
        url: urlToHandler,
        data: jsonData,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            datax = msg;

            if (msg == "success")
            { window.location.href = "Profile.aspx"; }
            else
            { jQuery("#dvrgnerror").html(msg); }

            //alert("Successfully Verified.");
            //EmployeeViewModel.init();
        }
    });

});



