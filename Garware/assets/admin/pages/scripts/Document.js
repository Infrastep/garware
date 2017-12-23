﻿var DocumentViewModel = function () {

    function restoreRow() {
        $("#CID").val("0");      
        $("#code").val("");
        $("#doctype").val("");
        $("#MedDocType").val("0")
        $("#Validity").val("");
        $("#issuedate").val("");
        $("#issueplace").val("");
        $("#docfile").val("");
    }

    var initTablecer = function () {
        var table = $('#DocumentTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */



        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);

            $("#CID").val(aData.DMID);
          
            $("#code").val(aData.DMCODE);
            $("#doctype").val(aData.DOCUMENTS_TYPE.DTID);
            $("#MedDocType").val(aData.MED_TYPE)
            $("#Validity").val(aData.VALIDITY.split("T")[0]);
            $("#issuedate").val(aData.ISSUE_DATE.split("T")[0]);
            $("#issueplace").val(aData.ISSUE_PLACE);
            $("#docfile").val(aData.PATH);




        }



        var urlToHandler = "/Handler/DocumentHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetDOC","id":"' + $("#EID").val() + '"}';


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

                        { "data": "DMCODE" },
                        { "data": "DOCUMENTS_TYPE.DTNAME" },
                     
                        {
                            "data": null,
                            "render": function (data, type, full, meta) {
                                //var stat = data;
                                return full.VALIDITY.split("T")[0];
                            }
                        },
                        {
                            "data": null,
                            "render": function (data, type, full, meta) {
                                //var stat = data;
                                return full.ISSUE_DATE.split("T")[0];
                            }
                        },
                     
                          { "data": "ISSUE_PLACE" },
                           {
                               "data": null,
                               "render": function (data, type, full, meta) {
                                   return '<a class="edit1" target="_blank" href="http://scanmar.infronthrs.com/UploadCertificate/' + full.PATH + '">' + full.PATH + ' </a>';
                               }
                           },
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

    var initTablecer2 = function () {
        var table = $('#DocumentTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */



        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);

            $("#CID").val(aData.DMID);

            $("#code").val(aData.DMCODE);
            $("#doctype").val(aData.DOCUMENTS_TYPE.DTID);
            $("#MedDocType").val(aData.MED_TYPE)
            $("#Validity").val(aData.VALIDITY.split("T")[0]);
            $("#issuedate").val(aData.ISSUE_DATE.split("T")[0]);
            $("#issueplace").val(aData.ISSUE_PLACE);
            $("#docfile").val(aData.PATH);




        }



        var urlToHandler = "/Handler/DocumentHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetDOC","id":"' + $("#EID").val() + '"}';


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

                        { "data": "DMCODE" },
                        { "data": "DOCUMENTS_TYPE.DTNAME" },

                        {
                            "data": null,
                            "render": function (data, type, full, meta) {
                                //var stat = data;
                                return full.VALIDITY.split("T")[0];
                            }
                        },
                        {
                            "data": null,
                            "render": function (data, type, full, meta) {
                                //var stat = data;
                                return full.ISSUE_DATE.split("T")[0];
                            }
                        },

                          { "data": "ISSUE_PLACE" },
                           {
                               "data": null,
                               "render": function (data, type, full, meta) {
                                   return '<a class="edit1" target="_blank" href="http://scanmar.infronthrs.com/UploadCertificate/' + full.PATH + '">' + full.PATH + ' </a>';
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
     
    }



    return {

        //main function to initiate the module
        init: function () {

            if (!jQuery().dataTable) {
                return;
            }

            // console.log('me 1');

            restoreRow();
            var currentUrl = $(location).attr('pathname');
           
            if (currentUrl == "/EmpLstforClient.aspx") {
                
                initTablecer2();
            }
            else { initTablecer(); }
            


            // console.log('me 2');
        }

    };

}();




$("#Insertdoc").click(function (evt) {

    var table = $('#DocumentTable');
    //fileupload();
    $(table).dataTable().fnDestroy();

    var fileUpload = $("#docfile").get(0);
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

            var urlToHandler = "/Handler/DocumentHandler.ashx";
            jsonData = '{ "Method": "InsertDOC","id":"' + $("#CID").val() + '","eid":"' + $("#EID").val() + '","code":"' + $("#code").val() + '","validity":"' + $("#Validity").val() + '","path":"' + result + '","doctype":"' + $("#doctype").val() + '","medtype":"' + $("#MedDocType").val() + '","issuedate":"' + $("#issuedate").val() + '","issueplace":"' + $("#issueplace").val() + '"}';

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
                    DocumentViewModel.init();
                    mmsg("success", "Successfully Saved.");
                    $("#InsertdataCC").show();
                    $('.nav-tabs li a[href="#training"]').trigger('click');

                }
            });




        },
        error: function (err) {
            alert(err.statusText)
        }
    });

    evt.preventDefault();
});



$("#doctype").change(function () {
    var doc_ID = $(this).val();
    if(doc_ID==="4" )
    {
        $("#meddoc").show();
    }
    else
    { $("#meddoc").hide(); }

    });