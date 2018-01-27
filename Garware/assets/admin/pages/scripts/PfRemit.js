var PfRemitViewModel = function () {

    function restoreRow() {
        $("#PfID").val("0");
        $("#refno").val("");
        $("#StDate").val("");
        $("#add0").val("");
        $("#add1").val("");
        $("#add2").val("");
        $("#add3").val("");
        $("#add4").val("");
        $("#rchqno").val("");
        $("#rchqdate").val("");
        $("#rchqamount").val("");
        $("#rchqbank").val("");
        $("#radmnno").val("");
        $("#radmndate").val("");
        $("#radmnamount").val("");
        $("#radmnbank").val("");
        $("#authsign").val("");
        $("#authdsgn").val("");
    }

    var initTablecer = function () {
        var ReportHandler = "/Handler/ReportHandler.ashx";
        var table = $('#PfRemitTable');

        /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

        /* Set tabletools buttons and button container */
        function PrintContract(oTable, nRow) {

            var aData = oTable.fnGetData(nRow);
            //alert(aData.GRATUITY_REMITID);
            window.open(ReportHandler + "?Method=PF_Letter&id=" + aData.PF_REMIT_ID);
        }


        function editRow(oTable, nRow) {
            restoreRow();

            var aData = oTable.fnGetData(nRow);
            $("#PfID").val(aData.PF_REMIT_ID);
            $("#refno").val(aData.REF_NO);
            
            var dateFormat = aData.REF_DT;
            dateFormat = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat));
            $("#StDate").val(dateFormat);
            $("#add0").val(aData.ADDR0);
            $("#add1").val(aData.ADDR1);
            $("#add2").val(aData.ADDR2);
            $("#add3").val(aData.ADDR3);
            $("#add4").val(aData.ADDR4);
            
            $("#rchqno").val(aData.REMIT_CHQ_NO);
            var dateFormat1 = aData.REMIT_CHQ_DT;
            dateFormat1 = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat1));
            $("#rchqdate").val(dateFormat1);
            $("#rchqamount").val(aData.REMIT_AMT);
            $("#rchqbank").val(aData.REMIT_BANK);

            $("#radmnno").val(aData.ADMN_CHQ_NO);
            var dateFormat2 = aData.ADMN_CHQ_DT;
            dateFormat2 = $.datepicker.formatDate('dd/mm/yy', new Date(dateFormat2));
            $("#radmndate").val(dateFormat2);
            $("#radmnamount").val(aData.ADMN_AMT);
            $("#radmnbank").val(aData.ADMN_BANK);
            $("#authsign").val(aData.AUTH_SIGN);
            $("#authdsgn").val(aData.AUTH_DESIG);
           
            $(".tools a").removeClass("expand");
            $(".tools a").addClass("collapse");
            $(".portlet-body").show();
            $(window).scrollTop();
        }



        var urlToHandler = "Handler/PfRemitHandler.ashx";
        var jsonData;
        jsonData = '{ "Method": "Getdata"}';


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
                  { "data": "PF_REMIT_ID"},
                        { "data": "REF_NO" },
                        {
                            "data": "REF_DT",
                            "render": function (data, type, full, meta) {
                                return moment(data).format("MMM Do YY");
                            }
                        },
                        {
                            "data": "null",
                            "render": function (data, type, full, meta) {
                                return full.REMIT_CHQ_NO + " dt " + moment(full.REMIT_CHQ_DT).format("MMM Do YY") + " for Rs." + full.REMIT_AMT;
                            }
                        },
                        {
                            "data": "null",
                            "render": function (data, type, full, meta) {
                                return full.ADMN_CHQ_NO + " dt " + moment(full.ADMN_CHQ_DT).format("MMM Do YY") + " for Rs." + full.ADMN_AMT;
                            }
                        },
                        
                          {
                              "data": null,
                              "render": function (data, type, full, meta) {
                                  return '<a class="edit" href="javascript:;">Edit </a>';
                              }
                          },
                           {
                               "data": null,
                               "render": function (data, type, full, meta) {
                                   return '<a class="Rptprint" href="javascript:;">Print </a>';
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
        table.on('click', '.Rptprint', function (e) {
            e.preventDefault();

            /* Get the row as a parent of the link that was clicked on */
            var nRow = $(this).parents('tr')[0];

            /* No edit in progress - let's start one */
            PrintContract(oTable, nRow);
            nEditing = nRow;

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




$("#InsertdataCC").click(function (evt) {

    var table = $('#PfRemitTable');
    //fileupload();
    $(table).dataTable().fnDestroy();
    var urlToHandler = "Handler/PfRemitHandler.ashx";
    jsonData = '{ "Method": "InsertUpdate","PF_REMIT_ID":"' + $("#PfID").val() + '","REF_NO":"' + $("#refno").val() + '","REF_DT":"' + $("#StDate").val() + '","ADDR0":"' + $("#add0").val() + '","ADDR1":"' + $("#add1").val() + '","ADDR2":"' + $("#add2").val() + '","ADDR3":"' + $("#add3").val() + '","ADDR4":"' + $("#add4").val() + '","REMIT_CHQ_NO":"' + $("#rchqno").val() + '","REMIT_CHQ_DT":"' + $("#rchqdate").val() + '","REMIT_BANK":"' + $("#rchqbank").val() + '","REMIT_AMT":"' + $("#rchqamount").val() + '","ADMN_CHQ_NO":"' + $("#radmnno").val() + '","ADMN_CHQ_DT":"' + $("#radmndate").val() + '","ADMN_BANK":"' + $("#radmnbank").val() + '","ADMN_AMT":"' + $("#radmnamount").val() + '","AUTH_SIGN":"' + $("#authsign").val() + '","AUTH_DESIG":"' + $("#authdsgn").val() + '"}';

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
            PfRemitViewModel.init();
            //mmsg(datax.EXP.Type, datax.EXP.Msg);
            mmsg("success", "Successfully Saved");


        }
    });
}
)