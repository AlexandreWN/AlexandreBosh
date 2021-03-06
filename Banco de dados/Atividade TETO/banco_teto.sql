/*use Atividade_Imo;*/
/*
create table proprietario (
proprietario_id integer not null PRIMARY KEY,
nome varchar(50) not null);
*/
/*
create table pagamentos (
pag_id integer not null PRIMARY KEY,
tipo varchar(30) not null);
*/
/*
create table email (
email_id integer not null PRIMARY KEY,
email varchar (50) not null);

create table telefone (
telefone_id integer not null PRIMARY KEY,
telefone integer not null);

create table cliente(
cliente_id integer not null PRIMARY KEY, 
rg char(9) not null, 
nome varchar (50) not null,
telefone_id integer not null,
email_id integer not null,
FOREIGN KEY (telefone_id) REFERENCES telefone,
FOREIGN KEY (email_id) REFERENCES email);
*/
/*
create table imovel(
imovel_id integer not null PRIMARY KEY,
tipo_imovel varchar(30) not null,
tipo_opera varchar(30) not null,
pag_id integer not null,
proprietario_id integer not null,
FOREIGN KEY (pag_id) REFERENCES pagamentos,
FOREIGN KEY (proprietario_id) REFERENCES proprietario);
*/
/*
create table teto (
empresa_id integer not null PRIMARY KEY,
telefone_id integer not null,
FOREIGN KEY (telefone_id) REFERENCES telefone);
*/
/*
create table funcionario (
funcionario_id integer not null PRIMARY KEY,
cargo varchar(30) not null,
nome varchar(50) not null,
telefone_id integer not null,
empresa_id integer not null,
FOREIGN KEY (telefone_id) REFERENCES telefone,
FOREIGN KEY (empresa_id) REFERENCES teto);
*/
/*
create table endereco (
endereco_id integer not null PRIMARY KEY,
rua varchar(50) not null,
bairro varchar(50) not null,
cidade varchar(50) not null,
estado char(2) not null,
numero integer not null,
cep integer not null);
*/
/*
create table atendimento (
atendimento_id integer not null PRIMARY KEY,
horario time not null,
data_atend char(10),
cliente_id integer not null,
funcionario_id integer not null,
FOREIGN KEY (cliente_id) REFERENCES cliente,
FOREIGN KEY (funcionario_id) REFERENCES funcionario);
*/
/*
create table visita (
visita_id integer not null PRIMARY KEY,
horario time not null,
data_visi char(10) not null,
atendimento_id integer not null,
imovel_id integer not null,
funcionario_id integer not null,
FOREIGN KEY (atendimento_id) REFERENCES atendimento,
FOREIGN KEY (imovel_id) REFERENCES imovel,
FOREIGN KEY (funcionario_id) REFERENCES funcionario);

create table proposta (
proposta_id integer not null PRIMARY KEY,
valor numeric (38,2) not null,
visita_id integer not null,
cliente_id integer not null,
imovel_id integer not null,
pag_id integer not null,
FOREIGN KEY (visita_id) REFERENCES visita,
FOREIGN KEY (cliente_id) REFERENCES cliente,
FOREIGN KEY (imovel_id) REFERENCES imovel,
FOREIGN KEY (pag_id) REFERENCES pagamentos);
*/
/*
insert into proprietario (proprietario_id, nome) 
values (1,'jose'),
(2,'murilo'),
(3,'bruno'),
(4,'luiz');
*/
/*
insert into pagamentos (pag_id, tipo)
values (1,'dinheiro'),
(2,'cartao'),
(3,'cheque');
*/
/*
insert into email (email_id, email) 
values (1,'josejose@jose.com'),
(2,'murilomurilo@murilo.com'),
(3,'brunobruno@bruno.com'),
(4,'luisluis@luis.com');
*/
/*
insert into telefone (telefone_id, telefone) 
values (1,111111111),
(2,222222222),
(3,333333333),
(4,444444444),
(5,5),
(6,6),
(7,7);
*/
/*
insert into cliente(cliente_id, rg, nome,telefone_id,email_id)
values (1,111111111,'bebe',1,1),
(2,222222222,'kkkkk',2,2),
(3,333333333,'qqqqq',3,3),
(4,444444444,'afawf',4,4),
(5,'awdawdfhi'),
(6,'awjhfawiofjapwfj'),
(7,'awhdawjhoiwgowijg');
*/
/*
insert into imovel(imovel_id,tipo_imovel,tipo_opera,pag_id,proprietario_id)
values(1, 'casa','venda',1,1),
(2,'sobrado', 'aluga',2,2),
(3,'apartamento', 'aluga',3,3),
(4,'casa','aluga',1,4);
*/
/*
insert into teto (
empresa_id,
telefone_id) values (1,7);
*/
/*
insert into funcionario (
funcionario_id,
cargo,
nome,
telefone_id,
empresa_id)
values(1,'vendedor','qwr',5,1),(2,'vendedor','qwer',6,1),(3,'sla','qwert',7,1);
*/
/*
insert into endereco (
endereco_id,
rua,
bairro,
cidade,
estado,
numero,
cep) values (1,'a','ab','abc','pr',11,112),
(2,'b','bc','bcd','rj',12,123),
(3,'c','cd','cde','mg',13,134),
(4,'d','de','def','pr',14,145);
*/
/*
insert into atendimento (
atendimento_id,
horario,
data_atend,
cliente_id,
funcionario_id) values (1,'19:46:00','19/11/2000', 1, 1),
(2,'19:47:00','11/11/2000', 2, 1),
(3,'19:48:00','12/11/2000', 3, 2),
(4,'19:49:00','13/11/2000', 4, 3);
*/
/*
insert into visita (
visita_id,
horario,
data_visi,
atendimento_id,
imovel_id,
funcionario_id) values (1,'19:48:00','11/09/2000',1,1,1),
(2,'19:49:00','11/10/2000',2,2,2),
(3,'19:44:00','11/12/2000',3,3,2),
(4,'19:45:00','11/1/2000',4,4,3);
*/
/*
insert into proposta (
proposta_id,
valor,
visita_id,
cliente_id,
imovel_id,
pag_id) values (1,1222.00,1,1,2,1),
(2,100.00,2,2,3,2);
*/

