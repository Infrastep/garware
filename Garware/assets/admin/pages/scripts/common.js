$(document).ready(function () {

    //BindRank();
    //BindClass();
    //BindShipType();

    //BindReligion();
    //BindRelationshipMaster();
    //BindSectionLimit();
    // BindBankBranch();
    //BindCategory();
});
function BindRank() {
    var urlToHandler1 = "/Handler/RankMasterHandler.ashx";
    jsonData1 = '{ "Method": "GetRM"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Rank').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Rank').append($("<option />").val(value.RANKID).text(value.RANK_DESC));



            });


        }
    });
}

function BindRPTMonth() {
    var year = new Array(2015, 2016, 2017, 2018)
   
    var month = moment.localeData().monthsShort();
    $.each(year, function (valyr, textyr) {
        $.each(month, function (valmo, textmo) {
            $('#RPTMonth').append(
                $('<option></option>').val(textyr + "," + textmo).html(textmo + "   " + textyr)
            );
        });
    });

}

function BindClass() {
    var urlToHandler2 = "/Handler/ClassMasterHandler.ashx";
    jsonData2 = '{ "Method": "GetCLS"}';

    var datax;
    $.ajax({
        url: urlToHandler2,
        data: jsonData2,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Class').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Class').append($("<option />").val(value.CLASSID).text(value.CLASS_NAME));



            });


        }
    });

}
function BindShipType() {

    var urlToHandler3 = "/Handler/Ship_Type_MasterHandler.ashx";
    jsonData3 = '{ "Method": "GetSTM"}';

    var datax;
    $.ajax({
        url: urlToHandler3,
        data: jsonData3,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#ShipType').html("");
            $('#ShipType1').html("");
            $('#ShipType').append($("<option />").val(0).text("Select"));

            $('#ShipType1').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#ShipType').append($("<option />").val(value.TypeID).text(value.Description));

                $('#ShipType1').append($("<option />").val(value.Description).text(value.Description));



            });


        }
    });
}

function BindCountryddl() {
    var urlToHandler4 = "/Handler/CountryMasterHandler.ashx";
    jsonData4 = '{ "Method": "GetCountry"}';

    var datax;
    $.ajax({
        url: urlToHandler4,
        data: jsonData4,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Country').html("");

            $('#Country').append($("<option />").val(0).text("Select"));

            $.each(msg, function (key, value) {


                $('#Country').append($("<option />").val(value.CID).text(value.C_Name));



            });


        }
    });

}

function BindCountry() {
    var urlToHandler4 = "/Handler/CountryMasterHandler.ashx";
    jsonData4 = '{ "Method": "GetCountry"}';

    var datax;
    $.ajax({
        url: urlToHandler4,
        data: jsonData4,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#KinCountry').html("");
            $('#Country').html("");
            $('#Nationality').html("");
            $('#KinCountry').append($("<option />").val(0).text("Select"));
            $('#Country').append($("<option />").val(0).text("Select"));
            $('#Nationality').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Country').append($("<option />").val(value.CID).text(value.C_Name));
                $('#KinCountry').append($("<option />").val(value.CID).text(value.C_Name));
                $('#Nationality').append($("<option />").val(value.CID).text(value.C_Name));


            });


        }
    });

}




function BindReligion() {

    var urlToHandler5 = "/Handler/ReligionMasterHandler.ashx";
    jsonData5 = '{ "Method": "GetRGM"}';

    var datax;
    $.ajax({
        url: urlToHandler5,
        data: jsonData5,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Religion').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Religion').append($("<option />").val(value.RELIGIONID).text(value.RELIGION_NAME));



            });


        }
    });

}




function BindRelationshipMaster() {


    var urlToHandler8 = "/Handler/RelationshipMasterHandler.ashx";
    jsonData8 = '{ "Method": "GetRSM"}';

    var datax;
    $.ajax({
        url: urlToHandler8,
        data: jsonData8,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('.Relation').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('.Relation').append($("<option />").val(value.RELATIONSHIPID).text(value.RELATION));



            });


        }
    });

}




