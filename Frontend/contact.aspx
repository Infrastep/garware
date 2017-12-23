<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Frontend.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="PageLevel_JS/utility.js"></script>
    <script src="PageLevel_JS/Contact.js"></script>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SliderArea" runat="server">
    <div id="dajy" class="mtslide sliderbg fixed cstyle11">	
			<div id="map-canvas2"></div>
	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-200 z-index100">		
		  <div class="row">
			<div class="col-md-12">
				<div class="bs-example bs-example-tabs cstyle04">
				
					<div class="tab-content">

						<div class="col-md-4">
						
							<span class="opensans size24 slim">Contact</span>
							<input type="text" id="name" placeholder="Name" class="form-control logpadding margtop10" />
							<input type="text"  id="phone" placeholder="Phone" class="form-control logpadding margtop20" />
							<input type="text" id="email" placeholder="E-mail" class="form-control logpadding margtop20" />
						</div>
						<div class="col-md-4">
							<textarea rows="9" id="qry" class="form-control margtop10"></textarea>
						</div>
						<div class="col-md-4 opensans grey">
                            <input type="hidden" id="cemail"/>
                            <div id="dvadd"></div>
							<br/>
                            <div id="dvcon"></div>
						</div>
					</div>
					
					<div class="searchbg3">
						<button type="button" id="btnsubmit" class="btn-search right mr20">Send Email</button>
					</div>
						
				</div>
			</div>
		  </div>
		</div>
		

    <script type="text/javascript">

        $(document).ready(function () {
            bindContact();
        });

    </script>
</asp:Content>
