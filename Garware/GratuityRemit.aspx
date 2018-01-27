<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="GratuityRemit.aspx.cs" Inherits="Garware.GratuityRemit" %>
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
            <h5 class="page-title">Gratuity Remit
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

                                    <div class="col-md-6">
                                        <input id="GrID" type="hidden" value="0" />

                                        <div class="form-group">
                                            <label class="control-label col-md-3">Reference No</label>
                                            <div class="col-md-4">
                                                <input class="form-control" id="refno" type="text" />

                                            </div>
                                        </div>


                                    </div>



                                    <div class="col-md-6">


                                        <div class="form-group">
                                            <label class="control-label col-md-3">Reference Date</label>
                                            <div class="col-md-4">
                                                <input class="form-control" id="StDate" type="text" />

                                            </div>
                                        </div>


                                    </div>

                                </div>

                                <div class="row">
                                    <label class="control-label col-md-1">To</label>
                                </div>
                                <div class="row">

                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3"></label>

                                            <div class="col-md-9">
                                                <input class="form-control" id="add0" type="text" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3"></label>

                                            <div class="col-md-9">
                                                <input class="form-control" id="add1" type="text" />
                                            </div>
                                        </div>
                                    </div>




                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3"></label>

                                            <div class="col-md-9">
                                                <input class="form-control" id="add2" type="text" />
                                            </div>
                                        </div>
                                    </div>






                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3"></label>

                                            <div class="col-md-9">
                                                <input class="form-control" id="add3" type="text" />
                                            </div>
                                        </div>
                                    </div>





                                    <div class="col-md-6">
                                        <div class="form-group ">
                                            <label class="control-label col-md-3"></label>

                                            <div class="col-md-9">
                                                <input class="form-control" id="add4" type="text" />
                                            </div>
                                        </div>
                                    </div>



                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <fieldset>
                                            <legend>PF Contribution Cheque Details</legend>
                                            <div class="row">

                                                <div class="col-md-12">
                                                    <div class="form-group ">
                                                        <label class="control-label col-md-3">NO</label>

                                                        <div class="col-md-9">
                                                            <input class="form-control" id="rchqno" type="text" />
                                                            <span class="help-block"></span>
                                                        </div>
                                                    </div>
                                                </div>



                                            </div>
                                            <div class="row">

                                                <div class="col-md-12">


                                                    <div class="form-group">
                                                        <label class="control-label col-md-3">Date</label>
                                                        <div class="col-md-4">
                                                            <input class="form-control" id="rchqdate" type="text" />

                                                        </div>
                                                    </div>


                                                </div>

                                            </div>
                                            <div class="row">

                                                <div class="col-md-12">


                                                    <div class="form-group">
                                                        <label class="control-label col-md-3">Amount</label>
                                                        <div class="col-md-4">
                                                            <input class="form-control" id="rchqamount" type="text" />

                                                        </div>
                                                    </div>


                                                </div>

                                            </div>
                                            <div class="row">

                                                <div class="col-md-12">


                                                    <div class="form-group">
                                                        <label class="control-label col-md-3">Bank</label>
                                                        <div class="col-md-4">
                                                            <input class="form-control" id="rchqbank" type="text" />

                                                        </div>
                                                    </div>


                                                </div>

                                            </div>
                                        </fieldset>
                                    </div>
                                    
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <fieldset>
                                            <legend>Authorised Signatory</legend>
                                            <div class="row">

                                                <div class="col-md-12">


                                                    <div class="form-group">
                                                        <label class="control-label col-md-3"></label>
                                                        <div class="col-md-4">
                                                            <input class="form-control" id="authsign" type="text" />

                                                        </div>
                                                    </div>


                                                </div>

                                            </div>

                                            <div class="row">

                                                <div class="col-md-12">


                                                    <div class="form-group">
                                                        <label class="control-label col-md-3"></label>
                                                        <div class="col-md-4">
                                                            <input class="form-control" id="authdsgn" type="text" />

                                                        </div>
                                                    </div>


                                                </div>

                                            </div>
                                        </fieldset>
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
                        <table class="table table-striped table-bordered table-hover" id="GratuityRemitTable">
                            <thead>
                                <tr>
                                      <th>ID
                                    </th>
                                    <th>Letter No
                                    </th>
                                    <th>Letter Date
                                    </th>
                                    <th>PF Contr. Remitance Cheque Details
                                 
                                    </th>
                                    
                                    <th>Edit
                                    </th>
                                    <th>Letter Print
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
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN PAGE LEVEL SCRIPTS -->
    <script src="assets/global/scripts/metronic.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/layout.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/quick-sidebar.js" type="text/javascript"></script>
    <script src="assets/admin/layout/scripts/demo.js" type="text/javascript"></script>
    <script src="assets/admin/pages/scripts/components-pickers.js"></script>
    <script src="assets/admin/pages/scripts/common.js"></script>
    <script src="assets/admin/pages/scripts/GratuityRemit.js"></script>

    <script>
        jQuery(document).ready(function () {

            Metronic.init(); // init metronic core components
            Layout.init(); // init current layout
            QuickSidebar.init(); // init quick sidebar
            Demo.init(); // init demo features
            ComponentsPickers.init();


            handleDatePickers();
            GratuityRemitViewModel.init();

        });
    </script>
</asp:Content>
