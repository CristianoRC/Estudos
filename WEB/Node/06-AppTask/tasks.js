const fileRepository = require('./repositories/file')
const readLine = require('./readLineConsole')


class task {
    constructor() {
        this.repository = fileRepository;
    }

    async showAllTasks() {
        let tasks = await this.repository.getAllTasks();

        tasks.forEach(element => {
            console.log(element)
        });
    }

    async createTask() {
        let task = {}
        task.title = await readLine("título: ")
        task.description = await readLine("Descrição: ")
        task.finished = false

        this.repository.createTask(task);
    }

    async setStatusDone(taskId) {
        console.log("Mudando status da task ...")
    }

    async deleteTask(taskId) {
        console.log("Deletando uma task ...")
    }
}

module.exports = new task()