/*1)Selecione todos os tipos de imoveis que receberam proposta e os valores das propostas*/
/*
select imovel.tipo_imovel, proposta.valor as valor_proposta from imovel inner join proposta on imovel.imovel_id = proposta.imovel_id;
*/

/*2)Selecione a o valor medio das propostas*/
/*
select avg(valor) as media_valor_proposta from proposta;
*/
/*3)Selecione o tipo de imovel, seu id e o nome do dono*/
/*
select imovel.tipo_imovel,imovel.imovel_id, proprietario.nome as nome_proprietario from imovel 
inner join proprietario on imovel.proprietario_id = proprietario.proprietario_id;
*/
/*4)selecione quantas visitas cada funcionario atendeu*/
/*
select funcionario.nome,count(visita_id) as quantidade_visitas from funcionario 
inner join visita on funcionario.funcionario_id = visita.funcionario_id group by funcionario.nome;
*/
/*5)quais os telefones de cada funcionario*/
/*
select funcionario.nome, telefone.telefone from funcionario 
inner join telefone on telefone.telefone_id = funcionario.telefone_id;
*/
/*6)selecione todos os dados das propostas*/
/*
select * from proposta;
*/
/*7)selecione os nomes dos funcionario que trabalham na empresa id 1*/
/*
select funcionario.nome from funcionario where empresa_id = 1;
*/
/*8)selecione quantos proprietarios est?o cadastrados*/
/*
select count(proprietario_id) as quantidade_proprietarios_cadastrados from proprietario;
*/
/*9)Selecione a data, hora e o nome do funcionario que realizou o atendimento*/
/*
select atendimento.data_atend,atendimento.horario,funcionario.nome from atendimento 
inner join funcionario on atendimento.funcionario_id = funcionario.funcionario_id;
*/
/*10)selecione todos os dados da tabela endereco*/
/*
select * from endereco;
*/



