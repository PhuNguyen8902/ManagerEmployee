use master
go

CREATE DATABASE employeeDB
GO

USE employeeDB
GO

CREATE TABLE department (
	id int primary key identity(1,1),
	name nvarchar (50),
	phone char (20),
	address nvarchar (50),
)
GO

CREATE TABLE levelSalary_Detail (
	id int primary key identity(1,1),
	coefficient int,
	level char (20) NOT NULL,

)
GO



CREATE TABLE allowanceSalary_Detail (
	id int primary key identity(1,1),
	allowance int,
)
GO

CREATE TABLE salary (
	id int primary key identity(1,1),
	coefficient int,
	level int,
	allowance int,
	net_salary int,
	constraint fk_e_levelsalary foreign key (level) references levelSalary_Detail(id),
	constraint fk_e_allowancedepartment foreign key (allowance) references allowanceSalary_Detail(id),
)
GO

CREATE TABLE position (
	id int primary key identity(1,1),
	name nvarchar (50),
	description nvarchar (50),
)
GO


CREATE TABLE employee (
	id int primary key identity(1,1),
	name nvarchar (50),
	phone char (20),
	gender tinyint not null check (gender in (0, 1)),
	home_town nvarchar (50),
	department_id int,
	salary_id int,
	position_id int,
	constraint fk_e_salary foreign key (salary_id) references salary(id),
	constraint fk_e_department foreign key (department_id) references department(id),
	constraint fk_e_position foreign key (position_id) references position(id)
)
GO


CREATE TABLE project (
	id int primary key identity(1,1),
	name nvarchar (50),
	description nvarchar (50),
	is_active bit default 1,
	start_date date,
	end_date date,
)
GO



CREATE TABLE employee_project (
	employee_id int,
	project_id int,
	description nvarchar (50),
	start_date date,
	end_date date,
	role nvarchar (50),
	constraint fk_ep_employee foreign key (employee_id) references employee(id),
	constraint fk_ep_project foreign key (project_id) references project(id)
)
GO

CREATE TABLE timekeeping (
	id int primary key identity(1,1),
	date date,
	working_hour time,
	employee_id int,
	constraint fk_t_employee foreign key (employee_id) references employee(id)
)
GO

CREATE TABLE account (
	id int primary key identity(1,1),
	user_name nvarchar (50),
	password nvarchar (50),
	full_name nvarchar (50),
	email nvarchar (50),
	type nvarchar (50),
	employee_id int,
	constraint fk_a_employee foreign key (employee_id) references employee(id)
)
GO

insert into account(user_name,password,full_name,email,type,employee_id) values ('admin','123','Admin','admin@gmail.com','Admin',1);
insert into account(user_name,password,full_name,email,type,employee_id) values ('employee','123','Employee','employee@gmail.com','Employee',5);
insert into account(user_name,password,full_name,email,type,employee_id) values ('manage','123','Manage','manage@gmail.com','Manage',2);


insert into department(name,phone,address) values ('IT',09374725826,'hoc mon');
insert into department(name,phone,address) values ('Sale',01627482756,'binh thuan');
insert into department(name,phone,address) values ('PR',07236285637,'go vap');


insert into levelSalary_Detail (coefficient,level) values(5000000,'Employee');
insert into levelSalary_Detail (coefficient,level) values(10000000,'Manage');
insert into levelSalary_Detail (coefficient,level) values(20000000,'Admin');

insert into allowanceSalary_Detail (allowance) values (1000000);
insert into allowanceSalary_Detail (allowance) values (2000000);
insert into allowanceSalary_Detail (allowance) values (3000000);
insert into allowanceSalary_Detail (allowance) values (4000000);
insert into allowanceSalary_Detail (allowance) values (5000000);


insert into salary(coefficient,level,allowance,net_salary) values (5000000,1,1,6000000);

insert into position(name,description) values('Employee','khong');
insert into position(name,description) values('Admin','khong');
insert into position(name,description) values('Manage','khong');


insert into project( name,description,start_date,end_date) values ('Project 1','Description 1','2003-10-10','2004-01-01');
insert into project( name,description,start_date,end_date) values ('Project 2','Description 2','2001-11-20','2002-03-11');
insert into project( name,description,start_date,end_date) values ('Project 3','Description 3','2010-12-30','2012-03-23');
insert into project( name,description,start_date,end_date) values ('Project 4','Description 4','2005-01-13','2006-03-01');
insert into project( name,description,start_date,end_date) values ('Project 5','Description 5','2020-02-24','2021-11-25');
insert into project( name,description,start_date,end_date) values ('Project 6','Description 6','2005-05-23','2006-05-01');
insert into project( name,description,start_date,end_date) values ('Project 7','Description 7','2001-07-19','2002-11-01');
insert into project( name,description,start_date,end_date) values ('Project 8','Description 8','2000-09-12','2001-12-11');


insert into employee(name,phone,gender,home_town,department_id,salary_id,position_id) values ('phu',09328467267,0,'hoc mon',1,1,2);
insert into employee(name,phone,gender,home_town,department_id,salary_id,position_id) values ('phan',08937627365,1,'binh thuan',2,1,3);
insert into employee(name,phone,gender,home_town,department_id,salary_id,position_id) values ('bang',08932746928,0,'go vap',3,1,3);
insert into employee(name,phone,gender,home_town,department_id,salary_id,position_id) values ('chuong',08937659368,1,'binh duong',1,1,3);
insert into employee(name,phone,gender,home_town,department_id,salary_id,position_id) values ('tu',08937674659,1,'quan 7',3,1,1);
insert into employee(name,phone,gender,home_town,department_id,salary_id,position_id) values ('hoa',08937265365,0,'hoc mon',1,1,1);



insert into timekeeping (date,working_hour,employee_id) values ('2002-10-02','11:00:00',1);

insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 1','2003-10-10','2004-01-01','Manage','4','1');
insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 2','2001-11-20','2002-03-11','Manage','2','2');
insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 3','2010-12-30','2012-03-23','Manage','3','3');
insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 4','2005-01-13','2006-03-01','Employee','1','4');
insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 5','2020-02-24','2021-11-25','Employee','5','5');
insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 6','2005-05-23','2006-05-01','Employee','6','6');
insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 7','2001-07-19','2002-11-01','Employee','1','7');
insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('description 8','2000-09-12','2001-12-11','Employee','6','8');




