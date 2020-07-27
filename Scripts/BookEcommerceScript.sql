CREATE TABLE Book (
    Id int  IDENTITY(1,1) PRIMARY KEY,
    Title nvarchar(255) NOT NULL,
	Description nvarchar(255) not null,
	BookImageUrl nvarchar(255) not null,
	BookPages int not null,
	CategoryId int not null,
	AuthorId int not null,
	PublisherId int not null
	
);
create table Category
(
	Id int identity(1,1) primary key,
	[Name] nvarchar(255) not null,

);

create table Publisher
(
	Id int identity(1,1) primary key,
	[Name] nvarchar(255) not null,
	Address nvarchar(255) not null
);

create table Author
(
	Id int identity(1,1) primary key,
	FirstName nvarchar(255) not null,
	LastName nvarchar(255) not null
);


create table [Order]
(
	Id int identity(1,1) primary key,	
	AddDate datetime not null,
	UserId nvarchar(450) not null
);
create table OrderDetail
(
	Id int identity(1,1) primary key,
	BookId int not null,
	Quantity int not null,
	OrderId int not null
);

create table ShoppingBox
(
	Id int identity(1,1) primary key,
	BookId int not null,
	Price decimal not null,
	Title nvarchar(255) not null,
	UserId nvarchar(455) not null
);

alter table ShoppingBox
add  Quantity int not null;

alter table Book add StockCount int null;


ALTER TABLE [OrderDetail]
ADD FOREIGN KEY (BookId) REFERENCES Book(Id);



alter table [Order]
add UserName nvarchar(256) not null;

ALTER TABLE [OrderDetail]
ADD FOREIGN KEY (OrderId) REFERENCES [Order](Id);