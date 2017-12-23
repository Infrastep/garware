var CategoryViewModel = function () {

    function restoreRow() {
        $("#CTID").val("0");

        $("#CategoryName").val("");
        $("#CategoryCode").val("");
        //$("#CategoryLeave").val("");
        //$("#CategoryShore").val("");
        $("input:radio[name='Status']").each(function (i) {
            this.checked = false;
        });
        $("#sttrue").parents('span').removeClass("checked");
        $("#stfalse").parents('span').removeClass("checked");

    }

    var initTable2 = function () {
        var table = $('#CategoryTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */
        function restoreRow() {
            $("#CTID").val("0");

            $("#CategoryName").val("");
            $("#CategoryCode").val("");
            //$("#CategoryLeave").val("");
            //$("#CategoryShore").val("");


        }
        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);

           
            $("#CTID").val(aData.CATEGORY_ID);

            $("#CategoryName").val(aData.CATEGORY_NAME);
            $("#CategoryCode").val(aData.CATEGORY_CODE);
            //$("#CategoryLeave").val(aData.LEAVE_SYSTEM);
            //$("#CategoryShore").val(aData.SHORE_FLOAT);
            if (aData.STATUS == true) {

                $("#sttrue").attr('checked', 'checked');
                $("#sttrue").parents('span').addClass("checked");
            }
            else if (aData.STATUS == false) {
                $("#stfalse").attr('checked', 'checked');
                $("#stfalse").parents('span').addClass("checked");
            }
            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();
            $(window).scrollTop();
        }

        var urlToHandler = "/Handler/CategoryHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetCT"}';


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



                        { "data": "CATEGORY_NAME" },
                        { "data": "CATEGORY_CODE" },
                       { "data": "STATUS" },
                     


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

            console.log('me 1');

            restoreRow();
            initTable2();


            console.log('me 2');
        }

    };

}();









$("#InsertdataCT").click(function () {
    var table = $('#CategoryTable');

    $(table).dataTable().fnDestroy();

    var status = $("input[type='radio'][name='Status']:checked").val();
    var urlToHandler = "/Handler/CategoryHandler.ashx";
    //jsonData = '{ "Method": "InsertCT","id":"' + $("#CTID").val() + '","cname":"' + $("#CategoryName").val() + '","leave":"' + $("#CategoryLeave").val() + '","shore":"' + $("#CategoryShore").val() + '" }';
    jsonData = '{ "Method": "InsertCT","id":"' + $("#CTID").val() + '","cname":"' + $("#CategoryName").val() + '","code":"' + $("#CategoryCode").val() + '","status":"' + status + '"}';
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
            mmsg("success", "Successfully Saved.");
            //alert("Successfully Saved.")
            CategoryViewModel.init();
        }
    });

}
)