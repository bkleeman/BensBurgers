<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BensBurgers.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>We're listening.</h3>
    <address>
        137 W. North Bend Way<br />
        North Bend, WA 98045<br />
        <abbr title="Phone">P:</abbr>
        425.555.5511
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@bensburgers.com">Support@bensburgers.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@bensburgers.com">Marketing@bensburgers.com</a>
    </address>
</asp:Content>
