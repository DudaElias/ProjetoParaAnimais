﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" type="text/css" href="estilo.css" />
    <div class="content">
        <img src="Imagens/animais.jpg"></div>
    <footer class="s-mPrincipal">
        <ul class="menuFooterP">
            <li><a href="Sobre nós.aspx">Sobre nós</a></li>
            <li><a href="Pergunta.aspx">Fale conosco</a></li>
        </ul>
        <ul class="menuFooterP">
            <li><a href="#">Como pedir</a></li>
            <li><a href="#">Cadastre sua loja</a></li>
            <li><a href="#">Cadastre-se</a></li>

        </ul>
        <!--<ul class="menuFooter">
                <a href="#">Sobre nós</a>
                <a href="#">Contato</a>
                <a href="#">Entrar ou cadastrar</a> 
        </ul>-->

        <a class="icone" href="https://www.facebook.com/petfeed.shoping/?epa=SEARCH_BOX"><i class="fab fa-facebook-f"></i></a>

        <a href="#" class="icone"><i class="fab fa-twitter"></i></a>

        <!--<a href="#"><i class="fab fa-google-plus-g"></i></a>
            
<a href="#"><i class="fab fa-youtube"></i></a>-->

        <a href="https://www.instagram.com/petfeed.shopping/?hl=pt-br" class="icone"><i class="fab fa-instagram"></i></a>
        <span>PetFeed <i class="far fa-copyright"></i>Lorenna Joanna Leal Nunes e Maria Eduarda Elias Rocha. Todos os direitos reservados.</span>

    </footer>
</asp:Content>

