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
                    $("#valor").html("<label> Valor: " + result[0] + "Prazo de entrega:" + result[1] + "</label>");
                    var para = document.createElement("input");
                    para.type = 'submit';
                    para.value = 'Finalizar Compra';
                    para.className = 'btn-compra';
                    var x = document.createElement("input");
                    x.type = 'text';
                    x.placeholder = 'Complemento';
                    x.name = "complemento"
                    var element = document.getElementById("form-cep");
                    element.appendChild(para);
                    element.appendChild(x);
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