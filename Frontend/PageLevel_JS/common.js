
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
            $('#ShipType').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {
                $('#ShipType').append($("<option />").val(value.TypeID).text(value.Description));
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
            $('#placeCdc').html("");
            $('#place').html("");
            $('#placeMedi').html("");
            $('#placePan').html("");
            $('#placeDC').html("");
            $('#placeCdc').append($("<option />").val(0).text("Select"));
            $('#place').append($("<option />").val(0).text("Select"));
            $('#placeMedi').append($("<option />").val(0).text("Select"));
            $('#placePan').append($("<option />").val(0).text("Select"));
            $('#placeDC').append($("<option />").val(0).text("Select"));
            $('#Country').append($("<option />").val(0).text("Select"));
            $.each(msg, function (key, value) {

                $('#place').append($("<option />").val(value.CID).text(value.C_Name));
                $('#placeCdc').append($("<option />").val(value.CID).text(value.C_Name));
                $('#placeMedi').append($("<option />").val(value.CID).text(value.C_Name));
                $('#placePan').append($("<option />").val(value.CID).text(value.C_Name));
                $('#placeDC').append($("<option />").val(value.CID).text(value.C_Name));
                $('#Country').append($("<option />").val(value.CID).text(value.C_Name));

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
function BindClient() {
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

            if (msg != "")
            {
               // $("#hdnuid").val(msg);
               // window.location.href = "Default.aspx";
            }
            else
            {
                $("#hdnuid").val("0");
                window.location.href = "Default.aspx";
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


