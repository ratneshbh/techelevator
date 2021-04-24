
-- Switch to the system (aka master) database
USE master;
GO

DROP DATABASE IF EXISTS ArtSales

-- Delete the World Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='ArtSales')
DROP DATABASE ArtSales;
GO

-- Create a new World Database
CREATE DATABASE ArtSales;
GO

-- Switch to the World Database
USE ArtSales
GO

BEGIN TRANSACTION;

CREATE TABLE customer 
(
	
	customerid  int				identity(1,1), 
	name		varchar(100)	NOT NULL, 
	address		varchar(255)	NOT NULL,
	phone		varchar(20), 

	CONSTRAINT pk_customer PRIMARY KEY (customerid)
);


COMMIT TRANSACTION;

