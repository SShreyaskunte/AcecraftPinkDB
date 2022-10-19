create database acecraft

use acecraft

create table Registration(
	id int NOT NULL Primary Key identity(1,1),
	fname varchar(25),
	lname varchar(25),
	useremail varchar(25),
	password varchar(25),
	confpassword varchar(25),
	pname varchar(25),
	adno varchar(25)

);

select * from Registration

drop table Registration