//callback

obterUsuario(resolverUsuario);

function resolverUsuario(erro, usuario) {
    console.log(usuario);
}

function obterUsuario(callback) {
    setTimeout(() => {
        return callback(null, {
            id: uuidv4(),
            nome: "Cristiano Cunha",
            dataNascimento: new Date(1998, 07, 28)
        })
    }, 3000)
}

const uuidv4 = require('uuid/v4');