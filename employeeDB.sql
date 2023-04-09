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
	net_salary float,
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

insert into account(user_name,password,full_name,email,type,employee_id) values ('admin','123','Admin','admin@gmail.com','Admin',null);

insert into department(name,phone,address) values ('toa 1',012312312,'hoc mon');

insert into levelSalary_Detail (coefficient,level) values(5000000,'nhân viên');
insert into levelSalary_Detail (coefficient,level) values(10000000,'quản lý');
insert into levelSalary_Detail (coefficient,level) values(15000000,'phó giám đốc');
insert into levelSalary_Detail (coefficient,level) values(20000000,'giám đốc');

insert into allowanceSalary_Detail (allowance) values (1000000);
insert into allowanceSalary_Detail (allowance) values (2000000);
insert into allowanceSalary_Detail (allowance) values (3000000);

insert into salary(coefficient,level,allowance,net_salary) values (5000000,1,1,6000000);

insert into position(name,description) values('nhanvien','khong');

insert into project( name,description,start_date,end_date) values ('du an 1','mo ta 1','2003-10-10','2010-01-01');

insert into employee(name,phone,gender,home_town,department_id,salary_id,position_id) values ('phu',01321232,0,'hoc mon',1,1,1);

insert into timekeeping (date,working_hour,employee_id) values ('2002-10-02','11:00:00',2);

insert into employee_project (description,start_date,end_date,role,employee_id,project_id) values('mo ta 1','2005-10-10','2008-04-04','nhan vien','2','1');



