const express = require('express');
const cors = require("cors");
const server = express();
const dataBase = [];

server.use(cors());
server.options("*", cors())
server.use(express.json({}));

server.post("/post", function (req, res) {

    if (!(req.body.user || req.body.text)) {
        return res.status(400).send();
    }

    dataBase.push({ user: req.body.user, text: req.body.text });
    return res.status(200).send();
});

server.get("/get", function (req, res) {
    return res.status(200).send(dataBase);
})


server.listen(3000, function () {
    console.log("=================================")
    console.log("Servidor Iniciado, na porta 3000|");
    console.log("=================================")
});