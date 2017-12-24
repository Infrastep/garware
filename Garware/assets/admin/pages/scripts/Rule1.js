var RULE1ViewModel = function () {

    function restoreRow() {
        $("#RULE1ID").val("0");
        $("#EarnDedn").val("");
        $("#EarnDednDesc").val("");
        $("#StDate").val("");
        $("#Class").val("");
        //$("#ShipId").val("");
        //$("#ShipName").val("");
        //$("#RankId").val("");
        //$("#RankName").val("");
        $("#Type").val("");
       
        $("#Amount").val("");

    }

    var initTablecer = function () {
        var table = $('#RULE1Table');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */



        function editRow(oTable, nRow) {
            restoreRow();
            BindEarnDedn();
            var aData = oTable.fnGetData(nRow);

            $("#RULE1ID").val(aData.RULE1ID);
            $("#EarnDedn").val(aData.EARN_DEDN_CODE);
            //$("#StDate").val(aData.RULE_WEF_DATE);
            var dateFormat = aData.RULE_WEF_DATE;
            dateFormat = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat));
            $("#StDate").val(dateFormat);
            $("#Class").val(aData.EMPL_CLASS);
            $("#Type").val(aData.AMOUNT_DPM_MPY_FLAG);
           
            $("#Amount").val(aData.EARN_DEDN_RATE);
            //BindEarnDednById(aData.EARN_DEDN_CODE);
            //BindShipById(aData.SHIP_CODE);
            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();
            $(window).scrollTop();
        }



        var urlToHandler = "Handler/Rule1Handler.ashx";
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
                          { "data": "EMPL_CLASS" },
                           { "data": "AMOUNT_DPM_MPY_FLAG" },
                            { "data": "EARN_DEDN_RATE" },
                        
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

    var urlToHandler1 = "/Handler/EarningDeductionMasterHandler.ashx";
    jsonData1 = '{ "Method": "GetdataByID","EarnDednID":"' + status + '"}';

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
});


function BindEarnDednById(earnid) {

    $('#EarnDednDesc').html("");
    var status = this.value;

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
$("#InsertdataCC").click(function (evt) {

    var table = $('#RULE1Table');
    //fileupload();
    $(table).dataTable().fnDestroy();
    var urlToHandler = "Handler/Rule1Handler.ashx";
    jsonData = '{ "Method": "InsertUpdate","RULE1ID":"' + $("#RULE1ID").val() + '","EARN_DEDN_CODE":"' + $("#EarnDedn").val() + '","EMPL_CLASS":"' + $("#Class").val() + '","RULE_WEF_DATE":"' + $("#StDate").val() + '","AMOUNT_DPM_MPY_FLAG":"' + $("#Type").val() + '","EARN_DEDN_RATE":"' + $("#Amount").val() + '"}';

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
            RULE1ViewModel.init();
            //mmsg(datax.EXP.Type, datax.EXP.Msg);
            mmsg("success", "Successfully Saved");


        }
    });
}
)