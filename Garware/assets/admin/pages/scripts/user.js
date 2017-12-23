
var UserViewModel = function () {

    function restoreRow() {
        $("#EID").val("0");
        $("#EBID").val("0");
        $("#Salutation").val("0");
        $("#Name").val("");
       
        $("#PMMobile").val("");
        $("#PMEmail").val("");
        $("#dsgn").val("");
        $("input:radio[name='Sign']").each(function (i) {
            this.checked = false;
        });
        $("input:radio[name='Status']").each(function (i) {
            this.checked = false;
        });
       
    }

    var initTable2 = function () {
        var table = $('#UserTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */
        //EmployeeBranchViewModel.init();
        function editRow(oTable, nRow) {
            restoreRow();
            var aData = oTable.fnGetData(nRow);
            
            if (aData.STATUS == 9) {

                $("#stenable").attr('checked', 'checked');
                $("#stenable").parents('span').addClass("checked");
            }
            else if (aData.STATUS == 10)
            {
                $("#stendisable").attr('checked', 'checked');
                $("#stendisable").parents('span').addClass("checked");
            }
            if (aData.SIGNINGAUTH == true) {

                $("#sttrue").attr('checked', 'checked');
                $("#sttrue").parents('span').addClass("checked");
            }
            else if (aData.SIGNINGAUTH == false) {
                $("#stfalse").attr('checked', 'checked');
                $("#stfalse").parents('span').addClass("checked");
            }
            
            $("#EID").val(aData.EMPID);
            $("input[type=radio][value='" + aData.RoleName + "']").attr('checked', 'checked');
            //$("#complete_" + aData.EMPID).
            if (aData.RoleName == "Client")
            {
                if (aData.CLIENTUSERID == null)
                { $("#ECID").val("0"); }
                else
                { $("#ECID").val(aData.CLIENTUSERID); }
             
                $("#dvclient").show();
                BindClient();
                $("#Client").val(aData.CLIENTID);
            }
            else
            { $("#ECID").val("0");$("#dvclient").hide(); }

            $("#Salutation").val(aData.NAME_PREFIX);
            $("#Name").val(aData.EMP_NAME);
            $("#dsgn").val(aData.DESIGNATION);
            $("#PMMobile").val(aData.MOBILE);
            $("#PMEmail").val(aData.EMAIL);

            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();

            $(".icon-arrow-up").click();
        }



        var urlToHandler = "/Handler/UserHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetUM"}';


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
                           
                         { "data": "EMP_NAME" },


                         { "data": "EMAIL" },
                         { "data": "MOBILE" },
                         { "data": "DESIGNATION" },
                           { "data": "SIGNINGAUTH" },

                             


                             { "data": "SPNAME" },
                             { "data": "RoleName" },
                              { "data": "CLIENT_NAME" },
                           {
                               "data": null,
                               "render": function (data, type, full, meta) {
                                   return '<a class="edit" href="javascript:;">Edit </a>';
                               }

                           },

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

            restoreRow()
            initTable2();


            console.log('me 2');
        }

    };

}();



$("#InserUsertdata").click(function () {
    var table = $('#UserTable');

    var rolename = $("input[type='radio'][name='complete']:checked").val();

    var status = $("input[type='radio'][name='Status']:checked").val();
    var auth = $("input[type='radio'][name='Sign']:checked").val();
    //alert(status);
    $(table).dataTable().fnDestroy();

    var fileUpload = $("#Photo").get(0);
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

            var urlToHandler = "/Handler/UserHandler.ashx";
            jsonData = '{ "Method": "InsertUM","id":"' + $("#EID").val() + '","prefix":"' + $("#Salutation").val() + '","name":"' + $("#Name").val() + '","photo":"' + result + '","pmmobile":"' + $("#PMMobile").val() + '","pmemail":"' + $("#PMEmail").val() + '","status":"' + status + '","dsgn":"' + $("#dsgn").val() + '","rolename":"' + rolename + '","auth":"' + auth + '"}';

            var datax = utility.ajax(urlToHandler, jsonData, false, false, false);
            if (datax != "error") {
                //datax = msg;
                if (rolename == "Client") {
                    var urlToHandler = "/Handler/ClientUserHandler.ashx";
                    jsonData = '{ "Method": "InsertCU","id":"' + $("#ECID").val() + '","uid":"' + datax.EMPID + '","clientid":"' + $("#Client").val() + '"}';

                    var datax = utility.ajax(urlToHandler, jsonData, false, false, false);
                }
                mmsg("success", "Successfully Saved.");
                UserViewModel.init();

               

                //editRow(oTable, oTable.row(0));
            }
            else { mmsg("error", "This email id is allready exist,Please try another."); }
           
        },
        error: function (err) {
            alert(err.statusText)
        }
    });
    evt.preventDefault();
});


$(document).on("change", "input[name=complete]:radio", function ()
{
    if ($(this).val() == "Client")
    {
        $("#dvclient").show();
        BindClient();
    }
    else
    { $("#dvclient").hide(); }


});

