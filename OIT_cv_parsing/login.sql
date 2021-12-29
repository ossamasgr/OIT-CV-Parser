use master
create database parsing
use parsing
create table login
(
FullName varchar(50),
Username varchar(50) primary key ,
Company varchar(50),
Email nvarchar(100),
Password  nvarchar(100),
ConfEmail char(3) check (ConfEmail in ('oui' , 'non'))
)

insert into login values('reda','el','cloutechio','elmerzouki@gmail.com','merzouki','non')

select * from login
