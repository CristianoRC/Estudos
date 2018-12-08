// var letras = ordenarLetras()
//     .then(response => console.log("Letras ordenadas -", response))
//     .catch(response => console.log(response))

var letras = ordenarLetras(['U', 'G', 'D', 'Y', 'A', 'X', 'P', 'S'])
    .then(response => console.log("Letras ordenadas -", response))
    .catch(response => console.log(response))


function ordenarLetras(letras) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            if (!letras)
                return reject(new Error("Deve ser passado um vetor com as letras que devem ser ordenadas"))

            return resolve(letras.sort());
        }, 500)
    })
}