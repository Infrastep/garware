var EmployeeForClientViewModel = function () {

    function restoreRow() {
        $("#EID").val("0");
        $("#EBID").val("0");
        $("#NamePrefix").val("");
        $("#Name").val("");
        $("#Code").val("");

        $("#Nationality").val("");
        $("#Religion").val("");
        $("#BirthPlace").val("");
        $("#SrCitizen").val("");

        $("#DOB").val("");
        $("#PMPhone").val("");
        $("#fathername").val("");
        $("#PAddress1").val("");
        $("#PAddress2").val("");

        $("#PPhone").val("");

        $("#PMAddress1").val("");
        $("#PMAddress2").val("");


        $("#PMFax").val("");
        $("#PMMobile").val("");
        $("#PMEmail").val("");

        $("input:radio[name='Status']").each(function (i) {
            this.checked = false;
        });
    }

    var initTableEmployeeClient = function () {
        var table = $('#EmployeeTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */
        //EmployeeBranchViewModel.init();
        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);



            $("#EID").val(aData.EMPID);

            $("#name").val(aData.NAME_PREFIX + " " + aData.EMP_NAME);

            $("#email").val(aData.EMP_NAME);
            $("#fathername").val(aData.FATHER_NAME);

            $("#Nationality").val(aData.NATIONALITY);
            $("#Religion").val("");
            $("#BirthPlace").val(aData.BIRTH_PLACE);
            $("#SrCitizen").val(aData.SR_CITIZEN);

            $("#DOB").val(aData.DOB);

            //$("#PAddress1").val(aData.ADDR_PRESENT1);
            //$("#PAddress2").val(aData.ADDR_PRESENT2);

            //$("#PPhone").val(aData.TELEPHONE_PRESENT);
            //$("#PMPhone").val(aData.TELEPHONE_PRMNT);

            //$("#PMAddress1").val(aData.ADDR_PRMNT1);
            //$("#PMAddress2").val(aData.ADDR_PRMNT2);

            //$("#PMFax").val(aData.FAX);
            //$("#PMMobile").val(aData.MOBILE);
            //$("#email").val(aData.EMAIL);

            //$(".tools a").removeClass("expand");
            //$(".tools a").addClass("collapse");
            //$(".portlet-body").show();


            //$("#InsertdataBA").show();
            //$("#InsertdataKD").show();
            //$("#InsertdataEE").show();
            //$("#InsertdataCC").show();
            //$("#Insertdoc").show();
            //$("#InsertdataDD").show();
            //$(".icon-arrow-up").click();
        }


        var empId = utility.getCookie("empid");
        var urlToHandler = "/Handler/EmployeeClientHandler.ashx";
        var urlToHandler1 = "/Handler/ClientUserHandler.ashx";
        var jsonData1 = '{ "Method": "GetCL","uid":"' + empId + '"}';

        var rrst = utility.ajax(urlToHandler1, jsonData1, false, false, false);
        var jsonData;
        jsonData = '{ "Method": "GetECbyClientID","CID":"' + rrst.CLIENTID + '"}';


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
                        { "data": "EMP_FIXED.SELECTION_STATUS_MASTER.SPNAME" },

                        { "data": "SHIP_MASTER.VNAME" },
                          { "data": "RANK_CLASS.RANK_MASTER.RANK_DESC" },

                            {
                                "data": "RANK_CLASS.CLASS.CLASS_NAME"
                            },
                             {
                                 "data": "SHIP_MASTER.CLIENT_MASTER.CLIENT_NAME."
                             },
 {
     "data": null,
     "render": function (data, type, full, meta) {
         return '<a class="comment" href="javascript">Comment</a>';
     }

 },



            {
                "data": null,
                "render": function (data, type, full, meta) {
                    return '<a  class="edit1 ancdetails" href="javascript">View Details </a>';
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
        $.fn.dataTable.ext.search.push(
              function (settings, data, dataIndex) {
                  var val1 = $('#Status').val();
                  var clnt = data[2];// use data for the age column

                  if (val1 == clnt) {
                      return true;
                  }
                  if (val1 == 0) {

                      return true;
                  }
                  return false;
              });
        var tableWrapper = $('#sample_2_wrapper'); // datatable creates the table wrapper by adding with id {your_table_jd}_wrapper
        tableWrapper.find('.dataTables_length select').select2(); // initialize select2 dropdown

        var nEditing = null;
        var nNew = false;

        table.on('click', '.ancdetails', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];


            var aData = oTable.fnGetData(nRow);


            $("#EID").val(aData.EMP_FIXED.EMPID);

            $("#name").html(aData.EMP_FIXED.NAME_PREFIX + " " + aData.EMP_FIXED.EMP_NAME);

            $("#email").html(aData.EMP_FIXED.EMAIL);
            $("#fathername").html(aData.EMP_FIXED.FATHER_NAME);

            $("#Nationality").html(aData.EMP_FIXED.NATIONALITY);
            $("#Religion").html(aData.EMP_FIXED.RELIGION.RELIGION_NAME);
            $("#BirthPlace").html(aData.EMP_FIXED.BIRTH_PLACE);
            $("#SrCitizen").html(aData.EMP_FIXED.SR_CITIZEN);

            $("#DOB").html(aData.EMP_FIXED.DOB.split("T")[0]);
            //editRow(oTable, nRow);

            $('#EmployeeBranchTable').dataTable().fnDestroy();
            EmployeeBranchViewModel.init();
            $('#DocumentTable').dataTable().fnDestroy();
            DocumentViewModel.init();
            $('#CertificateTable').dataTable().fnDestroy();
            CertificateViewModel.init();
            $('#KinTable').dataTable().fnDestroy();
            KinDetailsViewModel.init();
            $('#EmpExperienceTable').dataTable().fnDestroy();
            EmpExperienceViewModel.init();


            $("#EmpName").val(aData.EMP_FIXED.EMP_NAME);
            $("#EmpEmail").val(aData.EMP_FIXED.EMAIL);

            $('#EmpPop').modal('show');


        });

        table.on('click', '.comment', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];
            var aData = oTable.fnGetData(nRow);
            var EmpID = aData.EMP_FIXED.EMPID;
            bindComment(EmpID);

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
            initTableEmployeeClient();


            console.log('me 2');
        }

    };

}();
$(document).on('click', '#anccom', function () {

    var EmpID = $("#hdnCEmpId").val();
    var sender = $("#hdnCSender").val();
    var receiver = $("#hdnCReciver").val();
    var comment = $("#txtmsg").val();
    var status;
    var pri;
    var pub;
    if ($("input[type='radio'].rdbtn1").is(':checked')) {
        status = $("input[type='radio'].rdbtn1:checked").val();
        if (status == "Private") {
            pri = true;
            pub = false;
        }
        else {
            pub = true;
            pri = false;
        }

    }
    var urlToHandler = "/Handler/ClientCommentHandler.ashx";
    jsonData = '{ "Method": "InsertCOM","comid":"0","empID":"' + EmpID + '","sender":"' + sender + '","receiver":"' + receiver + '","comment":"' + comment + '","pub":"' + pub + '","pri":"' + pri + '"}';
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
            $("#txtmsg").val("");
            //$('#verifyPop').modal('hide');
            bindComment(EmpID);
            mmsg("success", "Successfully Send.");
            //alert("Successfully Verified.");
            //EmployeeViewModel.init();
        }
    });

});

