<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="associates.aspx.cs" Inherits="Frontend.associates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SliderArea" runat="server">
<%--    <div class="mtslide2 sliderbg2"></div>--%>
   
    <div class="fullwidthbanner" style="display:none">
                            <ul id="foo1">

                                <!-- papercut fade turnoff flyin slideright slideleft slideup slidedown-->

                              

                               
                            </ul>
                            <div class="tp-bannertimer none"></div>
                        </div>
     <script type="text/x-kendo-template" id="template1">
           
                                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">
                                    <img src="#:PICTURE#" alt="" />

                                    <div class="tp-caption scrolleffect sft"
							 data-x="center"
							 data-y="120"
							 data-speed="1000"
							 data-start="800"
							 data-easing="easeOutExpo">
							 <div class="sboxpurple textcenter">
								<span class="lato size28 slim caps white">#:CLIENT_NAME#</span><br/><br/><br/>
								
							 </div>
						</div>

                                </li>
                      
                         
                    </script>
                    <script>

                        jQuery(function () {

                            var urlToHandler = "/Handler/ClientMasterHandler.ashx";
                            var jsonData;
                            jsonData = '{ "Method": "GetCLM"}';
                            var rslt = utility.ajax(urlToHandler, jsonData, false, false, false);
                            orders = rslt;


                            var clientDataSource = new kendo.data.HierarchicalDataSource({ data: orders, pageSize: 4 });


                            jQuery("#foo1").kendoListView({
                                dataSource: clientDataSource,


                                template: kendo.template(jQuery("#template1").html()),
                                dataBound: function () {
                                    DisplayNoResultsFound();
                                }

                            });



                        });






                        function DisplayNoResultsFound() {


                        }

                    </script>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-200 z-index100">
        <div class="container pagecontainer offset-0">
            <div class="rightcontent col-md-12 offset-0">

                <div class="hpadding20">
                    <!-- Top filters -->
                    <div class="topsortby">
                        OUR ASSOCIATES
						<%--<div class="col-md-4 offset-0">
								
								<div class="left mt7"><b>Sort by:</b></div>
								
								<div class="right wh70percent">
									<select class="form-control mySelectBoxClass ">
									  <option selected>Guest rating</option>
									  <option>5 stars</option>
									  <option>4 stars</option>
									  <option>3 stars</option>
									  <option>2 stars</option>
									  <option>1 stars</option>
									</select>
								</div>

						</div>			
						<div class="col-md-4">
							<div class="w50percent">
								<div class="wh90percent">
									<select class="form-control mySelectBoxClass ">
									  <option selected>Name</option>
									  <option>A to Z</option>
									  <option>Z to A</option>
									</select>
								</div>
							</div>
							<div class="w50percentlast">
								<div class="wh90percent">
									<select class="form-control mySelectBoxClass ">
									  <option selected>Price</option>
									  <option>Ascending</option>
									  <option>Descending</option>
									</select>
								</div>
							</div>					
						</div>
						<div class="col-md-4 offset-0">
							<button class="popularbtn left">Most Popular</button>
							<div class="right">
								<button class="gridbtn active">&nbsp;</button>
								<button class="listbtn" onClick="window.open('list4.html','_self');">&nbsp;</button>
								<button class="grid2btn" onClick="window.open('list3.html','_self');">&nbsp;</button>
							</div>
						</div>--%>
                    </div>
                    <!-- End of topfilters-->
                </div>
                <!-- End of padding -->

                <br />
                <br />
                <div class="clearfix"></div>


                <div class="itemscontainer offset-1">
                    <div class="wrapper">
                        <div class="list_carousel">
                            <ul id="foo2">
                            </ul>
                            <div class="clearfix"></div>
                        <a id="prev_btn2" class="prev" href="#">
                            <img src="images/spacer.png" alt="" /></a>
                        <a id="next_btn2" class="next" href="#">
                            <img src="images/spacer.png" alt="" /></a>
                        </div>
                    </div>
                    <script type="text/x-kendo-template" id="template2">
                        <li>
                                <a href="list2.html">
                                    <img src="#:PHOTO#" alt="" height="179px" width="255px" /></a>
                                <div class="m1">
                                    <h6 class="lh1 dark"><b>#:VNAME#</b></h6>
                                  
                                </div>
                            </li>
                         
                    </script>
                    <script>

                        jQuery(function () {

                            var urlToHandler = "/Handler/ShipMasterHandler.ashx";
                            var jsonData;
                            jsonData = '{ "Method": "GetSM"}';
                            var rslt = utility.ajax(urlToHandler, jsonData, false, false, false);
                            orders = rslt;


                            var clientDataSource = new kendo.data.HierarchicalDataSource({ data: orders, pageSize: 4 });


                            jQuery("#foo2").kendoListView({
                                dataSource: clientDataSource,


                                template: kendo.template(jQuery("#template2").html()),
                                dataBound: function () {
                                    DisplayNoResultsFound();
                                }

                            });



                        });






                        function DisplayNoResultsFound() {


                        }

                    </script>
                </div>
            </div>
        </div>
    </div>
     <script src="kendu/kendo.web.min.js"></script>
    <script type="text/javascript" src="../../assets/js/js-list4.js"></script>
    <script type="text/javascript" src="../../assets/js/js-list3.js"></script>
</asp:Content>