function BindSectionLimit() {

    var urlToHandler9 = "/Handler/SectionLimitHandler.ashx";
    jsonData9 = '{ "Method": "GetSL"}';

    var datax;
    $.ajax({
        url: urlToHandler9,
        data: jsonData9,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('.TaxUnderSec').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('.TaxUnderSec').append($("<option />").val(value.ID).text(value.SECTION));



            });


        }
    });

}



function BindBankBranch() {
    $("#Bank").change(function () {
        var bank = $(this).val();



        jsonData = '{ "Method": "GetBDByBANKID","id":"' + bank + '" }';


        var urlToHandler6 = "/Handler/BranchDetailsHandler.ashx";
        // jsonData6 = '{ "Method": "GetBD"}';

        var datax;
        $.ajax({
            url: urlToHandler6,
            data: jsonData,
            dataType: 'json',
            type: 'POST',
            async: false,
            contentType: 'application/json',
            success: function (msg) {


                $('#Branch').html("");
                $('#Branch').append($("<option />").val(0).text("Select"));
                $.each(msg, function (key, value) {

                    var branch = "";
                    if (value.ADDRESS1 != "") {

                        branch += value.ADDRESS1

                    }
                    if (value.ADDRESS2 != "" && value.ADDRESS1 != "") {

                        branch += ", " + value.ADDRESS2

                    }
                    if (value.ADDRESS2 != "" && value.ADDRESS1 == "") {

                        branch += value.ADDRESS2

                    }

                    $('#Branch').append($("<option />").val(value.BRANCHID).text(branch));



                });


            }
        });







    });
}



function BindCategory() {
    var urlToHandlercat = "/Handler/CategoryHandler.ashx";
    var jsonDatacat = '{ "Method": "GetCT"}';

    var datax;
    $.ajax({
        url: urlToHandlercat,
        data: jsonDatacat,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#Category').html("");
            //$('#Category').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Category').append($("<option />").val(value.CATEGORY_ID).text(value.CATEGORY_NAME));



            });


        }
    });


}





function BindBank() {
    var urlToHandler6 = "/Handler/BankMasterHandler.ashx";
    jsonData6 = '{ "Method": "GetBM"}';

    var datax;
    $.ajax({
        url: urlToHandler6,
        data: jsonData6,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#Bank').html("");
            $('#Bank1').html("");
            $('#Bank').append($("<option />").val(0).text("Select"));
            $('#Bank1').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Bank').append($("<option />").val(value.BANKID).text(value.BANK_NAME));
                $('#Bank1').append($("<option />").val(value.BANKID).text(value.BANK_NAME));



            });


        }
    });

}



function CheckUserLogin() {
    var urlToHandler1 = "/Handler/LoginHandler.ashx";
    jsonData1 = '{ "Method": "CheckLoginUser"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            if (msg != "") {
                $("#hdnuid").val(msg);
                if (msg == "Client")
                { window.location.href = "EmpLstforClient.aspx"; }
            }
            else {
                $("#hdnuid").val("0");
                window.location.href = "Login.aspx";
            }


        }
    });
}

function BindRankClass() {
    var urlToHandler1 = "/Handler/RankClassHandler.ashx";
    jsonData1 = '{ "Method": "GetRCM"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#RankClass').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#RankClass').append($("<option />").val(value.RCID).text(value.RANK_MASTER.RANK_DESC + "-" + value.CLASS.CLASS_NAME));



            });


        }
    });
}
function BindShip() {
    var urlToHandler1 = "/Handler/ShipMasterHandler.ashx";
    jsonData1 = '{ "Method": "GetSM"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Ship').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Ship').append($("<option />").val(value.SMID).text(value.VNAME));



            });


        }
    });
}

function BindDocType() {

    var urlToHandler3 = "/Handler/DocumentTypeMasterHandler.ashx";
    jsonData3 = '{ "Method": "GetDocType"}';

    var datax;
    $.ajax({
        url: urlToHandler3,
        data: jsonData3,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#doctype').html("");
            $('#doctype').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#doctype').append($("<option />").val(value.DTID).text(value.DTNAME));



            });


        }
    });
}


function BindCertificateType() {

    var urlToHandler3 = "/Handler/CertificateTypeMasterHandler.ashx";
    jsonData3 = '{ "Method": "GetCTM"}';

    var datax;
    $.ajax({
        url: urlToHandler3,
        data: jsonData3,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#CerType').html("");
            $('#CerType').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#CerType').append($("<option />").val(value.CTID).text(value.CT_DESC));



            });


        }
    });
}

