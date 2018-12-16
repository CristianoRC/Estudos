const service = require('./service.js')

async function main() {

    try {
        let result = await service.obterPessoas();
        let names = [];
        let namesUsingReturn = []
        //result.forEach(item => { names.push(item.first_name) }); Como eu utilizava

        result.map(item => { names.push(item.first_name) });

        namesUsingReturn = result.map(user => { return user.first_name })

        console.log("Without return", names);
        console.log("with return", namesUsingReturn)

    } catch (error) {
        console.error(error);
    }

}

main();