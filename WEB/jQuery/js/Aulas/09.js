$(function () {
    var nome = $('#nome');
    var sobrenome = $('#sobrenome');
    var email = $('#email');
    var tabela = $('#tabela')
    var botao = $('#adicionar');
    var aviso = $('#aviso');
    var NovaLinha;

    $(botao).click(function () {

        NovaLinha = "<tr><td>" + nome.val() + "</td><td>" + sobrenome.val() + "</td><td>" + email.val() + "</td></tr>"
        $(tabela).append(NovaLinha);

        $(nome).val("");
        $(sobrenome).val("");
        $(email).val("");

        aviso
            .show("slow")
            .delay(3000)
            .hide("slow");

    });
});