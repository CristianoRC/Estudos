const assert = require('assert')
const nock = require('nock')

describe('Testes', function () {
    it('Soma', () => {
        const resultExpected = 7;
        const n1 = 4;
        const n2 = 3;

        assert.deepEqual(somar(n1, n2), resultExpected, "Soma inválida!")
    });

    it('Subtrair', () => {
        it('Subtrair', () => {
            const resultExpected = 7;
            const n1 = 15;
            const n2 = 8;

            assert.deepEqual(subtrair(n1, n2), resultExpected, "Subtração inválida")
        })
    });
})

function somar(n1, n2) {
    return n1 + n2
}

function subtrair(n1, n2) {
    return n1 + n2
}