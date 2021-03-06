/*CRIAÇÃO DA TABELA CLIENTE*/
/*
CREATE TABLE Cliente(
Cod_Cliente integer primary key not null,
Nome_Cliente varchar(50),
Endereco varchar(50),
Cidade varchar(50),
CEP char(8),
UF char(2),
CNPJ numeric(20),
IE numeric(20)
);
*/

/*CRIAÇÃO DA TABELA VENDEDOR*/
/*
CREATE TABLE Vendedor(
Cod_Vendedor integer primary key not null,
Nome_Vendedor varchar(50),
Sal_Fixo numeric(10,2),
Faixa_Comissao char(1)
);
*/

/*CRIAÇÃO TABELA PEDIDO*/
/*
CREATE TABLE Pedido(
Num_Pedido integer primary key not null,
Prazo_Entrega integer,
Cod_Cliente integer,
Cod_Vendedor integer,
FOREIGN KEY (Cod_Cliente) REFERENCES Cliente,
FOREIGN KEY (Cod_Vendedor) REFERENCES Vendedor,
);
*/

/*CRIAÇÃO TABELA PRODUTO*/
/*
CREATE TABLE Produto(
Cod_Produto integer primary key not null,
Unit_Produto varchar(5),
Descricao varchar(50),
Valor_Unit numeric(10,2)
);
*/

/*CRIAÇÃO TABELA Item_Pedido*/
/*
CREATE TABLE Item_Pedido(
Num_Pedido integer not null,
Quantidade integer,
Cod_Produto integer,
FOREIGN KEY (Cod_Produto) REFERENCES Produto,
);
*/
/*INSERÇÃO DE VALORES NA TABELA CLIENTE*/
/*
INSERT INTO Cliente(Cod_Cliente,Nome_Cliente,Endereco,Cidade,CEP,UF,CNPJ,IE)
VALUES
(720,'Ana','Rua 17 n.19','Niteroi','24358310','RJ',12113231000134, 2134),
(870,'Ravio','Av. Pres. Vargas','S�o Paulo','22763931','SP',2253412692879, 4631),
(110,'Jorge','Rua Caiapo 13','Curitiba','30078500','PR',1451276498349,null),
(222,'L�cia','Rua Itabira 123 Loja 9','Belo Horizonte','22124391','MG',2831521393488,2985),
(830,'Maur�cio','Av. Paulista 1236 sl/2345','S�o Paulo','3012683','SP',3281698574656,9343),
(130,'Edmar','Rua da Praia sn/','Salvador','30079300','BA',234632842349,7121),
(410,'Rodolfo','Largo da Lapa 27 sobrado','Rio de Janeiro','30078900','RJ',1283512823469,7431),
(20,'Beth','Av. Clim�rio n. 45','S�o Paulo','25679300','SP',3248512673268,9280),
(157,'Paulo','Tv. Moraes c/3','Londrina',null,'PR',328482233242,1923),
(180,'L�vio','Av. Beira Mar n. 1256','Florian�polis','30077500','SC',1273657123474,null),
(260,'Susana','Rua Lopes Mendes 12','Niter�i','30046500','RJ',217635712329,2530),
(290,'Renato','Rua Meireles n. 123 bl.2 sl.345','S�o Paulo','30225900','SP',1327657112314,1820),
(390,'Sebasti�o','Rua da Igreja n. 10','Uberaba','30438700','MG',321765472133,9071),
(234,'Jos�','Quadra 3 bl. 3 sl. 1003','Bras�lia','22841650','DF',2176357612323,2931);
*/

/*INSERÇÃO DE VALORES NA TABELA VENDEDOR*/
/*
INSERT INTO Vendedor(Cod_Vendedor,Nome_Vendedor,Sal_Fixo,Faixa_Comissao)
VALUES
(209,'José',1800.00,'C'),
(111,'Carlos',2490.00,'A'),
(11,'João',2780.00,'C'),
(240,'Antônio',9500.00,'C'),
(720,'Felipe',4600.00,'A'),
(213,'Jonas',2300.00,'A'),
(101,'João',2650.00,'C'),
(310,'Josias',870.00,'B'),
(250,'Maurício',2930.00,'B');
*/

/*INSERÇÃO DE VALORES NA TABELA PRODUTO*/
/*
INSERT INTO Produto(Cod_Produto,Unit_Produto,Descricao,Valor_Unit)
VALUES
(25,'Kg','Queijo',0.97),
(31,'BAR','Chocolate',0.87),
(78,'L','Vinho',2.00),
(22,'M','Linho',0.11),
(30,'SAC','Açúcar',0.30),
(53,'M','Linha',1.80),
(13,'G','Ouro',6.18),
(45,'M','Madeira',0.25),
(87,'M','Cano',1.97),
(77,'M','Papel',1.05);
*/

/*INSERÇÃO DE VALORES PARA A TABELA PEDIDO*/
/*
INSERT INTO Pedido(Num_Pedido,Prazo_Entrega,Cod_Cliente,Cod_Vendedor)
VALUES
(121,20,410,209),
(97,20,720,101),
(101,15,720,101),
(137,20,720,720),
(148,20,720,101),
(189,15,870,213),
(104,30,110,101),
(203,30,830,250),
(98,20,410,209),
(143,30,20,111),
(105,15,180,240),
(111,20,260,240),
(103,20,260,11),
(91,20,260,11),
(138,20,260,11),
(108,15,290,310),
(119,30,390,250),
(127,10,410,11);
*/

/* Inserção de dados Item_pedido*/
/*Insert into Item_pedido(Num_Pedido,Cod_Produto,Quantidade)
values
(121,25,10),
(124,31,35),
(97,77,20),
(101,31,9),
(101,78,18),
(101,13,5),
(98,77,5),
(148,45,8),
(148,31,7),
(148,77,3),
(148,25,10),
(148,78,30),
(104,53,32),
(203,31,6),
(189,78,45),
(143,31,20),
(143,78,10),
(105,78,10),
(111,25,10),
(111,78,70),
(103,53,37),
(91,77,40),
(138,22,10),
(138,77,35),
(138,53,18),
(108,13,17),
(119,77,40),
(119,13,6),
(119,22,10),
(119,53,43),
(137,13,8);
*/

/*ATIVIDADE DA AULA*/
/*
1)
select Descricao, Unit_Produto, Unit_Produto from Produto;
*/
/*
2)
select CNPJ, Nome_Cliente, Endereco from cliente; 
*/
/*
3)
select * From Vendedor;
*/
/*
select Cod_Vendedor as numero , Nome_Vendedor as nome , Sal_Fixo as rendimentos, Faixa_Comissao as comissao from Vendedor; 
*/
/*Nome vendedor, salario fixo multiplicado por 2*/
/*
select Nome_Vendedor as VENDEDOR,Sal_Fixo*2 as Salario from Vendedor;
*/
/*listar o numero de pedido, codgo do produto e a quantidade dos itens do pedido com quantidade igual a 35 na table item di pedido*/
/*
select Num_Pedido, Cod_Produto,Quantidade  from Item_Pedido where Quantidade = 35;
*/
/*07*/
/*
select Nome_Cliente, Cidade from Cliente where Cidade = 'Niterói'
*/