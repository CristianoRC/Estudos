const readLine = require('./readLineConsole')
const tasks = require('./tasks')
const commander = require('commander')
async function main() {
    commander.version('0.1')
        .option('-m, --menu [valor]', 'Id da ação que deve ser executada')
        .parse(process.argv)

    let result = commander.menu;

    if (!result) {
        showMenu();
        result = await readLine("Escolha uma opção: ")
    }

    switch (result) {
        case '1':
            await tasks.showAllTasks(true)
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

module.exports = main