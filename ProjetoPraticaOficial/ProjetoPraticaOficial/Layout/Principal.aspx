<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Base.master" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" type="text/css" href="../Content/estilo.css" /> 
    <div class="content">
        <img src="../Imagens/animais.jpg">
    </div>
 <!--
    <footer class="rodape">
        <div class="social-icons">
            <a href="#"><i class="fab fa-google-plus-g"></i></a>
            <a href="#"><i class="fab fa-youtube"></i></a>
            <a href="https://www.instagram.com/petfeed.shopping/?hl=pt-br" class="icone"><i class="fab fa-instagram"></i></a>
        </div>
        <span class="creditosFooter">PetFeed <i class="far fa-copyright"></i>Lorenna Joanna Leal Nunes e Maria Eduarda Elias Rocha. Todos os direitos reservados.</span>
    </footer>
            -->
    <footer class="s-mPrincipal">

        <p class="fPetFeed">PetFeed</p>
        <ul class="menuFooterP">
            <li><a href="Sobre nós.aspx">Sobre nós</a></li>
            <li><a href="Pergunta.aspx">Fale conosco</a></li>
        </ul>

        <p class="fDescubra">Descubra</p>
        <ul class="menuFooterD">
            <li><a href="#">Como pedir</a></li>
            <li><a href="#">Cadastre sua loja</a></li>
            <li><a href="#">Cadastre-se</a></li>
        </ul>

        <a class="icone" href="https://www.facebook.com/petfeed.shoping/?epa=SEARCH_BOX"><i class="fab fa-facebook-f"></i></a>
        <a href="https://www.instagram.com/petfeed.shopping/?hl=pt-br" class="icone"><i class="fab fa-instagram"></i></a>
        <a href="#" class="icone"><i class="fab fa-twitter"></i></a>
           
        <!--
        <a href="#"><i class="fab fa-google-plus-g"></i></a>         
        <a href="#"><i class="fab fa-youtube"></i></a> -->
        
        <hr class="hrFooter" />
        <span class="creditosFooter">PetFeed <i class="far fa-copyright"></i>Lorenna Joanna Leal Nunes e Maria Eduarda Elias Rocha. Todos os direitos reservados.</span>
    </footer>
   
</asp:Content>
