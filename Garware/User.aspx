<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Garware.User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">

    <!-- BEGIN PAGE LEVEL STYLES -->
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/select2/select2.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/ColReorder/css/dataTables.colReorder.min.css" />
    <link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css" />
    <link href="assets/global/plugins/bootstrap-modal/css/bootstrap-modal-bs3patch.css" rel="stylesheet" type="text/css" />
    <link href="assets/global/plugins/bootstrap-modal/css/bootstrap-modal.css" rel="stylesheet" type="text/css" />
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
        <!-- BEGIN PAGE HEADER-->
        <div class="col-lg-12 col-md-12">
            <h5 class="page-title">User</h5>
        </div>

        <!-- END PAGE HEADER-->
        <div class="row">
            <div class="col-md-12">
                <div class="portlet  box red bg-inverse">
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
                                <input id="EID" type="hidden" value="0" />
                                <input id="ECID" type="hidden" value="0" />
                                <div class="tabbable tabbable-tabdrop">
                                    <ul class="nav nav-tabs">

                                        <li class="active">
                                            <a href="#general" data-toggle="tab" aria-expanded="true">General</a>
                                        </li>



                                    </ul>
                                    <div class="tab-content">
                                        <div class="tab-pane active" id="general">
                                            <div class="form-horizontal">
                                                <div class="form-body">

                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="row">
                                                                <h3 class="form-section">General Info</h3>
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Prefix</label>
                                                                        <div class="col-md-9">
                                                                            <select class="form-control" id="Salutation">
                                                                               
                                                                            </select>
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">

                                                                <div class="col-md-12">
                                                                    <div class="form-group ">
                                                                        <label class="control-label col-md-3">Name</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="Name" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                            </div>


                                                            <div class="row">

                                                                <div class="col-md-12">
                                                                    <div class="form-group ">
                                                                        <label class="control-label col-md-3">Designation</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="dsgn" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                            </div>




                                                            <div class="row">
                                                                <h3 class="form-section">Photo</h3>
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Photo</label>
                                                                        <input type="file" name="Photo" id="Photo" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>


                                                        <div class="col-md-6">

                                                          

                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Mobile</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PMMobile" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Email Address</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PMEmail" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Signing Auth</label>
                                                                        <div class="col-md-9">
                                                                            <input type="radio" name="Sign" value="true" id="sttrue" class="rdubtn"  /><label  for="sttrue">True</label>
                                                                            <input type="radio" name="Sign" value="false" id="stfalse" class="rdubtn" /><label  for="stfalse">False</label>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            
                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Status</label>
                                                                        <div class="col-md-9">
                                                                            <input type="radio" name="Status" value="9" id="stenable" class="rdubtn"  /><label  for="stenable">Enable</label>
                                                                            <input type="radio" name="Status" value="10" id="stendisable" class="rdubtn" /><label  for="stendisable">Disable</label>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            
                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Role for User</label>
                                                                        <div id="dvrole" class="col-md-offset-3 col-md-9">
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div id="dvclient" class="row" style="display: none">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Select Company</label>
                                                                        <div class="col-md-9">
                                                                            <select id="Client" class="form-control"></select>
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
                                                                        <button type="button" class="btn green" id="InserUsertdata">Save And Continue</button>
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
                            <!-- END FORM-->
                        </div>
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
                        <table class="table table-striped table-bordered table-hover" id="UserTable">
                            <thead>
                                <tr>
                                    
                                    <th>Name</th>

                                    <th>Email</th>
                                    <th>Mobile</th>
                                    <th>Designation</th>
                                    <th>Signing Auth</th>
                                    <th>Status</th>
                                    <th>RoleName</th>
                                    <th>Company Name</th>
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
    </div>
                    </ContentTemplate>                    
                </asp:RoleGroup>
                <asp:RoleGroup >
                    <ContentTemplate>
                        <div class="page-content">
        <!-- BEGIN PAGE HEADER-->
        <div class="col-lg-12 col-md-12">
            <h5 class="page-title">User</h5>
        </div>

        <!-- END PAGE HEADER-->
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
                        <table class="table table-striped table-bordered table-hover" id="UserTable">
                            <thead>
                                <tr>
                                    
                                    <th>Name</th>

                                    <th>Email</th>
                                    <th>Mobile</th>
                                    <th>Designation</th>
                                    <th>Signing Auth</th>
                                    <th>Status</th>
                                    <th>RoleName</th>
                                    <th>Company Name</th>
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
    <script type="text/javascript" src="assets/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js"></script>
    <script src="assets/admin/layout/scripts/demo.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/components-pickers.js"></script>
    <script src="assets/global/plugins/bootstrap-modal/js/bootstrap-modalmanager.js" type="text/javascript"></script>
    <script src="assets/global/plugins/bootstrap-modal/js/bootstrap-modal.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/ui-extended-modals.js"></script>

    <script type="text/javascript" src="assets/admin/pages/scripts/jquery.uploadify.js"></script>
    <script src="assets/admin/pages/scripts/user.js"></script>


    <script>
        jQuery(document).ready(function ($) {

            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            UIExtendedModals.init();
            ComponentsPickers.init();
            BindReligion();
            BindRole();
            BindSalutation();
            UserViewModel.init();
        });
    </script>

</asp:Content>
