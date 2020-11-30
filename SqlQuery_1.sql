create database OnlineStore
go
CREATE TABLE dbo.Product
(
     Id int primary key identity(1,1),
     Code int,
     Title nvarchar(50),
     UnitPrice money,
     Qountity int
);