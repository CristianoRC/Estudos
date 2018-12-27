const readLine = require('./readLineConsole')
const tasks = require('./tasks')

async function main() {

    showMenu();
    let result = await readLine("Escolha uma opção: ")

    switch (result) {
        case '1':
            await tasks.showAllTasks()
            break;
        case '2':
            await tasks.createTask();
            break;
        case '3':
            await tasks.setStatusDone()
            break;
        case '4':
            await tasks.deleteTask()
            break;
    }

}

function showMenu() {
    console.log("1 -> Mostrar Tarefas")
    console.log("2 -> Criar Tarefa")
    console.log("3 -> Finalizar Tarefa")
    console.log("4 -> Deletar Tarefa")
    console.log("0 -> Sair")
    console.log("");
}

main();
