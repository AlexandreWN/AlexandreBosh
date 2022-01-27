/*
USE AlexandreBosh
GO
BACKUP DATABASE AlexandreBosh
TO DISK = 'C:\Users\disrct\Desktop\aa';
GO
*/

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
(720,'Ana','Rua 17 n.19','Niterói','24358310','RJ',12113231000134, 2134),
(870,'Ravio','Av. Pres. Vargas','São Paulo','22763931','SP',2253412692879, 4631),
(110,'Jorge','Rua Caiapo 13','Curitiba','30078500','PR',1451276498349,null),
(222,'Lúcia','Rua Itabira 123 Loja 9','Belo Horizonte','22124391','MG',2831521393488,2985),
(830,'Maurício','Av. Paulista 1236 sl/2345','São Paulo','3012683','SP',3281698574656,9343),
(130,'Edmar','Rua da Praia sn/','Salvador','30079300','BA',234632842349,7121),
(410,'Rodolfo','Largo da Lapa 27 sobrado','Rio de Janeiro','30078900','RJ',1283512823469,7431),
(20,'Beth','Av. Climério n. 45','São Paulo','25679300','SP',3248512673268,9280),
(157,'Paulo','Tv. Moraes c/3','Londrina',null,'PR',328482233242,1923),
(180,'Lívio','Av. Beira Mar n. 1256','Florianópolis','30077500','SC',1273657123474,null),
(260,'Susana','Rua Lopes Mendes 12','Niterói','30046500','RJ',217635712329,2530),
(290,'Renato','Rua Meireles n. 123 bl.2 sl.345','São Paulo','30225900','SP',1327657112314,1820),
(390,'Sebastião','Rua da Igreja n. 10','Uberaba','30438700','MG',321765472133,9071),
(234,'José','Quadra 3 bl. 3 sl. 1003','Brasília','22841650','DF',2176357612323,2931);
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
(121,31,35),
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
/*08*/
/*
select Descricao from Produto where Unit_Produto = 'M' and Valor_Unit = 1.05;
*/
/*09*/
/*
select Nome_Cliente, Endereco from Cliente where Cidade = 'São Paulo' or CEP >= 30077000 and CEP <= 30079000;
*/
/*10*/
/*
select Num_Pedido from Pedido where Prazo_Entrega != 15;
*/
/*11*/
/*
select Cod_Produto, Descricao from Produto where Valor_Unit between 0.32 and 2.00;
*/
/*12*/
/*
select Descricao from Produto where Descricao like 'q%'
*/

/*13*/
/*
select Cod_Vendedor,Nome_Vendedor from Vendedor where Nome_Vendedor not like 'Jo%';
*/

/*14*/
/*
select Nome_Vendedor from Vendedor where Faixa_Comissao like 'A%' or Faixa_Comissao like 'B%' order by Nome_Vendedor;
*/
/*15*/
/*
select * from Cliente where IE is null;
*/
/*16*/
/*
select Nome_Vendedor, Sal_Fixo from Vendedor order by Nome_Vendedor;
*/
/*17*/
/*
select Nome_Cliente, Cidade, Uf from Cliente order by Uf desc, Cidade desc;
*/

/*18*/
/*
select Descricao, Valor_Unit from Produto where Unit_Produto = 'M' order by Valor_Unit asc 
*/

/*19*/
/*
select Nome_Vendedor, Sal_Fixo * 1.75 as Novo_Salario from Vendedor  where Faixa_Comissao = 'C' order by Nome_Vendedor
*/
/*20*/
/*
select Min(Sal_Fixo) as Menor_Salario, Max(Sal_Fixo) as Maior_Salario from Vendedor;
*/
/*21*/
/*
select SUM(Quantidade) as Soma_Quantidade from Item_Pedido where Cod_Produto = 78;
*/
/*22*/
/*
select AVG(Sal_Fixo) as Media_Salarios from Vendedor;
*/
/*23*/
/*
select COUNT(*) as 'COUNT(*)' from Vendedor where Sal_Fixo > 2500;
select COUNT(Sal_Fixo) as Salario from Vendedor where Sal_Fixo > 2500;
*/
/*24*/
/*
select distinct Unit_Produto from Produto;
*/
/*25*/
/*
select Num_Pedido, count(Quantidade) from Item_Pedido group by Num_Pedido;
*/
/*26*/
/*
select Num_Pedido, Quantidade = COUNT(*) from Item_Pedido group by Num_Pedido having count(*) > 3;
*/
/*27*/
/*
select Cliente.Nome_Cliente, Pedido.Num_Pedido, Pedido.Cod_Cliente 
from Cliente inner join Pedido 
on Cliente.Cod_Cliente = Pedido.Cod_Cliente order by Cod_Cliente; 
*/
/*28*/
/*
select Nome_Cliente, Pedido.Cod_Cliente, Pedido.Num_Pedido from Cliente,Pedido order by Cod_Cliente;
*/
/*29*/
/*
select Cliente.Nome_Cliente, Pedido.Cod_Cliente, Num_Pedido from Cliente left join Pedido on Cliente.Cod_Cliente = Pedido.Cod_Cliente;
*/
/*30*/
/*
select distinct Cliente.Nome_Cliente, Cliente.UF, Prazo_Entrega from Cliente inner join Pedido on Cliente.Cod_Cliente = Pedido.Cod_Cliente where (Prazo_Entrega > 15) and (UF = 'SP' or UF = 'RJ');
*/
/*31*/
/*
select distinct Cliente.Nome_Cliente, Cliente.UF, Prazo_Entrega from Cliente inner join Pedido on Cliente.Cod_Cliente = Pedido.Cod_Cliente order by Prazo_Entrega desc;
*/
/*32*/
/*
select distinct Vendedor.Nome_Vendedor, Vendedor.Sal_Fixo ,Pedido.Prazo_Entrega 
from Vendedor inner join Pedido 
on Vendedor.Cod_Vendedor = Pedido.Cod_Vendedor 
where (Sal_Fixo >= 1000) and (Prazo_Entrega > 15)
order by Nome_Vendedor;
*/
/*33*/
/*
select distinct Cliente.Nome_Cliente from Cliente inner join Pedido on Cliente.Cod_Cliente = Pedido.Cod_Cliente 
inner join Item_Pedido on Pedido.Num_Pedido  = Item_Pedido.Num_Pedido
inner join Produto on Item_Pedido.Cod_Produto = Produto.Cod_Produto where Prazo_Entrega > 15 and Descricao = 'Queijo' and UF = 'RJ' order by Nome_Cliente;
*/

