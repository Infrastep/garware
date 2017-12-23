<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="OtherIncome.aspx.cs" Inherits="Garware.OtherIncome" %>


<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
<!-- BEGIN PAGE LEVEL STYLES -->
<link rel="stylesheet" type="text/css" href="assets/global/plugins/select2/select2.css"/>
<link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css"/>
<link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/extensions/ColReorder/css/dataTables.colReorder.min.css"/>
<link rel="stylesheet" type="text/css" href="assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css"/>
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
        <h5 class="page-title">
			Other Income 
			</h5></div>
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
                <div class="col-md-4">

                    <div class="portlet box red bg-inverse">
									<div class="portlet-title">
										<div class="caption">
								<i class="fa fa-globe"></i>Insert Update Data
							</div>
										<div class="tools">
											<a href="javascript::void" class="collapse">
											</a>
											
										</div>
									</div>
									<div class="portlet-body form" style="display: block;">
										<!-- BEGIN FORM-->
										<div class="form-horizontal">
											<div class="form-body">
												<input id="OIID" type="hidden" value="0" />
												<div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-3">Description</label>
															<div class="col-md-9">
																<input type="text" class="form-control" placeholder="" id="Description" />
																<span class="help-block">
																 </span>
															</div>
														</div>
													</div>
													<!--/span-->
                                                </div>
                                                <div class="row">
                                                    <div class="col-md-12">
														<div class="form-group">
															<label class="control-label col-md-3">Type</label>
															<div class="col-md-9">
																<select class="form-control" id="Type">
                                                                    <option value="">Please Select</option>
                                                                    <option value="01">Office</option>
                                                                    <option value="02">Outside</option>
                                                    
                                                                </select>
															</div>
														</div>
													</div>


                                                
												</div>

                                                <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-3">Non Taxable Limit</label>
															<div class="col-md-9">
																<input type="text" class="form-control" placeholder="" id="TaxLimit" />
																<span class="help-block">
																 </span>
															</div>
														</div>
													</div>
													<!--/span-->
                                                </div>



												<!--/row-->
												
												<!--/row-->
											
											<div class="form-actions">
												<div class="row">
													<div class="col-md-12">
														<div class="row">
															<div class="col-md-offset-3 col-md-9">
																<button type="button" class="btn green" id="InsertdataOI">Submit</button>
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
							<table class="table table-striped table-bordered table-hover" id="OtherIncomeTable">
							<thead>
							<tr>
								
								<th>
									 Description
								</th>
								<th>
									 Type
								</th>
                               <th>
									 Non Taxable Limit
								</th>

                                <th>
									Edit
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
        <h5 class="page-title">
			Other Income 
			</h5></div>
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
							<table class="table table-striped table-bordered table-hover" id="OtherIncomeTable">
							<thead>
							<tr>
								
								<th>
									 Description
								</th>
								<th>
									 Type
								</th>
                               <th>
									 Non Taxable Limit
								</th>

                                <th>
									Edit
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
<script src="assets/admin/pages/scripts/OtherIncome.js"></script>
<script>
    jQuery(document).ready(function () {
        Metronic.init(); // init metronic core components
        Layout.init(); // init current layout
        QuickSidebar.init(); // init quick sidebar
        Demo.init(); // init demo features
        OtherIncomeViewModel.init();
    });
</script>
</asp:Content>