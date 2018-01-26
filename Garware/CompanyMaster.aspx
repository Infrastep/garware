<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="CompanyMaster.aspx.cs" Inherits="Garware.CompanyMaster" %>

<%@ Register Src="~/controls/Company_Branch.ascx" TagPrefix="uc1" TagName="Branch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
    <!-- BEGIN PAGE LEVEL STYLES -->
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/select2/select2.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/ColReorder/css/dataTables.colReorder.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css" />
    <link href="assets/global/plugins/bootstrap-modal/css/bootstrap-modal-bs3patch.css" rel="stylesheet" type="text/css" />
    <link href="assets/global/plugins/bootstrap-modal/css/bootstrap-modal.css" rel="stylesheet" type="text/css" />
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
        <h3 class="page-title">Company Master 
        </h3>
        <%--<div class="page-bar">
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

        </div>--%>
        <!-- END PAGE HEADER-->
        <!-- BEGIN PAGE CONTENT-->
        <input id="companyId" type="hidden" value="0" />
        <div class="row">
            <div class="col-md-12">

                <div class="portlet box red bg-inverse">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="fa fa-globe"></i>Insert Update Data
                        </div>
                        <div class="tools">
                            <a class="expand btn btn-block blue wdth"></a>

                        </div>
                    </div>
                    <div class="portlet-body form" style="display: none;">
                        <!-- BEGIN FORM-->
                        <div class="form-horizontal">
                            <div class="form-body">
                                <div class="tabbable tabbable-tabdrop">
                                    <ul class="nav nav-tabs">

                                        <li class="active">
                                            <a href="#general" data-toggle="tab" aria-expanded="true">General</a>
                                        </li>
                                        <li class="">
                                            <a href="#CompanyBranch" data-toggle="tab" aria-expanded="false">Bank Details</a>
                                        </li>

                                    </ul>
                                    <div class="tab-content">
                                        <div class="tab-pane active" id="general">
                                            <div class="form-horizontal">
                                                <div class="form-body">
                                                    <div class="row">
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Company Name</label>
                                                                <div class="col-md-9">
                                                                    <input type="text" class="form-control" placeholder="" id="companyName" />
                                                                    <span class="help-block"></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <!--/span-->
                                                        <div class="col-md-12">
                                                            <div class="form-group ">
                                                                <label class="control-label col-md-3">Phone</label>
                                                                <div class="col-md-9">
                                                                    <input type="text" class="form-control" placeholder="" id="phone" />
                                                                    <span class="help-block"></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <!--/span-->
                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">Fax</label>
                                                                <div class="col-md-9">
                                                                    <input type="text" class="form-control" placeholder="" id="fax" />
                                                                    <span class="help-block"></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <!--/span-->
                                                        <div class="col-md-12">
                                                            <div class="form-group ">
                                                                <label class="control-label col-md-3">Email</label>
                                                                <div class="col-md-9">
                                                                    <input type="text" class="form-control" placeholder="" id="email" />
                                                                    <span class="help-block"></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <h3 class="form-section">Tax Details</h3>
                                                    <div class="row">

                                                        <!--/span-->
                                                        <div class="col-md-6">
                                                            <div class="form-group ">
                                                                <label class="control-label col-md-3">Tax</label>
                                                                <div class="col-md-6">
                                                                    <input type="text" class="form-control" placeholder="" id="tax" />
                                                                    <span class="help-block"></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <!--/span-->
                                                        <div class="col-md-9">
                                                            <div class="form-group ">
                                                                <label class="control-label col-md-2">Pan</label>

                                                                <div class="col-md-10">
                                                                    <input type="text" class="form-control" placeholder="" id="pan" />

                                                                    <span class="help-block"></span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="clearfix"></div>
                                                        <!--/span-->

                                                        <!--/span-->
                                                    </div>
                                                    <h3 class="form-section">Logo</h3>
                                                    <div class="row">

                                                        <div class="col-md-12">
                                                            <div class="form-group">
                                                                <label class="control-label col-md-3">File</label>
                                                                <div class="col-md-9">
                                                                    <input type="file" name="companylogo" id="companylogo" />

                                                                    <%--<span class="help-block">
																This field has error. </span>--%>
                                                                </div>
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
                                                </div>

                                                <div class="form-actions">
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="row">
                                                                <div class="col-md-offset-3 col-md-9">
                                                                    <button type="submit" class="btn green" id="insertcompanydata">Submit</button>
                                                                    <button type="button" class="btn default">Cancel</button>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6">
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="tab-pane" id="CompanyBranch">
                                            <uc1:Branch runat="server" ID="com_branch" />
                                        </div>
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
                        <table class="table table-striped table-bordered table-hover" id="CompanyTable">
                            <thead>
                                <tr>
                                    <th>Name
                                    </th>

                                    <th>Phone
                                    </th>
                                    <th>Fax
                                    </th>
                                    <th>Email
                                    </th>
                                    <th>Tax No
                                    </th>
                                    <th>Pan No
                                    </th>
                                    <th>Status
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
        <h3 class="page-title">Company Master 
        </h3>
        <%--<div class="page-bar">
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

        </div>--%>
        <!-- END PAGE HEADER-->
        <!-- BEGIN PAGE CONTENT-->
        <input id="companyId" type="hidden" value="0" />
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
                        <table class="table table-striped table-bordered table-hover" id="CompanyTable">
                            <thead>
                                <tr>
                                    <th>Name
                                    </th>

                                    <th>Phone
                                    </th>
                                    <th>Fax
                                    </th>
                                    <th>Email
                                    </th>
                                    <th>Tax No
                                    </th>
                                    <th>Pan No
                                    </th>
                                    <th>Status
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
    <script src="assets/admin/pages/scripts/components-pickers.js"></script>
    <script src="assets/global/plugins/bootstrap-modal/js/bootstrap-modalmanager.js" type="text/javascript"></script>
    <script src="assets/global/plugins/bootstrap-modal/js/bootstrap-modal.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/ui-extended-modals.js"></script>
    <script type="text/javascript" src="assets/admin/pages/scripts/jquery.uploadify.js"></script>
    <script src="assets/admin/pages/scripts/common.js"></script>
    <script src="assets/admin/pages/scripts/ComBranch.js"></script>
    <script src="assets/admin/pages/scripts/Company.js"></script>
    <script src="assets/admin/pages/scripts/BankMaster.js"></script>
    <script src="assets/admin/pages/scripts/BranchMaster.js"></script>
    <script>
        jQuery(document).ready(function () {
            CheckUserLogin();
            BindBank();
            BindBankBranch();
            BindCountry();
            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features

            CompanyViewModel.init();
            $('.nav-tabs li a[href="#CompanyBranch"]').click(function () {
                $('#CompanyBranchTable').dataTable().fnDestroy();
                CompanyBranchViewModel.init();

            });
        });
    </script>
</asp:Content>
