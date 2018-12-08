main()

async function main() {
    try {
        // const letras = await ordenarLetras();
        const letras = await ordenarLetras(['U', 'G', 'D', 'Y', 'A', 'X', 'P', 'S'])
        console.log(letras);
    } catch (error) {
        console.error(error)
    }
}

function ordenarLetras(lestras) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            if (!lestras)
                return reject(new Error("Deve ser passado um vetor com as letras que devem ser ordenadas"))

            return resolve(lestras.sort());
        }, 500)
    })
}