$(function() {
    var s = $('.s');
    var h = $('.h');
    var t = $('.t');
    var executar = $('#executar');
    $(s).hide();

    executar.click(function() {
        //Parametros Slow / Fast ou ms
        $(h).hide('slow');
        $(s).show(5000);
        $(t).toggle('slow'); //Altera entre o hide e o show
    });
});