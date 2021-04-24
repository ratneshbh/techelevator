BEGIN TRANSACTION

-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

SELECT * FROM actor
ORDER BY last_name
INSERT INTO actor(last_name, first_name)
VALUES ( 'Avenue', 'Hampton'), ('Byway', 'Lisa');

-- this has been done and runs

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

--select *
--from film
-- checked - this was added 



INSERT INTO film(title, description, release_year, language_id,length)
VALUES ('Euclidean PI','The epic story of Euclid as a pizza delivery boy in 
ancient Greece','2008','1','198');


-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother
--SELECT * FROM film_actor
--ORDER BY film_id DESC




INSERT INTO actor(first_name,last_name)
VALUES ((SELECT first_name FROM actor WHERE first_name = 'HAMPTON' AND last_name = 'AVENUE'),(SELECT last_name FROM actor WHERE first_name = 'LISA' AND last_name = 'BYWAY'));


--INSERT INTO film_actor(actor_id,film_id)
--VALUES ((SELECT actor_id FROM actor WHERE first_name = 'LISA' AND last_name = 'BYWAY'),(SELECT film_id FROM film WHERE title = 'Euclidean PI'))
--COMMIT;


-- 4. Add Mathmagical to the category table.
--SELECT * FROM category

INSERT INTO category (name) VALUES ('Mathmagical');




-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"




INSERT INTO film_category
	(film_id, category_id)
	VALUES ((SELECT film_id
			FROM film
			WHERE title = 'Euclidean PI'),
			(SELECT category_id
			FROM category
			WHERE name = 'Mathmagical'));

INSERT INTO film_category
	(film_id, category_id)
	VALUES ((SELECT film_id
			FROM film
			WHERE title = 'Egg Igby'),
			(SELECT category_id
			FROM category
			WHERE name = 'Mathmagical'));

INSERT INTO film_category
	(film_id, category_id)
	VALUES ((SELECT film_id
			FROM film
			WHERE title = 'Karate Moon'),
			(SELECT category_id
			FROM category
			WHERE name = 'Mathmagical'));

INSERT INTO film_category
	(film_id, category_id)
	VALUES ((SELECT film_id
			FROM film
			WHERE title = 'Random Go'),
			(SELECT category_id
			FROM category
			WHERE name = 'Mathmagical'));

INSERT INTO film_category
	(film_id, category_id)
	VALUES ((SELECT film_id
			FROM film
			WHERE title = 'Young Language'),
			(SELECT category_id
			FROM category
			WHERE name = 'Mathmagical'));

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)  --getting 4 rows affected is my answer fine?

--SELECT *
--FROM category
--WHERE  name = 'Mathmagical'

--SELECT * FROM film WHERE title = 'Mathmagical'

--BEGIN TRANSACTION;

UPDATE film SET rating = 'G'
WHERE film_id IN
(SELECT film_id FROM film_category WHERE category_id IN
(SELECT category_id FROM category WHERE name = 'Mathmagical'));

--COMMIT;

--ROLLBACK TRANSACTION;



-- 7. Add a copy of "Euclidean PI" to all the stores.

--INSERT INTO inventory (store_id, film_id)
--VALUES (
--(SELECT  film.film_id
--FROM    film
--WHERE   title = 'Euclidean PI'),1);

--INSERT INTO inventory (store_id, film_id)
--VALUES (
--(SELECT  film.film_id
--FROM    film
--WHERE   title = 'Euclidean PI'),2);


--
INSERT INTO inventory (film_id, store_id)
SELECT (SELECT film_id FROM film WHERE title = 'EUCLIDEAN PI'), store_id FROM store;


--SELECT film_id
--FROM film WHERE title = 'Euclidean PI'

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>






DELETE FROM film WHERE title = 'Euclidean PI';




-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>


DELETE FROM category WHERE name = 'Mathmagical';

ROLLBACK

--I think it succeeded this time

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

--SELECT *
--FROM film_category;

--DELETE FROM film_category WHERE category_id = --not sure



-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
--SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
--SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

