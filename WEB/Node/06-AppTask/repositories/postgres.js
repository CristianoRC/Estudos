const sequelize = require('sequelize')
const driver = new sequelize('nodejs', 'postgres', '1qaz2wsx',
    {
        host: '172.17.0.2',
        port: '5432',
        dialect: 'postgres',
        quoteIdentifiers: false,
        operatorsAliases: false
    });

class postgreRepository {

    constructor() {
        this.driver = driver;
        this.tasks = driver.define('taks', {
            id: { type: sequelize.BIGINT, require: true, autoIncrement: true, primaryKey: true },
            title: { type: sequelize.STRING, require: true },
            description: { type: sequelize.TEXT, defaultValue: '-' },
            finished: { type: sequelize.BOOLEAN, defaultValue: false }
        }, { tableName: 'tasks', freezeTableName: false, timestamps: false, logging: false });

    }

    async getAllTasks() {
        try {
            await this.tasks.sync();
            let result = await this.tasks.findAll({ raw: true });
            return result;

        } catch {
            return []
        }
    }

    async createTask(task) {
        await this.tasks.sync();

        if (task.title != null) {
            await this.tasks.create({ title: task.title, description: task.description });
        }
    }

    async finishTask(taskId) {
        await this.tasks.sync();
        await this.tasks.update({ finished: true }, { where: { id: taskId } })
    }

    async deleteTask(taskId) {
        await this.tasks.sync();
        await this.tasks.destroy({ where: { id: taskId } })
    }
}

module.exports = postgreRepository;