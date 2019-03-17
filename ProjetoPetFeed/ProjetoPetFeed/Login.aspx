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

        <div class="btns">
        <asp:Label ID="Label2" runat="server" Text="Quero me cadastrar: " CssClass="lblCadastrar"></asp:Label>
        <asp:Button ID="btnEmpresa" CssClass="Button2" runat="server" Text="Empresa" OnClick="btnEmpresa_Click" /><asp:Button CssClass="Button3" ID="btnCliente" OnClick="btnCliente_Click" runat="server" Text="Cliente" /></div>
            <div class="box-btn">
        <asp:TextBox ID="txtEmailEmpresa" placeholder="Digite o e-mail da empresa" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtCelularEmpresa" placeholder="Digite o telefone da empresa" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtNomeEmpresa" placeholder="Digite o nome da empresa" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtCPFEmpresa" placeholder="Digite o CPF do dono da empresa" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtRGEmpresa" placeholder="Digite o RG do dono da empresa" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtOrgaoEmpresa" placeholder="Digite o órgão emissor da empresa" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:Button ID="btnCadastrarEmpresa" CssClass="btnCadastrar" runat="server" Text="Cadastrar" Visible="false"/>
                </div>
    <div class="box-btn2">
        <asp:TextBox ID="txtNomeCliente" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtEmailCliente" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtCpfCliente" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtSenhaCliente" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtSenhaNovCliente" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <!--<asp:Label ID="lblPreferencia" CssClass="lblCliente" runat="server" Visible="false"></asp:Label>
        <asp:TextBox ID="txtDDDCliente" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>-->
        <asp:TextBox ID="txtCelularCliente" CssClass="txtEmpresa" runat="server" Visible="false"></asp:TextBox>
        <asp:CheckBox ID="chkTermos" CssClass="chkCliente" runat="server" Visible="false"/>
        <asp:Label ID="lblTermos" CssClass="lblCliente" runat="server" Visible="false"></asp:Label>
        <asp:Button ID="btnCadastrarCliente" CssClass="btnCadastrar" Text="Cadastrar" runat="server" Visible="false"/>
    </div>
</asp:Content>

