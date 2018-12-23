const assert = require('assert')

describe('Testes com listas', () => {
    it('Teste da exception', () => {
        assert.throws(obterNumerosPares, Error)
    })

    it('Teste com valores validos', () => {
        const esperado = [2, 4, 6, 8, 10]
        const numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

        let saida = obterNumerosPares(numeros);

        assert.deepEqual(esperado.length, saida.length)
        assert.deepEqual(esperado, saida)
    })
})

function obterNumerosPares(numeros) {
    return numeros.filter(valor => valor % 2 === 0);
}