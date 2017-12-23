<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmpExperience.ascx.cs" Inherits="Garware.controls.EmpExperience" %>


<input id="EEID" type="hidden" value="0" />
<div class="form-horizontal">
    <div class="form-body">

        <div class="row">



            <div class="col-md-6">


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Company</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="CompanyServed" />
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Area Special Job</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="Area_Sp_Job" />
                            </div>
                        </div>
                    </div>

                </div>

                 <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Ship Name</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="ShipName" />
                            </div>
                        </div>
                    </div>

                </div>
                 <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Area Operation</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="Area_Operation" />
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Ship Type</label>
                            <div class="col-md-8">
                                <select class="form-control" id="ShipType">
                                </select>
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-4">DWT</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="Dwt" />
                                <span class="help-block"></span>
                            </div>
                        </div>
                    </div>
                </div>


                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-4">Engine</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="Engine" />
                                <span class="help-block"></span>
                            </div>
                        </div>
                    </div>
                </div>


                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label col-md-4">BHP</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="Bhp" />
                                <span class="help-block"></span>
                            </div>
                        </div>
                    </div>
                </div>





            </div>
            <div class="col-md-6">

                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Service From</label>
                            <div class="col-md-8">
                                <div class="input-group input-medium date date-picker" data-date-format="dd-mm-yyyy" data-date-start-date="+0d">
                                    <input type="text" class="form-control" readonly="" id="ServiceFrom" />
                                    <span class="input-group-btn">
                                        <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                    </span>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Service To</label>
                            <div class="col-md-8">
                                <div class="input-group input-medium date date-picker" data-date-format="dd-mm-yyyy" data-date-start-date="+0d">
                                    <input type="text" class="form-control" readonly="" id="ServiceTo" />
                                    <span class="input-group-btn">
                                        <button class="btn default" type="button"><i class="fa fa-calendar"></i></button>
                                    </span>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Rank</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="ERank" />
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Months</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="Months" />
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Days</label>
                            <div class="col-md-8">
                                <input type="text" class="form-control" placeholder="" id="Days" />
                            </div>
                        </div>
                    </div>

                </div>


                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group ">
                            <label class="control-label col-md-4">Direct</label>
                            <div class="col-md-8">
                                <select class="form-control" id="Direct">
                                    <option value="true">Yes</option>
                                    <option value="false">No</option>
                                </select>
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
                            <button type="button" class="btn green" id="InsertdataEE" style="display: none">Save</button>
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

