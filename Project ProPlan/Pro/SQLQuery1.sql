create database ProPlan
use ProPlan
create table Login (loginId int primary key identity, username varchar(50), pasword varchar(50), ranking int)
insert into Login (username , pasword , ranking) values ('admin' , 'admin', 0)
alter table Login add firstName varchar(50), lastName varchar (50), fatherName varchar(50)
create table Students (stdId int primary key identity, firstName varchar(50), lastName varchar(50), fathersName varchar(50), age int, contactNo# bigint, gender varchar (10))
alter table Students add address varchar(50)
select * from Students
drop table Students
alter table Students add course varchar (50), semester varchar(50)
create table Semester(sId int primary key identity,semesters varchar (50))
insert into Semester (semesters) values ('Semester 1'),('Semester 2'),('Semester 3'),('Semester 4')
select * from Semester
create table Batches (batchId int primary key identity(1001,1),batchTiming varchar(50),batchDuration varchar(50),batchStartDate varchar (50), maxStd int)
create Table Batchtiming (btId int primary key identity,Bt varchar (50))
insert into Batchtiming (bt) values ('9am to 11am'),('1pm to 3pm'),('5pm to 7pm')
select * from Batchtiming
alter table Students add batchId int foreign key references Batches(batchId)
select * from Batches
create table Groups (grpId int primary key identity,student1 varchar (50) , student2 varchar (50), student3 varchar (50), student4 varchar (50),batchId int foreign key references Batches (batchId))
create table Project (projectId int primary key identity,projectStart varchar(50),projectReview varchar(50),projectEnd varchar(50) ,projectPresentation varchar(50),projectTopic varchar(50),grpId int foreign key references Groups (grpId))
select * from Groups
select * from Batches
select * from Project
alter table Batchtiming add remarks varchar(50)
select * from Batchtiming

alter table Groups add marks int, remarks varchar(50) 
alter table Project add reminder varchar(50)

select * from Login
select * from Students
select * from Batches
select * from Groups
select * from Batches
select * from Project

update Students set batchId = 1001 where stdId=3
update Batchtiming set remarks = 'poor' where btId=1
update Batchtiming set remarks = 'fair' where btId=2
update Batchtiming set remarks = 'good' where btId=3


