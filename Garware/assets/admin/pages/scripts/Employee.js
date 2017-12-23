var EmployeeViewModel = function () {

    function restoreRow() {
        $("#EID").val("0");
        $("#EBID").val("0");
        $("#Salutation").val("0");
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

    var initTable2 = function () {
        var table = $('#EmployeeTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */
        //EmployeeBranchViewModel.init();
        function editRow(oTable, nRow) {
            var aData = oTable.fnGetData(nRow);


            $('.nav-tabs li a[href="#general"]').trigger('click');
           
            
            //$("#MaritialStatus" + aData.MARITAL_STATUS).parents('span').addClass("checked");
            //$("#MaritialStatus" + aData.MARITAL_STATUS).prop("checked","checked");
            //$("#Status" + aData.STATUS).parents('span').addClass("checked");
            //$("#Status" + aData.STATUS).prop("checked", "checked");
            if (aData.STATUS == 9) {

                $("#stenable").attr('checked', 'checked');
                $("#stenable").parents('span').addClass("checked");


            }
            else if (aData.STATUS == 10) {
                $("#stendisable").attr('checked', 'checked');
                $("#stendisable").parents('span').addClass("checked");
            }
           


            $("#EID").val(aData.EMPID);
            if (aData.EBID != null) {
                $("#EBID").val(aData.EBID);

            } else {
                $("#EBID").val("0");

            }


            if (aData.KID != null) {
                $("#KID").val(aData.KID);

            } else {
                $("#KID").val("0");

            }

            $("#Salutation").val(aData.NAME_PREFIX);
            $("#Name").val(aData.EMP_NAME);
            $("#Code").val(aData.EMP_CODE);

            $("#Nationality").val(aData.NATIONALITY);
            $("#Religion").val(aData.RELIGION.RELIGIONID);
            $("#BirthPlace").val(aData.BIRTH_PLACE);
            if (aData.SR_CITIZEN == true)
                $("#SrCitizen").val("1");
            else
            { $("#SrCitizen").val("0"); }

            $("#DOB").val(aData.DOB);

            $("#PAddress1").val(aData.ADDR_PRESENT1);
            $("#PAddress2").val(aData.ADDR_PRESENT2);

            $("#PPhone").val(aData.TELEPHONE_PRESENT);
            $("#PMPhone").val(aData.TELEPHONE_PRMNT);
            $("#fathername").val(aData.FATHER_NAME);
            $("#PMAddress1").val(aData.ADDR_PRMNT1);
            $("#PMAddress2").val(aData.ADDR_PRMNT2);

            $("#PMFax").val(aData.FAX);
            $("#PMMobile").val(aData.MOBILE);
            $("#PMEmail").val(aData.EMAIL);

            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();


            $("#InsertdataBA").show();
            $("#InsertdataKD").show();
            $("#InsertdataEE").show();
            $("#InsertdataCC").show();
            $("#Insertdoc").show();
            $("#InsertdataDD").show();
            $(".icon-arrow-up").click();
        }


        $.extend(true, $.fn.DataTable.TableTools.classes, {
            "container": "btn-group tabletools-dropdown-on-portlet",
            "buttons": {
                "normal": "btn btn-sm default",
                "disabled": "btn btn-sm default disabled"
            },
            "collection": {
                "container": "DTTT_dropdown dropdown-menu tabletools-dropdown-menu"
            }
        });


        // begin: third table
        var oTable = table.dataTable({
            "dom": "<'row' <'col-md-12'T>><'row'<'col-md-6 col-sm-12'l><'col-md-6 col-sm-12'f>r><'table-scrollable't><'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12'p>>",
            "bFilter": true,
            "bSort": true,
            "bSortClasses": true,
            "bProcessing": true,
            "bServerSide": true,
            "bDestroy": true,
            "sAjaxSource": "/Handler/EmployeeGridHandler.ashx",

            "columns": [
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


                            { "data": "SELECTION_STATUS_MASTER.SPNAME" },
                          {
                              "data": null,
                              "render": function (data, type, full, meta) {
                                  return '<a class="edit" href="javascript:;">Edit </a>';
                              }

                          },
            {
                "data": null,
                "render": function (data, type, full, meta) {
                    
                    if ($("#hdnuid").val() == "SuperAdmin") {

                        if (full.ALEVELVERIFY == false )
                        { return '<span class="label label-sm label-info"><a class="aVerify anc-info" href="javascript:">Verify(A) </a><i class="fa fa-hand-o-up"></i>  </span>'; }

                        else if (full.BLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span><br><br><span class="label label-sm label-info"><a class="bVerify anc-info" href="javascript:">Verify(B)</a><i class="fa fa-hand-o-up"></i>  </span>'; }
                        else if (full.CLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br><br> <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span><br><br><span class="label label-sm label-info"><a class="cVerify anc-info" href="javascript:"> Verify(C) </a><i class="fa fa-hand-o-up"></i>  </span>'; }
                       

                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == true && full.CLEVELVERIFY == true)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br> <br> <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span>  <br>  <br><span class="label label-sm label-success">C Level <i class="fa fa-check"></i>  </span> '; }

                    }

                    else if ($("#hdnuid").val() == "A Level Verifier") {

                        if (full.ALEVELVERIFY == false)
                        { return '<span class="label label-sm label-info"><a class="aVerify anc-info" href="javascript:">Verify(A) </a><i class="fa fa-hand-o-up"></i>  </span> '; }

                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == false && full.CLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br><br> <span class="label label-sm label-warning">Waiting(B) <i class="fa fa-clock-o"></i>  </span><br><br> <span class="label label-sm label-warning">Waiting(C)<i class="fa fa-clock-o"></i>  </span> '; }
                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == true && full.CLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span><br><br> <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span> <br> <br><span class="label label-sm label-warning">Waiting(C) <i class="fa fa-clock-o"></i>  </span> '; }


                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == true && full.CLEVELVERIFY == true)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br><br>  <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span><br><br>  <span class="label label-sm label-success">C Level <i class="fa fa-check"></i>  </span>'; }

                    }
                    else if ($("#hdnuid").val() == "B Level Verifier") {


                        if (full.ALEVELVERIFY == false)
                        { return '<span class="label label-sm label-warning">Waiting for A Level </a><i class="fa fa-clock-o"></i>  </span> '; }

                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == false && full.CLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br><br> <span class="label label-sm label-info"><a class="bVerify anc-info" href="javascript:">Verify(B) </a><i class="fa fa-hand-o-up"></i>  </span><br><br> <span class="label label-sm label-warning">Waiting(C) <i class="fa fa-clock-o"></i>  </span> '; }
                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == true && full.CLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span><br><br> <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span> <br> <br><span class="label label-sm label-warning">Waiting(C)<i class="fa fa-clock-o"></i>  </span> '; }


                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == true && full.CLEVELVERIFY == true)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br><br>  <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span><br><br>  <span class="label label-sm label-success">C Level <i class="fa fa-check"></i>  </span>'; }

                    }
                    else if ($("#hdnuid").val() == "C Level Verifier") {
                        if (full.ALEVELVERIFY == false)
                        { return '<span class="label label-sm label-warning">Waiting(A) </a><i class="fa fa-clock-o"></i>  </span> '; }

                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == false && full.CLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br><br> <span class="label label-sm label-warning">Waiting(B) <i class="fa fa-clock-o"></i>  </span><br><br> <span class="label label-sm label-warning">Waiting(C) <i class="fa fa-clock-o"></i>  </span> '; }
                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == true && full.CLEVELVERIFY == false)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span><br><br> <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span> <br> <br> <span class="label label-sm label-info"><a class="cVerify anc-info" href="javascript:">Verify(C) </a><i class="fa fa-hand-o-up"></i>  </span>'; }


                        else if (full.ALEVELVERIFY == true && full.BLEVELVERIFY == true && full.CLEVELVERIFY == true)
                        { return '<span class="label label-sm label-success">A Level <i class="fa fa-check"></i>  </span> <br><br>  <span class="label label-sm label-success">B Level <i class="fa fa-check"></i>  </span><br><br>  <span class="label label-sm label-success">C Level <i class="fa fa-check"></i>  </span>'; }

                       

                    }
                    else { return ' '; }

                }

            },
             {
                 "data": null,
                 "render": function (data, type, full, meta) {
                     return '<a class="comment" href="javascript:">Comment </a>';
                 }

             },
            {
                "data": null,
                "render": function (data, type, full, meta) {
                    if (full.STATUS == 4 || full.STATUS == 5 || full.STATUS == 6 || full.STATUS == 17)
                    { return full.SELECTION_STATUS_MASTER.SPNAME; }

                    else

                    { return '<a class="edit1" href="EmployeeClientMaster.aspx?id=' + full.EMPID + '"> Assign Client </a>'; }
                }

            }
            ],


            "tableTools": {
                "sSwfPath": "../../assets/global/plugins/datatables/extensions/TableTools/swf/copy_csv_xls_pdf.swf",
                "aButtons": [{
                    "oSelectorOpts": { filter: 'applied', order: 'current' },
                    "sExtends": "pdf",
                    "sButtonText": "PDF"
                }, {
                    "oSelectorOpts": { filter: 'applied', order: 'current' },
                    "sExtends": "csv",
                    "sButtonText": "CSV"
                }, {
                    "oSelectorOpts": { filter: 'applied', order: 'current' },
                    "sExtends": "xls",
                    "sButtonText": "Excel"
                }, {
                    "oSelectorOpts": { filter: 'applied', order: 'current' },
                    "sExtends": "print",
                    "sButtonText": "Print",
                    "sInfo": 'Please press "CTR+P" to print or "ESC" to quit',
                    "sMessage": "Generated by DataTables"
                }]
            },
            //Internationalisation. For more info refer to http://datatables.net/manual/i18n
            "language": {
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                },
                "emptyTable": "No data available in table",
                "info": "Showing _START_ to _END_ of _TOTAL_ entries",
                "infoEmpty": "No entries found",
                "infoFiltered": "(filtered from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "search": "Search:",
                "zeroRecords": "No matching records found"
            },

            // Uncomment below line("dom" parameter) to fix the dropdown overflow issue in the datatable cells. The default datatable layout
            // setup uses scrollable div(table-scrollable) with overflow:auto to enable vertical scroll(see: assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.js). 
            // So when dropdowns used the scrollable div should be removed. 
            //"dom": "<'row'<'col-md-6 col-sm-12'l><'col-md-6 col-sm-12'f>r>t<'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12'p>>",

            //"bStateSave": true, // save datatable state(pagination, sort, etc) in cookie.

            "lengthMenu": [
                [5, 10, 15, -1],
                [5, 10, 15, "All"] // change per page values here
            ],
            // set the initial value
            "pageLength": 10,
            "language": {
                "lengthMenu": " _MENU_ records"
            },
            "columnDefs": [{  // set default column settings
                'orderable': true
            }],
            "order": [
                [2, "asc"]
            ] // set first column as a default sort by asc
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
        table.on('click', '.aVerify', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];


            var aData = oTable.fnGetData(nRow);

            var EmpID = aData.EMPID;
            var EmpName = aData.EMP_NAME;
            var EmpEmail = aData.EMAIL;
            var text = "A";
            $('#verifyPop').modal('show');
            $("#hdnEmpId").val(EmpID);
            $("#hdnEmpName").val(EmpName);
            $("#hdnEmpEmail").val(EmpEmail);
            $("#hdnText").val(text);


        });
        table.on('click', '.bVerify', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];
            var aData = oTable.fnGetData(nRow);
            var EmpID = aData.EMPID;
            var EmpName = aData.EMP_NAME;
            var EmpEmail = aData.EMAIL;
            var text = "B";
            $('#verifyPop').modal('show');
            $("#hdnEmpId").val(EmpID);
            $("#hdnEmpName").val(EmpName);
            $("#hdnEmpEmail").val(EmpEmail);
            $("#hdnText").val(text);



        });
        table.on('click', '.cVerify', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];
            var aData = oTable.fnGetData(nRow);
            var EmpID = aData.EMPID;
            var EmpName = aData.EMP_NAME;
            var EmpEmail = aData.EMAIL;
            var text = "C";
            $('#verifyPop').modal('show');
            $("#hdnEmpId").val(EmpID);
            $("#hdnEmpName").val(EmpName);
            $("#hdnEmpEmail").val(EmpEmail);
            $("#hdnText").val(text);



        });
        table.on('click', '.comment', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];
            var aData = oTable.fnGetData(nRow);
            var EmpID = aData.EMPID;
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

            restoreRow()
            initTable2();


            console.log('me 2');
        }

    };

}();


