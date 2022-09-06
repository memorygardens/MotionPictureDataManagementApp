USE Master 
GO

--drop database if it exists 
If DB_ID('motionPicturesDatabase') IS NOT NULL
BEGIN
	ALTER DATABASE MotionPictures SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE MotionPictures;
END

CREATE DATABASE MotionPictures
GO

USE MotionPictures
GO

--create tables 
CREATE TABLE MotionPictures (
	ID int Primary Key NOT NULL,
	Name NVARCHAR(50) NOT NULL,
	Description NVARCHAR(500), 
	ReleaseYear int NOT NULL

)

INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (1,'The GodFather', 'The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.', 1972)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (2,'The Dark Knight','When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.',2008)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (3,'12 Angry Men','The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.',1957)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (4,'Pulp Fiction','The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.',1994)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (5,'Forrest Gump','The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.',1994)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (6,'Inception','A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.',2010)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (7,'Star Wars','Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire''s world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.',1977)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (8,'Spirited Away','During her family''s move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.',2001)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (9,'Alien','The crew of a commercial spacecraft encounter a deadly lifeform after investigating an unknown transmission.0',1979)
INSERT INTO MotionPictures (ID, Name, Description, ReleaseYear) VALUES (10,'Rear Window','A wheelchair-bound photographer spies on his neighbors from his Greenwich Village courtyard apartment window, and becomes convinced one of them has committed murder, despite the skepticism of his fashion-model girlfriend.',1954)