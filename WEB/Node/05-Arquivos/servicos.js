const { readFile, writeFile, } = require('fs')
const { promisify } = require('util')

const readFileAsync = promisify(readFile)
const writeFileAsync = promisify(writeFile)

class Servicos {
    constructor() {
        this.nomeArquivo = "/home/cristiano/Projetos/Pessoal/Estudos/WEB/Node/05-Arquivos/pessoas.json"
    }

    async obterTextoDoArquivo() {
        return await readFileAsync(this.nomeArquivo, 'utf8')
    }

    async obterDadosConvertidos() {
        let texto = await this.obterTextoDoArquivo();

        return JSON.parse(texto)
    };
}

module.exports = new Servicos();