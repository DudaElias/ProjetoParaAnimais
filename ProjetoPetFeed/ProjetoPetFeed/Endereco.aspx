<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/Base.master" CodeFile="Endereco.aspx.cs" Inherits="Endereco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
             <link rel="stylesheet" type="text/css" href="estilo.css" />
    <script type="text/javascript" src="login.js"></script>
    <div class="endereco">
        <asp:Label ID="Label1" runat="server" Text="Meus endereços:" CssClass="lbEndereco"></asp:Label>
        <input id="txtUF" type="text" placeholder="UF"/>
        <input id="txCidade" type="text" placeholder="Cidade"/>
        <input id="txtEndereco" type="text" placeholder="Endereco"/>
        <input id="txtNumero" type="text" placeholder="Número"/>
        <input id="txtComplemento" type="text" placeholder="Complemento"/>&nbsp;
        <input id="chkSemComplemento" type="checkbox">Sem complemento
        <input id="chkCasa" type="checkbox">Casa
        <input id="chkTrabalho" type="checkbox">Trabalho
        <input id="chkOutro" type="checkbox">Outro
        <input id="Text6" type="text" placeholder="Ponto de referência"/>
        <input id="btnVoltar" type="button" value="Voltar" class="btn"/>
        <input id="btnCadastrarEndereco" type="button" value="Cadastrar endereço" class="btn"/>
    </div>
     
</asp:Content>
