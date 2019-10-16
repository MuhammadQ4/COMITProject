SET SQL_SAFE_UPDATES = 0;
drop database if exists onlineShop;
create database onlineShop;
use onlineShop;
drop table if exists products;
create table products(
Id int not null auto_increment primary key,
Name varchar(25) not null default 'No name provided',
Brand varchar(25) not null default 'No brand provided',
Price decimal(6,2)  not null default 0 
);

insert into products(Name, Brand, Price)
Values  ('Samsung Galaxy S10', 'Samasung', 1399.99),
		('Samsung Galaxy S10+', 'Samsung', 1574.99), 
        ('Samasung Galaxy Note10+', 'Samsung',1699.99 ),
        ('Samsung Galaxy S10e','Samsung',1124.99),
        ('iPhone XR','Apple',1059.99),
        ('iPhone XS','Apple',1419.99),
        ('iPhone 8','Apple',844.99),
        ('iPhone X','Apple',1274.99),
        ('iPhone XS Max','Apple',1559.99),
        ('iPhone 8 Plus','Apple',974),
        ('Samsung Galaxy A70','Samsung',599.99);
        
update products set Price=699.99 where Name='Samsung Galaxy A70';

-- select * from products;

select * from products;

delete from products where Id = 13;

delete from products where Id = 13;


update products set Name ='Nokia N97', Brand = 'Nokia' where id = 8;

        