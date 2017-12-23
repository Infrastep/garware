<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Front.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="assets/global/plugins/fancybox/source/jquery.fancybox.css" rel="stylesheet">
  <link href="assets/global/plugins/carousel-owl-carousel/owl-carousel/owl.carousel.css" rel="stylesheet">
  <link href="assets/global/plugins/slider-revolution-slider/rs-plugin/css/settings.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- BEGIN SLIDER -->
    <div id="Home" class="page-slider margin-bottom-40" style="margin-bottom: -30px !important;">
      <div class="fullwidthbanner-container revolution-slider">
        <div class="fullwidthabnner">
          <ul id="revolutionul">
            <!-- THE NEW SLIDE -->
            <li data-transition="fade" data-slotamount="8" data-masterspeed="700" data-delay="9400" data-thumb="assets/frontend/pages/img/revolutionslider/thumbs/thumb2.jpg">
              <!-- THE MAIN IMAGE IN THE FIRST SLIDE -->
         <img src="Upload/Slider/52627_ships_container_ship.jpg" />
              
              
              <div class="caption  slide_title_white slide_item_left " style="background:rgba(0,0,0,.7);padding:0 10px;"
                data-x="30"
                data-y="160"
                data-speed="400"
                data-start="1500"
                data-easing="easeOutExpo">
                Get Enrolled today<br><span class="slide_title_white_bold">With DSG </span>
              </div>
            
              <a class="caption center-block   btn dark slide_btn slide_item_left" href="http://themeforest.net/item/metronic-responsive-admin-dashboard-template/4021469?ref=keenthemes"
                data-x="170"
                data-y="315"
                data-speed="400"
                data-start="3000"
                data-easing="easeOutExpo">
                Register
              </a>   
                 <a class="caption  btn dark slide_btn slide_item_left" href="http://themeforest.net/item/metronic-responsive-admin-dashboard-template/4021469?ref=keenthemes"
                data-x="287"
                data-y="315"
                data-speed="400"
                data-start="3000"
                data-easing="easeOutExpo">
                Login
              </a>                          
          
            </li>    


           
                </ul>
                <div class="tp-bannertimer tp-bottom"></div>
            </div>
        </div>
    </div>
    <!-- END SLIDER -->
    <div class="main">
      <div class="container">
        <div id="About" class="row padding-top-45 col-md-12">&nbsp;</div>
          
          <!-- BEGIN STEPS -->
        <div  class="row margin-bottom-40 front-steps-wrapper front-steps-count-3">
            
          <div class="col-md-4 col-sm-4 front-step-col">
            <div class="front-step front-step1">
              <h2>Register Yourself </h2>
              <p>Fill our registration form and upload your entire details along with all necessery documents </p>
            </div>
          </div>
          <div class="col-md-4 col-sm-4 front-step-col">
            <div class="front-step front-step2">
              <h2>Get verified </h2>
              <p>Our Executive will contact you and verify all documents<br/>&nbsp;</p>
            </div>
          </div>
          <div class="col-md-4 col-sm-4 front-step-col">
            <div class="front-step front-step3">
              <h2>Get Assigned </h2>
              <p>After verification process done we can assign you in ship<br/>&nbsp;</p>
            </div>
          </div>
        </div>
        <!-- END STEPS -->
        
        <!-- BEGIN BLOCKQUOTE BLOCK -->   
        <div class="row quote-v1 margin-bottom-30">
          <div class="col-md-9">
            <span>DSG - We are hiring for multiple Ships Around The Globe</span>
          </div>
          <div class="col-md-3 text-right">
            <a class="btn-transparent" href="#" target="_blank"><i class="fa fa-rocket margin-right-10"></i>Register Today</a>
          </div>
        </div>
        <!-- END BLOCKQUOTE BLOCK -->

        <!-- BEGIN RECENT WORKS -->
        <div id="Associate" class="row recent-work margin-bottom-40">
            <div class="padding-top-60">&nbsp;</div>
          <div class="col-md-3">
            <h2><a href="portfolio.html">Hiring Open</a></h2>
            <p>Lorem ipsum dolor sit amet, dolore eiusmod quis tempor incididunt ut et dolore Ut veniam unde voluptatem. Sed unde omnis iste natus error sit voluptatem.</p>
          </div>
          <div class="col-md-9">
            <div class="owl-carousel owl-carousel3">
              <div class="recent-work-item">
                <em>
        
                  <img src="Upload/Ship/bahamas.jpg" alt="Amazing Project" class="img-responsive">
                  <a href="portfolio-item.html"><i class="fa fa-link"></i></a>
                  <a href="Upload/Ship/bahamas.jpg" class="fancybox-button" title="Project Name #1" data-rel="fancybox-button"><i class="fa fa-search"></i></a>
                </em>
                <a class="recent-work-description" href="javascript:;">
                  <strong>Apj Shipping</strong>
                  <b>Hiring Open.</b>
                </a>
              </div>
              <div class="recent-work-item">
                <em>
                  <img src="Upload/Ship/paris.jpg" alt="Amazing Project" class="img-responsive">
                  <a href="portfolio-item.html"><i class="fa fa-link"></i></a>
                  <a href="Upload/Ship/paris.jpg" class="fancybox-button" title="Project Name #2" data-rel="fancybox-button"><i class="fa fa-search"></i></a>
                </em>
                <a class="recent-work-description" href="javascript:;">
                  <strong>Global Offshore</strong>
                  <b>Hiring Open.</b>
                </a>
              </div>
              <div class="recent-work-item">
                <em>
                  <img src="Upload/Ship/rome.jpg" alt="Amazing Project" class="img-responsive">
                  <a href="portfolio-item.html"><i class="fa fa-link"></i></a>
                  <a href="Upload/Ship/rome.jpg" class="fancybox-button" title="Project Name #3" data-rel="fancybox-button"><i class="fa fa-search"></i></a>
                </em>
                <a class="recent-work-description" href="javascript:;">
                  <strong>DSG</strong>
                  <b>Hiring Open.</b>
                </a>
              </div>
              <div class="recent-work-item">
                <em>
                  <img src="Upload/Ship/santorini.jpg" alt="Amazing Project" class="img-responsive">
                  <a href="portfolio-item.html"><i class="fa fa-link"></i></a>
                  <a href="Upload/Ship/santorini.jpg" class="fancybox-button" title="Project Name #4" data-rel="fancybox-button"><i class="fa fa-search"></i></a>
                </em>
                <a class="recent-work-description" href="javascript:;">
                  <strong>India Steam Ship</strong>
                  <b>Hiring Open.</b>
                </a>
              </div>
              
            </div>       
          </div>
        </div>   
        <!-- END RECENT WORKS -->

    

        

        <!-- BEGIN CLIENTS -->
        <div class="row margin-bottom-40 our-clients">
          <div class="col-md-3">
            <h2><a href="javascript:;">Our Clients</a></h2>
            <p>Lorem dipsum folor margade sitede lametep eiusmod psumquis dolore.</p>
          </div>
          <div class="col-md-9">
            <div class="owl-carousel owl-carousel6-brands">
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_1_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_1.png" class="color-img img-responsive" alt="">
                </a>
              </div>
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_2_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_2.png" class="color-img img-responsive" alt="">
                </a>
              </div>
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_3_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_3.png" class="color-img img-responsive" alt="">
                </a>
              </div>
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_4_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_4.png" class="color-img img-responsive" alt="">
                </a>
              </div>
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_5_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_5.png" class="color-img img-responsive" alt="">
                </a>
              </div>
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_6_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_6.png" class="color-img img-responsive" alt="">
                </a>
              </div>
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_7_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_7.png" class="color-img img-responsive" alt="">
                </a>
              </div>
              <div class="client-item">
                <a href="javascript:;">
                  <img src="assets/frontend/pages/img/clients/client_8_gray.png" class="img-responsive" alt="">
                  <img src="assets/frontend/pages/img/clients/client_8.png" class="color-img img-responsive" alt="">
                </a>
              </div>                  
            </div>
          </div>          
        </div>
        <!-- END CLIENTS -->
      </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="assets/global/plugins/fancybox/source/jquery.fancybox.pack.js" type="text/javascript"></script><!-- pop up -->
    <script src="assets/global/plugins/carousel-owl-carousel/owl-carousel/owl.carousel.min.js" type="text/javascript"></script><!-- slider for products -->
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
  <script type="text/javascript">
      jQuery(document).ready(function () {
          Layout.init();
          Layout.initOWL();
          RevosliderInit.initRevoSlider();
          Layout.initTwitter();
          Layout.initFixHeaderWithPreHeader(); /* Switch On Header Fixing (only if you have pre-header) */
          Layout.initNavScrolling(); 
      });
    </script>
    </asp:Content>