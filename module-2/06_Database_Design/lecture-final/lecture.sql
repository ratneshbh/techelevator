-- Switch to the system (aka master) database
USE master;
GO

-- Delete the World Database (IF EXISTS)
DROP DATABASE IF EXISTS ArtSales

-- Create a new World Database
CREATE DATABASE ArtSales;
GO

-- Switch to the World Database
USE ArtSales
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION;

CREATE TABLE customer
(
--  column      type            constraint if any identity starts a 1 increments by 1
	customerid	int				identity(1,1),
	name		varchar(100)	NOT NULL,
	address		varchar(255)	NOT NULL,
	phone		varchar(20),
	--         name         type        column
	CONSTRAINT pk_customer PRIMARY KEY (customerid),
);

CREATE TABLE artist
(
	artistid	int		identity(100,5),
	firstname	varchar(255)	NOT NULL,
	lastname	varchar(255)	NOT NULL

	CONSTRAINT pk_artist PRIMARY KEY (artistid)  --
);

CREATE TABLE art
(
	artcode		char(4),
	arttitle	varchar(255) NOT NULL,
	artistid	int

	CONSTRAINT pk_art PRIMARY KEY (artcode),
	CONSTRAINT fk_art_artist FOREIGN KEY (artistid) REFERENCES artist(artistid)
);

CREATE TABLE sale
(
	customerid		int,
	artcode			char(4),
	purchasedate	datetime	NOT NULL,
	price			money		NOT NULL
								--composite primary key
	CONSTRAINT pk_sale PRIMARY KEY (customerid, artcode, purchasedate),
	CONSTRAINT fk_sale_customer FOREIGN KEY (customerid) REFERENCES customer(customerid),  --where is this from?
	CONSTRAINT fk_sale_art FOREIGN KEY (artcode) REFERENCES art(artcode)
);


COMMIT TRANSACTION;