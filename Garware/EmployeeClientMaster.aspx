<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeClientMaster.aspx.cs" Inherits="Garware.EmployeeClientMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
    <!-- BEGIN PAGE LEVEL STYLES -->
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/select2/select2.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/ColReorder/css/dataTables.colReorder.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="assets/admin/pages/css/jquery-ui.css" />
    <!-- END PAGE LEVEL STYLES -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodycontent" runat="server">

    <asp:LoginView ID="LoginView1" runat="server">
           <AnonymousTemplate>Please Login</AnonymousTemplate>
            <RoleGroups>
                 <asp:RoleGroup >
                    <ContentTemplate>
                     <div class="page-content">
                        <div class="col-lg-12 col-md-12">
                            <h5 class="page-title">Dont Have Permission to view
                            </h5>
                        </div>
                    </div>
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup >                    
                    <ContentTemplate>
                       <div class="page-content">
        <!-- BEGIN SAMPLE PORTLET CONFIGURATION MODAL FORM-->
        <div class="modal fade" id="portlet-config" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
                        <h4 class="modal-title">Modal title</h4>
                    </div>
                    <div class="modal-body">
                        Widget settings form goes here
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn blue">Save changes</button>
                        <button type="button" class="btn default" data-dismiss="modal">Close</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <!-- END SAMPLE PORTLET CONFIGURATION MODAL FORM-->

        <!-- BEGIN PAGE HEADER-->
        <div class="col-lg-3 col-md-3">
            <h5 class="page-title">Employee Client
            </h5>
        </div>
        <div class="col-lg-9 col-md-9">
            <div class="page-bar">
                <ul class="page-breadcrumb">
                    <li>
                        <i class="fa fa-home"></i>
                        <a href="index.html">Home</a>
                        <i class="fa fa-angle-right"></i>
                    </li>
                    <li>
                        <a href="#">Data Tables</a>
                        <i class="fa fa-angle-right"></i>
                    </li>
                    <li>
                        <a href="#">Advanced Datatables</a>
                    </li>
                </ul>

            </div>
        </div>
        <!-- END PAGE HEADER-->
        <!-- BEGIN PAGE CONTENT-->

        <div class="row">
            <div class="col-md-4">

                <div class="portlet box red bg-inverse">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="fa fa-globe"></i>Insert Update Data
                        </div>
                        <div class="tools">
                            <a href="javascript::void" class="collapse"></a>

                        </div>
                    </div>
                    <div class="portlet-body form" style="display: block;">
                        <!-- BEGIN FORM-->
                        <div class="form-horizontal">
                            <div class="form-body">
                                <input id="ECId" type="hidden" value="0" />
                                <div class="row">

                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Rank Class</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="RankClass">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <!--/span-->
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Company</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="Client">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Ship</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="Ship">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Start Date</label>

                                            <div class="col-md-9">
                                                <%--<input id="sdate" type="text" class="form-control datepicker" data-date-format="mm/dd/yyyy" />--%>
                                                <input type="text" class="form-control mySelectCalendar" id="sdate" placeholder="dd/mm/yyyy"
                                                    style="cursor: pointer" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">End Date</label>

                                            <div class="col-md-9">
                                                <%--<input id="edate" type="text" class="form-control datepicker" data-date-format="mm/dd/yyyy" />--%>
                                                <input type="text" class="form-control mySelectCalendar" id="edate" placeholder="dd/mm/yyyy"
                                                    style="cursor: pointer" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                <!--/row-->

                                <!--/row-->

                                <div id="dvbtn" class="form-actions" style="display:none">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="row">
                                                <div class="col-md-offset-3 col-md-9">
                                                    <button type="button" class="btn green" id="InsertEmpClientdata">Submit</button>
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
            <div class="col-md-8">

                <!-- BEGIN Ship Type TABLE PORTLET-->
                <div class="portlet box green-haze">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="fa fa-globe"></i>List
                        </div>

                    </div>

                    <div class="portlet-body">
                        <table class="table table-striped table-bordered table-hover" id="EmpClientTable">
                            <thead>
                                <tr>
                                    <th><input type="checkbox" id="chkall" onclick="chkalll(this)"/></th>
                                    <th>Code</th>
                                    <th>Name</th>
                                    <th>Nationality</th>
                                    <th>Religion</th>
                                    <th>DOB</th>
                                    <th>Status</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                    <%--<div class="portlet-body">
                        <table class="table table-striped table-bordered table-hover" id="EmpClientTable">
                            <thead>
                                <tr>


                                    <th>Ship Name
                                    </th>
                                    <th>Rank Class
                                    </th>
                                    <th>Start Date
                                    </th>
                                    <th>End Date
                                    </th>
                                    <th>Edit
                                    </th>


                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>--%>
                </div>
                <!-- END Ship Type TABLE PORTLET-->

            </div>
        </div>
        <!-- END PAGE CONTENT-->
    </div>
                    </ContentTemplate>                    
                </asp:RoleGroup>
                <asp:RoleGroup >
                    <ContentTemplate>
                      <div class="page-content">
        <!-- BEGIN SAMPLE PORTLET CONFIGURATION MODAL FORM-->
        <div class="modal fade" id="portlet-config" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
                        <h4 class="modal-title">Modal title</h4>
                    </div>
                    <div class="modal-body">
                        Widget settings form goes here
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn blue">Save changes</button>
                        <button type="button" class="btn default" data-dismiss="modal">Close</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->
        <!-- END SAMPLE PORTLET CONFIGURATION MODAL FORM-->

        <!-- BEGIN PAGE HEADER-->
        <div class="col-lg-3 col-md-3">
            <h5 class="page-title">Employee Client
            </h5>
        </div>
        <div class="col-lg-9 col-md-9">
            <div class="page-bar">
                <ul class="page-breadcrumb">
                    <li>
                        <i class="fa fa-home"></i>
                        <a href="index.html">Home</a>
                        <i class="fa fa-angle-right"></i>
                    </li>
                    <li>
                        <a href="#">Data Tables</a>
                        <i class="fa fa-angle-right"></i>
                    </li>
                    <li>
                        <a href="#">Advanced Datatables</a>
                    </li>
                </ul>

            </div>
        </div>
        <!-- END PAGE HEADER-->
        <!-- BEGIN PAGE CONTENT-->

        <div class="row">
            
            <div class="col-md-12">

                <!-- BEGIN Ship Type TABLE PORTLET-->
                <div class="portlet box green-haze">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="fa fa-globe"></i>List
                        </div>

                    </div>

                    <div class="portlet-body">
                        <table class="table table-striped table-bordered table-hover" id="EmpClientTable">
                            <thead>
                                <tr>
                                    <th><input type="checkbox" id="chkall" onclick="chkalll(this)"/></th>
                                    <th>Code</th>
                                    <th>Name</th>
                                    <th>Nationality</th>
                                    <th>Religion</th>
                                    <th>DOB</th>
                                    <th>Status</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                    <%--<div class="portlet-body">
                        <table class="table table-striped table-bordered table-hover" id="EmpClientTable">
                            <thead>
                                <tr>


                                    <th>Ship Name
                                    </th>
                                    <th>Rank Class
                                    </th>
                                    <th>Start Date
                                    </th>
                                    <th>End Date
                                    </th>
                                    <th>Edit
                                    </th>


                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>--%>
                </div>
                <!-- END Ship Type TABLE PORTLET-->

            </div>
        </div>
        <!-- END PAGE CONTENT-->
    </div>
                    </ContentTemplate>
                </asp:RoleGroup>
            </RoleGroups>
        </asp:LoginView>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footercontent" runat="server">
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
    <script src="assets/admin/pages/scripts/EmpClient.js"></script>
    <script src="assets/admin/pages/scripts/common.js"></script>
   
    <script>
        jQuery(document).ready(function () {
            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            EmployeeClientModel.init();
            BindRankClass();
            BindClient();
           
            var date = new Date();
            var currentMonth = date.getMonth();
            var currentDate = date.getDate();
            var currentYear = date.getFullYear();

            "use strict";
            jQuery("#sdate,#edate").datepicker({ dateFormat: 'mm-dd-yy', minDate: new Date(currentYear, currentMonth, currentDate), showOtherMonths: true, selectOtherMonths: true });


            //$('.datepicker').datepicker({
            //    startDate: '-3d'
            //})
        });
    </script>
</asp:Content>
