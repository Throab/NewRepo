create table users(
	userId int identity(1,1) primary key not null,
	username nvarchar(50) not null,
	password nvarchar(50) not null,
	role nvarchar(20) not null,
	created_date datetime
)