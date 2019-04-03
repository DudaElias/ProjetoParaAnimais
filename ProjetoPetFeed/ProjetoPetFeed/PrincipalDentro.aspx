<%@ Page Title="" Language="C#" MasterPageFile="~/BaseDentro.master" AutoEventWireup="true" CodeFile="PrincipalDentro.aspx.cs" Inherits="PrincipalDentro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="search-box">
        <input class="search-txt" type="text" name="" placeholder="Type to search" />
        <a class="search-btn" href="#">
            <i class="fas fa-search"></i>
        </a>
    </div>
        <input type="checkbox" id="chk-filtro">
            <label for="chk-filtro" class="aa">
                <a class="img-filtro"><i class="fas fa-filter fa-2x"></i></a>
            </label>


    <ul id="filtros">
        <li class="filtro"><a class="qualFiltro">aaa   <i class="fas fa-times-circle"></i></a></li>
        <li class="filtro"><a class="qualFiltro">bbb   <i class="fas fa-times-circle"></i></a></li>
        <li class="filtro"><a class="qualFiltro">ccc   <i class="fas fa-times-circle"></i></a></li>
        <li class="filtro"><a class="qualFiltro">ddd   <i class="fas fa-times-circle"></i></a></li>
    </ul>

</asp:Content>

