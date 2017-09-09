// Write your Javascript code.


$(function () {
    $('#lampada').change(function () {
        if ($(this).prop('checked') == true) {
            LigarLampada();
        }
        else {
            DesligarLampada();
        }
    })
})

function LigarLampada() {
    window.location.replace('/Lampada/Ligada');
}

function DesligarLampada() {
    window.location.replace('/Lampada/Desligada');
}