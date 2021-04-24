-- Display all the films and their language

SELECT * 
FROM film
JOIN language ON film.language_id = language.language_id;

-- Display all the films and in English

SELECT * 
FROM film f
JOIN language l ON f.language_id = l.language_id
WHERE l.name = 'English';

-- Display all the films with their category

SELECT *
FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON fc.category_id = c.category_id;

-- Display all the films with a category of Horror

SELECT *
FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON fc.category_id = c.category_id
WHERE c.name = 'Horror';

-- Display all the films with a category of Horror and title that begins with the letter F

SELECT *
FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON fc.category_id = c.category_id
WHERE c.name = 'Horror' AND f.title LIKE 'F%';

-- Who acted in what together?

SELECT f.title, (actor1.first_name + ' ' + actor1.last_name) AS actor_one, actor2.first_name + ' ' + actor2.last_name
FROM film f
JOIN film_actor fa1 ON f.film_id = fa1.film_id
JOIN film_actor fa2 ON f.film_id = fa2.film_id AND fa1.actor_id <> fa2.actor_id
JOIN actor actor1 ON fa1.actor_id = actor1.actor_id
JOIN actor actor2 ON fa2.actor_id = actor2.actor_id;

-- How many times have two actors appeared together?

-- What movies did the two most often acted together actors appear in together?
