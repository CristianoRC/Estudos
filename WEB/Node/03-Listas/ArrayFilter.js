const { obterPessoas } = require('./service')

async function main() {
    let pessoas = await obterPessoas();
    let pessoasComFiltro = pessoas.filter(pessoa => pessoa.last_name.charAt(0) === 'W')
    console.log(pessoasComFiltro.map(pessoa => pessoa.first_name))
}

main();