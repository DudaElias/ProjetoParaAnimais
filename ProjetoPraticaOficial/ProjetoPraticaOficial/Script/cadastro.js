function CarregarImagem() {

    var c = document.getElementById("img").value;
    var d = document.createElement("div");
    d.style.backgroundImage = "url(" +c + ")";
    d.style.width = "8em";
    d.style.height = "13em";
    d.style.backgroundSize = "cover";
    d.style.marginLeft = "36em";
    d.style.marginTop = "5em";
    document.body.appendChild(d);
}