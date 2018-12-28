let prompt = require('prompt-sync')();

function readLine(question) {
    return new Promise((resolve, reject) => {
        if (question == undefined)
            question = ""

        let result = prompt(question);
        return resolve(result)
    })
}
module.exports = readLine;