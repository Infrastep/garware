

var ClientMasterViewModel = function () {

    function restoreRow() {
        $("#CLID").val("0")

        $("#clientname").val("");
        //$("#databasename").val("");
        //$("#databasehost").val("");
        //$("#databaseuid").val("");
        //$("#databasepsw").val("");
        $("#address").val("");
        $("#pin").val("");
        $("#city").val("");
        $("#state").val("");
        $("#phone").val("");
        $("#fax").val("");
        $("#tax").val("");
        $("#email").val("");
        $("#cinno").val("");
        $("#Pan").val("");
        $("#Tan").val("");
        $("#Website").val("");
        $("#Country").val("0");
        $("input:radio[name='Status']").each(function (i) {
            this.checked = false;
        });
        $("#sttrue").parents('span').removeClass("checked");
        $("#stfalse").parents('span').removeClass("checked");
    }

    var initTableClient = function () {
        var table = $('#ClientTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */

        function editRow(oTable, nRow) {
            restoreRow();
            var aData = oTable.fnGetData(nRow);



            $("#CLID").val(aData.CLIENTID);

            $("#clientname").val(aData.CLIENT_NAME);
            //$("#databasename").val(aData.DATABASE_NAME);
            //$("#databasehost").val(aData.DATABASE_HOST);
            //$("#databaseuid").val(aData.DATABASE_UID);
            //$("#databasepsw").val(aData.DATABASE_PASS);
            $("#address").val(aData.ADDRESS);
            $("#city").val(aData.CITY);
            $("#state").val(aData.STATE);
            $("#pin").val(aData.PIN);
            $("#phone").val(aData.PHONE);

            $("#cinno").val(aData.CIN_NO);
            $("#Pan").val(aData.PAN);
            $("#Tan").val(aData.TAN);
            $("#Website").val(aData.WEBSITE);
            $("#Country").val(aData.COUNTRY_ID);


            $("#fax").val(aData.FAX_NO);
            $("#email").val(aData.EMAIL);
            $("#taxno").val(aData.SERVICE_TAX_NO);
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

        var urlToHandler = "/Handler/ClientMasterHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetCLM"}';


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



                        { "data": "CLIENT_NAME" },
                         //{ "data": "DATABASE_NAME" },
                         //{ "data": "DATABASE_HOST" },
                         //{ "data": "DATABASE_PASS" },
                         //{ "data": "DATABASE_UID" },
                         { "data": "EMAIL" },
                         { "data": "ADDRESS" },
                         { "data": "CITY" },
                         { "data": "STATE" },
                         { "data": "COUNTRY_ID" },
                         { "data": "PHONE" },
                         { "data": "PIN" },
                         { "data": "FAX_NO" },
                         { "data": "SERVICE_TAX_NO" },
                         { "data": "CIN_NO" },
                         { "data": "PAN" },
                         { "data": "TAN" },
                         { "data": "WEBSITE" },
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
            initTableClient();


            console.log('me 2');
        }

    };

}();









$("#InsertdataClient").click(function () {
    var table = $('#ClientTable');

    $(table).dataTable().fnDestroy();
    var status = $("input[type='radio'][name='Status']:checked").val();
    var datax;
    var fileUpload = $("#ClientPic").get(0);
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
            var urlToHandler = "/Handler/ClientMasterHandler.ashx";
            var jsonData = '{ "Method": "InsertCLM",\
   "id":"' + $("#CLID").val() + '",\
    "clientname":"' + $("#clientname").val() + '",\
    "address":"' + $("#address").val() + '" ,\
    "pin":"' + $("#pin").val() + '",\
    "city":"' + $("#city").val() + '" ,\
    "state":"' + $("#state").val() + '",\
    "phone":"' + $("#phone").val() + '" ,\
    "fax":"' + $("#fax").val() + '",\
    "email":"' + $("#email").val() + '",\
    "tax":"' + $("#taxno").val() + '" ,\
"CIN_NO":"' + $("#cinno").val() + '" ,\
"PAN":"' + $("#Pan").val() + '" ,\
"TAN":"' + $("#Tan").val() + '" ,\
"WEBSITE":"' + $("#Website").val() + '" ,\
"COUNTRY_ID":"' + $("#Country").val() + '" ,\
    "path":"' + result + '",\
    "status":"' + status + '" }';

       

            $.ajax({
                url: urlToHandler,
                data: jsonData,
                dataType: 'json',
                type: 'POST',
                async: false,
                contentType: 'application/json',
                success: function (msg) {

                    datax = msg;
                    mmsg("success", "Successfully Saved.")
                    ClientMasterViewModel.init();

                }
            });
        },
        error: function (err) {
            alert(err.statusText)
        }
    });

    evt.preventDefault();
}
)