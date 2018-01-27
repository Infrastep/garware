<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Report_Duty_Details.aspx.cs" Inherits="Garware.Report_Duty_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
    <!-- BEGIN PAGE LEVEL STYLES -->
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/select2/select2.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/ColReorder/css/dataTables.colReorder.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css" />
    <!-- END PAGE LEVEL STYLES -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodycontent" runat="server">
    <div class="page-content">
        <div class="col-lg-12 col-md-12">
            <h5 class="page-title">Duty Data
            </h5>
        </div>
        <div class="row">
            <div class="col-md-8">

                <div class="portlet box red bg-inverse">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="fa fa-globe"></i>Generate Data
                        </div>
                        <div class="tools">
                            <a class="collapse"></a>

                        </div>
                    </div>
                    <div class="portlet-body form" style="display: block;">
                        <!-- BEGIN FORM-->
                        <div class="form-horizontal">
                            <div class="form-body">
                                <input id="AllrptID" type="hidden" value="0" />
                                <div class="row">

                                    <div class="clearfix"></div>

                                    <!--/span-->
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label class="control-label col-md-3">Employee Code</label>
                                            <div class="col-md-9">
                                                <select id="Emp" class="form-control"></select>

                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="clearfix"></div>

                                    <div class="col-md-6">


                                        <div class="form-group">
                                            <label class="control-label col-md-3">Ref No</label>
                                            <div class="col-md-9">
                                                 <select id="agreement" class="form-control updateagreedata">
                                                </select>

                                            </div>
                                        </div>


                                    </div>
                                    <div class="col-md-6">


                                        <div class="form-group">
                                            <label class="control-label col-md-3">Ref Date</label>
                                            <div class="col-md-9">
                                                <input class="form-control" id="RefDate" type="text" />

                                            </div>
                                        </div>


                                    </div>

                                    <!--/span-->
                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Duty Type</label>
                                            <div class="col-md-9">
                                                <select id="Dutytype" class="form-control">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Ship</label>
                                            <div class="col-md-9">
                                                <select id="Ship" class="form-control">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Port</label>
                                            <div class="col-md-9">
                                                <select id="Port" class="form-control">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Rank</label>
                                            <div class="col-md-9">
                                                <select id="Rank" class="form-control">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>


                                    <div class="col-md-12">


                                        <div class="form-group">
                                            <label class="control-label col-md-3">From Date</label>
                                            <div class="col-md-4">
                                                <input class="form-control" id="StDate" type="text" />

                                            </div>
                                        </div>


                                    </div>

                                    <div class="col-md-12">


                                        <div class="form-group">
                                            <label class="control-label col-md-3">To Date</label>
                                            <div class="col-md-4">
                                                <input class="form-control" id="EdDate" type="text" />

                                            </div>
                                        </div>


                                    </div>

                                      <div class="row">
                                        <div class="col-md-3">


                                            <div class="form-group">
                                                <label class="control-label col-md-12">Salary</label>
                                                <div class="col-md-12">
                                                    <input class="form-control" id="Salaryamount" type="text" />

                                                </div>
                                            </div>


                                        </div>
                                        <div class="col-md-3">


                                            <div class="form-group">
                                                <label class="control-label col-md-12">Witheld</label>
                                                <div class="col-md-12">
                                                    <input class="form-control" id="Witheldamount" type="text" />

                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-3">


                                            <div class="form-group">
                                                <label class="control-label col-md-12">Foreign</label>
                                                <div class="col-md-12">
                                                    <input class="form-control" id="Foramount" type="text" />

                                                </div>
                                            </div>


                                        </div>
                                       
                                    </div>



                                    <div class="row">
                                        <div class="col-md-3">


                                            <div class="form-group">
                                                <label class="control-label col-md-12">Basic</label>
                                                <div class="col-md-12">
                                                    <input class="form-control" id="Basicamount" type="text" />

                                                </div>
                                            </div>


                                        </div>
                                        <div class="col-md-3">


                                            <div class="form-group">
                                                <label class="control-label col-md-12">Leave</label>
                                                <div class="col-md-12">
                                                    <input class="form-control" id="Leaveamount" type="text" />

                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-3">


                                            <div class="form-group">
                                                <label class="control-label col-md-12">PF</label>
                                                <div class="col-md-12">
                                                    <input class="form-control" id="PFamount" type="text" />

                                                </div>
                                            </div>


                                        </div>
                                        <div class="col-md-3">


                                            <div class="form-group">
                                                <label class="control-label col-md-12">Gross</label>
                                                <div class="col-md-12">
                                                    <input class="form-control" id="Grossamount" type="text" />

                                                </div>
                                            </div>


                                        </div>
                                    </div>

                                    <!--/row-->
                                </div>
                            </div>
                            <div class="form-actions">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="row">
                                            <div class="col-md-offset-3 col-md-9">
                                                <button type="button" class="btn green" id="Insertdata">Ok</button>
                                                <button type="button" class="btn default">Cancel</button>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- END FORM-->
                    </div>
                </div>

            </div>


        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footercontent" runat="server">
    <!-- BEGIN PAGE LEVEL PLUGINS -->
    <script type="text/javascript" src="assets/global/plugins/select2/select2.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/media/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/extensions/TableTools/js/dataTables.tableTools.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/extensions/ColReorder/js/dataTables.colReorder.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/extensions/Scroller/js/dataTables.scroller.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.js"></script>
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN PAGE LEVEL SCRIPTS -->
    <script src="assets/global/scripts/metronic.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/layout.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/quick-sidebar.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/demo.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/common.js"></script>

    <script>
        jQuery(document).ready(function () {
            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            BindEmployee();
            BindCategory();
            BindCompany();
            BindRank();
            BindShip();
            
            BindAgreement();
            BindDutyType();
            handleDatePickers();
        });


        $("#agreement").change(function () {
            var agreement = $(this).val();


            var urlToHandler1 = "/Handler/AgreementDetailsHandler.ashx";
            jsonData1 = '{ "Method": "Getdataid","id":"' + agreement + '"}';

            var datax;
            $.ajax({
                url: urlToHandler1,
                data: jsonData1,
                dataType: 'json',
                type: 'POST',
                async: false,
                contentType: 'application/json',
                success: function (msg) {

                    datax = msg;

                    $("#Salaryamount").val(datax.BASIC);

                }
            });



        });


    </script>
</asp:Content>
