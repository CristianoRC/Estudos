let obj = {
    nome: "Cristiano"
}
function ToUpper(obj) {
    try {
        console.log(obj.name.toUpperCase())
    } catch (error) {
        console.log(obj.nome.toUpperCase())
    }
    finally{
        console.log("Fim da execução")
    }
}

ToUpper(obj);