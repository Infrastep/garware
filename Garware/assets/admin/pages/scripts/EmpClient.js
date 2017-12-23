check();
var EmployeeClientModel = function () {

    function restoreRow() {
        $("#ECId").val("0");

        $("#RankClass").val("");
        $("#Ship").val("");
        $("#sdate").val("");
        $("#edate").val("");

    }


    var initTable2 = function () {
        var table = $('#EmpClientTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */




        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);

            $("#ECId").val(aData.EMPCLINTID);

            $("#RankClass").val(aData.RANK_CLASS_ID);
            $("#Ship").val(aData.SHIP_ID);
            $("#sdate").val(aData.STARTDATE.split("T")[0]);

            $("#edate").val(aData.ENDDATE.split("T")[0]);

        }


        //var EmpId = utility.Querystring("id");
        var urlToHandler = "/Handler/EmployeeHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetEmpListForClient"}';


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
                {
                    "data": null,
                    "render": function (data, type, full, meta) {
                        return '<input type="checkbox" id="chk_' + full.EMPID + '" value="' + full.EMPID + '" />';
                    }
                },

               { "data": "EMP_CODE" },
                        { "data": "EMP_NAME" },

                        { "data": "NATIONALITY" },
                          { "data": "RELIGION.RELIGION_NAME" },

                            {
                                "data": null,
                                "render": function (data, type, full, meta) {
                                    return full.DOB.split("T")[0];
                                }
                            },


                            { "data": "SELECTION_STATUS_MASTER.SPNAME" }

            ],

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

            console.log('me 1');

            restoreRow();
            initTable2();


            console.log('me 2');
        }

    };

}();

$("#InsertEmpClientdata").click(function () {
    var table = $('#EmpClientTable');
    var arremp = [];
    $('#EmpClientTable').find("input:checkbox").each(function () {
        if (this.checked == true) {
            arremp.push($(this).val());
        }
    });
    
    //var EmpId = utility.Querystring("id");
    $(table).dataTable().fnDestroy();
    var urlToHandler = "/Handler/EmployeeClientHandler.ashx";
    jsonData = '{ "Method": "InsertEC","EmpID":"' + arremp + '","shipId":"' + $("#Ship").val() + '","rankclassId":"' + $("#RankClass").val() + '","sdate":"' + $("#sdate").val() + '","edate":"' + $("#edate").val() + '","id":"' + $("#ECId").val() + '"}';

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

            EmployeeClientModel.init();
            mmsg("success", "Successfully Saved.");

        }
    });

}
);
$("#Client").change(function () {
    var Client_ID = $(this).val();
    BindShipbyClientId(Client_ID);
});

function chkalll(chk) {

    $('#EmpClientTable').find("input:checkbox").each(function () {
        if (this != chk) {
            this.checked = chk.checked;
        }
    });
    check();
}
function check() {
    var count = $('#EmpClientTable').find('input[type="checkbox"]:checked').length;
  
    if (count != 0)
    { $("#dvbtn").show(); }
    else
    { $("#dvbtn").hide(); }
}
