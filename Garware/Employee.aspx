<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Garware.Employee" %>

<%@ Register Src="~/controls/Bank_Employee.ascx" TagPrefix="uc1" TagName="Bank_Employee" %>
<%@ Register Src="~/controls/KinDetails.ascx" TagPrefix="uc1" TagName="KinDetails" %>
<%@ Register Src="~/controls/EmpExperience.ascx" TagPrefix="uc1" TagName="EmpExperience" %>
<%@ Register Src="~/controls/Certificate.ascx" TagPrefix="uc1" TagName="Certificate" %>
<%@ Register Src="~/controls/Document.ascx" TagPrefix="uc1" TagName="Document" %>



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
                                <input id="EID" type="hidden" value="0" />

                                <div class="tabbable tabbable-tabdrop">
                                    <ul class="nav nav-tabs">

                                        <li class="active">
                                            <a href="#general" data-toggle="tab" aria-expanded="true">General</a>
                                        </li>
                                        <li class="">
                                            <a href="#BankAddress" data-toggle="tab" aria-expanded="false">Bank Address</a>
                                        </li>
                                        <li class="">
                                            <a href="#kin" data-toggle="tab" aria-expanded="false">Kin & Dependents</a>
                                        </li>
                                        <li class="">
                                            <a href="#doc" data-toggle="tab" aria-expanded="false">Documents</a>
                                        </li>
                                        <li class="">
                                            <a href="#training" data-toggle="tab" aria-expanded="false">Training & Certificates</a>
                                        </li>

                                        <li class="">
                                            <a href="#sea" data-toggle="tab" aria-expanded="false">Sea Experience</a>
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
                                                                        <label class="control-label col-md-3">EMP Code</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="Code" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Father's Name</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="fathername" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>


                                                            </div>

                                                           

                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Nationality</label>
                                                                        <div class="col-md-9">
                                                                            <select id="Nationality" class="form-control"></select>

                                                                            <%--<input type="text" class="form-control" placeholder="" id="Nationality" />--%>
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>


                                                            </div>


                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Religion</label>
                                                                        <div class="col-md-9">
                                                                            <select class="form-control" id="Religion">
                                                                            </select>
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>


                                                           


                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Birth Place</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="BirthPlace" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>


                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Sr. Citizen</label>
                                                                        <div class="col-md-9">
                                                                            <select class="form-control" id="SrCitizen">
                                                                                <option value="0">No</option>
                                                                                <option value="1">Yes</option>
                                                                            </select>
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                          


                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Date of Birth</label>
                                                                        <div class="col-md-9">
                                                                            <div class="input-group input-medium date date-picker" data-date-format="dd-mm-yyyy" data-date-start-date="+0d">
                                                                                <input type="text" class="form-control" readonly="" id="DOB" />
                                                                                <span class="input-group-btn">
                                                                                    <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                                                                </span>
                                                                            </div>
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
                                                                        <%--<span class="help-block">
																This field has error. </span>--%>
                                                                    </div>
                                                                </div>
                                                            </div>






                                                        </div>


                                                        <div class="col-md-6">
                                                            <div class="row">
                                                                <h3 class="form-section">Present Address</h3>
                                                                <div class="col-md-12">
                                                                    <div class="form-group ">
                                                                        <label class="control-label col-md-3">Address</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PAddress1" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">&nbsp;</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PAddress2" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                            </div>



                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Phone</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PPhone" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>


                                                            </div>




                                                            <div class="row">
                                                                <h3 class="form-section">Permanent Address</h3>
                                                                <div class="col-md-12">
                                                                    <div class="form-group ">
                                                                        <label class="control-label col-md-3">Address</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PMAddress1" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">&nbsp;</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PMAddress2" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Phone</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PMPhone" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>


                                                            </div>


                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Fax</label>
                                                                        <div class="col-md-9">
                                                                            <input type="text" class="form-control" placeholder="" id="PMFax" />
                                                                            <span class="help-block"></span>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>


                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label class="control-label col-md-3">Mobile / Pager</label>
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
                                                                        <label class="control-label col-md-3">Status</label>
                                                                        <div class="col-md-offset-3 col-md-9">
                                                                            <input type="radio" name="Status" value="9" id="stenable" class='rdubtn'/><label  for="stenable">Enable</label>
                                                                            <input type="radio" name="Status" value="10" id="stendisable" class='rdubtn'/><label  for="stendisable">Disable</label>
                                                                            <%--<input type="checkbox" checked="checked" class="make-switch" data-size="large" id="Status" />--%>

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
                                                                        <button type="button" class="btn green" id="Insertdata">Save And Continue</button>
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
                                        <div class="tab-pane" id="BankAddress">




                                            <uc1:Bank_Employee runat="server" ID="Bank_Employee" />





                                        </div>
                                        <div class="tab-pane" id="kin">


                                            <uc1:KinDetails runat="server" ID="KinDetails" />

                                        </div>
                                        <div class="tab-pane" id="doc">
                                            <p>
                                                <uc1:Document runat="server" ID="Document" />
                                            </p>
                                        </div>
                                        <div class="tab-pane" id="training">
                                            <uc1:Certificate runat="server" ID="Certificate" />
                                        </div>
                                        <div class="tab-pane" id="sea">
                                            <uc1:EmpExperience runat="server" ID="EmpExperience" />
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
                        <table class="table table-striped table-bordered table-hover" id="EmployeeTable">
                            <thead>
                                <tr>
                                    <th>Code</th>
                                    <th>Name</th>
                                    <th>Nationality</th>
                                    <th>Religion</th>
                                    <th>DOB</th>
                                    <th>Status</th>
                                    <th>Edit</th>
                                    <th>Action</th>
                                    <th>Comment</th>
                                    <th>Setting</th>
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
    <div id="verifyPop" class="modal fade" tabindex="-1" data-width="760">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
            <h4 class="modal-title">Verify Employee</h4>
        </div>
        <div class="modal-body">
            <input id="hdnEmpId" type="hidden" />
            <input id="hdnEmpName" type="hidden" />
            <input id="hdnEmpEmail" type="hidden" />
            <input id="hdnText" type="hidden" />
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
                <div class="col-md-8">
                    <div class="form-group ">
                        <label class="control-label col-md-4">Verified</label>
                        <div class="col-md-8">
                            <input type="radio" name="complete" value="true" id="complete_yes" class="rdbtn" />
                            <label for="complete_yes">verified</label>
                            <input type="radio" name="complete" value="7" id="complete_no" class="rdbtn" />
                            <label for="complete_no">Reject</label>
                            <input type="radio" name="complete" value="8" id="complete_no1" class="rdbtn" />
                            <label for="complete_no">Disable / Backlist</label>
                            <span class="help-block"></span>
                        </div>
                    </div>
                </div>




            </div>

        </div>
        <div class="modal-footer">
            <button type="button" data-dismiss="modal" class="btn btn-default">Close</button>
            <button type="button" class="btn blue" id="btnsave">Save changes</button>
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
            <div class="col-md-4 col-sm-4">
                <div class="portlet light ">
                    <div class="portlet-title">
                        <div class="caption">
                            <i class="icon-bubble font-red-sunglo"></i>
                            <span class="caption-subject font-red-sunglo bold uppercase">Users in Thread</span>
                        </div>
                        <div class="actions">
                        </div>
                    </div>
                    <div class="portlet-body">
                        <div class="scroller" style="height: 341px;" data-always-visible="1" data-rail-visible1="1">
                            <ul id="ulemp"></ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-8 col-sm-8">
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
                            <input type="radio" name="complete" value="Public" id="complete_public" class="rdbtn1" checked="checked" />
                            <label for="complete_public">Public</label>

                            <input type="radio" name="complete" value="Private" id="complete_private" class="rdbtn1" checked="checked" />
                            <label for="complete_private">Private</label>

                            <div class="input-cont">
                                <input class="form-control" type="text" id="txtmsg" placeholder="Type a message here..." />
                            </div>
                            <div id="dvchats" class="btn-cont" style="display: none">
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
                        <table class="table table-striped table-bordered table-hover" id="EmployeeTable">
                            <thead>
                                <tr>
                                    <th>Code</th>
                                    <th>Name</th>
                                    <th>Nationality</th>
                                    <th>Religion</th>
                                    <th>DOB</th>
                                    <th>Status</th>
                                    <th>Edit</th>
                                    <th>Action</th>
                                    <th>Comment</th>
                                    <th>Setting</th>
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

    <script src="assets/admin/pages/scripts/Employee.js"></script>
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
            BindBank();
            BindSalutation();
            BindCountry();
            BindShipType();
            BindReligion();
            BindBankBranch();
            BindRelationshipMaster();
            BindDocType();
            BindMedDocType();
            BindCertificateType();
            EmployeeViewModel.init();



            $('.nav-tabs li a[href="#BankAddress"]').click(function () {
                $('#EmployeeBranchTable').dataTable().fnDestroy();
                EmployeeBranchViewModel.init();

            });


            $('.nav-tabs li a[href="#kin"]').click(function () {
                $('#KinTable').dataTable().fnDestroy();
                KinDetailsViewModel.init();

            });

            $('.nav-tabs li a[href="#sea"]').click(function () {
                $('#EmpExperienceTable').dataTable().fnDestroy();
                EmpExperienceViewModel.init();

            });
            $('.nav-tabs li a[href="#doc"]').click(function () {
                $('#DocumentTable').dataTable().fnDestroy();
                DocumentViewModel.init();

            });



            $('.nav-tabs li a[href="#training"]').click(function () {

                $('#CertificateTable').dataTable().fnDestroy();
                CertificateViewModel.init();

            });

        });
    </script>
</asp:Content>
