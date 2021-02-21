<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="WebClient.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen" />

    <form id="form1" align ="center">
        <div style="max-width: 400px;">
            <h2 class="form-signin-heading">
                Student Login</h2>
            <label for="plemail">
                Username</label>
            <asp:TextBox ID="plemail" runat="server" CssClass="form-control" placeholder="Enter your email"
                required />
            <br />
            <label for="plpasswd">
                Password</label>
            <asp:TextBox ID="plpasswd" runat="server" TextMode="Password" CssClass="form-control"
                placeholder="Enter Mobile No" required />
            <br />
            <asp:Button ID="btnplogin" Text="Sign In" runat="server" Class="btn btn-primary" OnClick="btnplogin_Click"/>
            <br />
            <br />
            <asp:Label ID="errplogin" runat="server" ForeColor="Red" />
            </div>
        </div>
    </form>

</asp:Content>