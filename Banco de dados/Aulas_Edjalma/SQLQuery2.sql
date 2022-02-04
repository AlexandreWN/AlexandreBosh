/*
select * from Person.Person where Title != 'NULL' 
and MiddleName != 'NULL' 
and Suffix != 'NULL' 
order by FirstName asc 
*/
/*
select TOP 10 * from Sales.SalesOrderDetail
*/
/*
select TOP 10 AVG(LineTotal) AS 'MEDIA VALORES' FROM Sales.SalesOrderDetail
select TOP 10 SUM(LineTotal) AS 'SOMA VALORES' FROM Sales.SalesOrderDetail
select TOP 10 MIN(LineTotal) AS 'MIN VALOR' FROM Sales.SalesOrderDetail
select TOP 10 MAX(LineTotal) AS 'MAX VALOR' FROM Sales.SalesOrderDetail
*/
/*
select TOP 40 PERCENT AVG(LineTotal) AS 'MEDIA VALORES' FROM Sales.SalesOrderDetail
*/

/*
*/
/*
select coluna1,função de agregação (coluna2) from nome da tabela order by coluna1
*/

/*
select * from Sales.SalesOrderDetail

select SpecialOfferid,SUM(UnitPrice) as 'SOMA'
from Sales.SalesOrderDetail group by SpecialOfferID

select SpecialOfferid,UnitPrice
from Sales.SalesOrderDetail WHERE SpecialOfferID = 9

select SpecialOfferid,SUM(UnitPrice) as 'SOMA'
from Sales.SalesOrderDetail 
WHERE SpecialOfferID = 9 
group by SpecialOfferID


select Productid,count(productid)as CONTAGEM from Sales.SalesOrderDetail group by ProductID
*/

select ProductID as Identificador,
SUM(OrderQty) as Total_Vendido,
AVG(UnitPrice) as Media_Valor, 
SUM(UnitPriceDiscont) as Desconto_Total
SUM(LineTotal) as Total_Vendido from Sales.SalesOrderDetail

