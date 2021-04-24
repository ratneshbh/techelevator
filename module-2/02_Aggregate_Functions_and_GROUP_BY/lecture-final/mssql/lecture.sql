-- ORDERING RESULTS

-- Populations of all countries in descending order
SELECT name, population 
FROM country
ORDER BY population DESC;

--Names of countries and continents in ascending order

SELECT name, continent
FROM country
ORDER BY continent ASC, name DESC;

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
SELECT TOP 10 name, lifeexpectancy
FROM country
ORDER BY lifeexpectancy DESC;

-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city

SELECT (name + ', ' + district) AS districtandstand
FROM city
WHERE district IN ('California','Oregon','Washington')
ORDER BY district ASC, name ASC;

-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World

SELECT AVG(lifeexpectancy) AS lifeexpectancyaverage
FROM country;

-- Total population in Ohio

SELECT SUM(population) AS ohiopopulation
FROM city
WHERE district = 'Ohio';

-- The surface area of the smallest country in the world

SELECT MIN(surfacearea)
FROM country;
-- The 10 largest countries in the world

SELECT TOP 10 name, surfacearea
FROM country 
ORDER BY surfacearea DESC;

-- The number of countries who declared independence in 1991
SELECT COUNT(*) FROM country;

SELECT COUNT(*) as indep
FROM country
WHERE indepyear = 1991;

-- GROUP BY
-- Count the number of countries where each language is spoken, 
--ordered from most countries to least

SELECT DISTINCT(language) 
FROM countrylanguage;

SELECT COUNT(*) AS noc, language
FROM countrylanguage
GROUP BY language
ORDER BY noc DESC;


-- Average life expectancy of each continent ordered from highest to lowest
--avg
--country, lifeexp, continent
--order

SELECT AVG(lifeexpectancy) AS avg, continent 
FROM country
GROUP BY continent
ORDER BY avg DESC;


-- Exclude Antarctica from consideration for average life expectancy
--WHERE lifeexpectancy IS NOT NULL

SELECT AVG(lifeexpectancy) AS timetildeath, continent 
FROM country
WHERE continent <> 'Antarctica'
GROUP BY continent
ORDER BY timetildeath DESC;

-- Sum of the population of cities in each state in the USA ordered by state name
-- city
-- sum

SELECT SUM(population) as statepop, district
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district ASC;


-- The average population of cities in each state in the USA ordered by state name

SELECT AVG(population) as statepopavg, district
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district ASC;

SELECT COUNT(DISTINCT(district))
FROM city
WHERE countrycode = 'USA'

-- SUBQUERIES
-- Find the names of cities under a given government leader
SELECT * from city 
WHERE countrycode IN (
	SELECT code 
	FROM country 
	WHERE headofstate = 'Beatrix'
);

-- Find the names of cities whose country they belong to has not declared independence yet
--country
--city

SELECT * from city 
WHERE countrycode IN (
	SELECT code 
	FROM country 
	WHERE indepyear IS NULL
);

-- Additional samples
-- You may alias column and table names to be more descriptive

SELECT name AS cityname
FROM city AS c

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

SELECT * 
FROM city
WHERE name = 'Arlington'
ORDER BY name ASC, district DESC;


-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)

SELECT name
FROM city
ORDER BY name --must be used with order by
OFFSET 100 ROWS 
FETCH NEXT 100 ROWS ONLY;

-- Most database platforms provide string functions that can be useful for working with string data. 
--In addition to string functions, string concatenation is also usually supported, 
--which allows us to build complete sentences if necessary.

SELECT (name + ' is in the country ' + countrycode  ) as fulltext
FROM city

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX.
--Only returns a single row of value(s) unless used with GROUP BY.
-- Counts the number of rows in the city table

-- Also counts the number of rows in the city table

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
