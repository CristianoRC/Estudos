const service = require('./service')

async function main() {

    try {
        const result = await service.obterPessoas();
        const nomes = [];

        // for (let i = 0; i < result.length; i++) {
        //     const pessoa = result[i];

        //     nomes.push(`${pessoa.first_name} ${pessoa.last_name}`)
        // }

        // for (const i in result) {
        //     const pessoa = result[i];
        //     nomes.push(`${pessoa.first_name} ${pessoa.last_name}`)
        // }

        for (const pessoa of result) {
            nomes.push(`${pessoa.first_name} ${pessoa.last_name}`)
        }

        console.log(nomes);

    } catch (error) {
        console.error('Ocorreu um erro', error)
    }

}

main();
