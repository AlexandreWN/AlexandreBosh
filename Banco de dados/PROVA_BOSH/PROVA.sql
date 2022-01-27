/*
create table Departamentos(dep_id integer primary key not null,
dep_nome varchar(20),
dep_local integer);
*/
/*
create table Funcionarios(edv integer primary key not null,
nome varchar(15) not null,
lider varchar(15) not null,
data_de_contratacao date not null,
salario integer not null,
dep_id integer not null,
FOREIGN KEY (dep_id) REFERENCES Departamentos);
*/
/*
create table Grade_salarial(grade integer not null primary key,
sal_min integer not null,
sal_max integer not null);
*/
/*
insert into Departamentos(dep_id,dep_nome,dep_local) values (1,'REMAN',104),
(2,'ICO',101),
(3,'ETS',401),
(4,'FCM',303),
(5,'INOVE',303);
*/
/*
insert into Grade_salarial(grade,sal_min,sal_max) values (1,1500,4000),
(2,4001,9000),
(3,9001,22000),
(4,22001,50000);
*/
/*
insert into Funcionarios(edv,nome,lider,data_de_contratacao,salario,dep_id) values
(92890148,'Edna Carvalho','Andrea','1990-02-24',19000,1),
(92790062,'João Manfredo','Andrea','2001-09-26',12500,1),
(91004090,'Débora Junior','Andrea','1999-03-02',15600,1),
(94566222,'Carla Rodrigues','Andrea','1990-10-04',20000,1),
(96334100,'Maciel Oliveira','Andrea','1995-12-06',16500,1),
(97885245,'Guilherme Gui','Marcos','2010-05-13',9000,2),
(92894706,'Jessica Lima','Marcos','2015-08-14',25678,2),
(91450032,'Isabella Mach','Marcos','1993-01-22',10900,2),
(94661932,'Carlo Daniel','Lucio','1990-01-31',13750,2),
(95780634,'Maria Santana','Lucio','2015-09-05',8000,2),
(97881945,'Dominic Fer','Pietra','2020-02-09',2000,3),
(98490620,'Daniela Silva','Pietra','2020-02-09',1500,3),
(96854299,'Felipe Augusto','Pietra','2020-02-09',1600,3),
(97805503,'Natalia Reis','Pietra','2019-06-14',2200,3),
(90103456,'Thiago Dias','Pietra','2018-08-24',2800,3),
(98462157,'Lorena Ray','Pietra','2017-02-25',1900,3),
(95482340,'Natanael Brasil','Pietra','2020-06-03',3500,3),
(96314782,'Ana Mass','Captu','1997-02-19',3600,4),
(97854318,'Otávio Luis','Captu','2017-05-19',9200,4),
(94862122,'Luisa Otávia','Captu','2002-11-11',10500,4),
(97864320,'Lucas Moura','Captu','1990-08-29',6600,4),
(96315782,'Fernanda Lac','Captu','1999-12-17',2900,4),
(97546210,'Caroline Adeus','Captu','2018-02-19',4555,4),
(94621573,'Marco Valastro','Captu','2003-03-30',7000,4),
(96548432,'Valdemir Can','Jonas','2020-03-15',1200,5),
(97511020,'Eduarda Souza','Jonas','2011-08-14',1100,5),
(96410654,'Allan Jonas','Felipe','2008-06-17',3200,5),
(95645012,'Diana Jones','Felipe','2002-09-24',2050,5),
(94746054,'Mario Bros','Felipe','1990-01-18',25600,5),
(92085478,'Aline Franco','Jonas','1996-05-05',3700,5);
*/

/*
select TOP(1) Funcionarios.nome,  Departamentos.dep_nome as setor, Funcionarios.salario as salario from Funcionarios inner join Departamentos on
Funcionarios.dep_id = Departamentos.dep_id where Funcionarios.nome like 'D%' order by salario desc;
*/
/*
select Funcionarios.nome, Departamentos.dep_nome as Departamento, Departamentos.dep_local as Local_Trabalho from Funcionarios inner join
Departamentos on Funcionarios.dep_id = Departamentos.dep_id;
*/
/*
select sum(salario) as Func_Jonas_salarios from Funcionarios where lider = 'Jonas'
*/
/*
delete from Funcionarios where lider = 'Jonas'
*/
/*
select count(dep_id) as funcionarios_restantes from Funcionarios where dep_id = 5
*/
/*
UPDATE Funcionarios
 SET salario = salario+(6000 / 3)
 WHERE dep_id = 5;
 */
 /*
 select * from Funcionarios where dep_id = 5;
 */
 /*
 select TOP(1)Funcionarios.edv, Funcionarios.nome, Funcionarios.lider,salario,Grade_salarial.grade from Funcionarios, Grade_salarial 
 where Funcionarios.Salario >= Grade_salarial.sal_min and Funcionarios.salario <= Grade_salarial.sal_max 
 order by data_de_contratacao;
 */
 /*
 select count(Funcionarios.edv) as quantidade_Funcionarios, Departamentos.dep_nome as Setor from Funcionarios
 inner join Departamentos on Funcionarios.dep_id = Departamentos.dep_id where Funcionarios.salario > 4000 group by dep_nome;
 */
 /*
 UPDATE Funcionarios
 SET lider = 'Marcos'
 WHERE lider = 'Lucio';
 */
 /*
 select nome,edv from Funcionarios where data_de_contratacao >= '2015' and lider = 'Marcos' or lider = 'Captu'
 */
 /*
 select avg(Funcionarios.salario) as Média_salarial,
 max(Funcionarios.salario) as Maior_Salario, 
 min(Funcionarios.salario) as Menor_Salario, Departamentos.dep_nome as Departamento from Funcionarios 
 inner join Departamentos on Departamentos.dep_id = Funcionarios.dep_id 
 group by dep_nome;
 */



