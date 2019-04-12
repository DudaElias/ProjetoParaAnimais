<%@ Page Title="" Language="C#" MasterPageFile="~/BaseDentroEmpresa.master" AutoEventWireup="true" CodeFile="PerfilEmpresa.aspx.cs" Inherits="PerfilEmpresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="box">
        <asp:Label ID="Label1" runat="server" Text="Editar Dados da Empresa:" Width=440px CssClass="lblLogin"></asp:Label>
        <input id="txtNomeEm" type="text" placeholder="Nome"/>
        <input id="txtCpf" type="text" placeholder="CPF"/>
        <input id="txtEmail" type="email" placeholder="E-mail"/>
        <input id="senha" type="password" placeholder="Senha" />
        <input id="Button2" type="button" value="Cancelar" class="btn"/>
        <input id="Button1" type="button" value="Aplicar" class="btn"/>
    </div>
</asp:Content>

