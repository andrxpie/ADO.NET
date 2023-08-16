create database Sells
go

use Sells
go

create table Customers
(
	Id int primary key identity,
	Name nvarchar(100) not null check(Name <> ''),
	Surname nvarchar(100) not null check(Surname <> '')
);
go

create table Sellers
(
	Id int primary key identity,
	Name nvarchar(100) not null check(Name <> ''),
	Surname nvarchar(100) not null check(Surname <> '')
);
go

create table TSells
(
	Id int primary key identity,
	CustomerId int not null references Customers(Id),
	SellerId int not null references Sellers(Id),
	Price money not null check(Price > 0),
	Date date not null check(Date < GETDATE())
);
go