-- Switch to the system (aka master) database
USE master;
GO

-- Delete the World Database (IF EXISTS)
DROP DATABASE IF EXISTS ProjectOrganizer

-- Create a new World Database
CREATE DATABASE ProjectOrganizer;
GO

-- Switch to the World Database
USE ProjectOrganizer
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION;

CREATE TABLE department
(
--  column      type            constraint if any identity starts a 1 increments by 1
	departmentnumber int			IDENTITY(1,1),   --IDENTITY is a database assigned value
	departmentname	 varchar(50)	UNIQUE NOT NULL,
	

	CONSTRAINT pk_department PRIMARY KEY (departmentnumber)



);


CREATE TABLE project
(
	projectnumber int			IDENTITY(1,1),
	projectname	  varchar(100)	NOT NULL,
	startdate	  date			NOT NULL

	CONSTRAINT pk_project PRIMARY KEY (projectnumber), -- is this correct? I think so. Check the lecture one
	
);

CREATE TABLE employee
(
	employeenumber				int				 IDENTITY(1000,1),
	dateofhire					date			 NOT NULL,
	departmentnumber			int				 NOT NULL,
	jobtitle					varchar(255)	 NOT NULL,
	lastname					varchar(50)		 NOT NULL,
	firstname					varchar(50)		 NOT NULL,
	gender						varchar(20)		 NOT NULL,
	dateofbirth					date			 NOT NULL

	CONSTRAINT pk_employee PRIMARY KEY (employeenumber),  --verify that this syntax is correct - think so
	CONSTRAINT fk_employee_department FOREIGN KEY (departmentnumber) REFERENCES department(departmentnumber)  --i think this is correct 
);

CREATE TABLE project_assignments (

	projectnumber  int,	
	employeenumber int,
	

	CONSTRAINT pk_assignments_employee PRIMARY KEY (projectnumber, employeenumber),
	CONSTRAINT fk_assignments_project FOREIGN KEY (projectnumber) REFERENCES project(projectnumber),
	CONSTRAINT fk_assignments_employee FOREIGN KEY (employeenumber) REFERENCES employee(employeenumber)

);



COMMIT TRANSACTION;

INSERT INTO department(departmentname)
VALUES	('Accounting'), 
		('Underwriting'), 
		('Product');

INSERT INTO project (projectname, startdate) VALUES ( 'Accounting', '2012-08-31');
INSERT INTO project (projectname, startdate) VALUES ('Underwriting', '2013-10-15');
INSERT INTO project (projectname, startdate) VALUES ('Product', '2018-03-21');

SET IDENTITY_INSERT employee OFF;

INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (1, '2012-09-17', 'Chief Visionary Officer', 'Smith', 'Greg', 'M', '1953-07-15');
INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (2, '2012-09-18', 'Chief Executive Officer', 'Jones', 'Paul', 'M', '1954-07-15');
INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (3, '2012-09-19', 'Chief Financial Officer', 'Dior', 'Vincent', 'M', '1955-07-15');
INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (1,  '2012-09-20', 'Chief People Officer', 'Timpkins', 'Rhonda', 'F', '1956-07-15');
INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (2,  '2012-09-21', 'Chief Cheerleading Officer', 'Simpkins', 'Linda', 'F', '1957-07-15');
INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (3,  '2012-09-22', 'Chief Taxation Officer', 'Dinkins', 'Marion', 'M', '1958-07-15');
INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (1,  '2012-09-23', 'Chief Marketing Officer', 'Kinkins', 'Cameron', 'M', '1959-07-15');
INSERT INTO employee (departmentnumber, dateofhire, jobtitle, lastname, firstname, gender, dateofbirth)
VALUES (2,  '2012-09-24', 'Chief Operating Officer', 'Linkins', 'Samuel', 'M', '1960-07-15');

