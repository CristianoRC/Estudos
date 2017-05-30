$(function () {

    var nome = $('#nome');
    var email = $('#email');
    var senha = $('#senha');
    var mensagem = $('#mensagem');
    var enviar = $('#Enviar');

    $(nome).keyup(function () {
        if ($(this).val() == "Cristiano Cunha") {
            $(email).focus();
        }
    });

    $(email).keyup(function () {
        if ($(email).val() == "Contato@cristianoprogramador.com") {
            $(senha).focus();
        }
    });

    $(senha).keyup(function () {
        if ($(senha).val() == "123") {
            $(mesagem).focus();
        }
    });


    $(mensagem).keyup(function () {
        if ($(mensagem).val() == "Ola Mundo") {
            $(enviar).focus();
        }
    });

    $(enviar).click(function () {

        var nome = $('#nome').val();
        alert("e-mail enviado com sucesso " + nome + ".");
    });
});