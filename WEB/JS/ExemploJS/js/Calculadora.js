var botaoSoma = document.getElementById("Soma");
var botaoSubtracao = document.getElementById("Subtracao");
var botaoMultiplicacao = document.getElementById("Multiplicacao");
var botaoDivisao = document.getElementById("Divisao");

var labelResultado = document.getElementById("Resultado");

var numeroUm = document.getElementById("NumeroUm");
var numeroDois = document.getElementById("NumeroDois");

botaoSoma.addEventListener('click', function () {
    atualizaResultado(parseFloat(numeroUm.value) + parseFloat(numeroDois.value));
});

botaoSubtracao.addEventListener('click', function () {
    atualizaResultado(parseFloat(numeroUm.value) - parseFloat(numeroDois.value));
});

botaoMultiplicacao.addEventListener('click', function () {
    atualizaResultado(parseFloat(numeroUm.value) * parseFloat(numeroDois.value));
});

botaoDivisao.addEventListener('click', function () {
    atualizaResultado(parseFloat(numeroUm.value) / parseFloat(numeroDois.value));
});

function atualizaResultado(valor) {
    labelResultado.textContent = `Resultado: ${valor}`;
}