function BindCompany() {
    var urlToHandler4 = "/Handler/CompanyHandler.ashx";
    jsonData4 = '{ "Method": "GetCompany"}';

    var datax;
    $.ajax({
        url: urlToHandler4,
        data: jsonData4,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Company').html("");

            $('#Company').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Company').append($("<option />").val(value.COMPANYID).text(value.COMPANY_NAME));


            });


        }
    });

}

function BindClientsml() {
    var urlToHandler1 = "/Handler/ClientMasterHandler.ashx";
    jsonData1 = '{ "Method": "GetCLM"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#client').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#client').append($("<option />").val(value.CLIENTID).text(value.CLIENT_NAME));



            });


        }
    });
}

function BindClient() {

    var urlToHandler3 = "/Handler/ClientMasterHandler.ashx";
    jsonData3 = '{ "Method": "GetCLM"}';

    var datax;
    $.ajax({
        url: urlToHandler3,
        data: jsonData3,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#Client').html("");
            $('#Client').append($("<option />").val(0).text("Select"));
            $('#Client1').html("");
            $('#Client1').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Client').append($("<option />").val(value.CLIENTID).text(value.CLIENT_NAME));

                $('#Client1').append($("<option />").val(value.CLIENT_NAME).text(value.CLIENT_NAME));

            });


        }
    });
}
function BindShipbyClientId(clientID) {
    var urlToHandler1 = "/Handler/ShipMasterHandler.ashx";
    var jsonData1 = '{ "Method": "GetSMC","client":"' + clientID + '"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#Ship').html("");
            $('#Ship').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Ship').append($("<option />").val(value.SMID).text(value.VNAME));



            });


        }
    });
}

function BindRole() {
    var urlToHandler1 = "/Handler/UserHandler.ashx";
    jsonData1 = '{ "Method": "GetRoles"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#dvrole').html("");
            $.each(msg, function (key, value) {
                if (value != "SuperAdmin" && value != "Subscriber") {
                    $('#dvrole').append("<input type='radio' name='complete' value='" + value + "' id='complete_" + value + "' class='rdubtn'/><label for='complete_" + value + "'>&nbsp;" + value + "</label>&nbsp;");

                }
                //$('#Rank').append($("<option />").val(value.RANKID).text(value.RANK_DESC));



            });


        }
    });
}
function BindStatus() {

    var urlToHandler3 = "/Handler/SelectionStatusHandler.ashx";
    jsonData3 = '{ "Method": "GetStatus"}';

    var datax;
    $.ajax({
        url: urlToHandler3,
        data: jsonData3,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Status').html("");
            $('#Status').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {




                $('#Status').append($("<option />").val(value.SPNAME).text(value.SPNAME));

            });


        }
    });
}
function BindSalutation() {

    var urlToHandler5 = "/Handler/SalutationHandler.ashx";
    jsonData5 = '{ "Method": "GetSM"}';

    var datax;
    $.ajax({
        url: urlToHandler5,
        data: jsonData5,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Salutation').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Salutation').append($("<option />").val(value.SalutationID).text(value.SalutationName));



            });


        }
    });

}


$("#Bank").change(function () {
    var bank = $(this).val();



    jsonData = '{ "Method": "GetBDByBANKID","id":"' + bank + '" }';


    var urlToHandler6 = "/Handler/BranchDetailsHandler.ashx";
    // jsonData6 = '{ "Method": "GetBD"}';

    var datax;
    $.ajax({
        url: urlToHandler6,
        data: jsonData,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {


            $('#Branch').html("");
            $('#Branch').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {

                var branch = "";
                if (value.ADDRESS1 != "") {

                    branch += value.ADDRESS1

                }
                if (value.ADDRESS2 != "" && value.ADDRESS1 != "") {

                    branch += ", " + value.ADDRESS2

                }
                if (value.ADDRESS2 != "" && value.ADDRESS1 == "") {

                    branch += value.ADDRESS2

                }

                $('#Branch').append($("<option />").val(value.BRANCHID).text(branch));



            });


        }
    });







});

