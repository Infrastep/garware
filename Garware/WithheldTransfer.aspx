﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="WithheldTransfer.aspx.cs" Inherits="Garware.WithheldTransfer" %>
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
            <h5 class="page-title">Withheld Transfer
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
                            <a href="" class="collapse"></a>

                        </div>
                    </div>
                    <div class="portlet-body form" style="display: block;">
                        <!-- BEGIN FORM-->
                        <div class="form-horizontal">
                            <div class="form-body">
                                <div class="row">
                                    <input id="ID" type="hidden" value="0" />
                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Employee Code</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="Emp">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                <div class="row">

                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Employee Name</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="EmpName">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                 <div class="row">

                                    <div class="col-md-12">


                                        <div class="form-group">
                                            <label class="control-label col-md-3">Amount Withheld</label>
                                            <div class="col-md-4">
                                                <input class="form-control" id="amount" type="text" />

                                            </div>
                                        </div>


                                    </div>

                                </div>

                                 <div class="row">

                                    <div class="col-md-12">


                                        <div class="form-group">
                                            <label class="control-label col-md-3"> Year</label>
                                            <div class="col-md-4">
                                                <input class="form-control" id="year" type="text" />

                                            </div>
                                        </div>


                                    </div>

                                </div>
                                 <div class="row">
                                    <div class="col-md-12">
                                	<div class="form-group">
										<label class="control-label col-md-3">Month</label>
										<div class="col-md-9">
											<div id="spinnerMonth">
												<div class="input-group" style="width:150px;">
													<input type="text" class="spinner-input form-control" id="mon" maxlength="3" readonly>
													<div class="spinner-buttons input-group-btn">
														<button type="button" class="btn spinner-up default">
														<i class="fa fa-angle-up"></i>
														</button>
														<button type="button" class="btn spinner-down default">
														<i class="fa fa-angle-down"></i>
														</button>
													</div>
												</div>
											</div>
											<span class="help-block">
											Value 1 - 12</span>
										</div>
									</div>
                                        </div>
                                </div>

                                <div class="row">

                                    <div class="col-md-12">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3">Agreement Code</label>

                                            <div class="col-md-9">
                                                <select class="form-control" id="agreement">
                                                </select>
                                                <span class="help-block"></span>
                                            </div>
                                        </div>
                                    </div>



                                </div>

                                

                                <!--/row-->
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
                        <table class="table table-striped table-bordered table-hover" id="WithheldTransferTable">
                            <thead>
                                <tr>

                                    <th>Emp Code
                                    </th>
                                    <th>Emp Name 
                                    </th>
                                    <th>Year
                                 
                                    </th>
                                    <th>Month
                                    </th>
                                    <th>Amount
                                    </th>
                                    <th>Aagreement Code
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footercontent" runat="server">
    <script type="text/javascript" src="assets/global/plugins/select2/select2.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/media/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/extensions/TableTools/js/dataTables.tableTools.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/extensions/ColReorder/js/dataTables.colReorder.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/extensions/Scroller/js/dataTables.scroller.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.js"></script>
    <script type="text/javascript" src="assets/global/plugins/jquery-inputmask/jquery.inputmask.bundle.min.js"></script>
    <script type="text/javascript" src="assets/global/plugins/fuelux/js/spinner.min.js"></script>
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN PAGE LEVEL SCRIPTS -->
    <script src="assets/global/scripts/metronic.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/layout.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/quick-sidebar.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/demo.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/components-pickers.js"></script>
    <script src="assets/admin/pages/scripts/common.js"></script>
    <script src="assets/admin/pages/scripts/WithheldTransfer.js"></script>

    <script>
        jQuery(document).ready(function () {

            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            ComponentsPickers.init();
            handleDMSpinners();
            BindEmployee();
            BindAgreement();
            WithheldTransferViewModel.init();

        });
    </script>
</asp:Content>
