<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Company_Branch.ascx.cs" Inherits="Garware.controls.Company_Branch" %>

<%@ Register Src="~/controls/Bank_Master.ascx" TagPrefix="uc1" TagName="Bank" %>
<%@ Register Src="~/controls/Bank_Branch.ascx" TagPrefix="uc1" TagName="BankBranch" %>
<input id="CBID" type="hidden" value="0" />

<div class="form-horizontal">
    <div class="form-body">

        <div class="row">



            <div class="col-md-8">

                <div class="row">
                    <h3 class="form-section">Salary Transfer Bank A/C No</h3>
                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Bank Name</label>
                            <div class="col-md-8">
                                <select class="form-control" id="Bank">
                                </select>
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Branch</label>
                            <div class="col-md-8">
                                <select class="form-control" id="Branch">
                                </select>
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-4">Cheque Name</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="chequeno" />
                                <span class="help-block"></span>
                            </div>
                        </div>
                    </div>
                </div>




            </div>


            <div class="col-md-4">
                <div class="row">
                    <h3 class="form-section">&nbsp;</h3>
                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">


                                <a class="btn default" data-toggle="modal" href="#NewBankInsert">Add New Bank </a>
                            </label>
                            
                        </div>
                    </div>
                     <div class="col-md-12">
                        <div class="form-group ">
                           <label class="control-label col-md-4">
                                <a class="btn default" data-toggle="modal" href="#NewBankBranchInsert">Add Bank Branch </a>
                            </label>
                        </div>
                    </div>
                </div>
              
            </div>
            

        </div>
         
        

          <uc1:Bank runat="server" id="bank1" />
         <uc1:BankBranch runat="server" id="bankbrnch2" />

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
                        <table class="table table-striped table-bordered table-hover" id="CompanyBranchTable">
                            <thead>
                                <tr>
                                    <th>Company</th>
                                    <th>Bank</th>
                                    <th>Branch Address</th>
                                    <th>Branch Country</th>
                                    <th>Branch State</th>
                                    <th>Branch City</th>
                                    <th>Branch Pin</th>
                                    <th>IFSC Code</th>
                                    <th>Swift Code</th>
                                    <th>MICR Code</th>
                                    <th>Cheque Name</th>
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





        <div class="form-actions">
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-offset-3 col-md-9">
                            <button type="button" class="btn green" id="InsertdataCB" style="display: none">Save</button>
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
