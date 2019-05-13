function CalcularPrecoTempo() {
    var frete = require('frete');

    frete()
        .cepOrigem(document.getElementById("numero").nodeValue)
        .peso(1)
        .formato(1)
        .comprimento(16)
        .altura(2)
        .largura(11)
        .diametro(1)
        .maoPropria('N')
        .valorDeclarado(50)
        .avisoRecebimento('S')
        .servico(frete.codigos.sedex)
        .precoPrazo('13466321', function (err, results) {
            console.log(err);
            console.log(results);
        });
}