var MainTableOfficerViewModel = function () {

    function restoreRow() {
        $("#MAINID").val("0");
        $("#EarnDedn").val("");
        $("#EarnDednDesc").val("");
        $("#StDate").val("");
        $("#EdDate").val("");
        $("#Class").val("");
        $("#InputType").val("");
        $("#RateType").val("");
        $("#RuleType").val("");

        $("#OnArticle").prop("checked", false);
        $("#OnHarbour").prop("checked", false);
        $("#OnStaff").prop("checked", false);
        $("#OnLeave").prop("checked", false);
        $("#MedicalLeaveInIndia").prop("checked", false);
        $("#MedicalLeaveInAbroad").prop("checked", false);
        

        $("#Taxable").prop("checked", true);
        $("#ItForcast").prop("checked", true);
    }

    var initTablecer = function () {
        var table = $('#MainTableOfficerTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */



        function editRow(oTable, nRow) {
            restoreRow();
            BindEarnDedn();
            BindRuleType();
            var aData = oTable.fnGetData(nRow);
            $("#MAINID").val(aData.MAINTABLEID);
            $("#EarnDedn").val(aData.EARN_DEDN_CODE);
            $("#EarnDednDesc").val(aData.EARN_DEDN_CODE);
            var dateFormat = aData.RULE_WEF_DATE;
            dateFormat = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat));
            $("#StDate").val(dateFormat);
            var dateFormat1 = aData.RULE_TILL_DATE;
            dateFormat1 = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat1));
            $("#EdDate").val(dateFormat1);

            $("#Class").val(aData.EMPL_CLASS);

            var INPUT_TYPE = aData.INPUT_TYPE.trim();

            $("#InputType").val(INPUT_TYPE);

            if (INPUT_TYPE == "T") { $("#RuleType").val(aData.RULE_TYPE); }
            else { $('#RuleType').append($("<option />").val(0).text("N/A")); }

            var RateType = aData.RATE_TYPE.trim();
            $("#RateType").val(RateType);


            if (aData.OFF_ON_BRD_PRD_FLAG == "1") {
                $("#OnArticle").prop('checked', 'checked');
            } else {
                $("#OnArticle").prop('checked', "false");
            }

            if (aData.OFF_HRB_PRD_FLAG == "1") {
                $("#OnHarbour").prop('checked', 'checked');
            } else {
                $("#OnHarbour").prop('checked', "false");
            }
            if (aData.OFF_STF_PRD_FLAG == "1") {
                $("#OnStaff").prop('checked', 'checked');
            } else {
                $("#OnStaff").prop('checked', "false");
            }

            if (aData.OFF_LEAVE_EARND_FLAG == "1") {
                $("#OnLeave").prop('checked', 'checked');
            } else {
                $("#OnLeave").prop('checked', "false");
            }
            if (aData.OFF_MDCLI_PRD_FLAG == "1") {
                $("#MedicalLeaveInIndia").prop('checked', 'checked');
            } else {
                $("#MedicalLeaveInIndia").prop('checked', "false");
            }

            if (aData.OFF_MDCLF_PRD_FLAG == "1") {
                $("#MedicalLeaveInAbroad").prop('checked', 'checked');
            } else {
                $("#MedicalLeaveInAbroad").prop('checked', "false");
            }
            if (aData.IT_FORECAST_INDIC == "1") {
                $("#ItForcast").prop('checked', 'checked');
            } else {
                $("#ItForcast").prop('checked', "false");
            }
            if (aData.TAXABLE_FLAG == "1") {
                $("#Taxable").prop('checked', 'checked');
            } else {
                $("#Taxable").prop('checked', "false");
            }
            
            BindEarnDednById(aData.EARN_DEDN_CODE);
            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();
            $(window).scrollTop();
        }



        var urlToHandler = "/Handler/MainTableOfficerHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "Getdata"}';


        var orders

        $.ajax({
            url: urlToHandler,
            data: jsonData,
            dataType: 'json',
            type: 'POST',
            async: false,
            contentType: 'application/json',
            success: function (data) {
                orders = data;
            }
        });






        $.extend(true, $.fn.DataTable.TableTools.classes, {
            "container": "btn-group tabletools-btn-group pull-right",
            "buttons": {
                "normal": "btn btn-sm default",
                "disabled": "btn btn-sm default disabled"
            }
        });

        var oTable = table.dataTable({

            // Internationalisation. For more info refer to http://datatables.net/manual/i18n
            "language": {
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                },
                "emptyTable": "No data available in table",
                "info": "Showing _START_ to _END_ of _TOTAL_ entries",
                "infoEmpty": "No entries found",
                "infoFiltered": "(filtered1 from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "search": "Search:",
                "zeroRecords": "No matching records found"
            },

            "order": [
                [0, 'asc']
            ],
            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "All"] // change per page values here
            ],

            // set the initial value
            "pageLength": 10,
            "dom": "<'row' <'col-md-12'T>><'row'<'col-md-6 col-sm-12'l><'col-md-6 col-sm-12'f>r><'table-scrollable't><'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12'p>>", // horizobtal scrollable datatable


            data: orders,

            "columns": [

                        { "data": "EARN_DEDN_CODE" },
                         {
                             "data": "RULE_WEF_DATE",
                             "render": function (data, type, full, meta) {
                                 return moment(data).format("MMM Do YY");
                             }
                         },
                         {
                             "data": "RULE_TILL_DATE",
                             "render": function (data, type, full, meta) {
                                 return moment(data).format("MMM Do YY");
                             }
                         },
                          { "data": "EMPL_CLASS" },
                           { "data": "RATE_TYPE" },
                             { "data": "RULE_TYPE" },
                               { "data": "INPUT_TYPE" },

                          {
                              "data": null,
                              "render": function (data, type, full, meta) {
                                  return '<a class="edit" href="javascript:;">Edit </a>';
                              }
                          }],

            deferRender: true,




            // Uncomment below line("dom" parameter) to fix the dropdown overflow issue in the datatable cells. The default datatable layout
            // setup uses scrollable div(table-scrollable) with overflow:auto to enable vertical scroll(see: assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.js). 
            // So when dropdowns used the scrollable div should be removed. 
            //"dom": "<'row' <'col-md-12'T>><'row'<'col-md-6 col-sm-12'l><'col-md-6 col-sm-12'f>r>t<'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12'p>>",

            "tableTools": {
                "sSwfPath": "../../assets/global/plugins/datatables/extensions/TableTools/swf/copy_csv_xls_pdf.swf",
                "aButtons": [{
                    "sExtends": "pdf",
                    "sButtonText": "PDF"
                }, {
                    "sExtends": "csv",
                    "sButtonText": "CSV"
                }, {
                    "sExtends": "xls",
                    "sButtonText": "Excel"
                }, {
                    "sExtends": "print",
                    "sButtonText": "Print",
                    "sInfo": 'Please press "CTRL+P" to print or "ESC" to quit',
                    "sMessage": "Generated by DataTables"
                }, {
                    "sExtends": "copy",
                    "sButtonText": "Copy"
                }]
            }
        });

        var tableWrapper = $('#sample_2_wrapper'); // datatable creates the table wrapper by adding with id {your_table_jd}_wrapper
        tableWrapper.find('.dataTables_length select').select2(); // initialize select2 dropdown


        var nEditing = null;
        var nNew = false;
        table.on('click', '.edit', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];

            if (nEditing !== null && nEditing != nRow) {
                /* Currently editing - but not this row - restore the old before continuing to edit mode */
                restoreRow();
                editRow(oTable, nRow);
                nEditing = nRow;
            } else if (nEditing == nRow && this.innerHTML == "Save") {
                /* Editing this row and want to save it */
                saveRow(oTable, nEditing);
                nEditing = null;
                alert("Updated! Do not forget to do some ajax to sync with backend :)");
            } else {
                /* No edit in progress - let's start one */
                editRow(oTable, nRow);
                nEditing = nRow;
            }
        });
    }



    return {

        //main function to initiate the module
        init: function () {

            if (!jQuery().dataTable) {
                return;
            }

            // console.log('me 1');

            restoreRow();
            initTablecer();


            // console.log('me 2');
        }

    };

}();
$("#EarnDedn").change(function () {
    $('#EarnDednDesc').html("");
    var status = this.value;

    BindEarnDednById(status);
});

