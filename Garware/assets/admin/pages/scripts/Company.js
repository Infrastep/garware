﻿var CompanyViewModel = function () {


    function restoreRow() {
        $("#companyName").val("");
       
        $("#phone").val("");


        $("#fax").val("");
        $("#email").val("");
        $("#tax").val("");


        $("#pan").val("");
        $("input:radio[name='Status']").each(function (i) {
            this.checked = false;
        });
        $("#sttrue").parents('span').removeClass("checked");
        $("#stfalse").parents('span').removeClass("checked");

    }

    var initTable2 = function () {
        var table = $('#CompanyTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */





        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            $("#companyId").val(aData.COMPANYID);
            $("#companyName").val(aData.COMPANY_NAME);
            
            $("#phone").val(aData.PHONE);


            $("#fax").val(aData.FAX_NO);
            $("#email").val(aData.EMAIL);
            $("#tax").val(aData.SERVICE_TAX_NO);


            $("#pan").val(aData.PAN_NO);
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
         
            $("#InsertdataCB").show();

        }



        var urlToHandler = "/Handler/CompanyHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetCompany"}';


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

                        { "data": "COMPANY_NAME" },
                        
                        { "data": "PHONE" },
                        { "data": "FAX_NO" },
                        { "data": "EMAIL" },

                        { "data": "SERVICE_TAX_NO" },
                        { "data": "PAN_NO" },
                        { "data": "STATUS" },
                        
                        {
                            "data": null,
                            "render": function (data, type, full, meta) {
                                return '<a class="edit" href="javascript:;">Edit </a>';
                            }
                        }
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

           

            restoreRow()
            initTable2();

            
           
        }

    };

}();










$("#insertcompanydata").click(function () {

    var table = $('#CompanyTable');
    $(table).dataTable().fnDestroy();
    var status = $("input[type='radio'][name='Status']:checked").val();
    var fileUpload = $("#companylogo").get(0);
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
        success: function (rslt) {
            var urlToHandler = "/Handler/CompanyHandler.ashx";
            jsonData = '{ "Method": "InsertCOMPANY","id":"' + $("#companyId").val() + '","companyname":"' + $("#companyName").val() + '","phone":"' + $("#phone").val() + '","faxno":"' + $("#fax").val() + '","email":"' + $("#email").val() + '","servicetaxno":"' + $("#tax").val() + '","panno":"' + $("#pan").val() + '","companylogo":"' + rslt + '","status":"' + status + '"}';

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

                    CompanyViewModel.init();
                    $("#companyId").val(datax.COMPANYID);
                    $("#companyName").val(datax.COMPANY_NAME);
                    $("#companyAddress").val(datax.ADDRESS);
                    $("#city").val(datax.CITY);

                    $("#state").val(datax.STATE);
                    $("#pin").val(datax.PIN);
                    $("#phone").val(datax.PHONE);
                    $("#fax").val(datax.FAX_NO);

                    $("#email").val(datax.EMAIL);
                    $("#tax").val(datax.SERVICE_TAX_NO);
                    $("#pan").val(datax.PAN_NO);
                   
                    $("#InsertdataCB").show();
                    $('.nav-tabs li a[href="#CompanyBranch"]').trigger('click');
                }
            });
        },
        error: function (err) {
            alert(err.statusText)
        }
    });

    evt.preventDefault();
});




