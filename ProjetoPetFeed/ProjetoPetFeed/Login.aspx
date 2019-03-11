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
        <asp:Button ID="btnLoja" CssClass="Button2" runat="server" Text="Loja" OnClick="btnLoja_Click" /><asp:Button CssClass="Button3" ID="btnCliente" OnClick="btnCliente_Click" runat="server" Text="Cliente" />
        
        <asp:TextBox ID="txtEmailLoja" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtCelularLoja" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtNomeLoja" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtCPFLoja" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtRGLoja" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtOrgaoLoja" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:Button ID="btnCadastrarLoja" CssClass="btnCadastrar" runat="server" Text="Cadastrar" Visible="false"/>

        <asp:TextBox ID="txtNomeCliente" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtEmailCliente" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtSenhaCliente" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtSenhaNovCliente" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:Label ID="lblPreferencia" CssClass="txtLoja" runat="server" Visible="false"></asp:Label>
        <asp:TextBox ID="txtDDDCliente" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtCelularCliente" CssClass="txtLoja" runat="server" Visible="false"></asp:TextBox>
        <asp:CheckBox ID="chkTermos" CssClass="txtLoja" runat="server" Visible="false"/>
        <asp:Label ID="lblTermos" CssClass="txtLoja" runat="server" Visible="false"></asp:Label>
        <asp:Button ID="btnCadastrarCliente" CssClass="btnCadastrar" Text="Cadastrar" runat="server" Visible="false"/>
    </div>
</asp:Content>

