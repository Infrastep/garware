

$(document).ready(function () {
    CheckUserLogin();
    BindReligion();
    BindCountry();
    BindSalutation();
    bindEmp();
});
var urlToHandler = "/Handler/EmployeeHandler.ashx";

function bindEmp() {
    var eid = utility.getCookie("fempid");
    if (eid != 0) {
        var jsonData = '{ "Method": "GetEMByID","id":"' + eid + '"}';
        var rslt = utility.ajax(urlToHandler, jsonData, false, false, false);
        $("#name").val(rslt.EMP_NAME);
        $("#email").val(rslt.EMAIL);
        $("#EID").val(rslt.EMPID);
        $("#Code").val(rslt.EMP_CODE);
        $("#Country").val(rslt.NATIONALITY);
        $("#Religion").val(rslt.RELIGIONID);
        $("#BirthPlace").val(rslt.BIRTH_PLACE);
        //if (rslt.SR_CITIZEN == true) {
        //    $("#SrCitizen").val("1");
        //}
        //else
        //{ $("#SrCitizen").val("0"); }
        $("#datepicker8").val(rslt.DOB);
        $("#PAddress1").val(rslt.ADDR_PRESENT1);
        $("#PAddress2").val(rslt.ADDR_PRESENT2);
        $("#PPhone").val(rslt.TELEPHONE_PRESENT);
        $("#PMAddress1").val(rslt.ADDR_PRMNT1);
        $("#PMAddress2").val(rslt.ADDR_PRMNT2);
        $("#PMFax").val(rslt.FAX);
        $("#PMMobile").val(rslt.MOBILE);
        $("#PMPhone").val(rslt.TELEPHONE_PRMNT);
        $("#fathername").val(rslt.FATHER_NAME);
        $("#Salutation").val(rslt.SEX);
        //if (rslt.SEX == "Mr.") {
        //    $("#optionsRadios1").attr('checked', 'checked');
        //    //$('input:radio[name=optionsRadios]:checked').val(rslt.SEX);
        //}
        //else {
        //    $("#optionsRadios2").attr('checked', 'checked');
        //    //$('input:radio[name=optionsRadios]:checked').val(rslt.SEX);
        //}
        $("#imguser").attr("src", rslt.PHOTO);
        $("#InsertdataCCPass").show();
        $("#InsertdataCCCdc").show();
        $("#InsertdataCCPan").show();
        $("#InsertdataCCMedi").show();
        $("#InsertdataDC").show();
        $("#InsertdataEE").show();
    }
    else {
        $("#EID").val(0);
        $("#name").val(utility.getCookie("fname"));
        $("#email").val(utility.getCookie("femail"));
    }
}

//$('#btntab1').click(function (e) {
    $(document).on('click', '#btntab1', function (e) {
    e.preventDefault();
    var fileUpload = $("#Photo").get(0);
    var files = fileUpload.files;

    var data = new FormData();
    for (var i = 0; i < files.length; i++) {
        data.append(files[i].name, files[i]);
    }

    $.ajax({
        url: "/Handler/Uploader.ashx",
        type: "POST",
        data: data,
        contentType: false,
        processData: false,
        success: function (result) {

            var jsonData = '{ "Method": "InsertEM","id":"' + $("#EID").val() + '",\
    "prefix":"' + $("#Salutation").val() + '",\
"name":"' + $("#name").val() + '",\
"code":"' + $("#Code").val() + '",\
"nationality":"' + $("#Country").val() + '",\
"religion":"' + $("#Religion").val() + '",\
    "bplace":"' + $("#BirthPlace").val() + '",\
"dob":"' + $("#datepicker8").val() + '",\
    "photo":"'+result+'",\
"paddress1":"' + $("#PAddress1").val() + '",\
"paddress2":"' + $("#PAddress2").val() + '",\
"pphone":"' + $("#PPhone").val() + '",\
"pmaddress1":"' + $("#PMAddress1").val() + '",\
"pmaddress2":"' + $("#PMAddress2").val() + '",\
"pmfax":"' + $("#PMFax").val() + '",\
"pmmobile":"' + $("#PMMobile").val() + '",\
"pmemail":"' + $("#email").val() + '",\
"pmphone":"' + $("#PMPhone").val() + '",\
"fathername":"' + $("#fathername").val() + '"}';
            var rslt = utility.ajax(urlToHandler, jsonData, false, false, false);
            if (rslt != null) {

                $("#EID").val(rslt.EMPID);
                $("#InsertdataCCPass").show();
                $("#InsertdataCCCdc").show();
                $("#InsertdataCCPan").show();
                $("#InsertdataCCMedi").show();
                mmsg("success", "Successfully Saved.");
                //alert("Successfully Saved.");
            }
        },
        error: function (err) {
            alert(err.statusText)
        }
    });
    e.preventDefault();


});

$('#picup').click(function () {
    $("#UploadImage").modal("show");

});

$('#btnupload').click(function () {
    var fileUpload = $("#uimg").get(0);
    var files = fileUpload.files;

    var data = new FormData();
    for (var i = 0; i < files.length; i++) {
        data.append(files[i].name, files[i]);
    }

    $.ajax({
        url: "/Handler/imguploader.ashx",
        type: "POST",
        data: data,
        contentType: false,
        processData: false,
        success: function (result) {
            if (result != null) {
                var url = "/Handler/imguploader.ashx";
                var jdata = '{"Method": "UpdateEmpImage","id":"' + $("#EID").val() + '","path":"' + result + '"}';
                var rslt = utility.ajax(url, jdata, false, false, false);
            }
        }
    });
});


$('#chksame').change(function () {
    if ($(this).is(":checked")) {
        $("#PMAddress1").val($("#PAddress1").val());
        $("#PMAddress2").val($("#PAddress2").val());
        $("#PMPhone").val($("#PPhone").val());

    }
    else {
        $("#PMAddress1").val("");
        $("#PMAddress2").val("");
        $("#PMPhone").val("");
    }
   
});



