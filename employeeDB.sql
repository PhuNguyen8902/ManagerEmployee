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

CREATE TABLE salary (
	id int primary key identity(1,1),
	coefficient nvarchar (50),
	level char (20) NOT NULL,
	allowance char (20),
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
	birth_day varchar (20),
	gender tinyint not null check (gender in (0, 1)),
	home_town nvarchar (50),
	department_id int,
	salary_id int,
	position_id int,
	constraint fk_e_salary foreign key (salary_id) references salary(id),
	constraint fk_e_department foreign key (department_id) references department(id),
	constraint fk_e_position foreign key (position_id) references position(id)
	--CONSTRAINT pk_NHANVIEN PRIMARY KEY (MANV)
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
