Create database RequestSystem;


create table UserTypes
(
 Title nvarchar(20) primary key not null
 )
create table ProblemTypes
(
 Title nvarchar(20) primary key not null
)
create table RequestStatus
(
	Title nvarchar(20) primary key not null
)
create table RequestPriority
(
	Title nvarchar(20) primary key not null
)

insert into UserTypes values
('Default'),
('Admin'),
('Worker')
insert into ProblemTypes values
('Отказ'),
('Глюк');
insert into RequestStatus values
('Не выполнено'),
('В ожидании'),
('В работе'),
('Выполнено')
insert into RequestPriority values 
('Важно'),
('Не важно'),
('Срочно')

create table Users
(
	 UserLogin nvarchar(40) primary key not null, 
	 UserPassword nvarchar(30) not null,
	 UserFullName nvarchar(40) not null, 
	 UserType nvarchar(20)not null,
	 foreign key (UserType) references UserTypes (Title) ON DELETE CASCADE,
 )
create table Requests
(
	 Id int identity(1,1) primary key not null,
	 AdditionalTime nvarchar(19) not null,
	 EndTime nvarchar(19), 
	 Equipment nvarchar(100) not null,
	 ProblemDescription nvarchar(100) not null,
	 Comments nvarchar(100),
	 RequestPriority nvarchar(20)  foreign key references RequestPriority(Title),
	 ProblemType nvarchar(20) foreign key references ProblemTypes(Title) not null,
	 Client nvarchar (40) foreign key references Users(UserLogin)not null,
	 Worker nvarchar (40) foreign key references Users(UserLogin),
	 RequestStatus nvarchar(20)  foreign key references RequestStatus(Title)not null
 )
create table Reports
(
	Id int identity(1,1) primary key not null,
	CreationDate nvarchar(19) not null,
	RequestId int foreign key references Requests(Id)not null,
	Matherials nvarchar(100) not null,
	Cost float not null,
	Reason nvarchar (100) not null,
	WorkDone nvarchar(100) not null,
)

insert into Users values
('Alex','1234','Нуру Алексей Сейдович','Admin'),
('Sasha','123','Синицын Александр Васильевич','Worker'),
('Alena','12','Сидорова Алена Дмитриевна','Default')






