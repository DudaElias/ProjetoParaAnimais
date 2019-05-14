$(document).ready(function () {
    $("#btn").click(function () {
        $.ajax({
            url: "ComprarTeste",
            type: "GET",
            contentType: "application/json",
            data: {cep: $("#pesquisa").val()},
            success: function (result) {
                $("#valor").html("<label> Valor: " + result[0] + "Prazo de entrega:" + result[1] + "</label>")
            },
            error: function (xhr, exception) {
                alert("Erro ao calcular prazo!");
            }
        })
    })
});