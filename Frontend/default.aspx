<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Frontend._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="PageLevel_JS/login.js"></script>
    <script src="assets/js/validator.js"></script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SliderArea" runat="server">
    <!-- Blue background -->
    <div class="mtslide2 sliderbg2"></div>
    <!-- / Blue background -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="slideup">
        <div class="container z-index100">
            <div class="slidercontainer">

                <div class="row">
                    <div class="col-md-4 scolleft">


                        <ul class="nav nav-tabs" id="myTab">
                            <li onclick="mySelectUpdate()" class="active"><a data-toggle="tab" href="#login">Log In</a></li>
                            <li onclick="mySelectUpdate()" class=""><a data-toggle="tab" href="#registration">Registration</a></li>

                        </ul>


                        <div class="tab-content" id="myTabContent">
                            <!-- CRUISE TAB -->
                            <div class="tab-pane fade active in" id="login">
                                <%-- <h2>Login</h2><hr />
							<div class="clearfix"></div><br/>--%>

                                <div class="fullwidth">
                                    <div class="form-group">
                                        <span class="opensans size13"><b>Email</b></span>
                                        <input type="text" class="form-control " id="email" pattern="^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$" data-error="Email is invalid" required />
                                        <span class="help-block with-errors"></span>
                                    </div>
                                    <br />
                                    <div class="form-group">
                                        <span class="opensans size13"><b>Password</b></span>
                                        <input type="password" class="form-control " id="psw" data-error="Password required" required /><span class="help-block with-errors"></span>
                                    </div>
                                    <div id="dverror" style="color: red"></div>
                                </div>
                                <div class="clearfix"></div>
                                <a href="ForgotPassword.aspx">Forgot Password?</a>
                                <div class="form-group">
                                    <button type="submit" class="btn-search3 btn btn-primary" id="btnlog">Login</button>
                                </div>

                            </div>
                            <!-- END OF CRUISE TAB -->
                            <!-- CRUISE TAB -->
                            <div class="tab-pane fade" id="registration">
                                <%-- <h2>Login</h2><hr />
							<div class="clearfix"></div><br/>--%>
                                <div class="fullwidth">
                                    <div class="row">
                                        <div class="form-group col-md-6">
                                            <span class="opensans size13"><b>First Name</b></span>

                                            <input type="text" class="form-control " id="fname" data-error="First name required" required />
                                            <span class="help-block with-errors"></span>
                                        </div>

                                        <div class="form-group col-md-6">
                                            <span class="opensans size13"><b>Middle Name</b></span>
                                            <input type="text" class="form-control " id="mname" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="form-group col-md-6">
                                            <span class="opensans size13"><b>Last Name</b></span>
                                            <input type="text" class="form-control " id="lname" data-error="Last name required" required />
                                            <span class="help-block with-errors"></span>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <span class="opensans size13"><b>Email</b></span>
                                            <input type="text" class="form-control " id="uemail" placeholder="Email" pattern="^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$" data-error="Email is invalid" required />
                                            <span class="help-block with-errors"></span>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="form-group col-md-6">
                                            <span class="opensans size13"><b>CDC Number</b></span>
                                            <input type="text" class="form-control " id="cdcnum" data-minlength="6" data-error="CDC number is invalid" required />
                                            <span class="help-block with-errors"></span>
                                        </div>



                                        <div class="form-group col-md-6">
                                            <span class="opensans size13"><b>Password</b></span>
                                            <input type="password" class="form-control " id="upsw" data-minlength="6" data-error="Password minimum 6 characters" required />
                                            <span class="help-block with-errors"></span>
                                        </div>
                                    </div>
                                    <div id="dvrgnerror" style="color: red"></div>
                                </div>
                                <div class="clearfix"></div>
                                <br />
                                <br />
                                <div class="form-group">
                                    <button type="submit" class="btn-search3" id="btnregister">Register</button>
                                </div>
                            </div>
                            <!-- END OF CRUISE TAB -->
                        </div>


                    </div>
                    <div class="col-md-8 scolright">

                        <!--
							#################################
								- THEMEPUNCH BANNER -
							#################################
							-->

                        <div class="fullwidthbanner">
                            <ul>

                                <!-- papercut fade turnoff flyin slideright slideleft slideup slidedown-->

                                <!-- FADE -->
                                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">
                                    <img src="images/slider/bahamas.jpg" alt="" />

                                    <div class="tp-caption sfb"
                                        data-x="left"
                                        data-y="300"
                                        data-speed="1000"
                                        data-start="800"
                                        data-easing="easeOutExpo">
                                        <div class="blacklable">
                                            <h4 class="lato bold white">Hiring Open for APJ JAI &nbsp; <span class="green">Crew</span>&nbsp; Upload Resume - Today</h4>
                                        </div>
                                    </div>

                                </li>

                                <!-- FADE -->
                                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">
                                    <img src="images/slider/rome.jpg" alt="" />

                                    <div class="tp-caption sfb"
                                        data-x="left"
                                        data-y="300"
                                        data-speed="1000"
                                        data-start="800"
                                        data-easing="easeOutExpo">
                                        <div class="blacklable">
                                            <h4 class="lato bold white">Hiring Open for india steam ship&nbsp; <span class="green">Crew</span>&nbsp;Upload Resume - Today</h4>
                                        </div>
                                    </div>
                                </li>

                                <!-- FADE -->
                                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">

                                    <img src="images/slider/paris.jpg" alt="" />

                                    <div class="tp-caption sfb"
                                        data-x="left"
                                        data-y="300"
                                        data-speed="1000"
                                        data-start="800"
                                        data-easing="easeOutExpo">
                                        <div class="blacklable">
                                            <h4 class="lato bold white">Hiring Open for GARWARE&nbsp; <span class="green">Crew</span>&nbsp; Upload Resume - Today</h4>
                                        </div>
                                    </div>
                                </li>

                                <!-- FADE -->
                                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">
                                    <img src="images/slider/zakynthos.jpg" alt="" />

                                    <div class="tp-caption sfb"
                                        data-x="left"
                                        data-y="300"
                                        data-speed="1000"
                                        data-start="800"
                                        data-easing="easeOutExpo">
                                        <div class="blacklable">
                                            <h4 class="lato bold white">Hiring Open for MSC Cruises &nbsp;<span class="green">Crew</span> &nbsp;Upload Resume - Today</h4>
                                        </div>
                                    </div>
                                </li>

                                <!-- FADE -->
                                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">
                                    <img src="images/slider/santorini.jpg" alt="" />

                                    <div class="tp-caption sfb"
                                        data-x="left"
                                        data-y="300"
                                        data-speed="1000"
                                        data-start="800"
                                        data-easing="easeOutExpo">
                                        <div class="blacklable">
                                            <h4 class="lato bold white">Hiring Open for Phoenix Reisen &nbsp;<span class="green">Crew</span>&nbsp; Upload Resume - Todayk</h4>
                                        </div>
                                    </div>
                                </li>

                            </ul>
                            <div class="tp-bannertimer none"></div>
                        </div>

                        <!--
						##############################
						 - ACTIVATE THE BANNER HERE -
						##############################
						-->
                        <script type="text/javascript">

                            var tpj = jQuery;
                            tpj.noConflict();

                            tpj(document).ready(function () {

                                if (tpj.fn.cssOriginal != undefined)
                                    tpj.fn.css = tpj.fn.cssOriginal;

                                var api = tpj('.fullwidthbanner').revolution(
                                    {
                                        delay: 9000,
                                        startwidth: 960,
                                        startheight: 370,

                                        onHoverStop: "on",						// Stop Banner Timet at Hover on Slide on/off

                                        thumbWidth: 100,							// Thumb With and Height and Amount (only if navigation Tyope set to thumb !)
                                        thumbHeight: 50,
                                        thumbAmount: 3,

                                        hideThumbs: 0,
                                        navigationType: "bullet",				// bullet, thumb, none
                                        navigationArrows: "solo",				// nexttobullets, solo (old name verticalcentered), none

                                        navigationStyle: "round",				// round,square,navbar,round-old,square-old,navbar-old, or any from the list in the docu (choose between 50+ different item), custom


                                        navigationHAlign: "right",				// Vertical Align top,center,bottom
                                        navigationVAlign: "bottom",					// Horizontal Align left,center,right
                                        navigationHOffset: 30,
                                        navigationVOffset: 30,

                                        soloArrowLeftHalign: "left",
                                        soloArrowLeftValign: "center",
                                        soloArrowLeftHOffset: 20,
                                        soloArrowLeftVOffset: 0,

                                        soloArrowRightHalign: "right",
                                        soloArrowRightValign: "center",
                                        soloArrowRightHOffset: 20,
                                        soloArrowRightVOffset: 0,

                                        touchenabled: "on",						// Enable Swipe Function : on/off


                                        stopAtSlide: -1,							// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
                                        stopAfterLoops: -1,						// Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic

                                        hideCaptionAtLimit: 0,					// It Defines if a caption should be shown under a Screen Resolution ( Basod on The Width of Browser)
                                        hideAllCaptionAtLilmit: 0,				// Hide all The Captions if Width of Browser is less then this value
                                        hideSliderAtLimit: 0,					// Hide the whole slider, and stop also functions if Width of Browser is less than this value


                                        fullWidth: "on",

                                        shadow: 1								//0 = no Shadow, 1,2,3 = 3 Different Art of Shadows -  (No Shadow in Fullwidth Version !)

                                    });






                                // TO HIDE THE ARROWS SEPERATLY FROM THE BULLETS, SOME TRICK HERE:
                                // YOU CAN REMOVE IT FROM HERE TILL THE END OF THIS SECTION IF YOU DONT NEED THIS !
                                api.bind("revolution.slide.onloaded", function (e) {


                                    jQuery('.tparrows').each(function () {
                                        var arrows = jQuery(this);

                                        var timer = setInterval(function () {

                                            if (arrows.css('opacity') == 1 && !jQuery('.tp-simpleresponsive').hasClass("mouseisover"))
                                                arrows.fadeOut(300);
                                        }, 3000);
                                    })

                                    jQuery('.tp-simpleresponsive, .tparrows').hover(function () {
                                        jQuery('.tp-simpleresponsive').addClass("mouseisover");
                                        jQuery('body').find('.tparrows').each(function () {
                                            jQuery(this).fadeIn(300);
                                        });
                                    }, function () {
                                        if (!jQuery(this).hasClass("tparrows"))
                                            jQuery('.tp-simpleresponsive').removeClass("mouseisover");
                                    })
                                });
                                // END OF THE SECTION, HIDE MY ARROWS SEPERATLY FROM THE BULLETS

                            });




                            jQuery(document).ready(function ($) {
                                // gets the width of black bar at the bottom of the slider
                                var $gwsr = $('.scolright').outerWidth();
                                $('.blacklable').css({ 'width': $gwsr + 'px' });
                            });
                            jQuery(window).resize(function () {
                                jQuery(document).ready(function ($) {

                                    // gets the width of black bar at the bottom of the slider
                                    var $gwsr = $('.scolright').outerWidth();
                                    $('.blacklable').css({ 'width': $gwsr + 'px' });

                                });
                            });






                        </script>


                    </div>

                </div>
                <!-- end of row -->
            </div>
        </div>
    </div>

    <div class="padding10 text-center grey" style="background: #eee">
        <div class="container">
            <marque> LAST MINUTE: <b>Barcelona</b> - 2 nights - Flight+4* Hotel, Dep 27h Aug from $209/person</marque>
        </div>
    </div>

    <div class="container ">



        <div class="row anim3">
            <%--<div class="col-md-12">
                <h2>Associated Company<br />
                </h2>
                <br />

            </div>--%>
            <div class="col-md-12">

                <!-- Carousel -->
                <div class="wrapper padding20" style="padding-left:40px;padding-right:40px">
                    <div class="list_carousel">
                        <ul id="foo2">
                            <li>
                                <a href="list2.html">
                                    <img src="images/slider/bahamas.jpg" alt="" height="179px" width="255px" /></a>
                                <div class="m1">
                                    <h6 class="lh1 dark"><b>APJ</b></h6>
                                    <h6 class="lh1 green">Hiring</h6>
                                </div>
                            </li>
                            <li>
                                <a href="list2.html">
                                    <img src="images/slider/paris.jpg" alt="" height="179px" width="255px" /></a>
                                <div class="m1">
                                    <h6 class="lh1 dark"><b>Garware</b></h6>
                                    <h6 class="lh1 green">Hiring</h6>
                                </div>
                            </li>
                            <li>
                                <a href="list2.html">
                                    <img src="images/slider/bahamas.jpg" alt="" height="179px" width="255px" /></a>
                                <div class="m1">
                                    <h6 class="lh1 dark"><b>APJ</b></h6>
                                    <h6 class="lh1 green">Hiring</h6>
                                </div>
                            </li>
                            <li>
                                <a href="list2.html">
                                    <img src="images/slider/rome.jpg" alt="" height="179px" width="255px" /></a>
                                <div class="m1">
                                    <h6 class="lh1 dark"><b>India Steam Ltd</b></h6>
                                    <h6 class="lh1 green">Hiring</h6>
                                </div>
                            </li>
                            <li>
                                <a href="list2.html">
                                    <img src="images/slider/santorini.jpg" alt="" height="179px" width="255px" /></a>
                                <div class="m1">
                                    <h6 class="lh1 dark"><b>Phoenix Reisen</b></h6>
                                    <h6 class="lh1 green">Hiring</h6>
                                </div>
                            </li>
                            <li>
                                <a href="list2.html">
                                    <img src="images/slider/zakynthos.jpg" alt="" height="179px" width="255px" /></a>
                                <div class="m1">
                                    <h6 class="lh1 dark"><b>MSC Cruises </b></h6>
                                    <h6 class="lh1 green">Hiring</h6>
                                </div>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                        <a id="prev_btn2" class="prev" href="#">
                            <img src="images/spacer.png" alt="" /></a>
                        <a id="next_btn2" class="next" href="#">
                            <img src="images/spacer.png" alt="" /></a>
                    </div>
                </div>

            </div>
        </div>

    </div>


</asp:Content>
