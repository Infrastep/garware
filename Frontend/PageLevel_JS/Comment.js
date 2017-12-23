function bindComment() {
    
    var EmpID = utility.getCookie("fempid");
    var urlToHandler1 = "/Handler/EmployeeHandler.ashx";
    var urlToHandler2 = "/Handler/CommentHandler.ashx";
    var jsonData1 = '{ "Method": "GetCOM","id":"' + EmpID + '"}';
    var rslt = utility.ajax(urlToHandler2, jsonData1, false, false, false);
    if (rslt != null) {
        var htmls = "";
        var htmlss = "";
        var emplst = "";
        var emplsts = "";
        var flag;
        $("#chts").html("");
       
        
        $.each(rslt, function (key, value) {

            if (rslt[key].SENDERUSERID == EmpID) {
                htmls = "<li class='out'><img class='avatar' alt='' src='" + rslt[key].EMP_FIXED2.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt[key].EMP_FIXED2.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt[key].COMMENT1 + "</span></div></li>";
                $("#chts").append(htmls);

            }
            else if (rslt[key].RECEIVERUSERID == EmpID && rslt[key].PRIVATE == true) {
                htmls = "<li class='in'><img class='avatar' alt='' src='" + rslt[key].EMP_FIXED2.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt[key].EMP_FIXED2.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt[key].COMMENT1 + "</span><a id='" + rslt[key].EMP_FIXED2.EMPID + "' href='javascript:;' class='reply'>Reply</a></div></li>";
                $("#chts").append(htmls);

            } else if (rslt[key].PRIVATE == false && rslt[key].SENDERUSERID != EmpID) {
                htmlss = "<li class='in'><img class='avatar' alt='' src='" + rslt[key].EMP_FIXED2.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt[key].EMP_FIXED2.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt[key].COMMENT1 + "</span><a id='" + rslt[key].EMP_FIXED2.EMPID + "' href='javascript:;' class='reply'>Reply</a></div></li>";
                $("#chts").append(htmlss);

            }


        });

    }
    var urlToHandler = "/Handler/ClientCommentHandler.ashx";
    var jsonData = '{ "Method": "GetCLIENTCOM","id":"' + EmpID + '"}';
    var rslt1 = utility.ajax(urlToHandler, jsonData, false, false, false);
    if (rslt1 != null) {
        var htmls = "";
        var htmlss = "";
        
        $("#clchts").html("");


        $.each(rslt1, function (key, value) {

            if (rslt1[key].SENDERUSERID == EmpID ) {
                htmls = "<li class='out'><img class='avatar' alt='' src='" + rslt1[key].EMP_FIXED1.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt1[key].EMP_FIXED1.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt1[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt1[key].COMMENT + "</span></div></li>";
                $("#clchts").append(htmls);

            }
            if (rslt1[key].RECEIVERUSERID == EmpID && rslt1[key].PRIVATE == true) {
                htmls = "<li class='in'><img class='avatar' alt='' src='" + rslt1[key].EMP_FIXED1.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt1[key].EMP_FIXED1.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt1[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt1[key].COMMENT + "</span><a id='" + rslt[key].EMP_FIXED2.EMPID + "' href='javascript:;' class='clreply'>Reply</a></div></li>";
                $("#clchts").append(htmls);

            } else if (rslt1[key].PRIVATE == false && rslt1[key].SENDERUSERID != EmpID) {
                htmlss = "<li class='in'><img class='avatar' alt='' src='" + rslt1[key].EMP_FIXED1.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt1[key].EMP_FIXED1.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt1[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt1[key].COMMENT + "</span><a id='" + rslt[key].EMP_FIXED2.EMPID + "' href='javascript:;' class='clreply'>Reply</a></div></li>";
                $("#clchts").append(htmlss);

            }


        });

    }
   
}

$(document).on('click', '#anccom', function () {

    var EmpID = utility.getCookie("fempid");
   
    var sender = EmpID;
    var receiver = $("#hdnVReciver").val();
    var comment = $("#txtmsg").val();
    var status;
    var pri;
    var pub;
    if ($("input[type='radio'].rdbtn1").is(':checked')) {
        status = $("input[type='radio'].rdbtn1:checked").val();
        if (status == "Private") {
            pri = true;
            pub = false;
        }
        else {
            pub = true;
            pri = false;
        }

    }
    var urlToHandler = "/Handler/CommentHandler.ashx";
    jsonData = '{ "Method": "InsertCOM","comid":"0","empID":"' + EmpID + '","sender":"' + sender + '","receiver":"' + receiver + '","comment":"' + comment + '","pub":"' + pub + '","pri":"' + pri + '"}';
    var datax;
    $.ajax({
        url: urlToHandler,
        data: jsonData,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            datax = msg;
            $("#txtmsg").val("");
            //$('#verifyPop').modal('hide');
            bindComment(EmpID);
            mmsg("success", "Successfully Send.");
            //alert("Successfully Verified.");
            //EmployeeViewModel.init();
        }
    });

});

$(document).on('click', '.reply', function () {
    var rcid = $(this).attr("id");
    $("#hdnVReciver").val(rcid);
    $("#txtmsg").focus();
    $("#dvchats").show();
});

$(document).on('click', '#clanccom', function () {

    var EmpID = utility.getCookie("fempid");

    var sender = EmpID;
    var receiver = $("#hdnCReciver").val();
    var comment = $("#cltxtmsg").val();
    var status;
    var pri;
    var pub;
    if ($("input[type='radio'].clrdbtn1").is(':checked')) {
        status = $("input[type='radio'].clrdbtn1:checked").val();
        if (status == "Private") {
            pri = true;
            pub = false;
        }
        else {
            pub = true;
            pri = false;
        }

    }
    var urlToHandler = "/Handler/ClientCommentHandler.ashx";
    jsonData = '{ "Method": "InsertCOM","comid":"0","empID":"' + EmpID + '","sender":"' + sender + '","receiver":"' + receiver + '","comment":"' + comment + '","pub":"' + pub + '","pri":"' + pri + '"}';
    var datax;
    $.ajax({
        url: urlToHandler,
        data: jsonData,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            datax = msg;
            $("#cltxtmsg").val("");
            //$('#verifyPop').modal('hide');
            bindComment(EmpID);
            mmsg("success", "Successfully Send.");
            //alert("Successfully Verified.");
            //EmployeeViewModel.init();
        }
    });

});

$(document).on('click', '.clreply', function () {
    var rcid = $(this).attr("id");
    $("#hdnCReciver").val(rcid);
    $("#cltxtmsg").focus();
    $("#cldvchats").show();
});