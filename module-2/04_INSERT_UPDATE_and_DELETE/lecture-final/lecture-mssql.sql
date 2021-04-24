-- INSERT

-- 1. Add Klingon as a spoken language in the USA

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA','Klingon', 0, 0.0006);

SELECT * 
FROM countrylanguage
WHERE countrycode = 'USA';

-- 2. Add Klingon as a spoken language in Great Britain (GBR)

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('GBR', 'Klingon', 0, 0.0073);

SELECT * 
FROM countrylanguage
WHERE countrycode = 'CHN';

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES (
	(
	 SELECT code 
	 FROM country 
	 WHERE name = 'CHINA'), 
	'Klingon', 0, 0.0073
	);


-- UPDATE

-- 1. Update the capital of the USA to Houston
--MUST HAVE WHERE CLAUSE
UPDATE country
	SET capital = (
		SELECT id 
		FROM city 
		WHERE name = 'Cincinnati')
WHERE code = 'USA';

SELECT country.name, c.name
FROM country
JOIN city c ON country.capital = c.id
WHERE country.code = 'USA';

SELECT id 
FROM city 
WHERE name = 'Houston';

-- 2. Update the capital of the USA to Washington DC and the head of state
--MUST HAVE WHERE CLAUSE
SELECT id FROM city WHERE name = 'Washington';

UPDATE country
	SET capital = 3813,
		headofstate = 'Biden'
WHERE country.code = 'USA';

UPDATE country
 SET capital = (
		SELECT id FROM city WHERE name = 'Washington'
		),
	headofstate = 'Biden'
WHERE country.code = 'USA';

SELECT country.name, c.name, country.capital, country.headofstate
FROM country
JOIN city c ON country.capital = c.id
WHERE country.code = 'USA';

SELECT * FROM city WHERE name like 'Wash%';
-- DELETE
--MUST HAVE WHERE CLAUSE

-- 1. Delete English as a spoken language in the USA

SELECT * from countrylanguage 
WHERE countrycode = 'USA' AND language = 'English';

DELETE FROM countrylanguage
WHERE countrycode = 'USA' AND language = 'English';

-- 2. Delete all occurrences of the Klingon language 

SELECT * FROM countrylanguage WHERE language = 'Klingon';

DELETE FROM countrylanguage
WHERE language = 'Klingon';

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.

INSERT INTO countrylanguage (language)
VALUES ('Elvish');


-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
SELECT code FROM country WHERE code = 'ZZZ';

INSERT INTO countrylanguage (countrycode,language, isofficial, percentage)
VALUES ('ZZZ', 'English', 0, 5.2);

SELECT *
FROM city
JOIN country c ON city.countrycode = c.code;

-- 3. Try deleting the country USA. What happens?
 
SELECT * FROM country
WHERE code = 'USA';

DELETE FROM country
WHERE code = 'USA';

SELECT * FROM city WHERE countrycode = 'USA';

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA','English', 1, 95.3);


-- 2. Try again. What happens?

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA','English v2', 1, 95.3);

-- 3. Let's relocate the USA to the continent - 'Outer Space'

UPDATE country
	SET continent = 'Outer Space'
WHERE code = 'USA';

-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.
SELECT COUNT(*) from countrylanguage;

BEGIN TRANSACTION
--danger zone
--DELETE FROM countrylanguage;
--SELECT COUNT(*) from countrylanguage;
UPDATE countrylanguage
	SET isofficial = 0
WHERE countrycode = 'ABW';
ROLLBACK TRANSACTION

SELECT COUNT(*) from countrylanguage;

-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table where one 
--happens to be inside of a transaction but hasn't committed yet.