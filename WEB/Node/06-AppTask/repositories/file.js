const guid = require('uuid/v1')
const fs = require('fs');
const fileLink = "./repositories/tasks.json"

class fileRepository {

    async getAllTasks() {
        try {
            let fileText = getFileText();
            return JSON.parse(fileText)
        } catch {
            return []
        }
    }

    async createTask(task) {
        if (task.title != null) {
            task.id = guid();
            let tasks = await this.getAllTasks();
            tasks.push(task);
            updateFileText(JSON.stringify(tasks))
        }
    }

    async finishTask(taskId) {
        let tasks = await this.getAllTasks();

        tasks.forEach(task => {
            if (task.id == taskId) task.finished = true;
        });

        updateFileText(JSON.stringify(tasks))
    }

    async deleteTask(taskId) {
        let tasks = await this.getAllTasks();
        let tasksToSave = tasks.filter(task => task.id != taskId)
        updateFileText(JSON.stringify(tasksToSave))
    }
}

function getFileText() {
    return fs.readFileSync(fileLink, 'utf8')
}

function updateFileText(text) {
    fs.writeFileSync(fileLink, text, { flag: '' })
}

module.exports = new fileRepository();