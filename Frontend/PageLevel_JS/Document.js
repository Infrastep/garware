var DocumentViewModel = function () {

    function restoreRow() {

      
        var str = "Pass";
        var str1 = "Cdc"; var str2 = "Pan"; var str3 = "Medi";

        $("#CID").val(0);
        $("#code").val("");
        $("#Description").val("");
        $("#Validity").val("");
        $("#issue").val("");
        $("#place").val("");
        $("#Certificate").val("");
        
        
        //$("#C" + str1 + "ID").val(0);
        //$("#code" + str1).val("");
        //$("#Description" + str1).val("");
        //$("#Validity" + str1).val("");
        //$("#issue" + str1).val("");
        //$("#place" + str1).val("");
        //$("#Certificate" + str1).val("");

        //$("#C" + str2 + "ID").val(0);
        //$("#code" + str2).val("");
        //$("#Description" + str2).val("");
        //$("#Validity" + str2).val("");
        //$("#issue" + str2).val("");
        //$("#place" + str2).val("");
        //$("#Certificate" + str2).val("");

        //$("#C" + str3 + "ID").val(0);
        //$("#code" + str3).val("");
        //$("#Description" + str3).val("");
        //$("#Validity" + str3).val("");
        //$("#issue" + str3).val("");
        //$("#place" + str3).val("");
        //$("#Certificate" + str3).val("");
    }

    var initTablecer = function () {
        var table = $('#DocumentTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */



        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);
            var str;
            if (aData.DOCUMENTS_TYPE.DTID == 1) {
                str = "Passport";
            }
            else if (aData.DOCUMENTS_TYPE.DTID == 2)
            { str = "Cdc"; }
            else if (aData.DOCUMENTS_TYPE.DTID == 3)
            { str = "Pan"; }
            else
            { str = "Medi"; }
            $("#nnme").html(aData.DOCUMENTS_TYPE.DTNAME);
            $("#dvdoc").show();
       
            $("#CID").val(aData.DMID);

            $("#code").val(aData.DMCODE);
            $("#Description").val(aData.DMDESCRIPTION);
            $("#CdocID").val(aData.DOCUMENTS_TYPE.DTID);
            $("#Validity").val(aData.VALIDITY.split("T")[0]);
            $("#issue").val(aData.ISSUE_DATE.split("T")[0]);
            $("#place").val(aData.ISSUE_PLACE);
            $("#Certificate").val(aData.PATH);


        }

        var urlToHandler = "/Handler/DocumentHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "GetDOC","id":"' + $("#EID").val() + '"}';

        var orders = utility.ajax(urlToHandler, jsonData, false, false, false);

        //$.ajax({
        //    url: urlToHandler,
        //    data: jsonData,
        //    dataType: 'json',
        //    type: 'POST',
        //    async: false,
        //    contentType: 'application/json',
        //    success: function (data) {
        //        orders = data;
        //    }
        //});






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
                          { "data": "DMDESCRIPTION" },
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

                          { "data": "COUNTRY_MASTER.C_Name" },
                          {
                              "data": null,
                              "render": function (data, type, full, meta) {
                                  return '<a class="edit1" target="_blank" href="UploadCertificate/' + full.PATH + '">' + full.PATH + ' </a>';
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

function restoreRowNew() {


    var str = "Pass";
    var str1 = "Cdc"; var str2 = "Pan"; var str3 = "Medi";

    $("#CID").val(0);
    $("#code").val("");
    $("#Description").val("");
    $("#Validity").val("");
    $("#issue").val("");
    $("#place").val("");
    $("#Certificate").val("");
}
$("#doctype").change(function () {
    var txt = $('option:selected', this).text();
    var value = $('option:selected', this).val();
    restoreRowNew();
    $("#nnme").html(txt);
    $("#dvdoc").show();
    $("#CdocID").val(value);
    //alert($('option:selected', this).text());
});
$(".docsub").click(function (evt) {

    //alert();
    $('#DocumentTable').dataTable().fnDestroy();
    var str = $(this).attr('name');

    var fileUpload = $("#Certificate").get(0);
    var files = fileUpload.files;

    var data = new FormData();
    for (var i = 0; i < files.length; i++) {
        data.append(files[i].name, files[i]);
    }
    if ($("#Description").val() == "") {
        alert("Please enter description");
        return false;

    }

    $.ajax({
        url: "/Handler/imguploader.ashx",
        type: "POST",
        data: data,
        contentType: false,
        processData: false,
        success: function (result) {

            var urlToHandler = "/Handler/DocumentHandler.ashx";
            jsonData = '{ "Method": "InsertDOC","id":"' + $("#CID").val() + '","eid":"' + $("#EID").val() + '","validity":"' + $("#Validity").val() + '","path":"' + result + '","doctype":"' + $("#CdocID").val() + '","issuedate":"' + $("#issue").val() + '","issueplace":"' + $("#place").val() + '","code":"' + $("#code").val() + '","desc":"' + $("#Description").val() + '"}';

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
                    $("#InsertdataDC").show();
                    mmsg("success", "Successfully Saved.");

                    //DocumentViewModel.init();

                    //alert("Successfully Saved.");


                }
            });




        },
        error: function (err) {
            alert(err.statusText)
        }
    });

    evt.preventDefault();
});


//$(".docsub").click(function (evt) {

//    //alert();
//    $('#DocumentTable').dataTable().fnDestroy();
//    var str = $(this).attr('name');

//    var fileUpload = $("#Certificate" + str).get(0);
//    var files = fileUpload.files;

//    var data = new FormData();
//    for (var i = 0; i < files.length; i++) {
//        data.append(files[i].name, files[i]);
//    }
//    if ($("#Description" + str).val() == "")
//    {
//        alert("Please enter description");
//        return false;

//    }

//    $.ajax({
//        url: "/Handler/imguploader.ashx",
//        type: "POST",
//        data: data,
//        contentType: false,
//        processData: false,
//        success: function (result) {

//            var urlToHandler = "/Handler/DocumentHandler.ashx";
//            jsonData = '{ "Method": "InsertDOC","id":"' + $("#C" + str + "ID").val() + '","eid":"' + $("#EID").val() + '","validity":"' + $("#Validity" + str).val() + '","path":"' + result + '","doctype":"' + $("#C" + str + "docID").val() + '","issuedate":"' + $("#issue" + str).val() + '","issueplace":"' + $("#place" + str).val() + '","code":"' + $("#code" + str).val() + '","desc":"' + $("#Description" + str).val() + '"}';

//            var datax;
//            $.ajax({
//                url: urlToHandler,
//                data: jsonData,
//                dataType: 'json',
//                type: 'POST',
//                async: false,
//                contentType: 'application/json',


//                success: function (msg) {

//                    datax = msg;
//                    $("#InsertdataDC").show();
//                    mmsg("success", "Successfully Saved.");
                    
//                    //DocumentViewModel.init();
                    
//                    //alert("Successfully Saved.");


//                }
//            });




//        },
//        error: function (err) {
//            alert(err.statusText)
//        }
//    });

//    evt.preventDefault();
//});