$("#Bank1").change(function () {
    var bank = $(this).val();



    jsonData = '{ "Method": "GetBDByBANKID","id":"' + bank + '" }';


    var urlToHandler6 = "/Handler/BranchDetailsHandler.ashx";
    // jsonData6 = '{ "Method": "GetBD"}';

    var datax;
    $.ajax({
        url: urlToHandler6,
        data: jsonData,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {


            $('#Branch').html("");
            $('#Branch').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {

                var branch = "";
                if (value.ADDRESS1 != "") {

                    branch += value.ADDRESS1

                }
                if (value.ADDRESS2 != "" && value.ADDRESS1 != "") {

                    branch += ", " + value.ADDRESS2

                }
                if (value.ADDRESS2 != "" && value.ADDRESS1 == "") {

                    branch += value.ADDRESS2

                }

                $('#Branch').append($("<option />").val(value.BRANCHID).text(branch));



            });


        }
    });







});


var ClientType = [
    { id: 1, name: "Ship Owner" },
    { id: 2, name: "Management Co." }
];
function BindClientType() {

    $('#ClientType').html("");

    $.each(ClientType, function (key, value) {
        $('#ClientType').append($("<option />").val(value.id).text(value.name));
    });


}

var handleDMSpinners = function () {

    $('#spinnerMonth').spinner({ value: 1, min: 1, max: 12 });
    $('#spinnerMonth1').spinner({ value: 1, min: 1, max: 12 });
    $('#spinnerDay').spinner({ value: 1, min: 1, max: 31 });

}

var MedDocType = [
    { id: 0, name: "N/A" },
    { id: 1, name: "Type1" },
    { id: 2, name: "Type2" }
];
function BindMedDocType() {

    $('#MedDocType').html("");

    $.each(MedDocType, function (key, value) {
        $('#MedDocType').append($("<option />").val(value.id).text(value.name));
    });


}


var handleDatePickers = function () {

    $("#StDate").inputmask("d/m/y", {
        "placeholder": "dd/mm/yyyy"
    });

    $("#EdDate").inputmask("d/m/y", {
        "placeholder": "dd/mm/yyyy"
    });

    $("#rchqdate").inputmask("d/m/y", {
        "placeholder": "dd/mm/yyyy"
    });

    $("#radmndate").inputmask("d/m/y", {
        "placeholder": "dd/mm/yyyy"
    });

    /* Workaround to restrict daterange past date select: http://stackoverflow.com/questions/11933173/how-to-restrict-the-selectable-date-ranges-in-bootstrap-datepicker */
}

/* Ramita - 11.09.2017 */
function BindEarnDedn() {
    $('#EarnDedn').html("");
    var urlToHandler1 = "/Handler/EarningDeductionMasterHandler.ashx";
    jsonData1 = '{ "Method": "Getdata"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#EarnDedn').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#EarnDedn').append($("<option />").val(value.CODE).text(value.CODE + "-" + value.DESCR));



            });


        }
    });
}

/* Ramita - 12.09.2017 */
var InputType = [
    { id: "0", name: "N/A" },
    { id: "T", name: "T - Rule" },
    { id: "V", name: "V - Variable" },
    { id: "E", name: "E - Exception" },
    { id: "A", name: "A - Advance" },
    { id: "F", name: "F - Fixed" },
    { id: "L", name: "L - Allotment" }
];

function BindInputType() {

    $('#InputType').html("");

    $.each(InputType, function (key, value) {
        $('#InputType').append($("<option />").val(value.id).text(value.name));
    });


}

var RateType = [
    { id: 0, name: "N/A" },
    { id: "AN", name: "AN - Annual due Paid" },
    { id: "DM", name: "DM - Days per Month" },
    { id: "MY", name: "MY - Months per Year" },
    { id: "PD", name: "PD - Per Day" },
    { id: "PH", name: "PH - Per Hour" },
    { id: "PM", name: "PM - Per Month" },
    { id: "PY", name: "PY - Per Year" }
];
function BindRateType() {

    $('#RateType').html("");

    $.each(RateType, function (key, value) {
        $('#RateType').append($("<option />").val(value.id).text(value.name));
    });


}

