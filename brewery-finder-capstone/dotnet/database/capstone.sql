USE master
GO

--drop database if it exists
IF DB_ID('final_capstone') IS NOT NULL
BEGIN
	ALTER DATABASE final_capstone SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE final_capstone;
END

CREATE DATABASE final_capstone
GO

USE final_capstone
GO

--create tables
CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	user_role varchar(50) NOT NULL,
	first_name varchar(50),
	last_name varchar(50),
	email varchar(100),
	DOB date,
	active bit,
	CONSTRAINT PK_user PRIMARY KEY (user_id)
);

CREATE TABLE brewery (
	brewery_id int IDENTITY(1,1) NOT NULL,
	name varchar(50) NOT NULL,
	phone_number varchar(60),
	brewery_email varchar(100),
	address varchar(200),
	zipcode varchar(100),
	city varchar(250),
	state varchar(250),
	history varchar(1000),
	active bit,
	brewery_img varchar(7000),
	user_id int,
	logo varchar(4000),
	CONSTRAINT PK_brewery PRIMARY KEY (brewery_id),
	
);
CREATE TABLE operation (
	id int IDENTITY(1,1),
	monday varchar(50),
	tuesday varchar(50),
	wednesday varchar(50),
	thursday varchar(50),
	friday varchar(50),
	saturday varchar(50),
	sunday varchar(50),
	brewery_id int,
	CONSTRAINT PK_hours PRIMARY KEY(id),
);

CREATE TABLE beers (
	beer_id int IDENTITY(1,1),
	name varchar(100),
	description varchar(500),
	img varchar(500),
	abv decimal(18,1),
	brewery_id int,
	beer_type varchar(50),
	active_beer bit,
	

	CONSTRAINT PK_beer PRIMARY KEY (beer_id),

);
CREATE TABLE ratings(
	rating_id int IDENTITY(2500,3),
	rating int,
	title varchar(500),
	review varchar(1000),
	user_id int,
	beer_id int,

	CONSTRAINT PK_rating PRIMARY KEY (rating_id),
);
CREATE TABLE favorites(
	favorite_id int IDENTITY(1,3),
	user_id int,
	brewery_id int,
	
	CONSTRAINT PK_favorites PRIMARY KEY (favorite_id),

);
ALTER TABLE brewery
	ADD FOREIGN KEY(user_id) REFERENCES users(user_id);

ALTER TABLE beers
	ADD FOREIGN KEY(brewery_id) REFERENCES brewery(brewery_id);

ALTER TABLE operation 
	ADD FOREIGN KEY(brewery_id) REFERENCES brewery(brewery_id);

ALTER TABLE ratings
	ADD FOREIGN KEY(user_id) REFERENCES users(user_id);
ALTER TABLE ratings
	ADD FOREIGN KEY(beer_id) REFERENCES beers(beer_id);

ALTER TABLE favorites
	ADD FOREIGN KEY(user_id) REFERENCES users(user_id);
ALTER TABLE favorites
	ADD FOREIGN KEY(brewery_id) REFERENCES brewery(brewery_id);



INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('jonnien','fJnUh2pOEqhWhCqi5yvJ/CHV6GE=','A6osdPJs1uk=','Beer Lover','Jonnie','Niesz','startrekfan89@gmail.com','01/19/1995',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('chris','/+FGw7esicI1mNae2KWDTLAWyY4=','8IgLCCCvF8A=','Brewer','Chris','Templeton','chris@email.com','01/19/1995',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('admin','7/6QNlwk8FnuChVfuI2dgsHsPuw=','drMiKwICRn4=','Admin','admin','admin','admin@email.com','01-01-1990',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('beerlover','CsY5h3HCCzhNIGNmV2Ot3ES3INo=','2pvx2ZHJNOw=','Beer Lover','beer','lover','beerlover@email.com','03-15-2000',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('brewer','58gFQbNB04gmwCWnmhHFPiNaR7w=','ZhU1sxXo7h4=','Brewer','brewer','brewer','brewer@email.com','07-01-1969',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('hopslover','HYHdqTTV6svrSgVL9ex1QfEml2g=','ifoU+EQ3G3k=','Beer Lover','hops','lover','hopslover@email.com','01-01-1998',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('porterh8r','1p8/HPi63jEs8J3mNy5kJv64VEo=','2do7zn9uf4M=','Beer Lover','porter','hater','porterh8r@email.com','05-19-1995',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('live4lagers','pbUBeZ55xwgBE2zJRhzK+JtKrCc=','hTckh3g5QCc=','Beer Lover','live4','lagers','live4lagers@email.com','03-13-2000',1);

INSERT INTO users(username,password_hash,salt,user_role,first_name,last_name,email,DOB,active)
VALUES('fruitygirl','pbUBeZ55xwgBE2zJRhzK+JtKrCc=','hTckh3g5QCc=','Beer Lover','fruity','girl','fruitygirl@email.com','09/05/1998',1);




INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('Northern Row','(513)436-7000','marketing@northernrow.com','111 W McMicken Ave','45202','Cincinnati','Ohio','Situated in the historic Over-the-Rhine Brewery District, Northern Row Brewery and Distillery occupies a notable pre-prohibition building, constructed in 1895.  Convenient to the street car, our friends at Rhinegeist, and all the culinary deliciousness at Findlay Market, imbibers and friends are sure to find endless options in our neighborhood. Our name harkens back to our roots prior to the 18th Amendment (Prohibition).  Back then, Liberty Street was the north boundary of Cincinnati city limits.  North of that street was the area known as Northern Row.  It was the heart of the Cincinnati brewing industry.',1,'https://cdn.citybeat.com/files/base/scomm/cb/image/2019/05/960w/NorthernRowBrewing_HB_15.5cdb2e7194008.jpg', 5,'https://lh3.googleusercontent.com/cQQsD35yTmfZEBun6AYlkD9c_o5EdOtaA_3_1bU8V2iq5xq1BABgYbAMHNI52WopAUjXG4SCSUzhLDQZcfJdJVKuNbad1w=s750');

INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('MadTree','(513)836-8733','info@madtreebrewing.com','3301 Madison Road','45209','Cincinnati','Ohio','When MadTree started eight years ago, we were driven to craft great beer, but more importantly, to build something bigger than ourselves and the high-quality beer we produce. Since the beginning, we have cared deeply about creating meaningful connections with our communities. We embrace our name MadTree and work to celebrate and protect nature, while reducing our impact on the environment. We are proud members of 1% for the Planet, with a commitment to donate 1% of our sales to non-profits focused on environmental sustainability. The craftspeople at MadTree wake up every day to connect people to nature and each other.',1,'https://ohiomagazine.imgix.net/sitefinity/images/default-source/articles/2019/02---february-2019/madtree-interior-2.jpg?sfvrsn=74d9a938_2&w=960&auto=compress%2Cformat', 5,'https://d2pxm94gkd1wuq.cloudfront.net/BreweryLogos/Standard/568634387.madtree.logo.green-squarepng.png');

INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('Streetside','(513)615-5877','streetside@gmail.com','4003 Eastern Ave.','45226','Cincinnati','Ohio','In November 1788, the intersection of a dream and a pioneering spirit ignited Benjamin Stites and 26 others to found the settlement of �Columbia� along the banks of the Ohio near the Little Miami River. Now known as Columbia-Tusculum, Streetside Brewery is proud to be rooted in Cincinnati�s oldest neighborhood. With the same industrious energy, the Hickey family, Streetside Brewery founders and residents of Columbia-Tusculum, strives to provide a down-to-earth experience with a selection of exceptional craft beer that�s as diverse, and original, as the community they serve. Streetside Brewery beers run the gamut from IPAs and Wheats to Lagers and Stouts and specialty beers are featured seasonally. The taproom also spotlights guest taps to support fellow local breweries.',1,'https://2blxhf2wgxaolzlxi2xuosnn-wpengine.netdna-ssl.com/wp-content/uploads/2019/10/Streetside-Brewery-Patio.jpg', 2,'https://i0.wp.com/www.craftbeerjoe.com/wp-content/uploads/2017/09/streetside-logo-lrg.png?fit=400%2C152&ssl=1');

INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('Wiedemann Brewery','(513)482-6970','info@wiedemannbeer.com','4811 Vine Street','45217','Cincinnati','Ohio','German immigrant George Wiedemann began brewing Wiedemann�s Fine Beer way back in 1870. He had moved from Cincinnati, where he was brewmaster at Kauffmann Brewery in Over-the-Rhine, to Newport, where he partnered with John Butcher at the Jackson Street Brewery. That�s where Wiedemann�s beer was born and the legend began. That�s the time-tested tradition to which the new brewery in St. Bernard is still dedicated. Stop in and taste it for yourself, fresh from the barrel.',1,'https://www.gannett-cdn.com/presto/2020/08/03/PCIN/aa09ec77-343e-4668-8974-7bcfe29701f4-Wiedemanns_Exterior_Front.jpg', 2,'https://wiedemannsfinebeer.com/wp-content/uploads/2018/01/logoWhiteTransBG.png');

INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('North High Brewing','(614) 639-8800','info@northhighbrewing.com','2724 Erie Ave','45208','Cincinnati','Ohio','North High Brewing was founded in 2011 by a couple of guys who were passionate about great beer and fun times, and we opened our doors here in 2012 as just the 7th brewery in Central Ohio. Although the majority of our beer is now produced at our warehouse a half a mile from here, our Short North taproom remains to be the face of our business while we expand into more brewpubs and kitchens. Thank you for supporting local!',1,'https://www.breakfastwithnick.com/wp-content/uploads/img_9803.jpg', 2,'https://shortnorth.org/wp-content/uploads/2015/04/north-high-logo.jpg');

INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('Brooklyn Brewery','(718)486-7422','info@brooklynbrewery.com','79 N 11th St','11249','Brooklyn','New York','Our team stretches around the planet, ensuring our beer is delicious, adventurous, and available to all. Walk through our Packaging Hall in Brooklyn and you�ll meet people from over a dozen countries, speaking more than twenty languages.',0,'https://api.time.com/wp-content/uploads/2016/10/161013_em_brooklynbrewery.jpg?w=800&quality=85', 2,'https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Brookylnbrewery.svg/800px-Brookylnbrewery.svg.png');

INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('Smokehouse Brewing Co','(614)485-0BBQ','alex@smokehousebrewing.com','1130 Dublin Road','43215','Columbus','Ohio','Smokehouse Brewing Company is a community place where one feels at home, no matter where home happens to be',0,'https://cdn.usarestaurants.info/assets/uploads/4f321f244a78f98b0668d589891e5c20_-united-states-ohio-franklin-county-columbus-414133-smokehouse-brewing-companyhtm.jpg', 2,'https://www.smokehousebrewing.com/images/home_header1.jpg');

INSERT INTO brewery(name,phone_number,brewery_email,address,zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('Doolally Taproom','01191(022)48931314','placeholder2@gmail.com','10A Road Number 3','400052','Mumbai','Maharashtra','The first microbrewery in India, with three outlets in Mumbai',0,'https://imgmediagumlet.lbb.in/media/2017/08/599470d03e05710dff4c8621_56aad8b4dae5d95f37743284_1502900432931.jpg?fm=webp&w=750&h=500&dpr=2', 2,'https://doolally.in/asset/images/splashLogo.png');

INSERT INTO brewery(name,phone_number,brewery_email,address, zipcode, city, state, history,active,brewery_img,user_id,logo)
VALUES('Rhinegeist','(513) 381-1367','taproom@rhinegeist.com','1910 Elm St','45202','Cincinnati','Ohio','Rhinegeist is a craft brewery based in the Over-The-Rhine historical neighborhood of Cincinnati, Ohio. We have built a strong and dedicated team that believes in the power and beauty of great beer.',1,'https://rhinegeist.com/wp-content/uploads/2018/07/visit-hero.png', 5,'https://rhinegeist.com/wp-content/uploads/2018/08/rhinegeist-fb-default.png');



INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Mango Cider','A cider made with kesar mangoes','https://images.indianexpress.com/2016/02/doolallycider-pint-with-mango_759_mumbai-pune.jpg',4,8,'Cider',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Smoked Porter','Few words in the dictionary can describe the smoky, woody flavours of this beer. Even Shashi Tharoor would struggle.','https://untappd.akamaized.net/photos/2020_09_17/c23ef6952fa4c7477fe581a3d9ed1d26_raw.jpg',5.7,8,'Porter',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Preacher','Golden ale with a fresh addition of peach and apricot puree','https://untappd.akamaized.net/site/beer_logos_hd/beer-3256736_c500c_hd.jpeg',5.5,1,'Fruit Beer',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Heckler','Not just hops! Juicy citrus aroma with a pronounced bitter touch - Mosaic and Citra hops.','https://blog.twobeerdudes.com/wp-content/gallery/ohio-2021-february/21036001000005.jpg',7,1,'IPA',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Shade','If a shortcut through the woods beats the heat, why not take it? Though non-traditional, Shade�s blackberries and sea salt quench thirst amidst any sunny day. Feel free to kick back and relax, the �Tree has you covered.','https://untappd.akamaized.net/site/beer_logos_hd/beer-1156045_e8d85_hd.jpeg',4.6,2,'Fruit Beer',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Rubus Cacao','Sweet chocolate notes lead as raspberry tartness follows in unison resembling a perfectly executed dance. The result is a blend of flavors even more spectacular together than apart. It�s love at first sip.','https://untappd.akamaized.net/site/beer_logos_hd/beer-493755_f2ee6_hd.jpeg',7,2,'Stout',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Java Mama','Cousin to our wildly popular Wake Me Up coffee stout. Java Mama starts off with a strong kick of coffee complemented by mild hop bitterness and a rich French vanilla finish!','https://untappd.akamaized.net/site/beer_logos_hd/beer-4017492_c838e_hd.jpeg',4,4,'Blonde Ale',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Monkeys Dunkle','German-style Munich Dunkel with a flavorful melding of roasted, slightly nutty malts','https://untappd.akamaized.net/photos/2020_11_07/b970e63e9f9dbe984bf78cf1b88a32a7_640x640.jpg',5,4,'Lager',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('John Lemon','Based on the homebrew recipe of our buddies Brandon Lomax and Kory Roaden, scaled up for production, John Lemon is a tasty treat hopped generously with Citra for delightful citrus flavors. Lemon juice and vanilla add the perfect lemon meringue and whipped cream flavors, while a smooth milkshake mouthfeel, complemented by our heavy handed oat-filled grist bill, caresses the palate. We hope you enjoy this beer as much as we enjoyed brewing it with our friends!','https://untappd.akamaized.net/site/beer_logos_hd/beer-2552524_041ad_hd.jpeg',6.2,3,'IPA',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Suh,Brah','Starting with an intense nose of stone, fruit, grapefruit, and light pineapple, Suh, Brah?''s aromatics are created by piney dank notes from our double dry hop of Simcoe hopes. Suh, Brah?''s flavor leads with soft mango and pineapple, peach, and light dankness and then is rounded out by a soft, fluffy, almost creamy body.','https://untappd.akamaized.net/site/beer_logos_hd/beer-1805650_a88d6_hd.jpeg',6.7,3,'IPA',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Filthy McNasty','A big, bold stout showcasing layers of chocolate, coffee and roast character.','https://untappd.akamaized.net/photos/2021_04_07/578fd9a7aa00758dc658d777860fe074_raw.jpg',9,5,'Stout',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Cover Crop','An easy drinking ale brewed with all Ohio malt and hops','https://www.porchdrinking.com/wp-content/uploads/2019/01/North-High-Cover-Crop-Beer-4-700x325.jpg',4.5,5,'Stout',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Black Chocolate Stout','Rich roasted malts come together to create an unmistakable dark chocolate flavor perfect for special occasions and late nights by the fire.','https://brooklynbrewery.com/wp-content/uploads/2019/10/beer-1@3x-2-828x1024.jpg',10,6,'Stout',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Oktoberfest','Our take on the classic M�rzen lager style with sweet, bready malts and German noble hops.', 'https://brooklynbrewery.com/wp-content/uploads/2019/10/beer-1@2x-5-828x1024.jpg',5.5,6,'Golden Ale',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Alexanders Russian Imperial Stout','The result is a roasty, fruity beer that you might be tempted to eat with a spoon.', 'https://untappd.akamaized.net/photos/2020_12_10/c0c1b69da11bbb208154192a6fb4b919_640x640.jpg',7.6,7,'Stout',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Centennial India Pale Ale','First brewed to celebrate our 100th batch, this IPA is a British-style IPA. Whole hop additions add a citrus fruitness.', 'https://untappd.akamaized.net/photos/2021_01_24/b2c252cc70466da4fab2c61c9360bee9_raw.jpg',7.6,7,'IPA',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('PsycHOPathy','Explore the blend of citrus, bright, and floral aromas. Additional citrus flavors follow alongside a smooth bitterness. It finishes with a medium body and a slightly sweet, malty backbone. Trust your senses.', 'https://cdn.shopify.com/s/files/1/0384/0697/9715/products/9ce080ab3e90a4e731525887d6f2f51f_480x480.jpg?v=1596490586',6.9,2,'IPA',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('ThunderSnow','The conditions have to be just right for the formation of Thundersnow. Ginger, nutmeg, vanilla, hints of cinnamon and a bready malt sweetness are the secret. When you find this rare occurrence, savor it as long as you can.', 'https://i1.wp.com/www.thegnarlygnome.com/wp-content/uploads/2020/01/MadTree-Thundersnow-Label-1.jpeg?ssl=1', 8.5,2,'Scottish Ale',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('The Great PumpCAN','There are three things we have learned to never discuss with people here: religion, politics and The Great Pumpkin, But that doesn''t mean we can''t welcome our own Great PumpCan. So sing pumpkin carols and enjoy MadTree''s way of delivering some delicious pumpkin pie flavor right to your gullet.', 'https://untappd.akamaized.net/site/beer_logos_hd/beer-_470007_hd_bf31b77d9ab4119363a10b0eeff0ec.jpeg', 7.9,2,'Pumpkin Beer',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Bubbles', 'A bright, dry, and lithe Ros� Ale with apple, peach, and cranberry for tartness and blush. Bubbles erupts with effervescence and evanescence. ', 'https://rhinegeist.com/wp-content/uploads/2018/08/Bubbles_CanRender-768x1179.png', 6.2, 9,'Fruit Beer',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Cheetah', 'Swift in body and mind, Cheetah sprints ever forward. A blur of pure instinct. Buena onda. Pure, crisp, clean. Blissful simplicity. Savor this moment. All we have and all we need is now. Feel free and therefore you are free.', 'https://rhinegeist.com/wp-content/uploads/2018/08/Cheetah_12oz_CanRender-768x1179.png', 4.8, 9,'Lager',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Glow', 'Fruit forward and refreshingly tart, this Fruited Sour Ale illuminates palates with a bright blend of a�a�, prickly pear and passionfruit flavors highlighted with a hint of sea salt. Glow emits a flavorful, aromatic epiphany.', 'https://rhinegeist.com/wp-content/uploads/2021/02/Glow_CanRender-768x1179.png', 4.5, 9,'Fruited Sour Ale',1);

INSERT INTO beers(name,description,img,abv,brewery_id,beer_type,active_beer)
VALUES('Truth', 'Rare are moments of truth, when you�ve struck the last match, belting out tunes with your friends, staring deep into the campfire � times when you feel infinite. Our Truth is found in the scintillating brilliance of hops. Brewed with a nod to the Pacific, hops sizzle with tropical fruit aroma, grapefruit and mango notes and a dry finish.', 'https://rhinegeist.com/wp-content/uploads/2018/07/Truth_CanRender-768x1179.png', 7.2, 9,'IPA',1);




INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',1);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',2);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',3);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',4);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',5);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',6);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',7);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('10-5','10-5','10-5','10-5','10-5','10-9','10-9',8);

INSERT INTO operation(monday,tuesday,wednesday,thursday,friday,saturday,sunday,brewery_id)
VALUES ('3-10','3-10','3-10','3-10','12-12','12-12','12-9', 9);



INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Tropical get away, sorta', 2,'Fruity, tropical scent without much hop nose. Quite thin and light. Not bitter.', 6, 4);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('A juicy ipa', 3,'Kinda whatever. Not bad but just doesn�t do a lot for me.', 8, 4);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Peachy Goodness', 5,'The peach gets stronger with each sip.', 9, 3);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Tasty fruit beer', 4,'very apricot, which always seems to be very difficult to pull off. Well done!', 8, 3);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Breakfast beer? Or Dessert Beer?', 5,'Tastes like a breakfast beer with the tart blackberry flavor. Quenches your thirst and takes you on a delicious ride.', 9, 5);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Bold flavor',4,'Wow. Make sure you get a buddy to drive you home after this one. The only knock is that you can taste the high ABV.', 9, 11);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Very bitter strong taste',1,'Not really an IPA guy. Very bitter flavor and aftertaste.', 8, 16);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Perfect for a summer day', 5,'Wow its better than I expected. Very sweet and refreshing', 6, 12);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Not what I expected', 2,'It has a bit of a hop in all the wrong ways',8, 14);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Didn''t hold up to expectations', 3,'Flavors were muted and flat, not the best beer ever', 9, 13);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Suprised me flavorwise', 3,'Dark in color but yeasty flavor.', 7, 15);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('New Favorite Pink Drink', 4,'Tart but still easy drinking. Love how pink it is.', 8, 20);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('I think I fell in love', 5,'Yummy! I�m not sure what fruit it is supposed to be, but my best guess would be a fruit punch-type. LOVED IT!', 9, 20);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Getting this again', 4,'Not too sweet or tart. Reminds me of wine. I would get it again.', 7, 20);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Average', 3,' Average pale lager. The label says a �tinge� of malt, though it tastes slightly more malty than a tinge. Still, drinkable and chuggable.', 6, 21);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Good beer', 4,'This is a mighty light brew. Tons of flavor. These guys make some good beers.', 8, 21);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Wish it had stronger flavor', 2,'Very light beer, very drinkable, but just light on flavors', 6, 22);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Great sour beer', 3,'Very seltzer like', 9, 22);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Yummy and Delicious', 3,' Delicious sparkling passionfruit, then prickly pear and a�ai finish. Very smooth and flavorful', 7, 22);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Classic Cincy', 4,'It''s a tasty Cincy classic beer. Hoppy with tropical fruit undertones. Getting a growler to go!', 6, 23);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Too Hoppy', 1,'It''s so hoppy I couldn''t drink it. I''ll stick with lagers.', 8, 23);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Best Stout Around', 5,'Still what I think is the best chocolate raspberry beer on the market', 8, 6);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Not Quite What I Wanted', 2,'Didn''t love it but didn''t hate it. Tastes watered down and the flavor isn''t bold enough', 9, 6);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Best IPA Around', 1,'Super good IPA. Will definitely be a regular purchase', 6, 17);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Too Much Going On', 3,'All of the flavors seem to compete, and not in a good way.', 8, 18);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Not Enough Hops for me', 2,'Nice pumpkin flavor but I think I''ll stick with my IPA''s', 6, 19);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Nice Coffee Flavor', 3,'Coffee flavor is great but the french vanilla didn''t translate to beer very well.', 9, 7);

INSERT INTO ratings(title,rating,review,user_id,beer_id)
VALUES('Great Flavor Balance', 7,'Sweet and a well balanced bitter backbone.', 8, 8);


INSERT INTO favorites(user_id, brewery_id)
VALUES(9, 1);

INSERT INTO favorites(user_id, brewery_id)
VALUES(6, 2);

INSERT INTO favorites(user_id, brewery_id)
VALUES(7, 3);

INSERT INTO favorites(user_id, brewery_id)
VALUES(8, 4);