/*34*/
/*
select distinct Vendedor.Nome_Vendedor from Vendedor inner join Pedido on Vendedor.Cod_Vendedor = Pedido.Cod_Vendedor
inner join Item_Pedido on Item_Pedido.Num_Pedido = Pedido.Num_Pedido 
inner join Produto on Item_Pedido.Cod_Produto = Produto.Cod_Produto 
where Quantidade > 10 and Descricao = 'Chocolate'
*/

/*35*/
/*
select count(distinct Cliente.Cod_Cliente) as CompraramComOJoao from Cliente 
inner join Pedido on Cliente.Cod_Cliente = Pedido.Cod_Cliente
inner join Vendedor on Vendedor.Cod_Vendedor = Pedido.Cod_Vendedor
where Nome_Vendedor = 'João';
*/
/*36*/
/*
select count(distinct Cliente.Cod_Cliente) as CompraramNaCidade, Cliente.Cidade from Cliente
inner join Pedido on Cliente.Cod_Cliente = Pedido.Cod_Cliente
inner join Vendedor on Vendedor.Cod_Vendedor = Pedido.Cod_Vendedor
where Nome_Vendedor = 'João' and Cidade = 'Niterói' or Cidade = 'Rio de Janeiro' group by Cidade;
*/
/*37*/
/*
select *from Vendedor;
*/
/*38*/
/*
select distinct Produto.Descricao as Nome_Produto from Produto 
inner join Item_Pedido on Produto.Cod_Produto = Item_Pedido.Cod_Produto where Quantidade in(10);
*/
/*39*/
/*
select Nome_Vendedor from Vendedor where Sal_Fixo < (select avg(Sal_Fixo) from Vendedor);
*/
/*40*/
/*
select distinct Produto.Descricao from Produto 
full outer join Item_Pedido on Produto.Cod_Produto = Item_Pedido.Cod_Produto
where Produto.Cod_Produto not in(select Cod_Produto from Item_Pedido);
*/
/*41*/
/*
select Vendedor.Cod_Vendedor, Vendedor.Nome_Vendedor from Vendedor
inner join Pedido on Vendedor.Cod_Vendedor = Pedido.Cod_Vendedor
inner join Item_Pedido on Pedido.Num_Pedido = Item_Pedido.Num_Pedido
inner join Produto on Item_pedido.Cod_Produto = Produto.Cod_Produto
where Unit_Produto = 'G';
*/
/*42*/
/*
select Nome_Cliente, count(pd.Cod_Cliente) as 'Numero_Pedido' from Cliente as cl
inner join Pedido as pd on cl.Cod_Cliente = pd.Cod_Cliente 
group by Nome_Cliente 
having count(pd.Cod_Cliente) > 3;
*/
/*43*/
/*
INSERT INTO Produto(Cod_Produto,Unit_Produto,Descricao,Valor_Unit)
VALUES
(108,'Kg','PARAFUSO',1.25);

select * from Produto where Cod_Produto = 108
*/
/*44*/
/*
update Produto set Valor_Unit = 1.62 where Cod_Produto = 108;
*/
/*45*/
/*
select Nome_Vendedor, Sal_Fixo from Vendedor;
*/
/*46*/
/*Update Vendedor set Sal_Fixo = (1.27*Sal_Fixo +100);*/

/*47*/
/*update Produto set Valor_Unit = (1.025*Valor_Unit) where Valor_Unit < (select avg(Valor_Unit) from Produto);*/
