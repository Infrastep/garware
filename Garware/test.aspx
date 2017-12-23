<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Garware.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodycontent" runat="server">
    <asp:LoginView ID="LoginView1" runat="server">
           <AnonymousTemplate><h1>Please Login</h1></AnonymousTemplate>
            <RoleGroups>
                 <asp:RoleGroup >
                    <ContentTemplate>
                        Dont Have Permission to view
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup >                    
                    <ContentTemplate>
                       <div id="dvlo">Read write</div> 
                    </ContentTemplate>                    
                </asp:RoleGroup>
                <asp:RoleGroup >
                    <ContentTemplate>
                        <div id="dvlo">Only Read</div>
                    </ContentTemplate>
                </asp:RoleGroup>
            </RoleGroups>
        </asp:LoginView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footercontent" runat="server">
</asp:Content>
