<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.cs" Inherits="WebClient.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen" />

    <form id="form1" align ="center">
        <div style="max-width: 400px;">
            <h2 class="form-signin-heading">
                Students's Registration</h2>
            <label for="ptname">
                Full Name</label>
            <asp:TextBox ID="ptname" runat="server" CssClass="form-control" placeholder="Enter Full Name"
                required />
            <br />
            <label for="ptemail">
                Email</label>
            <asp:TextBox ID="ptemail" runat="server" TextMode="Email" CssClass="form-control" placeholder="Enter Email"
                required />
            <br />
            <label for="ptcontact">
                Mobile No</label>
            <asp:TextBox ID="ptcontact" runat="server" CssClass="form-control" placeholder="Enter Mobile No"
                required />
            <br />
            <label for="pcm">
                PCM Marks</label>
            <asp:TextBox ID="pcm" runat="server" CssClass="form-control"
                placeholder="Enter your PCM Marks" required />
            <br />
            <label for="guj">
                GUJCET Marks</label>
            <asp:TextBox ID="guj" runat="server" CssClass="form-control"
                placeholder="Enter your GUJCEt Marks" required />
            <br />
            <asp:Button ID="btnregister" Text="Register" runat="server" Class="btn btn-primary" OnClick="btnregister_Click"/>
            <br />
            <br />
            <asp:Label ID="errreg" runat="server" ForeColor="#FF3300" />
        </div>
        </div>
    </form>

</asp:Content>