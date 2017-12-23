<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Bank_Master.ascx.cs" Inherits="Garware.controls.Bank_Master" %>
<div id="NewBankInsert" class="modal fade" tabindex="-1" data-width="760">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
        <h4 class="modal-title">Add New Bank</h4>
    </div>
    <div class="modal-body">
        <input id="BID" type="hidden" value="0" />
        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-4">Bank Name</label>
                    <div class="col-md-8">
                        <input type="text" class="form-control" placeholder="" id="BankName" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">

            <div class="clearfix"></div>
            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-4">Bank Code</label>
                    <div class="col-md-8">
                        <input type="text" class="form-control" placeholder="" id="BankCode" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
            <!--/span-->


            <div class="col-md-6">
                <div class="form-group">
                    <label class="control-label col-md-4">Status</label>
                    <div class="col-md-offset-3 col-md-8">
                        <input type="checkbox" checked="checked" class="make-switch" data-size="large" id="BankStatus" />

                    </div>
                </div>
            </div>


        </div>
    </div>
    <div class="modal-footer">
        <button type="button" data-dismiss="modal" class="btn btn-default">Close</button>
        <button type="button" class="btn blue" id="InsertdataBank">Save changes</button>
    </div>
</div>
