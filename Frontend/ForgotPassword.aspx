<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Frontend.ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SliderArea" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-200 offset-0">


        <!-- CONTENT -->
        <div class="col-md-12 pagecontainer2 offset-0">
            <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" OnSendingMail="PasswordRecovery1_SendingMail">
                <UserNameTemplate>
                    <table cellspacing="0" cellpadding="1" style="border-collapse: collapse;">
                        <tr>
                            <td>
                                <table cellpadding="0">
                                    <tr>
                                        <td align="center" colspan="2">Forgot Your Password?</td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2">Enter your User Name to receive your password.</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label runat="server" AssociatedControlID="UserName" ID="UserNameLabel">User Name:</asp:Label></td>
                                        <td>
                                            <asp:TextBox runat="server" ID="UserName"></asp:TextBox>
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ValidationGroup="PasswordRecovery1" ToolTip="User Name is required." ID="UserNameRequired">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color: Red;">
                                            <asp:Literal runat="server" ID="FailureText" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="2">
                                            <asp:Button runat="server" CommandName="Submit" Text="Submit" ValidationGroup="PasswordRecovery1" ID="SubmitButton"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </UserNameTemplate>
            </asp:PasswordRecovery>
        </div>
    </div>
</asp:Content>
