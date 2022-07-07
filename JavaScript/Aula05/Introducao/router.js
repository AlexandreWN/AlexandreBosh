const express = require('express');
const controllerProduto = require('./src/controllers/produtoController');

//Criando uma instância router da classe express
const routes = express.Router();

//Definindo rotas para os métodos dentro da controller
routes.get('/GetAll', controllerProduto.GetAll);
routes.post('/Update', controllerProduto.Update);
routes.get('/GetOne', controllerProduto.GetOne);
routes.post('/Create', controllerProduto.Create);
routes.post('/Delete', controllerProduto.Delete);
module.exports = routes;