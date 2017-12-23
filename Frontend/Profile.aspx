<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Frontend.Profile" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%-- <link href="plugins/bootstrap-modal/css/bootstrap-modal.css" rel="stylesheet" type="text/css" />--%>
    <link href="assets/css/components.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SliderArea" runat="server">
    <div class="mtslide2 sliderbg2"></div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-200 offset-0">


        <!-- CONTENT -->
        <div class="col-md-12 pagecontainer2 offset-0">

            <!-- LEFT MENU -->
            <div class="col-md-1 offset-0">
                <!-- Nav tabs -->
                <ul class="nav profile-tabs">
                    <li class="active">
                        <a href="#profile" data-toggle="tab">
                            <span class="profile-icon"></span>
                            General
                        
                        </a></li>

                    <li>
                        <a href="#doc" data-toggle="tab" onclick="mySelectUpdate()">
                            <span class="settings-icon"></span>
                            Documents
                        </a></li>

                    <li>
                        <a href="#Tranning" data-toggle="tab" onclick="mySelectUpdate()">
                            <span class="password-icon"></span>
                            Training & Certificates
                        </a></li>
                    <li>
                        <a href="#seaexp" data-toggle="tab" onclick="mySelectUpdate()">
                            <span class="newsletter-icon"></span>
                            Sea Experience
                        </a></li>
                    <li>
                        <a href="#comment" data-toggle="tab" onclick="mySelectUpdate()">
                            <span class="newsletter-icon"></span>
                            Comment
                        </a></li>

                    <li>
                        <a href="#password" data-toggle="tab" onclick="mySelectUpdate()">
                            <span class="newsletter-icon"></span>
                            Additional Information
                        </a></li>
                </ul>
                <div class="clearfix"></div>
            </div>
            <!-- LEFT MENU -->

            <!-- RIGHT CPNTENT -->
            <div class="col-md-11 offset-0">
                <!-- Tab panes from left menu -->
                <div class="tab-content5">

                    <!-- TAB 1 -->
                    <div class="tab-pane padding40 active" id="profile">

                        <!-- Admin top -->
                        <div class="col-md-4 offset-0">
                            <img id="imguser" src="" alt="" class="left margright20" width="65" height="65" />
                            <p class="size12 grey margtop10">
                                <span class="lred">
                                    <asp:LoginName ID="LoginName1" runat="server" CssClass="username username-hide-on-mobile" />
                                </span>
                                <br />
                                <%--<a href="javascript:" id="picup" class="lblue">Change picture</a>
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target=".bs-example-modal-lg">Large modal</button>--%>
                            </p>
                            <div class="clearfix"></div>
                        </div>
                        <div class="col-md-4">
                        </div>
                        <%--<div class="col-md-4 offset-0">
                            <table class="table table-bordered  mt-10">
                                <tr class="grey opensans">
                                    <td class="center"><span class="size30 slim lh4">2</span><br />
                                        <span class="size12">Trips</span></td>
                                    <td class="center"><span class="size30 slim lh4">5</span><br />
                                        <span class="size12">Places</span></td>
                                    <td class="center"><span class="size30 slim lh4">14</span><br />
                                        <span class="size12">Days away</span></td>
                                    <td class="center"><span class="size30 slim lh4">3</span><br />
                                        <span class="size12">Countries</span></td>
                                </tr>
                            </table>
                        </div>--%>
                        <!-- End of Admin top -->


                        <div class="clearfix"></div>

                        <!-- COL 1 -->
                        <div class="col-md-5 offset-0">

                            <span class="size16 bold">Personal details</span>
                            <div class="line2"></div>
                            <input id="EID" type="hidden" value="3953" />


                            Prefix:
                             <select id="Salutation" class="form-control"></select>
                            <br />
                            <div class="form-group">
                                Name*:
							<input type="text" class="form-control" placeholder="John Doe" rel="popover" id="name" data-content="This field is mandatory" data-original-title="Here you can edit your name" required />
                                <span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <%--E*:
							<input type="text" class="form-control" placeholder="Jack" rel="popover" id="username" data-content="This field is mandatory" data-original-title="Here you can edit your username" />
                            <br />--%>
                           E-mail*:
							<input type="text" class="form-control" placeholder="office@email.com" id="email" data-content="This field is mandatory" data-original-title="Edit your email address" readonly="true" />
                            <br />
                            <br />
                            <%--Password*:
							<input type="password" class="form-control" placeholder="" id="pass" data-content="This field is mandatory" data-original-title="Edit your pass" />
                            <br />--%>
                            Father's Name*:
                             <div class="form-group">
                                 <input type="text" class="form-control" placeholder="John Doe" rel="popover" id="fathername" data-content="This field is mandatory" data-original-title="Here you can edit your name" required />
                                 <span class="help-block with-errors"></span>
                             </div>
                            <br />


                            Nationality:<br />
                            <select id="Country" class="form-control"></select>
                            <%--<input type="text" class="form-control" placeholder="" id="Nationality" />--%>

                            <br />
                            Religion:<br />
                            <select class="form-control" id="Religion">
                            </select>


                            <br />
                            <div class="form-group">
                                DOB:<br />
                                <input type="text" class="form-control mySelectCalendar" id="datepicker8" placeholder="mm/dd/yyyy" required />
                                <span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <div class="form-group">
                                Birth Place:<br />

                                <input type="text" class="form-control" placeholder="" id="BirthPlace" required />
                                <span class="help-block with-errors"></span>
                            </div>
                            <br />

                            Photo:<br />
                            <input type="file" name="Photo" id="Photo" />

                        </div>
                        <div class="col-md-2 offset-0">
                        </div>
                        <div class="col-md-5 offset-0">

                            <span class="size16 bold">Your Present address</span>
                            <div class="line2"></div>


                            <br />
                            <div class="form-group">
                                Address*:
						 <input type="text" class="form-control" placeholder="" id="PAddress1" required /><span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <div class="form-group">
                                <input type="text" class="form-control" placeholder="" id="PAddress2" required />
                                <span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <div class="form-group">
                                Phone:
                             <input type="text" class="form-control" placeholder="" id="PPhone" required /><span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <span class="size16 bold">Your Permanent address</span>
                            <div class="line2"></div>


                            <br />
                            <input id="chksame" type="checkbox" />same as present address 
                            <br />
                            <br />
                            Address*:
                            <div class="form-group">
                                <input type="text" class="form-control" placeholder="" id="PMAddress1" required /><span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <div class="form-group">
                                <input type="text" class="form-control" placeholder="" id="PMAddress2" required /><span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <div class="form-group">
                                Phone:
                            <input type="text" class="form-control" placeholder="" id="PMPhone" required />
                                <span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <div class="form-group">
                                Fax:
                            <input type="text" class="form-control" placeholder="" id="PMFax" required />
                                <span class="help-block with-errors"></span>
                            </div>
                            <br />
                            <div class="form-group">
                                Mobile:
                            <input type="text" class="form-control" placeholder="" id="PMMobile" required />
                                <span class="help-block with-errors"></span>
                            </div>

                        </div>
                        <!-- END OF COL 1 -->

                        <div class="clearfix"></div>
                        <div class="form-group">
                        <button type="submit" class="greenbtn  margtop20" id="btntab1">Save</button>
                            </div>
                        <br />
                        <br />
                        <br />



                    </div>
                    <!-- END OF TAB 1 -->
                    <!-- TAB 2 -->
                    <div class="tab-pane" id="doc">
                        <div class="row">
                            <div class="padding40 dark col-md-6">
                                <select id="doctype" class="form-control"></select>
                            </div>

                        </div>
                        <br />
                        <div class="row">
                            <div id="dvdoc" class="padding40 dark col-md-6" style="display: none">


                                <span id="nnme" class="dark size18"></span>
                                <input id="CID" type="hidden" value="0" />
                                <input id="CdocID" type="hidden" value="0" />
                                <div class="line4"></div>
                                Upload File<br />
                                <input type="file" class="form-control " id="Certificate" />
                                <br />

                                Code<br />
                                <input type="text" class="form-control " placeholder="" id="code" />
                                <br />
                                Issue Date<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="issue" />
                                <br />
                                Issue Place<br />
                                <input type="text" class="form-control " placeholder="" id="Description" />
                                <br />
                                Issue Country<br />
                                <select class="form-control" id="place"></select>
                                <%--<input type="text" class="form-control " placeholder="" id="placePass" />--%>
                                <br />
                                Valid Upto<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="Validity" />
                                <br />
                                <br />
                                <button type="button" class="btn-search5 docsub" id="InsertdataCCPass" name="Pass">Save changes</button>
                            </div>
                            <div class="padding40 dark col-md-6" style="display: none">


                                <span class="dark size18">CDC</span>
                                <input id="CCdcID" type="hidden" value="0" />
                                <input id="CCdcdocID" type="hidden" value="2" />
                                <div class="line4"></div>
                                Upload File<br />
                                <input type="file" class="form-control " id="CertificateCdc" />
                                <br />
                                Description<br />
                                <input type="text" class="form-control " placeholder="" id="DescriptionCdc" />
                                <br />
                                Code<br />
                                <input type="text" class="form-control " placeholder="" id="codeCdc" />
                                <br />
                                Issue Date<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="issueCdc" />
                                <br />
                                Issue Country<br />
                                <select class="form-control" id="placeCdc"></select>
                                <%--<input type="text" class="form-control " placeholder="" id="placeCdc" />--%>
                                <br />
                                Valid Upto<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="ValidityCdc" />
                                <br />
                                <br />


                                <button type="button" class="btn-search5 docsub" id="InsertdataCCCdc" name="Cdc" style="display: none">Save changes</button>




                            </div>
                            <div class="padding40 dark col-md-6" style="display: none">


                                <span class="dark size18">Pan</span>
                                <input id="CPanID" type="hidden" value="0" />
                                <input id="CPandocID" type="hidden" value="3" />
                                <div class="line4"></div>
                                Upload File<br />
                                <input type="file" class="form-control " id="CertificatePan" />
                                <br />
                                Description<br />
                                <input type="text" class="form-control " placeholder="" id="DescriptionPan" />
                                <br />
                                Code<br />
                                <input type="text" class="form-control " placeholder="" id="codePan" />
                                <br />
                                Issue Date<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="issuePan" />
                                <br />
                                Issue Place<br />
                                <select class="form-control" id="placePan"></select>
                                <%--<input type="text" class="form-control " placeholder="" id="placePan" />--%>
                                <br />
                                Valid Upto<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="ValidityPan" />
                                <br />
                                <br />


                                <button type="button" class="btn-search5 docsub" id="InsertdataCCPan" name="Pan" style="display: none">Save changes</button>




                            </div>
                            <div class="padding40 dark col-md-6" style="display: none">


                                <span class="dark size18">Medical</span>
                                <input id="CMediID" type="hidden" value="0" />
                                <input id="CMedidocID" type="hidden" value="4" />
                                <div class="line4"></div>
                                Upload File<br />
                                <input type="file" class="form-control " id="CertificateMedi" />
                                <br />
                                Description<br />
                                <input type="text" class="form-control " placeholder="" id="DescriptionMedi" />
                                <br />
                                Code<br />
                                <input type="text" class="form-control " placeholder="" id="codeMedi" />
                                <br />
                                Issue Date<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="issueMedi" />
                                <br />
                                Issue Place<br />
                                <select class="form-control" id="placeMedi"></select>
                                <%--<input type="text" class="form-control " placeholder="" id="placeMedi" />--%>
                                <br />
                                Valid Upto<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="ValidityMedi" />
                                <br />
                                <br />

                                <button type="button" class="btn-search5 docsub" id="InsertdataCCMedi" name="Medi" style="display: none">Save changes</button>

                            </div>

                            <div class="col-md-6">

                                <!-- BEGIN Ship Type TABLE PORTLET-->
                                <div class="portlet box green-haze">
                                    <div class="portlet-title">
                                        <div class="caption">
                                            <i class="fa fa-globe"></i>List
                                        </div>

                                    </div>
                                    <div class="portlet-body">
                                        <table class="table table-striped table-bordered table-hover" id="DocumentTable">
                                            <thead>
                                                <tr>
                                                    <th>Code</th>
                                                    <th>Description</th>
                                                    <th>Doc Type</th>
                                                    <th>Validity</th>
                                                    <th>Issue Date</th>

                                                    <th>Issue Place</th>
                                                    <th>File</th>
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
                    <!-- END OF TAB 2 -->

                    <!-- TAB 3 -->
                    <div class="tab-pane" id="Tranning">
                        <div class="row">
                            <div class="padding40 dark col-md-6">


                                <span class="dark size18">Documents and Certificates</span>
                                <input id="DCID" type="hidden" value="0" />

                                <div class="line4"></div>
                                Upload File<br />
                                <input type="file" class="form-control " id="CertificatefileDC" />
                                <br />
                                Description<br />
                                <input type="text" class="form-control " placeholder="" id="DescriptionDC" />
                                <br />
                                Certificate Type<br />
                                <select class="form-control" id="CerType">
                                </select>
                                <br />

                                Issue Place<br />
                                <select class="form-control" id="placeDC"></select><br />
                                Valid Upto<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="ValidityDC" />
                                <br />
                                <br />

                                <button type="button" class="btn-search5" id="InsertdataDC" name="DC" style="display: none">Save changes</button>




                            </div>


                            <div class="padding40 dark col-md-6">

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
                                                    <th>Issue Place</th>
                                                    <th>File</th>
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
                    <!-- END OF TAB 3 -->

                    <!-- TAB 4 -->

                    <!-- END OF TAB 4 -->

                    <!-- TAB 5 -->
                    <div class="tab-pane" id="seaexp">
                        <div class="row">
                            <div class="padding40 col-md-12 ">

                                <span class="dark size18">Input Previous Exp</span>
                                <div class="line4"></div>
                                <input id="EEID" type="hidden" value="0" />
                                Company<br />
                                <input type="text" class="form-control " placeholder="" id="CompanyServed" />
                                <br />
                                Ship Name<br />
                                <input type="text" class="form-control " placeholder="" id="ShipName" />
                                <br />
                                Ship Type<br />
                                <select class="form-control" id="ShipType">
                                </select>

                                <br />
                                <br />
                                DWT<br />
                                <input type="text" class="form-control " placeholder="" id="Dwt" />
                                <br />
                                BHP<br />
                                <input type="text" class="form-control " placeholder="" id="Bhp" />
                                <br />
                                Engine<br />
                                <input type="text" class="form-control " placeholder="" id="Engine" />
                                <br />
                                <br />
                                Service From<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="ServiceFrom" />
                                <br />
                                <br />
                                Service To<br />
                                <input type="text" class="form-control " readonly="" placeholder="MM/DD/YY" id="ServiceTo" />

                                <br />



                                Rank<br />
                                <input type="text" class="form-control " placeholder="" id="ERank" />
                                <br />

                                Months<br />
                                <input type="text" class="form-control " placeholder="" id="Months" />
                                <br />
                                Days<br />
                                <input type="text" class="form-control " placeholder="" id="Days" />
                                <br />
                                Direct<br />
                                <select class="form-control" id="Direct">
                                    <option value="true">Yes</option>
                                    <option value="false">No</option>
                                </select>
                                <br />
                                <br />
                                <br />
                                <button type="button" class="btn-search5" id="InsertdataEE" style="display: none">Save changes</button>
                            </div>
                        </div>
                        <div class="row">
                            <div class="padding40 col-md-12 ">

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
                    <!-- END OF TAB 5 -->
                    <div class="tab-pane" id="comment">
                        <div class="row">
                            <div class="padding40 dark col-md-6">
                                <input id="hdnVEmpId" type="hidden" />
                                <input id="hdnVSender" type="hidden" />
                                <input id="hdnVReciver" type="hidden" />
                                <div class="portlet light ">
                                    <div class="portlet-title">
                                        <div class="caption">
                                            <i class="icon-bubble font-red-sunglo"></i>
                                            <span class="caption-subject font-red-sunglo bold uppercase">Verification Level  Comment </span>
                                        </div>
                                        <div class="actions">
                                        </div>
                                    </div>
                                    <div class="portlet-body" id="chats">
                                        <div class="scroller" style="height: 341px; overflow-y: scroll" data-always-visible="1" data-rail-visible1="1">
                                            <ul class="chats" id="chts">
                                            </ul>
                                        </div>
                                        <div class="chat-form">
                                            <input type="radio" name="complete" value="Public" id="complete_public" class="rdbtn1" checked="checked" />
                                            <label for="complete_public">Public</label>

                                            <input type="radio" name="complete" value="Private" id="complete_private" class="rdbtn1" checked="checked" />
                                            <label for="complete_private">Private</label>

                                            <div class="input-cont">
                                                <input class="form-control" type="text" id="txtmsg" placeholder="Type a message here..." />
                                            </div>
                                            <div id="dvchats" class="btn-cont" style="display: none">
                                                <span class="arrow"></span>
                                                <a href="javascript:" id="anccom" class="btn blue icn-only">
                                                    <i class="fa fa-check icon-white"></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="padding40 dark col-md-6">
                                <input id="hdnCEmpId" type="hidden" />
                                <input id="hdnCSender" type="hidden" />
                                <input id="hdnCReciver" type="hidden" />
                                <div class="portlet light ">
                                    <div class="portlet-title">
                                        <div class="caption">
                                            <i class="icon-bubble font-red-sunglo"></i>
                                            <span class="caption-subject font-red-sunglo bold uppercase">Company Level Comment</span>
                                        </div>
                                        <div class="actions">
                                        </div>
                                    </div>
                                    <div class="portlet-body" id="clientchats">
                                        <div class="scroller" style="height: 341px; overflow-y: scroll" data-always-visible="1" data-rail-visible1="1">
                                            <ul class="chats" id="clchts">
                                            </ul>
                                        </div>
                                        <div class="chat-form">
                                            <input type="radio" name="clcomplete" value="Public" id="clcomplete_public" class="clrdbtn1" checked="checked" />
                                            <label for="complete_public">Public</label>

                                            <input type="radio" name="clcomplete" value="Private" id="clcomplete_private" class="clrdbtn1" checked="checked" />
                                            <label for="complete_private">Private</label>

                                            <div class="input-cont">
                                                <input class="form-control" type="text" id="cltxtmsg" placeholder="Type a message here..." />
                                            </div>
                                            <div id="cldvchats" class="btn-cont" style="display: none">
                                                <span class="arrow"></span>
                                                <a href="javascript:" id="clanccom" class="btn blue icn-only">
                                                    <i class="fa fa-check icon-white"></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="tab-pane" id="password">
                            <div class="row">
                            <div class="padding40 dark col-md-6">
                                <span class="dark size18">Change Password</span>
                                <div class="line4"></div>
                        <asp:ChangePassword ID="ChangePassword1" runat="server">
                            <ChangePasswordTemplate>
                                <table cellspacing="0" cellpadding="1" style="border-collapse: collapse;">
                                    <tr>
                                        <td>
                                            <table cellpadding="0">
                                                <tr>
                                                    <td align="center" colspan="2"></td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label runat="server" AssociatedControlID="CurrentPassword" ID="CurrentPasswordLabel">Password:</asp:Label></td>
                                                    <td>
                                                        <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="CurrentPassword"></asp:TextBox>
                                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="CurrentPassword" ErrorMessage="Password is required." ValidationGroup="ChangePassword1" ToolTip="Password is required." ID="CurrentPasswordRequired">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label runat="server" AssociatedControlID="NewPassword" ID="NewPasswordLabel">New Password:</asp:Label></td>
                                                    <td>
                                                        <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="NewPassword"></asp:TextBox>
                                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="NewPassword" ErrorMessage="New Password is required." ValidationGroup="ChangePassword1" ToolTip="New Password is required." ID="NewPasswordRequired">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label runat="server" AssociatedControlID="ConfirmNewPassword" ID="ConfirmNewPasswordLabel">Confirm New Password:</asp:Label></td>
                                                    <td>
                                                        <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="ConfirmNewPassword"></asp:TextBox>
                                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmNewPassword" ErrorMessage="Confirm New Password is required." ValidationGroup="ChangePassword1" ToolTip="Confirm New Password is required." ID="ConfirmNewPasswordRequired">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2">
                                                        <asp:CompareValidator runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" ErrorMessage="The Confirm New Password must match the New Password entry." Display="Dynamic" ValidationGroup="ChangePassword1" ID="NewPasswordCompare"></asp:CompareValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2" style="color: Red;">
                                                        <asp:Literal runat="server" ID="FailureText" EnableViewState="False"></asp:Literal>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Button runat="server" CommandName="ChangePassword" CssClass="btnlog" Text="Change Password" ValidationGroup="ChangePassword1" ID="ChangePasswordPushButton"></asp:Button>
                                                    </td>
                                                    <td>
                                                        <asp:Button runat="server" CausesValidation="False" CssClass="btnlog" CommandName="Cancel" Text="Cancel" ID="CancelPushButton"></asp:Button>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </ChangePasswordTemplate>
                        </asp:ChangePassword>
