CREATE TABLE IF NOT EXISTS users
(
	id serial NOT NULL,	
	username varchar(100) NOT NULL,
	password varchar(100) NOT NULL,
	CONSTRAINT pkuser PRIMARY KEY(id),
	CONSTRAINT uniqueusername UNIQUE(username)
);

insert into users(username, password) values('user1','password123');
insert into users(username, password) values('user2','password456');
