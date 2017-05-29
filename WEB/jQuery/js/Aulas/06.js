$(function() {
    var input = $('.place');
    var place = $('.place').attr('title')

    //para cada elemento que contem a classe place
    $(input).each(function() {
            input.val(place)
                .css({ color: "gray" });
        })
        .focusin(function() {
            if (input.val() == place) {
                input.val("")
                    .css({ color: "black" });
            }
        })
        .focusout(function() {
            if (input.val() == '') {
                input.val(place)
                    .css({ color: "gray" });
            }
        });

    var titulo = $('.titulo')
    $('.key').keyup(function() {
        titulo.text($(this).val());
    });

    /* Key press e key down tem um caracter de "delay"
    var titulo = $('.titulo')
    $('.key').keypress(function() {
        titulo.text($(this).val());
    });*/

    /*
    var titulo = $('.titulo')
    $('.key').keydown(function() {
        titulo.text($(this).val());
    }); */
});