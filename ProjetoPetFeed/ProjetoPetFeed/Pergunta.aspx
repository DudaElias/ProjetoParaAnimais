﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.master" AutoEventWireup="true" CodeFile="Pergunta.aspx.cs" Inherits="Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" type="text/css" href="estilo.css" />
    <script type="text/javascript" src="pergunta.js"></script>
    <div class="faq">
        <p>Pagamento</p>
        <a class="collapsible">Não consigo pagar online</a>
        <div class="conteudo">
            <p>O primeiro passo para conseguir pagar online é verificar se os dados do cartão estão cadastrados corretamento no site. Se estiver tudo certo, pedimos que você entre em contato com a emissora do cartão para entender se existe algum problema. Caso esteja tudo correto e , ainda assim, você não conseguir pagar online, pedimos que entre em contato com a gente.<br />
                <br />
                Ainda precisa de ajuda?
                <br />
            </p>
        </div>
        <a class="collapsible">Tive uma cobrança indevida</a>
        <div class="conteudo">
            <p>Para solicitar estorno de uma cobrança indevida, pedimos que envie uma mensagem pra gente contendo os dados do pedido e, principalmente, o comprovante de cobrança. Assim, com essas informações em mãos, poderemos entender seu caso e providenciar o estorno do valor cobrado indevidamente.
                <br />
                <br />
                Ainda precisa de ajuda?
                <br />
            </p>
        </div>
        <a class="collapsible">Não recebi meu estorno</a>
        <div class="conteudo">
            <p>Caso você não tenha recebido o estorno solicitado por conta de uma cobrança indevida, pedimos que envie uma mensagem pra gente contendo os dados do pedido e, principalmente, o comprovante de cobrança. Assim, com essas informações em mãos, poderemos entender seu caso e providenciar o estorno do valor cobrado indevidamente.</p>
                <br />
                <br />
                Ainda precisa de ajuda?
                <br />
        </div>
        <p>Conta e Privacidade</p>
        <a class="collapsible">Minha conta foi invadida por alguém</a>
        <div class="conteudo">
            <p>O acesso indevido à sua conta pode ter ocorrido pelo comprometimento da sua senha. Se a mesma senha é usada em mais de um serviço, um icidente de segurança em um destes dos serviços pode comprometer os outros. Se isso aconteceu, saiba que o invasor não teve acesso aos seus dados de pagamento no PetFeed, pois eles ficam salvos apenas no seu dispositivo (tablet, computador ou celular). Nesse caso, recomendamos a alteração da sua senha para uma nova mais forte, preferencialmente utilizando letras maiúscula e caracteres especiais (por exemplo #, @, !, etc).</p>
                <br />
                <br />
                Ainda precisa de ajuda?
                <br />
        </div>
        <a class="collapsible">Não encontro meu endereço</a>
        <div class="conteudo">
            <p>Se o seu CEP está errado ou se você teve qualquer outro problema para encontrar a sua localização no site, pedimos que envie uma mensagem pra gente com seu endereço correto e completo. Assim, poderemos trabalhar para melhorar nossa precisão de localização</p>
                <br />
                <br />
                Ainda precisa de ajuda?
                <br />
        </div>
        <a class="collapsible">Quero exluir uma avaliação que eu fiz</a>
        <div class="conteudo">
            <p>Entendemos que às vezes podemos mudar de ideia! Para que nosso time te ajude a excluir uma avaliação, envie uma mensagem para o PetFeed.</p>
                <br />
                <br />
                Ainda precisa de ajuda?
                <br />
        </div>
        <a class="collapsible">Quero exluir minha conta</a>
        <div class="conteudo">
            <p>Sentimos muito pela sua escolha de deixar o PetFeed. Para desativarmos a sua conta, é necessário que nos envie uma mensagem. Se você quiser voltar a fazer pedido conosco, mande-nos uma mensagem contendo o e-mail da sua conta antiga ou refaça o seu cadastro com um novo e-mail.</p>
                <br />
                <br />
                Ainda precisa de ajuda?
                <br />
        </div>
        <p>Loja</p>
        <a class="collapsible">Quero ser parceiro</a>
        <div class="conteudo">
            <p>Se você ainda não é uma loja cadastrada no PetFeed, você pode resolver isso agora mesmo por aqui.</p>
            <br />
            <br />
            <!--link para cadastrar restaurante -->
        </div>
        <p>Institucional</p>
        <a class="collapsible">Quero falar com a acessoria de imprensa do PetFeed</a>
        <div class="conteudo">
            <p>Se você é um jornalista e quer informações sobre o PetFeed, pedimos que entre em contato com a nossa acessoria de imprensa.</p>
            <br />
            <br />
            <!--link "falar com a nossa acessoria de imprensa" -->
        </div>
        <a class="collapsible">Quero saber mais sobre o PetFeed</a>
        <div class="conteudo">
            <p>O PetFeed é líder em delivery online de rações e uma das mais inovadoras formas de acesso a tal compra destes produtos. Há um ano no mercado, de origem brasileira, estando presente somente no país.</p>
            <br />
            <br />
            <!--link "Saber mais sobre a gente" e abrir o sobre nos -->
        </div>
    </div>
    <footer class="s-mPer">
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
    <script>
        var coll = document.getElementsByClassName("collapsible");
        var i;

        for (i = 0; i < coll.length; i++) {
            coll[i].addEventListener("click", function () {
                this.classList.toggle("active");
                var content = this.nextElementSibling;
                if (content.style.maxHeight) {
                    content.style.maxHeight = null;
                } else {
                    content.style.maxHeight = content.scrollHeight + "px";
                }
            });
        }
    </script>

</asp:Content>

