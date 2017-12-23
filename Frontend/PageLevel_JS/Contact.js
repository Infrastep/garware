
function bindContact() {

    
    var urlToHandler2 = "/Handler/AddressMasterHandler.ashx";
    var jsonData1 = '{ "Method": "GetAMByCOMID","id":"' + 3 + '"}';
    var rslt = utility.ajax(urlToHandler2, jsonData1, false, false, false);
    if (rslt != null) {
        
        var htmls = "";
        var htmlss = "";
        $("#cemail").val(rslt[0].COMPANY_PARAMETER.EMAIL);
        //$("#pph").append(rslt[0].COMPANY_PARAMETER.PHONE);
        htmlss = "Phone<br/><p class='opensans size30 orange xslim'>" + rslt[0].COMPANY_PARAMETER.PHONE + "</p><br> Email<br/><a href='" + rslt[0].COMPANY_PARAMETER.EMAIL + "' class='green2'>" + rslt[0].COMPANY_PARAMETER.EMAIL + "</a>";
        $("#dvcon").append(htmlss);

        $.each(rslt, function (key, value) {
            htmls = rslt[0].COMPANY_PARAMETER.COMPANY_NAME + "<br/><span class='dark'>" + value.ADDR0 + "<br/>" + value.ADDR1 + "<br>" + value.CITY + "," + value.COUNTRY_MASTER.C_Name + "<br>Pin:" + value.ZIP + "</span>";
            $("#dvadd").append(htmls);
           
        });

    }
    
}
$(document).on('click', '#btnsubmit', function ()
 {
    var tomail = $("#cemail").val();
    var name = $("#name").val(); var email = $("#email").val();
    var phone = $("#phone").val();
    var qry = $("#qry").val();
    var urlToHandler2 = "/Handler/AddressMasterHandler.ashx";
    var jsonData1 = '{ "Method": "SendMail","tomail":"' + tomail + '","name":"' + name + '","email":"' + email + '","phone":"' + phone + '","query":"' + qry + '"}';
    var rslt = utility.ajax(urlToHandler2, jsonData1, false, false, false);
    if (rslt != false) {
        mmsg("success", "Mail Send!");

    }
    else
    { mmsg("error", "Sorry,not able to send mail!"); }

});