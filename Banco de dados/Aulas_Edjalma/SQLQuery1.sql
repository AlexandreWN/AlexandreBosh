-- SELECT FROM - Consultas simples a uma Tabela:
 
select Nome_Autor from tbl_Autores
select * from tbl_Autores
select Nome_Livro from tbl_Livro
select Nome_Livro, Id_Autor from tbl_Livro
---------------------------------------------------------------------------------------------------

 -- ORDER BY - Consultas com ordena��o de Colunas:
 -- * ASC Ordem ascendente
 -- * DESC Ordem descendente
 
select * from tbl_Livro order by Nome_livro asc	
select * from tbl_Livro order by Nome_livro desc
select Nome_Livro, ISBN from tbl_Livro order by Nome_livro
---------------------------------------------------------------------------------------------------

 -- DISTINCT- Consultas com valores distintos, sem repeti��o:
 
 select distinct Id_Autor from tbl_Livro
---------------------------------------------------------------------------------------------------

 -- WHERE - Filtrando registros em uma consulta:
 
 select * from tbl_Livro where Id_Autor = '1'
 select Id_Autor from tbl_Autores where Sobrenome_Autor = 'stanek'
 --------------------------------------------------------------------------------------------------
 
 -- AND e OR - Operadores L�gicos:
 
 select * from tbl_Livro where Id_Livro > 2 and Id_Autor <3
 select * from tbl_Livro where Id_Livro > 2 or Id_Autor <3
 --------------------------------------------------------------------------------------------------
 
 -- SELECT TOP especificar n�mero de registros a retornar:
 
 select top 10 percent Nome_livro from tbl_Livro -- este comando traz uma porcentagem do total da tabela ou seja 10%
 select top 3 Nome_livro from tbl_Livro
 select top 5 Nome_livro from tbl_Livro
 --------------------------------------------------------------------------------------------------
 
 -- Alias com AS - Nomes alternativos para colunas:
 -- * Pode- se dar um nome diferente a uma coluna ou tabela em uma consulta.
 
 select Nome_Livro as Livro from tbl_Livro
 select Nome_Livro as Livro,Id_Autor as Id from tbl_Livro
 --------------------------------------------------------------------------------------------------
 
 -- UNION - Unir resultados de declara��es SELECT:
 -- * Permite combinar duas ou mais declara��es SELECT.
 -- * Cada declara��o Select deve ter o mesmo n�mero de colunas, tipos de dados e ordem das colunas.
 
 select Id_Autor from tbl_Autores 
 union 
 select Id_Autor from tbl_Livro
 --------------------------------------------------------------------------------------------------
 
 -- SELECT INTO - Criar nova tabela a partir de uma tabela existente:
 -- * Seleciona dados de uma ou mais tabelas e os inserem em uma tabela diferente.
 
 select Id_Livro, Nome_Livro, ISBN into LivroAutor from tbl_Livro where Id_Livro > 2 
 --------------------------------------------------------------------------------------------------

 select * from LivroAutor

 -- Fun��es Agregadas:
 -- * COUNT = CONTAR QUANTIDADE DE ITENS.
 
 select COUNT (*) from tbl_Autores
 select COUNT (Nome_Autor) from tbl_Autores
 
 -- * MAX = VALOR M�XIMO.
 
 select MAX (Preco_Livro) from tbl_Livro
 select MAX (Preco_Livro) as Pre�oM�ximo from tbl_Livro
 
 -- * MIN = VALOR M�NIMO.
 
 select MIN (Preco_Livro) from tbl_Livro
 select MIN (Preco_Livro) as Pre�oM�nimo from tbl_Livro
 
 -- * AVG = M�DIA ARITM�TICA.
 
 select AVG (Preco_Livro) from tbl_Livro
 select AVG (Preco_Livro) as M�diaPre�o from tbl_Livro
 
 -- * SUM = TOTAL (SOMA).
 
 select SUM (Preco_Livro) from tbl_Livro
 select SUM (Preco_Livro) as Pre�oTotal from tbl_Livro
 ---------------------------------------------------------------------------------------------------
 
 -- BETWEEN - Sele��o de Intervalos em Registros:
 
 select * from tbl_Livro where Data_Pub between '20040517'and '20100517'
 select Nome_Livro as livro, Preco_Livro as Pre�o from tbl_Livro where Preco_livro between 40.00 and 60.00
 ---------------------------------------------------------------------------------------------------
 
 -- LIKE e NOT LIKE - Filtrar por padr�es espec�ficos:
 -- * Determina se uma cadeia de caracteres espec�fica corresponde a uma padr�o especificado.
 -- Um padr�o pode incluir caracteres normais e curinga.
 -- * NOT LIKE: Inverte a compara��o, verificando se a cadeia de caracteres 
 -- N�o corresponde ao padr�o especificado.
 -- * Usado junto com Where.
 
 -- Padr�es Especificos - LIKE:
 -- '%' Qualquer cadeia de 0 ou mais caracteres.
 
 select Nome_Livro from tbl_Livro where Nome_Livro like 'S%' -- Come�a com S oque vem depois n�o interesa.
 
 -- '_' Sublinhado: qualquer caractere �nico.
 
 select Nome_Livro from tbl_Livro where Nome_Livro like '_i%' -- Termina com I oque vem antes n�o interesa.
 
 -- '[]' Qualquer caractere �nico no intervalo ou conjunto especificado ([a-h]; [aeiou])
 
 select Nome_Livro from tbl_Livro where Nome_Livro like '[sl]%'
 select Nome_Livro from tbl_Livro where Nome_Livro like '_i__0%'
 
 -- '[^]' Qualquer caractere �nico que n�o esteja no intervalo ou conjunto especificado ([a-h]; [aeiou])
 
 select Nome_Livro from tbl_Livro where Nome_Livro not like 'M%'