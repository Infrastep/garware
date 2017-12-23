<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KinDetails.ascx.cs" Inherits="Garware.controls.KinDetails" %>


    <input id="KID" type="hidden" value="0" />
                                        <div class="form-horizontal">
											<div class="form-body">
									
                                           <div class="row">
                                             


                                             <div class="col-md-6">

                                             
                                                  <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">Name</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinName" />
															</div>
														</div>
													</div>
													
                                                </div>


                                               <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">Address</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinAddress1" />
															</div>
														</div>
													</div>
													
                                                </div>

                                                 <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">&nbsp;</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinAddress2" />
															</div>
														</div>
													</div>
													
                                                </div>
                                                

                                                <div class="row">
                                                    <div class="col-md-12">
														<div class="form-group">
															<label class="control-label col-md-4">City</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinCity" />
																<span class="help-block">
																 </span>
															</div>
														</div>
													</div>
                                                </div>


                                                 <div class="row">
                                                    <div class="col-md-12">
														<div class="form-group">
															<label class="control-label col-md-4">Pin</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinPin" />
																<span class="help-block">
																 </span>
															</div>
														</div>
													</div>
                                                </div>


                                                  <div class="row">
                                                   <div class="col-md-12">
														<div class="form-group">
															<label class="control-label col-md-4">Gender</label>
															<div class="col-md-8">
																<div class="radio-list">
												<label class="radio-inline">
												<div class="radio" id=""><span>
                                                <input type="radio" name="Gender" id="GenderMale" value="Male" />
                                                </span></div> Male </label>
												<label class="radio-inline">
												<div class="radio" id=""><span >
                                                <input type="radio" name="Gender" id="GenderFemale" value="Female" />
                                                </span></div> Female </label>
                                                
												
											</div>
															</div>
														</div>
													</div>
                                                  </div>

                                                



                                              </div>
                                              <div class="col-md-6">

                                                  <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">DOB</label>
																														<div class="col-md-8">
																  <div class="input-group input-medium date date-picker" data-date-format="dd-mm-yyyy" data-date-start-date="+0d">
                                                    <input type="text" class="form-control" readonly="" id="KinDOB" />
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
															<label class="control-label col-md-4">Country</label>
															<div class="col-md-8">
																<select class="form-control" id="KinCountry">
                                                                </select>
															</div>
														</div>
													</div>
													
                                                  </div>

                                                  <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">State</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinState" />
															</div>
														</div>
													</div>
													
                                                </div>


                                                     <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">Email</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinEmail" />
															</div>
														</div>
													</div>
													
                                                </div>


                                                  <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">Phone</label>
															<div class="col-md-8">
																<input type="text" class="form-control" placeholder="" id="KinPhone" />
															</div>
														</div>
													</div>
													
                                                </div>


                                                  <div class="row">
													
													<div class="col-md-12">
														<div class="form-group ">
															<label class="control-label col-md-4">Relationship</label>
															<div class="col-md-8">
																<select class="form-control Relation" id="KinRelation">
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
                        <table class="table table-striped table-bordered table-hover" id="KinTable">
                            <thead>
                                <tr>
                                    <th>Name</th>
                                    <th>DOB</th>
                                    <th>Address</th>
                                    <th>Country</th>
                                    <th>State</th>
                                    <th>City</th>
                                    <th>Pin</th>
                                    <th>Phone</th>
                                    <th>Email</th>
                                    <th>Gender</th>
                                    <th>Relation</th>
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
																<button type="button" class="btn green" id="InsertdataKD" style="display:none">Save</button>
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

