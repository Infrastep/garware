<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Certificate.ascx.cs" Inherits="Garware.controls.Certificate" %>


<input id="CID" type="hidden" value="0" />
<div class="form-horizontal">
    <div class="form-body">

        <div class="row">



            <div class="col-md-6">


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-3">Description</label>
                            <div class="col-md-9">
                                <input type="text" class="form-control" placeholder="" id="Description">
                            </div>
                        </div>

                    </div>

                </div>

                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-3">Certificate Type</label>
                            <div class="col-md-9">
                                <select class="form-control" id="CerType">
                                </select>
                            </div>
                        </div>

                    </div>

                </div>







                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-3">File</label>
                            <div class="col-md-9">
                                <input type="file" name="certificate" id="certificate" />

                                <%--<span class="help-block">
																This field has error. </span>--%>
                            </div>
                        </div>



                    </div>

                </div>

                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-3">Validity</label>
                            <div class="col-md-9">
                                <div class="input-group input-medium date date-picker" data-date-format="dd-mm-yyyy" data-date-start-date="+0d">
                                    <input type="text" class="form-control" readonly="" id="cerValidity" />
                                    <span class="input-group-btn">
                                        <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                    </span>
                                </div>
                            </div>
                        </div>


                    </div>

                </div>


            </div>




        </div>
        <div class="row">

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
                            <table class="table table-striped table-bordered table-hover" id="CertificateTable">
                                <thead>
                                    <tr>
                                        <th>Decription</th>
                                        <th>Validity</th>
                                        <th>Certificate Type</th>
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


        <div class="form-actions">
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-offset-3 col-md-9">
                            <button type="button" class="btn green" id="InsertdataCC" style="display: none">Save</button>
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
