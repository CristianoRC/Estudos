const cors = require('cors');
const express = require('express');
const server = express();
const salas = [];

server.use(cors());
server.options("*", cors());
server.use(express.json({}));

server.get('/', function (req, res) {
    return res.status(200).send("Api de estudo do Express.js - github.com/cristianorc/");
});

server.get('/mensagem', function (req, res) {
    let indexSala;

    if (req.query.sala !== undefined) {
        if (typeof parseInt(req.query.sala) === "number")
            indexSala = req.query.sala;
        else
            return res.status(400).json({ Erro: "A sala deve conter um valor inteiro." });
    }
    else
        indexSala = 0;

    return res.status(200).json(salas[indexSala]);
});

server.post('/mensagem', function (req, res) {

    if (!req.body.nome || !req.body.mensagem)
        return res.status(400).send()

    let indexSala;
    if (req.query.sala !== undefined) {
        if ((typeof parseInt(req.query.sala)) === "number")
            indexSala = parseInt(req.query.sala);
        else
            return res.status(400).json({ Erro: "A sala deve conter um valor inteiro." });
    }
    else
        indexSala = 0;

    salas[indexSala].push({ nome: req.body.nome, mensagem: req.body.mensagem });

    return res.status(200).send();
});

server.get('/salas', function (req, res) {
    return res.status(200).json({ SalasCriadas: salas.length })
});

server.post('/sala', function (req, res) {
    salas.push([]);
    return res.status(200).send("Sala criada id:" + (salas.length - 1))
});

server.listen(3000, function () {
    console.log("==================================")
    console.log("| Servidor rodando na porta 3000 |");
    console.log("==================================")
    salas.push([]);
});