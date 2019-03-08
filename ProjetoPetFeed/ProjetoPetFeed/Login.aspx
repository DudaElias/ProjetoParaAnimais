<%@ Page Title="" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
             <link rel="stylesheet" type="text/css" href="estilo.css" />
    <div class="box">
        <asp:Label ID="Label1" runat="server" Text="Já sou cadastrado:" CssClass="lblLogin"></asp:Label>
        <input id="Text1" type="text" placeholder="Usuário"/>
        <input id="Password1" type="password" placeholder="Senha" />
        <input id="Button1" type="button" value="Entrar" class="btn"/>
    </div>
<div class="linha-vertical"></div>
</asp:Content>

