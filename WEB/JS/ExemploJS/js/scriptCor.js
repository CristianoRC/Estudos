var botaoCor = document.getElementById("MudarCor");
var botaoImagem = document.getElementById("MudarLink");
var txtCor = document.getElementById("Cor");
var txtImagem = document.getElementById("link");
var formulario = document.getElementById("FormCor");


botaoCor.addEventListener('click', function () {
    document.body.style.backgroundColor = txtCor.value;
    document.body.style.backgroundImage = null;
    console.log(txtCor.value);
});


botaoImagem.addEventListener('click', function () {
    document.body.style.backgroundImage = "url("+txtImagem.value+")";
    console.log(txtImagem.value);
});

// formulario.addEventListener('submit', function () {
//     document.body.style.backgroundColor = txtCor.value;
//     console.log(txtCor.value);
// });