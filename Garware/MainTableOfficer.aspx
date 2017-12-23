<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="MainTableOfficer.aspx.cs" Inherits="Garware.MainTableOfficer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
        <!-- BEGIN PAGE LEVEL STYLES -->
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/select2/select2.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/ColReorder/css/dataTables.colReorder.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/css/uploadify.css" />

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

        <div class="col-lg-12 col-md-12">
            <h5 class="page-title">MainTable
            </h5>
        </div>


        <!-- END PAGE HEADER-->
        <!-- BEGIN PAGE CONTENT-->

        <div class="row">
            <div class="col-md-12">

                <div class="portlet box red bg-inverse">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="fa fa-globe"></i>Insert Update Data
                        </div>
                        <div class="tools">
                            <a class="collapse"></a>

                        </div>
                    </div>

                    <div class="portlet-body form" style="display: none;">
                        <!-- BEGIN FORM-->
                        <div class="form-horizontal">
                            <div class="form-body">
                                 <div class="row">
                                <div class="col-md-6">
                                    <div class="row">
                                        <input id="MAINID" type="hidden" value="0" />

                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">Earn/Dedn Code</label>
                                                <div class="col-md-9">
                                                    <select class="form-control" id="EarnDedn">
                                                    </select>
                                                </div>
                                            </div>
                                        </div>

                                        <!--/span-->



                                    </div>
                                    <div class="row">

                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">Employee Class</label>
                                                <div class="col-md-9">
                                                    <select class="form-control" id="Class">
                                                    </select>
                                                </div>
                                            </div>
                                        </div>

                                        <!--/span-->



                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-6">PAYABLE FOR OFFICERS (Y/N)</label>
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <input type="checkbox" id="OnArticle"   />
                                            On Article

                                        </div>
                                        <div class="col-md-12">
                                            <input type="checkbox" id="OnHarbour" />
                                            On Harbour Duty

                                        </div>
                                        <div class="col-md-12">
                                            <input type="checkbox" id=" OnStaff" />
                                            On Staff

                                        </div>
                                        <div class="col-md-12">
                                            <input type="checkbox" id="OnLeave" />
                                            On Leave

                                        </div>
                                        <div class="col-md-12">
                                            <input type="checkbox" id="MedicalLeaveInIndia" />
                                            On Medical Leave In India

                                        </div>
                                        <div class="col-md-12">
                                            <input type="checkbox" id="MedicalLeaveInAbroad" />
                                           On Medical Leave In Abroad

                                        </div>
                                        


                                    </div>

                                </div>
                                     
                                 
                                <div class="col-md-6">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">Earn/Dedn Head</label>
                                                <div class="col-md-9">
                                                    <select class="form-control" id="EarnDednDesc">
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">

                                        <div class="col-md-12">


                                            <div class="form-group">
                                                <label class="control-label col-md-3">With Effect From</label>
                                                <div class="col-md-4">
                                                    <input class="form-control" id="StDate" type="text" />

                                                </div>
                                            </div>


                                        </div>

                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">

                                            <div class="form-group">
                                                <label class="control-label col-md-3">Effective Till Date</label>
                                                <div class="col-md-4">
                                                    <input class="form-control" id="EdDate" type="text" />

                                                </div>
                                            </div>

                                        </div>



                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">Input Type</label>
                                                <div class="col-md-9">
                                                    <select class="form-control" id="InputType">
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">Rate Type</label>
                                                <div class="col-md-9">
                                                    <select class="form-control" id="RateType">
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">RuleType</label>
                                                <div class="col-md-9">
                                                    <select class="form-control" id="RuleType">
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">

                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">Taxable</label>
                                                <div class="col-md-offset-3 col-md-9">
                                                    <input type="checkbox" checked="checked" class="make-switch" data-size="large" id="Taxable" />

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">

                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label class="control-label col-md-3">IT Forcast</label>
                                                <div class="col-md-offset-3 col-md-9">
                                                    <input type="checkbox" checked="checked" class="make-switch" data-size="large" id="ItForcast" />

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                     </div>
                           </div>

                            <div class="form-actions">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="row">
                                            <div class="col-md-offset-3 col-md-9">
                                                <button type="button" id="InsertdataCC" class="btn green">Submit</button>
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


            <div class="col-md-12">

                <!-- BEGIN Ship Type TABLE PORTLET-->
                <div class="portlet box green-haze">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="fa fa-globe"></i>List
                        </div>
                        <div class="tools">
                        </div>
                    </div>
                    <div class="portlet-body">
                        <table class="table table-striped table-bordered table-hover" id="MainTableOfficerTable">
                            <thead>
                                <tr>


                                   <th>EARN-DEDN CODE
                                    </th>
                                   
                                    <th>EFFECT FROM
                                    </th>
                                     <th>EFFECT TO
                                    </th>
                                    <th>EMP CLASS
                                    </th>
                                    <th>RATE TYPE
                                    </th>
                                    <th>RULE TYPE
                                    </th>
                                    <th>INPUT TYPE
                                    </th>
                                    <th>Edit
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
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

        <div class="col-lg-12 col-md-12">
            <h5 class="page-title">MainTable
            </h5>
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
                        <div class="tools">
                        </div>
                    </div>
                    <div class="portlet-body">
                        <table class="table table-striped table-bordered table-hover" id="MainTableOfficerTable">
                            <thead>
                                <tr>


                                   <th>EARN-DEDN CODE
                                    </th>
                                   
                                    <th>EFFECT FROM
                                    </th>
                                     <th>EFFECT TO
                                    </th>
                                    <th>EMP CLASS
                                    </th>
                                    <th>RATE TYPE
                                    </th>
                                    <th>RULE TYPE
                                    </th>
                                    <th>INPUT TYPE
                                    </th>
                                    <th>Edit
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
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
    <script type="text/javascript" src="assets/global/plugins/jquery-inputmask/jquery.inputmask.bundle.min.js"></script>
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN PAGE LEVEL SCRIPTS -->
    <script src="assets/global/scripts/metronic.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/layout.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/quick-sidebar.js" type="text/javascript"></script>
    <script type="text/javascript" src="assets/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js"></script>
    <script src="assets/admin/layout/scripts/demo.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/components-pickers.js"></script>
    <script src="assets/admin/pages/scripts/common.js"></script>
    <script src="assets/admin/pages/scripts/MainTableOfficer.js"></script>

    <script>
        jQuery(document).ready(function () {

            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            ComponentsPickers.init();
            BindEarnDedn();
            BindClass();
            handleDatePickers();
            BindInputType();
            BindRateType();

            MainTableOfficerViewModel.init();
        });
    </script>
</asp:Content>
