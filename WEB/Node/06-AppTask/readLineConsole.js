const readLineUtil = require('readline');
const leitor = readLineUtil.createInterface({ input: process.stdin, output: process.stdout })

function readLine(question) {
    return new Promise((resolve, reject) => {
        if (question !== undefined)
            leitor.write(question);
        leitor.on('line', (input) => {
            leitor.close()

            return resolve(input.replace(question, ""))
        });
    })
}
module.exports = readLine;