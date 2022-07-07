const sequelize = require('sequelize');
//configurações da base de dados
const database = new sequelize('AulasJs','aulasjs','etsds10240305',
{
    dialect: 'mssql', host:'JVLPC0565', port: 1433
});

//sincroniza com uma tabela já existente
database.sync();
module.exports = database;