$("#Insertdata").click(function () {
    var table = $('#EmployeeTable');
    // var type = $("input[type='radio'][name='Type']:checked").val();
    //var mstatus = $("input[type='radio'][name='MaritialStatus']:checked").val();
    var status = $("input[type='radio'][name='Status']:checked").val();
   // alert(status);
    if (status == undefined)
    { status = "0";}

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

            var urlToHandler = "/Handler/EmployeeHandler.ashx";
            jsonData = '{ "Method": "InsertEM","id":"' + $("#EID").val() + '","prefix":"' + $("#Salutation").val() + '","name":"' + $("#Name").val() + '","code":"' + $("#Code").val() + '","nationality":"' + $("#Nationality").val() + '","religion":"' + $("#Religion").val() + '","bplace":"' + $("#BirthPlace").val() + '","citizen":"' + $("#SrCitizen").val() + '","dob":"' + $("#DOB").val() + '","photo":"' + result + '","paddress1":"' + $("#PAddress1").val() + '","paddress2":"' + $("#PAddress2").val() + '","pphone":"' + $("#PPhone").val() + '","pmaddress1":"' + $("#PMAddress1").val() + '","pmaddress2":"' + $("#PMAddress2").val() + '","pmfax":"' + $("#PMFax").val() + '","pmmobile":"' + $("#PMMobile").val() + '","pmemail":"' + $("#PMEmail").val() + '","status":"' + status + '","pmphone":"' + $("#PMPhone").val() + '","fathername":"' + $("#fathername").val() + '"}';

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


                    //EmployeeViewModel.init();

                    $("input:radio[name='Status']").each(function (i) {
                        this.checked = false;
                    });


                    $("#Status" + datax.STATUS).parents('span').addClass("checked");
                    $("#Status" + datax.STATUS).prop("checked", "checked");
                    $("#EID").val(datax.EMPID);
                    $("#Salutation").val(datax.NAME_PREFIX);
                    $("#Name").val(datax.EMP_NAME);
                    $("#Code").val(datax.EMP_CODE);

                    $("#Nationality").val(datax.NATIONALITY);
                    $("#Religion").val(datax.RELIGIONID.RELIGIONID);
                    $("#BirthPlace").val(datax.BIRTH_PLACE);
                    $("#SrCitizen").val(datax.SR_CITIZEN);

                    $("#DOB").val(datax.DOB);
                    $("#fathername").val(datax.FATHER_NAME);

                    $("#PAddress1").val(datax.ADDR_PRESENT1);
                    $("#PAddress2").val(datax.ADDR_PRESENT2);

                    $("#PPhone").val(datax.TELEPHONE_PRESENT);

                    $("#PMAddress1").val(datax.ADDR_PRMNT1);
                    $("#PMAddress2").val(datax.ADDR_PRMNT2);

                    $("#PMFax").val(datax.FAX);
                    $("#PMMobile").val(datax.MOBILE);

                    $("#InsertdataBA").show();
                    $('.nav-tabs li a[href="#BankAddress"]').trigger('click');

                    //alert("Successfully Saved.");

                    //editRow(oTable, oTable.row(0));
                }
            });
        },
        error: function (err) {
            alert(err.statusText)
        }
    });
    evt.preventDefault();
});

