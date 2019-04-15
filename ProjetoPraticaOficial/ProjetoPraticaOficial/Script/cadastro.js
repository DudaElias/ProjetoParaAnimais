function Cadastro(i)
{
    if (i == 1)
    {
        document.getElementById("box1").style.visibility = "visible";
        document.getElementById("box2").style.visibility = "hidden";
        document.getElementById("btns").style.visibility = "hidden";
    }
        
    else
    {
        document.getElementById("box2").style.visibility = "visible";
        document.getElementById("box1").style.visibility = "hidden";
        document.getElementById("btns").style.visibility = "hidden";
    }
}

function Cadastrar(i) {
    if (i == 1) {
    }

    else {
        window.location.href = "ProjetoPraticaOficial\Views\PerfilUsu\Perfil.cshtml";
    }
}