var RuleType = [
    { id: 0, name: "N/A" },
    { id: 1, name: "Rule1" },
    { id: 2, name: "Rule2" },
    { id: 3, name: "Rule3" },
    { id: 4, name: "Rule4" },
    { id: 5, name: "Rule5" },
    { id: 6, name: "Rule6" }
];
function BindRuleType() {

    $('#RuleType').html("");

    $.each(RuleType, function (key, value) {
        $('#RuleType').append($("<option />").val(value.id).text(value.name));
    });


}

var Type = [
    { id: "0", name: "N/A" },
    { id: "T", name: "T - Rule" },
    { id: "V", name: "V - Variable" },
    { id: "E", name: "E - Exception" },
    { id: "A", name: "A - Advance" },
    { id: "F", name: "F-Fixed" },
    { id: "L", name: "L - Allotment" }
];
function BindType() {

    $('#Type').html("");

    $.each(Type, function (key, value) {
        $('#Type').append($("<option />").val(value.id).text(value.name));
    });


}


function BindRankId() {
    $('#RankId').html("");
    var urlToHandler1 = "/Handler/RankMasterHandler.ashx";
    jsonData1 = '{ "Method": "GetRM"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#RankId').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#RankId').append($("<option />").val(value.RANK_CODE).text(value.RANK_DESC));



            });


        }
    });
}

function BindShipId() {
    $('#ShipId').html("");
    var urlToHandler1 = "/Handler/ShipMasterHandler.ashx";
    jsonData1 = '{ "Method": "GetSM"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#ShipId').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#ShipId').append($("<option />").val(value.SMID).text(value.SMID));



            });


        }
    });
}
function BindSecEarnDedn() {
    $('#SecEarnDedn').html("");
    var urlToHandler1 = "/Handler/EarningDeductionMasterHandler.ashx";
    jsonData1 = '{ "Method": "Getdata"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#SecEarnDedn').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#SecEarnDedn').append($("<option />").val(value.CODE).text(value.CODE +"-"+ value.DESCR));



            });


        }
    });
}

function BindCertificate() {

    var urlToHandler3 = "/Handler/CertificateMasterHandler.ashx";
    jsonData3 = '{ "Method": "GetCMData"}';

    var datax;
    $.ajax({
        url: urlToHandler3,
        data: jsonData3,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {
            $('#Certificate').html("");
            $('#Certificate').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Certificate').append($("<option />").val(value.CERTID).text(value.CERT_DESC));



            });


        }
    });
}

function BindRoleforPermission() {
    var urlToHandler1 = "/Handler/UserHandler.ashx";
    jsonData1 = '{ "Method": "GetRoles"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#dwrole').html("");
            $.each(msg, function (key, value) {
                
                    $('#dwrole').append($("<option />").val(value).text(value));
                


            });


        }
    });
}

var WaterType = [
   { id: 0, name: "N/A" },
    { id: "INDIAN ", name: "INDIAN " },
    { id: "FOREIGN", name: "FOREIGN" }
];
function BindWaterType() {

    $('#WaterType').html("");

    $.each(WaterType, function (key, value) {
        $('#WaterType').append($("<option />").val(value.id).text(value.name));
    });


}
function BindEmployee() {
    var urlToHandler1 = "/Handler/EmployeeHandler.ashx";
    jsonData1 = '{ "Method": "GetEMP"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#Emp').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#Emp').append($("<option />").val(value.EMPID).text(value.EMP_CODE));



            });


        }
    });
}

function BindAgreement() {
    var urlToHandler1 = "/Handler/AgreementDetailsHandler.ashx";
    jsonData1 = '{ "Method": "Getdata"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#agreement').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#agreement').append($("<option />").val(value.AGREEMENT_DETAILS_ID).text(value.AGREEMENT_CODE));



            });


        }
    });
}

function BindTaxCode() {
    var urlToHandler1 = "/Handler/TaxCodeHandler.ashx";
    jsonData1 = '{ "Method": "GetTC"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#taxcode').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#taxcode').append($("<option />").val(value.ID).text(value.DESCRIPTIONS));



            });


        }
    });
}

function BindOtherIncome() {
    var urlToHandler1 = "/Handler/OtherIncomeHandler.ashx";
    jsonData1 = '{ "Method": "GetOI"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg) {

            $('#otherincome').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {


                $('#otherincome').append($("<option />").val(value.ID).text(value.DESCRIPTION));



            });


        }
    });
}