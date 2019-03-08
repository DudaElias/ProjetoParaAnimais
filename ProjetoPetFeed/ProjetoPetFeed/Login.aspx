<%@ Page Title="" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
             <link rel="stylesheet" type="text/css" href="estilo.css" />
    <div class="box">
        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        <input id="Text1" type="text" placeholder="Username"/>
        <input id="Password1" type="password" placeholder="Password" />
        <input id="Button1" type="button" value="Login" class="btn"/>
    </div>
</asp:Content>

