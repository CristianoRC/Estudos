$(function () {
    var nome = $('#nome');
    var sobrenome = $('#sobrenome');
    var email = $('#email');
    var tabela = $('#tabela')
    var botao = $('#adicionar');
    var aviso = $('#aviso');
    var NovaLinha;

    $(botao).click(function () {

        NovaLinha = "<tr><td>" + nome.val() + "</td><td>" + sobrenome.val() + "</td><td>" + email.val() + "</td> <td><button onclick=\"remove(this)\" class=\"btm btn-danger btn-sm\">Remover</button></td></tr>"
        $(tabela).append(NovaLinha);

        $(nome).val("");
        $(sobrenome).val("");
        $(email).val("");

        aviso
            .show("slow")
            .delay(3000)
            .hide("slow");

    });

    // remove e uma função que recebe o elemento por parâmero (onclikc(this))
    remove = function (item) {
        var tr = $(item).closest('tr');

        tr.fadeOut(400, function () {
            tr.remove();
        });
    }
});