<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ShipMaster.aspx.cs" Inherits="Garware.ShipMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
    <!-- BEGIN PAGE LEVEL STYLES -->
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/select2/select2.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/ColReorder/css/dataTables.colReorder.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css" />
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
            <h5 class="page-title">Ship Master</h5>
        </div>
        <%--<div class="col-lg-9 col-md-9">
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
        </div>--%>
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
                            <a class="expand"></a>

                        </div>
                    </div>
                    <div class="portlet-body form" style="display: none;">
                        <!-- BEGIN FORM-->
                        <div class="form-horizontal">
                            <div class="form-body">
                                <input id="SMID" type="hidden" value="0" />
                                <div class="row">

                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Vessel Name</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="VesselName" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Port of Registry</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="Port" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clearfix"></div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Trade & area of operation</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="Trade" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clearfix"></div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Official No</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="OffNo" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">IMO No</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="IMO" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-3">G.T.</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="GT" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Power(kw/bhp)</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="Power" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-3">No of Crew</label><br />
                                            <span style="font-size: 12px; font-style: italic">Including master</span>

                                            <div class="col-md-6">
                                                <input type="text" class="form-control" id="Crew" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Type</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="ShipType">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="clearfix"></div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">NRT</label>
                                            <div class="col-md-9">
                                                <input type="text" class="form-control" placeholder="" id="NRT" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Country/Flag</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="Country">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>


                                    <div class="clearfix"></div>
                                    <!--/span-->
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Owner</label>
                                            <div class="col-md-9">
                                                <select class="form-control" id="Client">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-4">Image</label>
                                            <div class="col-md-6" style="padding-top: 8px;">
                                                <input type="file" name="Photo" id="photo" />
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label class="control-label col-md-3">Status</label>
                                            <div class="col-md-9">
                                                <input type="radio" name="Status" value="true" id="sttrue" class="rdubtn" /><label for="sttrue">Enable</label>
                                                <input type="radio" name="Status" value="false" id="stfalse" class="rdubtn" /><label for="stfalse">Disable</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                    <%--<div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-4">QUALI_OR_NONQUALI</label>
                                            <div class="col-md-6" style="padding-top: 8px;">
                                                  <input id="chkqua" type="checkbox" name="chkquaname"/>       
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>--%>

                                    <!--/span-->
                                </div>
                                <!--/row-->

                                <!--/row-->
                            </div>
                            <div class="form-actions">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="row">
                                            <div class="col-md-offset-3 col-md-9">
                                                <button type="submit" class="btn green" id="Insertdata">Submit</button>
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

                    </div>
                    <div class="portlet-body">
                        <div class="row">


                            <div class="col-md-6">
                                <div class="form-group ">
                                    <label class="control-label col-md-3">Client:</label>
                                    <div class="col-md-6">
                                        <select id="Client1" class="form-control">
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group ">
                                    <label class="control-label col-md-3">Ship Type:</label>
                                    <div class="col-md-6">
                                        <select id="ShipType1" class="form-control">
                                        </select>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <table class="table table-striped table-bordered table-hover" id="ShipTable">
                            <thead>
                                <tr>
                                    <th>Ship Name</th>
                                    <th>Client Name</th>
                                    <th>IMO No</th>
                                    <th>GT Power</th>
                                    <th>Number Of Crew</th>
                                    <th>Ship Type</th>
                                    <th>NRT</th>
                                    <th>Operation Area</th>
                                    <th>Official No</th>
                                    <th>Country</th>
                                    <th>Status</th>
                                    <th>Edit</th>
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
            <h5 class="page-title">Ship Master</h5>
        </div>
        <%--<div class="col-lg-9 col-md-9">
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
        </div>--%>
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
                        <div class="row">


                            <div class="col-md-6">
                                <div class="form-group ">
                                    <label class="control-label col-md-3">Client:</label>
                                    <div class="col-md-6">
                                        <select id="Client1" class="form-control">
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group ">
                                    <label class="control-label col-md-3">Ship Type:</label>
                                    <div class="col-md-6">
                                        <select id="ShipType1" class="form-control">
                                        </select>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <table class="table table-striped table-bordered table-hover" id="ShipTable">
                            <thead>
                                <tr>
                                    <th>Ship Name</th>
                                    <th>Client Name</th>
                                    <th>IMO No</th>
                                    <th>GT Power</th>
                                    <th>Number Of Crew</th>
                                    <th>Ship Type</th>
                                    <th>NRT</th>
                                    <th>Operation Area</th>
                                    <th>Official No</th>
                                    <th>Country</th>
                                    <th>Status</th>
                                    <th>Edit</th>
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
    <script src="assets/admin/pages/scripts/Common.js"></script>
    <script src="assets/admin/pages/scripts/ShipMaster.js"></script>
    <script>
        jQuery(document).ready(function () {
            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            ShipViewModel.init();
            BindCountry();
            BindShipType();
            BindClient();
        });
    </script>
</asp:Content>
