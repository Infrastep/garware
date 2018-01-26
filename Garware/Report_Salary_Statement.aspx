<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Report_Salary_Statement.aspx.cs" Inherits="Garware.Report_Salary_Statement" %>
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
            <h5 class="page-title">Salary Statement
            </h5>
        </div>
        <div class="row">
            <div class="col-md-9">

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
                                            <label class="control-label col-md-3">Salary for</label>
                                            <div class="col-md-9">
                                                <select id="RPTMonth" class="form-control RPTMonth"></select>

                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="clearfix"></div>
                                    <!--/span-->
                                    <div class="col-md-4">
                                        <div class="form-group ">
                                            <label class="control-label col-md-4">Rank</label>
                                            <div class="col-md-9">
                                                <select multiple id="Rank" class="form-control">
                                                 
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                      <div class="col-md-4">
                                        <div class="form-group ">
                                            <label class="control-label col-md-4">Category</label>
                                            <div class="col-md-9">
                                                <select multiple id="Category" class="form-control">
                                                 
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                      <div class="col-md-4">
                                        <div class="form-group ">
                                            <label class="control-label col-md-4">Ship</label>
                                            <div class="col-md-9">
                                                <select multiple id="Ship" class="form-control">
                                                 
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="clearfix"></div>
                                        <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-8">Employement type</label>
                                            <div class="col-md-4">
                                                      <input type="radio" name="Sign" value="true" id="stReeg" class="rdubtn"  /><label  for="stReeg">Regular</label>
                                                   <br/>   <input type="radio" name="Sign" value="false" id="stCon" class="rdubtn" /><label  for="stCon">Contract</label>
                                                                     

                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>
                                           <div class="col-md-6">
                                        <div class="form-group">
                                            <label class="control-label col-md-3">Report type</label>
                                            <div class="col-md-9">
                                                      
                                                     <input type="radio" name="rt" value="true" id="stSummary" class="rdubtn"  /><label  for="stSummary">Summary</label>
                                                   <br/>   <input type="radio" name="rt" value="false" id="stDetails" class="rdubtn" /><label  for="stDetails">Details</label>
                                                                     

                                                <span class="help-block"></span>
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
                                                <button type="button" data-toggle="modal" data-target="#empModal" class="btn green" id="openempmodal">Select Employee</button>
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

    <!-- Modal -->
<div class="modal fade" id="empModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Employee List</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
            <select multiple id="Emp" class="form-control">
                                                 
                                                </select>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
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
            BindRPTMonth();
            BindRank();
            BindCategory();
            BindShip();
        });
    </script>
</asp:Content>
