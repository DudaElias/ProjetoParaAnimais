function Cadastro(i)
{
    if (i == 1)
    {
        document.getElementById("box1").style.visibility = "visible";
        document.getElementById("boxEm").style.visibility = "visible";
        document.getElementById("boxCli").style.visibility = "hidden";
        document.getElementById("linha").style.visibility = "visible";
        document.getElementById("box2").style.visibility = "hidden";
        document.getElementById("btns").style.visibility = "hidden";
        document.getElementById("Label2").style.visibility = "visible";
    }
        
    else
    {
        document.getElementById("box2").style.visibility = "visible";
        document.getElementById("box1").style.visibility = "hidden";
        document.getElementById("boxEm").style.visibility = "hidden";
        document.getElementById("boxCli").style.visibility = "visible";
        document.getElementById("linha").style.visibility = "visible";
        document.getElementById("btns").style.visibility = "hidden";
        document.getElementById("Label2").style.visibility = "visible";
    }
}

function Cadastrar(i) {
    if (i == 1) {
    }

    else {
        window.location.href = "PerfilUsu\Perfil";
    }
}