Querys MONGODB


===================| Criando Tabelas |===================

use 'meuBancoDeDados'
db.createCollection("ZBOTAOSEGURANCA")
db.createCollection("ZBOTAOSEGURANCACOMPL")
db.createCollection("ZPEDIDOS")
db.createCollection("ZPEDIDOSITEM")
db.createCollection("ZPRODUTO")
db.createCollection("ZSETOR")
db.createCollection("ZUSUARIO")


===================| Super Usuário |===================

use 'meuBancoDeDados'
db.minhaColecao.insertMany([
    {
        USUARIO: "user",
        SENHA: "1234",
        NOMECOMPLETO: "seunomecompleto",
        EMAIL: "seuemail@hotmail.com",
        IDSETOR: "1"
    }
]);
