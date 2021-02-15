--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers 

Select * from Customers where City='Berlin'

-- Case insensitive

Select* from Products where CategoryID=1 or CategoryID=3

Select* from Products where CategoryID=1 and UnitPrice>=10

--asc ascending= artan demek 

select * from Products where CategoryID=1 order by UnitPrice  desc

select count (*) Adet from Products where CategoryID= 2

select count (*) Adet from Products 

select CategoryID, count(*) from Products group by CategoryID


-- Burda yönetim diyor ki içerisinde 10dan daha az çeşit olan kategorileri ver ben onlara ürün ekliyim.
select CategoryID, count(*) from Products group by CategoryID having count(*)<10 



--Önce Her zaman where çalışır
select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 


select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join  Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO ==> Data Transformation object. C# la ilişkendircez.

select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderId=od.OrderID


select * from Customers  c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null




select
 * FROM Customers
where
 City = 'Berlin'
or
 
City = 'London'



select ContactName ,CompanyName ,City  from Customers

select * from Customers where City='London'


Select Products.ProductName 'Ürün Adı' ,
SUM([Order Details].UnitPrice*[Order Details].Quantity) 'Kazanılan Toplam Miktar'
From Products inner join [Order Details]
On Products.ProductID = [Order Details].ProductID
inner Join Orders 
On Orders.OrderID = [Order Details].OrderID
group by Products.ProductName



--Select
select ContactName Adi ,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='London'

Select ProductName URUNAdi , UnitPrice BirimFiyati from Products

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 order by UnitPrice asc

select count (*) Adet from Products where CategoryID=2 


select count (*)  from Products group by CategoryID


select CategoryId , count (*) from Products group by CategoryID



select categoryId, 
count (*) 
from Products where UnitPrice>20
group by CategoryID  having count(*)<10


select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryID
from Products inner join Categories
on  Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10
-- where order by group yazabilirsin sonra



select p.ProductName [Ürün adı],
sum (od.UnitPrice*od.Quantity) [Kazanılan Toplam Para]
from Products p 
inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders on od.OrderID=Orders.OrderID
group by p.ProductName



select p.ProductName [Ürün Adi], 
sum((od.UnitPrice*od.Quantity)-(od.UnitPrice*od.Quantity*od.Discount)) [Kazanılan Toplam Miktar] 
from Products p 
inner join [Order Details] od on p.ProductID=od.ProductID 
inner join Orders o on od.OrderID=o.OrderID
group by p.ProductName