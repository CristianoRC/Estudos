$(function () {

    var ex = $('.ex1');

    //click
    $('.ev1').click(function () {
        $(this).css({ "background-color": "Green", color: "black" });
        ex.text("Você Clicou!");
    });

    //Duplo click
    $('.ev2').dblclick(function () {
        $(this).css({ "background-color": "Green", color: "black" });
        ex.text("Você deu dois cliques");
    });

    //Hover & Leave
    $('.ev4').hover(function () {
        $(this).text("Você passou o mouse aqui.")
            .css({ "background-color": "Green", color: "black" });
    }).mouseleave(function () {
        $(this).text("Você remove o mouse")
            .css({ "background-color": "blue", color: "brown" });
    });

    //Mouse Up & Down
    $('.ev5').mousedown(function () {
        $(this).css({ "background-color": "Green", color: "black" });
        ex.text("Você executou o mouse down");
    }).mouseup(function () {
        $(this).css({ "background-color": "blue", color: "brown" });
        ex.text("Você executou o mouse up");
    });

    //Foco
    $('.ev3').focusin(function () {
        $(this).css({ "background-color": "Green", color: "black" });
        ex.text("Você está digitando");
    }).focusout(function () {
        $(this).css({ "background-color": "blue", color: "brown" });
        ex.text("Você estava digitando");
    });

    //"Entra e sai"
    var controle = 0;
    $('.ev6').mouseenter(function () {
        controle++;
        $(this).css({ "background-color": "Green", color: "black" });
        ex.text("Entradas com mouse : " + controle + " vezes.");
    }).mouseout(function () {
        ex.text("Você saiu com o mouse");
    });
});