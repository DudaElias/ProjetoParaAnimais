$(document).ready(function () {
    $("#btn").click(function () {
        var er = /^[0-9]{5}-[0-9]{3}$/;
        if (er.test($("#cepC").val()) == false)
        {
            alert("acerta ai")
        }
        else {
            $.ajax({
                url: "ComprarTeste",
                type: "GET",
                contentType: "application/json",
                data: { cep: $("#cepC").val() },
                success: function (result) {
                    $("#valor").html("<label class='lblValor'> Valor: " + result[0] + "<br>"+ " Prazo de entrega: " + result[1] + " dias úteis" + "</label>");
                    var para = document.createElement("input");
                    para.type = 'submit';
                    para.value = 'Finalizar Compra';
                    para.className = 'btn-compra';
                    var y = document.createElement("span");
                    y.textContent = 'Informações finais: ';
                    var x = document.createElement("input");
                    document.getElementById("cepC").style.display = 'none';
                    document.getElementById("btn").style.display = 'none';
                    document.getElementById("nomeCep").style.display = 'none';
                    x.type = 'text';
                    x.placeholder = 'Complemento';
                    x.name = "complemento";
                    x.autocomplete = 'off';
                    x.className = 'cepC';
                    x.style.position = 'absolute';
                    y.className = 'y';
                    x.style.top = '55%';
                    x.style.left = '23%';
                    document.getElementById("form-cep").style.height = '400px';
                    document.getElementById("form-cep").style.top = '75%';
                    document.getElementById('numero').style.display = 'inline';
                    document.getElementById('qtd').style.display = 'inline';

                    var element = document.getElementById("form-cep");
                    element.appendChild(para);
                    element.appendChild(x);
                    element.appendChild(y);
                },
                error: function (xhr, exception) {
                    alert("Erro");
                }
            })
        }
    })
});

$(document).ready(function () {
    $("#qualFiltro").click(function () {
        $.ajax({
            url: "GraficoPareto",
            success: function (result) {
                alert('aaaaaaa');
            },
            error: function (xhr, exception) {
                alert(exception);
            }
        })
    })
});