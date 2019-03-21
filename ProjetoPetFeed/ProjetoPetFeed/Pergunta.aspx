<%@ Page Title="" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="Pergunta.aspx.cs" Inherits="Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="estilo.css" />
    <script type="text/javascript" src="pergunta.js"></script>

    <a class="collapsible">aaaaaaaaaaa</a>
    <div class="content">
      <p>aaaaaaaaaaaaaa</p>
    </div>
    <a class="collapsible">vbbbbbbbbbbbbb</a>
    <div class="content">
      <p>BBBBBBBBBBBBBBBBBBBBBBBBBBB</p>
    </div>
    <a class="collapsible">cccccccccccccccc</a>
    <div class="content">
      <p>cccccccccccccccc</p>
    </div>
    <a class="collapsible">dddddddddddddddddd</a>
    <div class="content">
      <p>ddddddddddddddddddddddddd</p>
    </div>
    
    <script>

        var coll = document.getElementsByClassName("collapsible");
        var i;

        for (i = 0; i < coll.length; i++) {
            coll[i].addEventListener("click", function () {
                this.classList.toggle("active");
                var content = this.nextElementSibling;
                if (content.style.display === "block") {
                    content.style.display = "none";
                } else {
                    content.style.display = "block";
                }
            });
        }
    </script>
    <footer class="s-mPrincipal">
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
<span >PetFeed <i class="far fa-copyright"></i> Lorenna Joanna Leal Nunes e Maria Eduarda Elias Rocha. Todos os direitos reservados.</span>
        
</footer>
</asp:Content>

