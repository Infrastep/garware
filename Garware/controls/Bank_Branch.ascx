<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Bank_Branch.ascx.cs" Inherits="Garware.controls.Bank_Branch" %>
<div id="NewBankBranchInsert" class="modal fade" tabindex="-1" data-width="760">
    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
        <h4 class="modal-title">Add New Bank Branch</h4>
    </div>
    <div class="modal-body">
        <input id="BID" type="hidden" value="0" />
        <div class="row">

            <div class="clearfix"></div>
            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">IFSC Code</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="ifscCode" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>

        </div>

        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">SWIFT Code</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="swiftcode" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">MICR Code</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="micrcode" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">ADDRESS</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="add1" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">&nbsp;</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="add2" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">CITY</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="city" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">STATE</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="state" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">

            <!--/span-->
            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">PIN</label>
                    <div class="col-md-9">
                        <input type="text" class="form-control" placeholder="" id="pin" />
                        <span class="help-block"></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">

            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">Country</label>
                    <div class="col-md-9">
                        <select class="form-control" id="Country">
                        </select>
                    </div>
                </div>
            </div>

        </div>
        <div class="row">

            <div class="col-md-6">
                <div class="form-group ">
                    <label class="control-label col-md-3">Bank Name</label>
                    <div class="col-md-8">
                        <select class="form-control" id="Bank1">
                        </select>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div class="modal-footer">
        <button type="submit" class="btn green" id="InsertdataBankBranch">Submit</button>
        <button type="button" class="btn default">Cancel</button>
    </div>
</div>
