--create database [User Manager]
--use [User Manager]

create table Roles
(
	Id int primary key identity,
	Role nvarchar(100) not null default('User')
);
go

create table Users
(
	Id int primary key identity,
	Login nvarchar(100) not null unique check(Login <> ''),
	Password nvarchar(100) not null check(Password <> ''),
	Address nvarchar(100) not null check(Address <> ''),
	Phone nvarchar(100) not null check(Phone <> ''),
	Role int not null references Roles(Id)
);
go