const fileRepository = require('./repositories/file')
const postgresRepository = require('./repositories/postgres')
const readLine = require('./readLineConsole')

class task {
    constructor() {
        this.repository = new postgresRepository();
    }

    async showAllTasks(closeConnectionAfter) {
        let tasks = await this.repository.getAllTasks();

        tasks.forEach(task => {
            console.log(`Id: ${task.id}`)
            console.log(`Título: ${task.title}`)
            console.log(`Descrição: ${task.description}`)
            task.finished ? console.log("Status: Tarefa finalizada.") : console.log("Tarefa em andamento");
            console.log("==================================================")
            if (closeConnectionAfter === true)
                this.repository.driver.close();
        });
    }

    async createTask() {
        let task = {}
        task.title = await readLine("título: ")
        task.description = await readLine("Descrição: ")
        task.finished = false

        this.repository.createTask(task);

        let createNewTask = await readLine("Você deseja criar outra tarefa (S/N)? ");
        if (createNewTask.toLowerCase() == 's')
            await this.createTask();
        else
            console.log("=================== Até mais ===================")
        this.repository.driver.close();
        //TODO: Voltar para a tela inicial
    }

    async setStatusDone() {
        await this.showAllTasks();
        await readLine("\n\nCopie o id da tarefa que você quer finalizar e pressione enter.")
        await this.repository.finishTask(await readLine("Digite o id da tarefa selecionada: "))


        let updateNewTask = await readLine("Você deseja finalizar outra tarefa (S/N)? ");
        if (updateNewTask.toLowerCase() == 's')
            await this.setStatusDone();
        else
            console.log("=================== Até mais ===================")
        this.repository.driver.close();
        //TODO: Voltar para a tela inicial
    }

    async deleteTask(taskId) {
        await this.showAllTasks();
        await readLine("\n\nCopie o id da tarefa que você quer deletar e pressione enter.")
        await this.repository.deleteTask(await readLine("Digite o id da tarefa selecionada: "))


        let updateNewTask = await readLine("Você deseja finalizar outra tarefa (S/N)? ");
        if (updateNewTask.toLowerCase() == 's')
            await this.deleteTask();
        else
            console.log("=================== Até mais ===================")
        this.repository.driver.close();
        //TODO: Voltar para a tela inicial    }
    }
}

module.exports = new task()