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

    async createTask(Task) {
        Task.id = guid();
        console.log(Task)
    }
}

function getFileText() {
    return fs.readFileSync(fileLink, 'utf8')
}

module.exports = new fileRepository();