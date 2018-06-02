//Variáveis
var nome = document.getElementById("Nome");
var sobrenome = document.getElementById("Sobrenome");
var botao = document.getElementById("Enviar");

botao.addEventListener('click', function () {
    nomeCompleto()
});

function nomeCompleto() {
    alert('Olá ' + nome.value + ' ' + sobrenome.value + '!\nSejá bem vindo!');
}