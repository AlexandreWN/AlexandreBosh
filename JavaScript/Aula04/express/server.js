/*
const express = require('express');
 const app = express();
 app.get('/', (requisicao, resposta) => {
 resposta.send(`
 <form action="/" method="POST">
 Nome do cliente: <input type="text" name="nome">
 <button>Enviar</button>
 </form>
 `);
});

 app.post('/', (requisicao, resposta) => {
 resposta.send('Formulário recebido');
});

app.listen(3000, () => console.log("Acessar http://localhost:3000")); //Muito importante usar uma porta que não tenha nenhum processo rodando
*/

/*
const express = require('express');
const app = express();

app.get('/:numero?', (requisicao, resposta) => { // "?" serve para o dadoser opcional

resposta.send(`Número recebido: ${requisicao.params.numero}`);
});
app.listen(3000, () => console.log("Acessar http://localhost:3000"));
*/

const express = require("express");
const app = express();

app.use(express.urlencoded({ extended: true })); // Importante colocar essa parte, caso contrario não ira funcionar o envio do formulário
app.get("/", (requisicao, resposta) => {
    resposta.send(`
    <form action="/" method="POST">
    Nome do cliente: <input type="text" name="nome">
    <button>Enviar</button>
        </form>
    `);
});

app.post("/", (requisicao, resposta) => {
  resposta.send(`Nome: ${requisicao.body.nome}`);
});

app.listen(3000, () => console.log("Acessar http://localhost:3000"));
