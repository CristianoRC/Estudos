//promises

obterUsuario("Cristiadno")
    .then(r => console.log("Funcionou - ", r))
    .catch(r => console.log("Deu erro - ", r));

function obterUsuario(nome) {
    return new Promise(function resolvePromise(resolve, reject) {
        setTimeout(() => {
            if (nome !== "Cristiano")
                return reject(new Error("Nome informado inválido"));

            return resolve({
                id: uuidv4(),
                nome: "Cristiano Cunha",
                dataNascimento: new Date(1998, 07, 28)
            })
        }, 1500)
    })
}

const uuidv4 = require('uuid/v4');