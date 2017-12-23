
BindCountry();
var EmployeeBranchViewModel = function () {

    function restoreRow() {

        $("#EBID").val("0");
        $("#Bank").val("0");
        $("#Bank").trigger("change");
        $("#Branch").val("0");
        $("#BAccno").val("");
        $("input:radio[name='Pf']").each(function (i) {
            this.checked = false;
        });
       
    }

    var initTableBranch = function () {
        var table = $('#EmployeeBranchTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */

        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);


            $("input:radio[name='Pf']").parent('span').removeClass("checked");
            $("input:radio[name='Pf']").each(function (i) {
                this.checked = false;
                
            });


            $("#EBID").val(aData.EBID);
            $("#Bank").val(aData.BRANCH_DETAILS.BANK_MASTER.BANKID);
            $("#Bank").trigger("change");
            $("#Branch").val(aData.BRANCH_DETAILS.BRANCHID);
            $("#BAccno").val(aData.BANK_AC_NO_NRE);



            $("#Pf" + aData.NOT_PF).parent('span').addClass("checked");
            $("#Pf" + aData.NOT_PF).prop("checked", "checked");
            

            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();

            $(window).scrollTop();
        }

        var urlToHandler = "/Handler/EmployeeBranchHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetEBM","id":"' + $("#EID").val() + '"}';


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
                        { "data": "BRANCH_DETAILS.BANK_MASTER.BANK_NAME" },
                         {
                             "data": null,
                             "render": function (data, type, full, meta) {

                                 return full.BRANCH_DETAILS.ADDRESS1 + "," + full.BRANCH_DETAILS.ADDRESS2;
                             }
                         },
                        { "data": "BRANCH_DETAILS.COUNTRY_MASTER.C_Name" },
                        { "data": "BRANCH_DETAILS.STATE" },
                        { "data": "BRANCH_DETAILS.CITY" },
                         { "data": "BRANCH_DETAILS.PIN" },
                          { "data": "BRANCH_DETAILS.IFSCCODE" },
                           { "data": "BRANCH_DETAILS.SWIFTCODE" },
                            { "data": "BRANCH_DETAILS.MICRCODE" },
                        { "data": "BANK_AC_NO_NRE" },
                        { "data": "NOT_PF" },
                      


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

    var initTableBranch2 = function () {
        var table = $('#EmployeeBranchTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */

    
        var urlToHandler = "/Handler/EmployeeBranchHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetEBM","id":"' + $("#EID").val() + '"}';


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
                        { "data": "BRANCH_DETAILS.BANK_MASTER.BANK_NAME" },
                         {
                             "data": null,
                             "render": function (data, type, full, meta) {

                                 return full.BRANCH_DETAILS.ADDRESS1 + "," + full.BRANCH_DETAILS.ADDRESS2;
                             }
                         },
                        { "data": "BRANCH_DETAILS.COUNTRY_MASTER.C_Name" },
                        { "data": "BRANCH_DETAILS.STATE" },
                        { "data": "BRANCH_DETAILS.CITY" },
                         { "data": "BRANCH_DETAILS.PIN" },
                          { "data": "BRANCH_DETAILS.IFSCCODE" },
                           { "data": "BRANCH_DETAILS.SWIFTCODE" },
                            { "data": "BRANCH_DETAILS.MICRCODE" },
                        { "data": "BANK_AC_NO_NRE" },
                        { "data": "NOT_PF" }],

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
        



    }



    return {

        //main function to initiate the module
        init: function () {

            if (!jQuery().dataTable) {
                return;
            }

            console.log('me 1');

            restoreRow()
            var currentUrl = $(location).attr('pathname');
            
            if (currentUrl == "/EmpLstforClient.aspx") {
                
                initTableBranch2();
            }
            else
            { initTableBranch(); }
            


            console.log('me 2');
        }

    };

}();





$("#InsertdataBA").click(function () {
    var table = $('#EmployeeBranchTable');

    var pf = $("input[type='radio'][name='Pf']:checked").val();



    $(table).dataTable().fnDestroy();
    var urlToHandler = "/Handler/EmployeeBranchHandler.ashx";
    jsonData = '{ "Method": "InsertEBM","id":"' + $("#EBID").val() + '","eid":"' + $("#EID").val() + '","accno":"' + $("#BAccno").val() + '","branch":"' + $("#Branch").val() + '" ,"pf":"' + pf + '" }';

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
            EmployeeBranchViewModel.init();
            //$("#BAccno").val(datax.BANK_AC_NO_NRE);
            //$("#Branch").val(datax.BRANCHID);
            //if (datax.NOT_PF == "true") {
            //    $("#Pftrue").parents('span').addClass("checked");
            //    $("#Pftrue").prop("checked", "checked");
            //}
            //else {
            //    $("#Pffalse").parents('span').addClass("checked");
            //    $("#Pffalse").prop("checked", "checked");
            //}
            //$("#Bank").val(datax.BRANCH_DETAILS.BANK_MASTER.BANKID);
            $("#InsertdataKD").show();
            $('.nav-tabs li a[href="#kin"]').trigger('click');
        }
    });

}
)

