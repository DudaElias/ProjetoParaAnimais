<%@ Page Title="" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
             <link rel="stylesheet" type="text/css" href="estilo.css" />
    <script type="text/javascript" src="login.js"></script>
    <div class="box">
        <asp:Label ID="Label1" runat="server" Text="Já sou cadastrado:" CssClass="lblLogin"></asp:Label>
        <input id="Text1" type="text" placeholder="Usuário"/>
        <input id="Password1" type="password" placeholder="Senha" />
        <input id="Button1" type="button" value="Entrar" class="btn"/>
    </div>
<hr>
    <div class="box-btn">
        <asp:Label ID="Label2" runat="server" Text="Quero me cadastrar: " CssClass="lblCadastrar"></asp:Label>
         <input id="Button2" type="button" value="Loja" onclick="RecarregarLoja()" class="btn" /><input id="Button3" type="button" value="Cliente" onclick="RecarregarCliente()" class="btn"/>
    </div>
</asp:Content>