</div></div>
                    </div>


                </div>
                <!-- End of Tab panes from left menu -->

            </div>
            <!-- END OF RIGHT CPNTENT -->

            <div class="clearfix"></div>
            <br />
            <br />
        </div>
        <!-- END CONTENT -->



    </div>

    <div class="modal fade bs-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                ...
            </div>
        </div>
    </div>
    <div id="UploadImage" class="modal fade" tabindex="-1" data-width="760">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true"></button>
            <h4 class="modal-title">Upload Pictre</h4>
        </div>
        <div class="modal-body">
            <input type="file" id="upldpic" />
        </div>
        <div class="modal-footer">
            <button type="button" data-dismiss="modal" class="btn btn-default">Close</button>
            <button type="button" class="btn blue" id="btnupload">Save changes</button>
        </div>
    </div>
    <!-- BEGIN PAGE LEVEL PLUGINS -->
    <script type="text/javascript" src="plugins/select2/select2.min.js"></script>
    <script type="text/javascript" src="plugins/datatables/media/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="plugins/datatables/extensions/TableTools/js/dataTables.tableTools.min.js"></script>
    <script type="text/javascript" src="plugins/datatables/extensions/ColReorder/js/dataTables.colReorder.min.js"></script>
    <script type="text/javascript" src="plugins/datatables/extensions/Scroller/js/dataTables.scroller.min.js"></script>
    <script type="text/javascript" src="plugins/datatables/plugins/bootstrap/dataTables.bootstrap.js"></script>
    <!-- END PAGE LEVEL PLUGINS -->
    <script type="text/javascript" src="assets/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js"></script>
    <script src="PageLevel_JS/Profile.js"></script>
    <script src="PageLevel_JS/Document.js"></script>
    <script src="PageLevel_JS/CertificateMaster.js"></script>
    <script src="PageLevel_JS/EmpExperience.js"></script>
    <script src="PageLevel_JS/Comment.js"></script>
    <script>

        $('.profile-tabs li a[href="#doc"]').click(function () {
            BindDocType();
            BindCountry();
            $('#DocumentTable').dataTable().fnDestroy();
            DocumentViewModel.init();

        });
        $('.profile-tabs li a[href="#Tranning"]').click(function () {
            BindCountry();
            BindCertificateType();
            $('#CertificateTable').dataTable().fnDestroy();
            CertificateViewModel.init();


        });
        $('.profile-tabs li a[href="#seaexp"]').click(function () {
            BindShipType();
            $('#EmpExperienceTable').dataTable().fnDestroy();
            EmpExperienceViewModel.init();


        });
        $('.profile-tabs li a[href="#comment"]').click(function () {

            bindComment();


        });
    </script>
</asp:Content>