function BindEarnDednById(earnid) {

    $('#EarnDednDesc').html("");

    var urlToHandler1 = "/Handler/EarningDeductionMasterHandler.ashx";
    jsonData1 = '{ "Method": "GetdataByID","EarnDednID":"' + earnid + '"}';

    var datax;
    $.ajax({
        url: urlToHandler1,
        data: jsonData1,
        dataType: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json',
        success: function (msg1) {

            //$('#EarnDednDesc').append($("<option />").val(0).text("Select"));

            // alert(msg1);
            $('#EarnDednDesc').append($("<option />").val(msg1.EARNDEDNID).text(msg1.DESCRIPTION));




        }
    });
}
$("#InputType").change(function () {
    $('#RuleType').html("");
    var status = this.value;
    if (status == "T")
    { BindRuleType(); }
    else
    { $('#RuleType').append($("<option />").val(0).text("N/A")); }

});
$("#InsertdataCC").click(function (evt) {
   
    var OnArticle;
    var OnHarbour;
    var OnStaff;
    var OnLeave;
    var MedicalLeaveInIndia;
    var MedicalLeaveInAbroad;
   
    var table = $('#MainTableOfficerTable');
    //fileupload();
    $(table).dataTable().fnDestroy();
    var urlToHandler = "/Handler/MainTableOfficerHandler.ashx";
    if ($("#OnArticle").prop("checked") == true)
    { OnArticle = 1; }
    else
    { OnArticle = 0; }

    if ($("#OnHarbour").prop("checked") == true)
    { OnHarbour = 1; }
    else
    { OnHarbour = 0; }

    if ($("#OnStaff").prop("checked") == true)
    { OnStaff = 1; }
    else
    { OnStaff = 0; }

    if ($("#OnLeave").prop("checked") == true)
    { OnLeave = 1; }
    else
    { OnLeave = 0; }

    if ($("#MedicalLeaveInIndia").prop("checked") == true)
    { MedicalLeaveInIndia = 1; }
    else
    { MedicalLeaveInIndia = 0; }

    if ($("#MedicalLeaveInAbroad").prop("checked") == true)
    { MedicalLeaveInAbroad = 1; }
    else
    { MedicalLeaveInAbroad = 0; }

   


    if ($("#Taxable").prop("checked") == true)
    { Taxable = 1; }
    else
    { Taxable = 0; }

    if ($("#ItForcast").prop("checked") == true)
    { ItForcast = 1; }
    else
    { ItForcast = 0; }

    jsonData = '{ "Method": "InsertUpdate","id":"' + $("#MAINID").val() + '","EARN_DEDN_CODE":"' + $("#EarnDedn").val() + '","EMPL_CLASS":"' + $("#Class").val() + '","OFF_HRB_PRD_FLAG":"' + OnHarbour + '","OFF_LEAVE_EARND_FLAG":"' + OnLeave + '","OFF_MDCLF_PRD_FLAG":"' + MedicalLeaveInAbroad + '","OFF_MDCLI_PRD_FLAG":"' + MedicalLeaveInIndia + '","OFF_ON_BRD_PRD_FLAG":"' + OnArticle + '","OFF_STF_PRD_FLAG":"' + OnStaff + '","RULE_WEF_DATE":"' + $("#StDate").val() + '","RULE_TILL_DATE":"' + $("#EdDate").val() + '","INPUT_TYPE":"' + $("#InputType").val() + '","RULE_TYPE":"' + $("#RuleType").val() + '","RATE_TYPE":"' + $("#RateType").val() + '","TAXABLE_FLAG":"' + Taxable + '","IT_FORECAST_INDIC":"' + ItForcast + '"}';
    //,"CRW_ON_BRD_PRD_FLAG":"' + $("#Board").val() + '","CRW_RETN1_PRD_FLAG":"' + $("#PostsignOnRetention").val() + '","CRW_RETN2_PRD_FLAG":"' + $("#PresignOnRetention").val() + '","CRW_HOSPTLSD_IND_FLAG":"' + $("#HospitalizedInIndia").val() + '","CRW_HOSPTLSD_ABROAD_FLAG":"' + $("#HospitalizedInAbroad").val() + '","CRW_MDCLI_PRD_FLAG":"' + $("#MedicalInIndia").val() + '","CRW_ADV_FLAG":"' + $("#Advance").val() + '","CRW_LEAVE_EARND_FLAG":"' + $("#LeaveEarned").val() + '","CRW_CONTNS_SERVICE_FLAG":"' + $("#ContinuousService").val() + '","RULE_WEF_DATE":"' + $("#StDate").val() + '","RULE_TILL_DATE":"' + $("#EdDate").val() + '","INPUT_TYPE":"' + $("#InputType").val() + '","RULE_TYPE":"' + $("#RuleType").val() + '","RATE_TYPE":"' + $("#RateType").val() + '","TAXABLE_FLAG":"' + $("#Taxable").val() + '","IT_FORECAST_INDIC":"' + $("#ItForcast").val() + '"}';

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
            MainTableOfficerViewModel.init();
            mmsg("success", "Successfully Saved");


        }
    });
}
)