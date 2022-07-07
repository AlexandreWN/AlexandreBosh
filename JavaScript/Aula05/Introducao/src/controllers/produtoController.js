const ModelProduto = require("../models/produto");
module.exports = {
  async Create(req, res) {
    try {
      const prod = await ModelProduto.create({
        Descricao: req.body.Descricao,
        DataCriacao: req.body.DataCriacao,
        DataAtualizacao: null,
      });
      return res.json(prod);
    } catch (erro) {
      return console.error("Error na Create :", erro);
    }
  },
  async Delete(req, res) {
    try {
      const prod = await ModelProduto.findByPk(req.body.Codigo);
      await prod.destroy();
    } catch (erro) {
      return console.error("Error na Delete :", erro);
    }
  },
  async GetAll(req, res) {
    try{
      const all = await ModelProduto.findAll();
      return res.json(all)
    }catch (erro){
      return console.error("Error na findAll :", erro);
    }
  },
  async GetOne(req, res) {
    try{
      const byId = await ModelProduto.findByPk(req.body.Codigo);
      return res.json(byId)
    }catch (erro){
      return console.error("Error na findAll :", erro);
    }
  },
  async Update(req, res) {
    try{
      const produto = await ModelProduto.update({
        Descricao : req.body.Descricao,
        DataAtualizacao : req.body.DataAtualizacao
      },{
        where: {Codigo : req.body.Codigo}
      })
      return res.json(produto)
    }catch (erro){
      return console.error("Error na findAll :", erro);
    }
  },
};