$(document).on('click', '#btnverified', function () {

    var EmpID = $("#EID").val();
    var EmpName = $("#EmpName").val();
    var EmpEmail = $("#EmpEmail").val();
    var text;
    var comment = $("#remarks").val();
    var status;
    if ($("input[type='radio'].rdbtn").is(':checked')) {
        status = $("input[type='radio'].rdbtn:checked").val();
        if (status = "4")
        { text = "CA"; }
        else if (status = "5") { text = "CNA"; }
        else if (status = "6") { text = "CB"; }
    }
    var urlToHandler = "/Handler/EmployeeHandler.ashx";
    jsonData = '{ "Method": "VERIFYEM","empID":"' + EmpID + '","text":"' + text + '","comment":"' + comment + '","status":"' + status + '","empname":"' + EmpName + '","email":"' + EmpEmail + '"}';
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
            $('#EmpPop').modal('hide');
            mmsg("success", "Successfully Verified.");
            //alert("Successfully Verified.");
            //EmployeeViewModel.init();
        }
    });

});

$("#Status").change(function () {
    var table = $('#EmployeeTable').DataTable();
    table.draw();;
});
function bindComment(EmpID) {
    var uid = utility.getCookie("empid");
    var urlToHandler1 = "/Handler/ClientCommentHandler.ashx";
    var jsonData1 = '{ "Method": "GetCOM","id":"' + EmpID + '"}';
    var rslt = utility.ajax(urlToHandler1, jsonData1, false, false, false);
    if (rslt != null) {
        var htmls = "";
        var htmlss = "";
        $(".chats").html("");
        $.each(rslt, function (key, value) {


            if (rslt[key].SENDERUSERID == uid) {
                htmls = "<li class='out'><img class='avatar' alt='' src='" + rslt[key].EMP_FIXED1.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt[key].EMP_FIXED1.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt[key].COMMENT + "</span></div></li>";
                $(".chats").append(htmls);

            } else {
                htmlss = "<li class='in'><img class='avatar' alt='' src='" + rslt[key].EMP_FIXED1.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt[key].EMP_FIXED1.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt[key].COMMENT + "</span><a id='" + rslt[key].EMP_FIXED1.EMPID + "' href='javascript:;' class='reply'>Reply</a></div></li>";
                $(".chats").append(htmlss);

            }


        });

    }
    var text = "A";
    $('#CommentPop').modal('show');
    $("#hdnCEmpId").val(EmpID);
    $("#hdnCReciver").val(EmpID);
    $("#hdnCSender").val(uid);
}