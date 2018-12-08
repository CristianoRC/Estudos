const http = require('axios');
const URL = 'https://reqres.in/api';

async function obterPessoas() {
    const url = `${URL}/users`
    const response = await http.get(url);
    return response.data.data;
}


module.exports = {
    obterPessoas
}