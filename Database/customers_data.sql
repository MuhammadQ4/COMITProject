drop database if exists onlineShop;
create database onlineShop;
use onlineShop;

use onlineShop;
drop table if exists customers;

create table customers(
Id int not null auto_increment primary key,
fname varchar(25) not null default 'No first name provided',
lname varchar(25) not null default 'No last name provided',
address varchar(100) not null default 'No address provided',
email varchar(100) not null default 'No address provided',
phone varchar(10) not null default 'Missing'
);

insert into customers (fname, lname, address, email, phone)
values 	('Modupe', 'Krakue', '360 Main Street, Winnipeg, Canada', 'dkrakue@gmail.com', '4315572898'),
		('Maryia', 'Yelisviya', 'Osborne Village, Winnipeg, Canada', 'maryiaya@gmail.com', '2045572898'),
        ('Taniya', 'Shafique', '770 Allegheny Drive, Winnipeg, Canada', 'tshafiqe@outlook.com', '4315575060');