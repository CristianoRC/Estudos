class postgreRepository {

    async getAllTasks() {
        try {

        } catch {
            return []
        }
    }

    async createTask(task) {
        if (task.title != null) {
            task.id = guid();
        }
    }

    async finishTask(taskId) {
    }

    async deleteTask(taskId) {
    }

    async isConnected() {

    }
}

module.exports = new postgreRepository();