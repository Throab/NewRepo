create database QuanLyPhongMay
go
use QuanLyPhongMay
go 


create table GroupUser
(
	GroupName nvarchar(30) primary key,
)

go

create table Users
(
	UserName varchar(60) primary key,
	FullName nvarchar(60),
	GroupUser nvarchar(30) references GroupUser(GroupName),
	PhoneNumber varchar(11),
	Email varchar(100),
	Password varchar(30)
)

go 

create table GroupClient
(
	GroupName varchar(30) primary key,
	Description nvarchar(120),
	Price float
)

go

create table Client
(
	ClientIP varchar(20) primary key,
	ClientName varchar(30),
	GroupClientName varchar(30) references GroupClient(GroupName),
	StatusClient varchar(50),
	Note nvarchar(100)
)


create table Member
(
	AccountName varchar(30) primary key,
	Password varchar(30),
	GroupUser nvarchar(30) references GroupUser(GroupName),
	CurrentMoney float,
	StatusAccount nvarchar(30)
)
--Nhom nguoi dung
insert into GroupUser values ('Member')
insert into GroupUser values ('Staff')
insert into GroupUser values ('Manager')
--Nguoi Dung
insert into Users values ('admin',N'Nguyễn Thanh Bảo','Manager','0961563202','nguyenthanhbao9a@gmail.com','admin')
insert into Users values ('user1',N'Phạm Phú An','Staff','0123456789','phuanpham@gmail.com','user1')
insert into Users values ('user2',N'Lê Văn Đại','Staff','097851364','daile123@gmail.com','user2')
--Thanh Vien
insert into Member values ('Seraphim','123','Member',50000,N'Cho Phép')
insert into Member values ('abc','123','Member',0,N'Hết Thời Gian')
insert into Member values ('xyz','123','Member',60000,N'Cho Phép')
--Nhom may tram
insert into GroupClient values ('basic',N'Phòng máy thường',6000)
insert into GroupClient values ('VIP',N'Phòng máy lạnh',10000)
insert into GroupClient values ('SVIP',N'Phòng vip',20000)
insert into GroupClient values ('esport',N'Phòng máy dành cho giải đấu Game',100000)
--May tram
insert into Client values ('127.0.0.1','MAY1','basic','DISCONNECT',N'máy phòng thường')
