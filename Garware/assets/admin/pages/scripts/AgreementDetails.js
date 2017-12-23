var AgreementDetailsViewModel = function () {

    function restoreRow() {
        $("#ACID").val("0");
        $("#Emp").val("");
        $("#EmpName").val("");
        $("#amount").val("");
        $("#fyear").val("");
        $("#cerno").val("");
        $("#StDate").val("");
        $("#taxcode").val("");
        $("#mon").val("");
        $("#agreement").val("");
    }

    var initTablecer = function () {
        var table = $('#AgreementDetailsTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */



        function editRow(oTable, nRow) {
            restoreRow();

            var aData = oTable.fnGetData(nRow);
            $("#ACID").val(aData.ACTUAL_SAVINGS_ID);
            $("#Emp").val(aData.EMP_CODE);
            $("#EmpName").val(aData.EMP_FIXED.EMP_NAME);
            //$("#StDate").val(aData.RULE_WEF_DATE);
            var dateFormat = aData.SAVINGS_DATE;
            dateFormat = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat));
            $("#StDate").val(dateFormat);
            $("#amount").val(aData.AMOUNT);
            $("#fyear").val(aData.FINANCIAL_YEAR);
            $("#taxcode").val(aData.TYPE);
            var taxdes = aData.TAX_CODE.DESCRIPTIONS.trim();
            if (taxdes == "ROOM RENT") {
                $("#dvmo").show();
            }
            else { $("#dvmo").hide(); }
            $("#cerno").val(aData.CERTIFICATE_NO);
            $("#agreement").val(aData.AGREEMENT_CODE);
            $("#mon").val(aData.NO_MONTHS);
            BindEmpById(aData.EMP_FIXED.EMPID);
            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();
            $(window).scrollTop();
        }



        var urlToHandler = "Handler/AgreementDetailsHandler.ashx";
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
                { "data": "AGREEMENT_CODE" },
                {
                    "data": "ref_date",
                    "render": function (data, type, full, meta) {
                        return moment(data).format("MMM Do YY");
                    }
                },
                        { "data": "EMP_CODE" },
                        { "data": "EMP_NAME" },

                        { "data": "VNAME" },


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




$("#Emp").change(function () {
    var id = this.value;
    BindEmpById(id);
});


function BindEmpById(empid) {

    $('#EmpName').html("");

    var urlToHandler1 = "/Handler/EmployeeHandler.ashx";
    jsonData1 = '{ "Method": "GetEMPByID","empID":"' + empid + '"}';

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
            $('#EmpName').append($("<option />").val(msg1.EMPID).text(msg1.EMP_NAME));




        }
    });
}



$("#InsertdataCC").click(function (evt) {

    var table = $('#AgreementDetailsTable');
    //fileupload();
    $(table).dataTable().fnDestroy();
    var urlToHandler = "Handler/AgreementDetailsHandler.ashx";
    jsonData = '{ "Method": "InsertUpdate","ACTUAL_SAVINGS_ID":"' + $("#ACID").val() + '","EMP_CODE":"' + $("#Emp").val() + '","AMOUNT":"' + $("#amount").val() + '","FINANCIAL_YEAR":"' + $("#fyear").val() + '","TYPE":"' + $("#taxcode").val() + '","CERTIFICATE_NO":"' + $("#cerno").val() + '","SAVINGS_DATE":"' + $("#StDate").val() + '","NO_MONTHS":"' + $("#mon").val() + '","AGREEMENT_CODE":"' + $("#agreement").val() + '"}';

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
            AgreementDetailsViewModel.init();
            //mmsg(datax.EXP.Type, datax.EXP.Msg);
            mmsg("success", "Successfully Saved");


        }
    });
}
)