$(document).on('click', '#btnsave', function () {

    var EmpID = $("#hdnEmpId").val();
    var EmpName = $("#hdnEmpName").val();
    var EmpEmail = $("#hdnEmpEmail").val();
    var text = $("#hdnText").val();
    var comment = $("#remarks").val();
    var status;
    if ($("input[type='radio'].rdbtn").is(':checked')) {
        status = $("input[type='radio'].rdbtn:checked").val();

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
            $('#verifyPop').modal('hide');
            mmsg("success", "Successfully Verified.");
            //alert("Successfully Verified.");
            //EmployeeViewModel.init();
        }
    });

});

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
    var urlToHandler = "/Handler/CommentHandler.ashx";
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

$(document).on('click', '.reply', function () {
    var rcid = $(this).attr("id");
    $("#hdnCReciver").val(rcid);
    $("#txtmsg").focus();
    $("#dvchats").show();
});

function bindComment(EmpID) {
    $("#dvchats").hide();
    var uid = utility.getCookie("empid");
    var urlToHandler1 = "/Handler/EmployeeHandler.ashx";
    var urlToHandler2 = "/Handler/CommentHandler.ashx";
    var jsonData1 = '{ "Method": "GetCOM","id":"' + EmpID + '"}';
    var rslt = utility.ajax(urlToHandler2, jsonData1, false, false, false);
    if (rslt != null) {
        var htmls = "";
        var htmlss = "";
        var emplst = "";
        var emplsts = "";
        var flag;
        $(".chats").html("");
        $("#ulemp").html("");
        var jsonData2 = '{ "Method": "GetEmpListForComment","empID":"' + EmpID + '"}';
        var rslt1 = utility.ajax(urlToHandler1, jsonData2, false, false, false);
        $.each(rslt1, function (key, value) {
            if (rslt1[key].EMPID != uid) {
                emplst = "<li><a id='" + rslt1[key].EMPID + "' href='javascript:;' class='name reply'>" + rslt1[key].EMP_NAME + "</a></li>";
                $("#ulemp").append(emplst);
            }

        });
        $.each(rslt, function (key, value) {


            if (rslt[key].SENDERUSERID == uid) {
                htmls = "<li class='out'><img class='avatar' alt='' src='" + rslt[key].EMP_FIXED2.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt[key].EMP_FIXED2.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt[key].COMMENT1 + "</span></div></li>";
                $(".chats").append(htmls);

            } else {
                htmlss = "<li class='in'><img class='avatar' alt='' src='" + rslt[key].EMP_FIXED2.PHOTO + "' width='45' height='45'/><div class='message'><span class='arrow'></span><a href='javascript:;' class='name'>" + rslt[key].EMP_FIXED2.EMP_NAME + "</a><span class='datetime'>&nbsp;" + rslt[key].COMMENTDATE.split("T")[0] + "</span><span class='body'>" + rslt[key].COMMENT1 + "</span><a id='" + rslt[key].EMP_FIXED2.EMPID + "' href='javascript:;' class='reply'>Reply</a></div></li>";
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


