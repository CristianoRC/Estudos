const {
    deepEqual,
    ok
} = require('assert')

const servicos = require("./servicos")

describe('Crud de arquivos', () => {
    it('Ler o carquivo e converter para objeto', async () => {
        const esperado = JSON.parse('[{ "nome": "Cristiano", "idade": 20 }, { "nome": "Cristiano Cunha", "idade": 20 }]')

        const objetoConvertido = await servicos.obterDadosConvertidos();

        ok(objetoConvertido, esperado)

        console.log(objetoConvertido);

    })
})