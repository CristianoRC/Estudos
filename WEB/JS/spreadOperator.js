console.log("Uso em array")
let nome = ['Meu','nome','é','Cristiano']
let ultimoNome = ['Cunha','!']
let nomeCompleto = [...nome,'Raffi',...ultimoNome]

console.log(nomeCompleto.join(' '))
console.log("\n===================================\n")
console.log("Parâmetro de função")

let numeros = [1,5]

function somar(a,b){
   console.log(`${a}+${b}=${a+b}`)
}

somar(...numeros)

console.log("\n===================================\n")
console.log("Parâmetro de função - Params C#")

function imprimirNomes(...nomes)
{
  console.log(nomes.join(' '))
}

imprimirNomes('Cristiano', 'Raffi', 'Cunha')
console.log("\n===================================\n")

