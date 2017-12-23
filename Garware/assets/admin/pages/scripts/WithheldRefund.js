var WithheldRefundViewModel = function () {

    function restoreRow() {
        $("#ID").val("0");
        $("#Emp").val("");
        $("#EmpName").val("");
        $("#amount").val("");
        $("#fyear").val("");
        $("#refno").val("");
        $("#StDate").val("");
        $("#remark").val("");

    }

    var initTablecer = function () {
        var table = $('#WithheldRefundTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */



        function editRow(oTable, nRow) {
            restoreRow();

            var aData = oTable.fnGetData(nRow);
            $("#ID").val(aData.ID);
            $("#Emp").val(aData.EMP_CODE);
            $("#EmpName").val(aData.EMP_FIXED.EMP_NAME);
            //$("#StDate").val(aData.RULE_WEF_DATE);
            var dateFormat = aData.REF_DATE;
            dateFormat = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat));
            $("#StDate").val(dateFormat);
            $("#amount").val(aData.AMOUNT);
            $("#fyear").val(aData.FINANCIAL_YEAR);
            $("#remark").val(aData.REMARKS);
            $("#refno").val(aData.REF_NO);
            BindEmpById(aData.EMP_FIXED.EMPID);
            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();
            $(window).scrollTop();
        }



        var urlToHandler = "Handler/WithheldRefundHandler.ashx";
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

                        { "data": "EMP_FIXED.EMP_CODE" },
                        { "data": "EMP_FIXED.EMP_NAME" },
                        { "data": "REF_NO" },
                        { "data": "REMARKS" },
                        { "data": "AMOUNT" },
                       

                         {
                             "data": "REF_DATE",
                             "render": function (data, type, full, meta) {
                                 return moment(data).format("MMM Do YY");
                             }
                         },
                            { "data": "FINANCIAL_YEAR" },
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
    
    var table = $('#WithheldRefundTable');
    //fileupload();
    $(table).dataTable().fnDestroy();
    var urlToHandler = "Handler/WithheldRefundHandler.ashx";
    jsonData = '{ "Method": "InsertUpdate","ID":"' + $("#ID").val() + '","EMP_CODE":"' + $("#Emp").val() + '","AMOUNT":"' + $("#amount").val() + '","FINANCIAL_YEAR":"' + $("#fyear").val() + '","REMARKS":"' + $("#remark").val() + '","REF_NO":"' + $("#refno").val() + '","REF_DATE":"' + $("#StDate").val() + '"}';

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
            WithheldRefundViewModel.init();
            //mmsg(datax.EXP.Type, datax.EXP.Msg);
            mmsg("success", "Successfully Saved");


        }
    });
}
)