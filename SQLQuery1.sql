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
	UserID int identity primary key,
	UserName varchar(60) unique,
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
	ClientID int identity primary key,
	ClientIP varchar(20) unique,
	ClientName varchar(30) unique,
	GroupClientName varchar(30) references GroupClient(GroupName),
	StatusClient varchar(50),
)
 
 go

create table Member
(
	MemberID int identity primary key,
	AccountName varchar(30) unique,
	Password varchar(30),
	GroupUser nvarchar(30) references GroupUser(GroupName),
	CurrentMoney float,
	CreatedAt datetime,
	MemberStatus varchar(10)
)

go

create table AddMoneyTransaction
(
	AddMoneyTransactionId int identity primary key,
	ClientIP varchar(20) references Client(ClientIP),
	UserName varchar(60) references Users(UserName),
	MemberName varchar(30) references Member(AccountName),
	TransacDate datetime,
	AddMoney float,
	TransacStatus varchar(20)
)

go

create table Chat
(
	ChatID bigint identity primary key,
	MemberName varchar(30) references Member(AccountName),
	UserName varchar(60) references Users(UserName),
	ClientName varchar(30) references Client(ClientName),
	Message nvarchar(200),
	CreatedAt datetime,
	SendBy varchar(10)
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
insert into Member values ('Seraphim','123','Member',50000,null, 'ALLOW')
insert into Member values ('abc','123','Member',0, null, 'ALLOW')
insert into Member values ('xyz','123','Member',60000, null, 'ALLOW')
insert into Member values ('123','123','Member',1000, null, 'ALLOW')
insert into Member values ('1237','123','Member',10, null, 'ALLOW')
--Nhom may tram
insert into GroupClient values ('basic',N'Phòng máy thường',6000)
insert into GroupClient values ('VIP',N'Phòng máy lạnh',10000)
insert into GroupClient values ('SVIP',N'Phòng vip',20000)
insert into GroupClient values ('esport',N'Phòng máy dành cho giải đấu Game',100000)
--May tram
insert into Client values ('127.0.0.1','MAY1','basic','DISCONNECT')
insert into Client values ('192.168.1.2','MAY2','basic','DISCONNECT')
insert into Client values ('192.168.1.3','MAY3','basic','DISCONNECT')
insert into Client values ('192.168.1.4','MAY4','basic','DISCONNECT')
insert into Client values ('192.168.1.5','MAY-VIP-1','VIP','DISCONNECT')
insert into Client values ('192.168.1.6','MAY-VIP-2','VIP','DISCONNECT')
insert into Client values ('192.168.1.7','MAY-SVIP-1','SVIP','DISCONNECT')
insert into Client values ('192.168.1.8','MAY-SVIP-2','SVIP','DISCONNECT')
--danh Muc
insert into Category values(N'Mì gói')
insert into Category values(N'Cơm')
insert into Category values(N'Phở')
insert into Category values(N'Bún')
insert into Category values(N'Nước Ngọt')
insert into Category values(N'Trà')
insert into Category values(N'Bia')
insert into Category values(N'Rượu')
