const assert = require('assert')

describe('Testes de exceptions', () => {
    it('Com exception', () => {
        assert.throws(rodarException, Error, "Erro não executado")
    })

    it('Sem exception', () => {
        assert.doesNotThrow(rodarSemException)
    })
})

function rodarException() {
    throw new Error('Exception de teste')
}

function rodarSemException() {
    let x = 1 + 2
}