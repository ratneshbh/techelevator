-- Display all the films and their language

SELECT * 
FROM film; 
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
WHERE c.name = 'Horror' AND f.title LIKE 'F%';   ---wilcard % - starts with F

-- Who acted in what together?

SELECT * 
FROM film f
JOIN film_actor fa ON f.film_id = fa.film_id
JOIN actor a ON fa.actor_id = a.actor_id; 

-- How many times have two actors appeared together?

-- What movies did the two most often acted together actors appear in together?
