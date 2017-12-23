<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="EmpLstforClient.aspx.cs" Inherits="Garware.EmpLstforClient" %>

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
            <h5 class="page-title">Employee</h5>
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
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group ">
                                    <label class="control-label col-md-3">Status:</label>
                                    <div class="col-md-6">
                                        <select id="Status" class="form-control">
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <table class="table table-striped table-bordered table-hover" id="EmployeeTable">
                            <thead>
                                <tr>
                                    <th>Code</th>
                                    <th>Name</th>
                                    <th>Status</th>
                                    <th>Ship</th>
                                    <th>Rank</th>
                                    <th>Class</th>
                                    <th>Client</th>
                                    <th>Comment</th>
                                    <th>Action</th>

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
    <div id="EmpPop" class="modal fade scroller" tabindex="-1" data-width="760" style="height: 500px;" data-always-visible="1" data-rail-visible1="1">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>

        </div>
        <div class="modal-body">
            <input id="EID" type="hidden" />
            <input id="EmpName" type="hidden" />
            <input id="EmpEmail" type="hidden" />
            <input id="hdnClientId" type="hidden" />

            <div class="col-md-12 col-sm-12">
                <div class="clearfix"></div>

                <!-- COL 1 -->
                <div class="col-md-5 offset-0">

                    <span class="size16 bold">Personal details</span>
                    <div class="line2"></div>

                    <br />
                    Name*:
                            <div id="name"></div>
                    <br />
                    E-mail*:
                            <div id="email"></div>
                    <br />
                    Father's Name*:
                             <div id="fathername"></div>
                    <br />

                    Nationality:<br />
                    <div id="Nationality"></div>

                    <br />
                    Religion:<br />
                    <div id="Religion"></div>

                    <br />

                    DOB:<br />
                    <div id="DOB"></div>

                    <br />
                    Birth Place:<br />
                    <div id="BirthPlace"></div>


                    <br />
                    Sr. Citizen:<br />
                    <div id="SrCitizen"></div>


                    <br />
                </div>
                <div class="col-md-2 offset-0">
                </div>
                <br />
                <div class="row">
                    <div class="col-md-12">

                        <!-- BEGIN Ship Type TABLE PORTLET-->
                        <div class="portlet box green-haze">
                            <div class="portlet-title">
                                <div class="caption">
                                    <i class="fa fa-globe"></i>Bank Details
                                </div>

                            </div>
                            <div class="portlet-body">
                                <table class="table table-striped table-bordered table-hover" id="EmployeeBranchTable">
                                    <thead>
                                        <tr>
                                            <th>Bank</th>
                                            <th>Branch Address</th>
                                            <th>Branch Country</th>
                                            <th>Branch State</th>
                                            <th>Branch City</th>
                                            <th>Branch Pin</th>
                                            <th>IFSC Code</th>
                                            <th>Swift Code</th>
                                            <th>MICR Code</th>
                                            <th>Account NRE</th>
                                            <th>PF</th>


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
                <div class="row">
                    <div class="col-md-12">

                        <!-- BEGIN Ship Type TABLE PORTLET-->
                        <div class="portlet box green-haze">
                            <div class="portlet-title">
                                <div class="caption">
                                    <i class="fa fa-globe"></i>Documents
                                </div>

                            </div>
                            <div class="portlet-body">
                                <table class="table table-striped table-bordered table-hover" id="DocumentTable">
                                    <thead>
                                        <tr>
                                            <th>Code</th>
                                            <th>Doc Type</th>
                                            <th>Validity</th>
                                            <th>Issue Date</th>
                                            <th>Issue Place</th>
                                            <th>File</th>

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
                <div class="row">
                    <div class="col-md-12">

                        <!-- BEGIN Ship Type TABLE PORTLET-->
                        <div class="portlet box green-haze">
                            <div class="portlet-title">
                                <div class="caption">
                                    <i class="fa fa-globe"></i>Certificates
                                </div>

                            </div>
                            <div class="portlet-body">
                                <table class="table table-striped table-bordered table-hover" id="CertificateTable">
                                    <thead>
                                        <tr>
                                            <th>Decription</th>
                                            <th>Validity</th>
                                            <th>Certificate Type</th>
                                            <th>File</th>

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
                <div class="row">
                    <div class="col-md-12">

                        <!-- BEGIN Ship Type TABLE PORTLET-->
                        <div class="portlet box green-haze">
                            <div class="portlet-title">
                                <div class="caption">
                                    <i class="fa fa-globe"></i>Kin Details
                                </div>

                            </div>
                            <div class="portlet-body">
                                <table class="table table-striped table-bordered table-hover" id="KinTable">
                                    <thead>
                                        <tr>
                                            <th>Name</th>
                                            <th>DOB</th>
                                            <th>Address</th>
                                            <th>Country</th>
                                            <th>State</th>
                                            <th>City</th>
                                            <th>Pin</th>
                                            <th>Phone</th>
                                            <th>Email</th>
                                            <th>Gender</th>
                                            <th>Relation</th>

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
                <div class="row">
                    <div class="col-md-12">

                        <!-- BEGIN Ship Type TABLE PORTLET-->
                        <div class="portlet box green-haze">
                            <div class="portlet-title">
                                <div class="caption">
                                    <i class="fa fa-globe"></i>Sea Experience
                                </div>

                            </div>
                            <div class="portlet-body">
                                <table class="table table-striped table-bordered table-hover" id="EmpExperienceTable">
                                    <thead>
                                        <tr>
                                            <th>Company</th>
                                            <th>Ship Name</th>
                                            <th>Ship Type</th>
                                            <th>DWT</th>
                                            <th>BHP</th>
                                            <th>Engine</th>
                                            <th>Rank</th>
                                            <th>Service From</th>
                                            <th>Service To</th>
                                            <th>Months</th>
                                            <th>Days</th>
                                            <th>Direct</th>


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
                <div class="row">

                    <!--/span-->
                    <div class="col-md-6">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Remarks</label>
                            <div class="col-md-8">
                                <textarea id="remarks" cols="20" rows="5"></textarea>

                                <span class="help-block"></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">

                    <!--/span-->
                    <div class="col-md-6">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Verified</label>
                            <div class="col-md-8">
                                <input type="radio" name="complete" value="4" id="complete_yes" class="rdbtn" />
                                <label for="complete_yes">verified</label>
                                <input type="radio" name="complete" value="5" id="complete_no" class="rdbtn" />
                                <label for="complete_no">Reject</label>
                                <input type="radio" name="complete" value="6" id="complete_no1" class="rdbtn" />
                                <label for="complete_no">Disable / Backlist</label>
                                <span class="help-block"></span>
                            </div>
                        </div>
                    </div>




                </div>
            </div>
            <div class="modal-footer">
                <button type="button" data-dismiss="modal" class="btn btn-default">Close</button>
                <button type="button" class="btn blue" id="btnverified">Save</button>
            </div>
        </div>
    </div>
    <div id="CommentPop" class="modal fade" tabindex="-1" data-width="760">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>

        </div>
        <div class="modal-body">
            <input id="hdnCEmpId" type="hidden" />
            <input id="hdnCSender" type="hidden" />
            <input id="hdnCReciver" type="hidden" />
            <div class="col-md-12 col-sm-12">
                <!-- BEGIN PORTLET-->
                <div class="portlet light ">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="icon-bubble font-red-sunglo"></i>
                            <span class="caption-subject font-red-sunglo bold uppercase">Chats</span>
                        </div>
                        <div class="actions">
                        </div>
                    </div>
                    <div class="portlet-body" id="chats">
                        <div class="scroller" style="height: 341px;" data-always-visible="1" data-rail-visible1="1">
                            <ul class="chats">
                            </ul>
                        </div>
                        <div class="chat-form">
                            <input type="radio" name="complete" value="Public" id="complete_public" class="rdbtn1" />
                            <label for="complete_public">Public</label>

                            <input type="radio" name="complete" value="Private" id="complete_private" class="rdbtn1" />
                            <label for="complete_private">Private</label>

                            <div class="input-cont">
                                <input class="form-control" type="text" id="txtmsg" placeholder="Type a message here..." />
                            </div>
                            <div id="dvchats" class="btn-cont">
                                <span class="arrow"></span>
                                <a href="javascript:" id="anccom" class="btn blue icn-only">
                                    <i class="fa fa-check icon-white"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- END PORTLET-->
            </div>

        </div>
        <%--  <div class="modal-footer">
            <button type="button" data-dismiss="modal" class="btn btn-default">Close</button>
            <button type="button" class="btn blue" id="btncom">Save changes</button>
        </div>--%>
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
            <h5 class="page-title">Employee</h5>
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
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group ">
                                    <label class="control-label col-md-3">Status:</label>
                                    <div class="col-md-6">
                                        <select id="Status" class="form-control">
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <table class="table table-striped table-bordered table-hover" id="EmployeeTable">
                            <thead>
                                <tr>
                                    <th>Code</th>
                                    <th>Name</th>
                                    <th>Status</th>
                                    <th>Ship</th>
                                    <th>Rank</th>
                                    <th>Class</th>
                                    <th>Client</th>
                                    <th>Comment</th>
                                    <th>Action</th>

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
    <script type="text/javascript" src="assets/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js"></script>
    <script src="assets/admin/layout/scripts/demo.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/components-pickers.js"></script>
    <script src="assets/global/plugins/bootstrap-modal/js/bootstrap-modalmanager.js" type="text/javascript"></script>
    <script src="assets/global/plugins/bootstrap-modal/js/bootstrap-modal.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/ui-extended-modals.js"></script>
    <script type="text/javascript" src="assets/admin/pages/scripts/jquery.uploadify.js"></script>
    <script src="assets/admin/pages/scripts/common.js"></script>

    <script src="assets/admin/pages/scripts/emplstforClient.js"></script>
    <script src="assets/admin/pages/scripts/EmpBranch.js"></script>
    <script src="assets/admin/pages/scripts/KinDetails.js"></script>
    <script src="assets/admin/pages/scripts/EmpExperience.js"></script>
    <script src="assets/admin/pages/scripts/CertificateMaster.js"></script>
    <script src="assets/admin/pages/scripts/BankMaster.js"></script>
    <script src="assets/admin/pages/scripts/BranchMaster.js"></script>
    <script src="assets/admin/pages/scripts/Document.js"></script>

    <script>
        jQuery(document).ready(function ($) {

            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            UIExtendedModals.init();
            ComponentsPickers.init();
            BindStatus();
            EmployeeForClientViewModel.init();


        });
    </script>
</asp:Content>
