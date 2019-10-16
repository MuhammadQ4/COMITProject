drop database if exists myProject_db;
create database myProject_db;
use myProject_db;


create table categories
        (catID  int auto_increment primary key,
		 catName varchar(15)
        );
        
create table inventory 
(
ID int not null auto_increment primary key,
Name varchar(35) not null, 
Retail decimal(6, 2) not null default 0, 
PerMonth decimal (4, 2) not null default 0
);
        
create table subcategories
( subcatID int auto_increment primary key,
  subcatName varchar(35) 
);
	   
create table catinv
( ID int auto_increment primary key,
  cat_id int,
  inv_id int,
  subcat_id int,
  foreign key(cat_id) references categories(catID),
  foreign key(inv_id) references inventory(ID),
  foreign key(subcat_id) references subcategories(subcatID)
);

-- Categories Data
insert into categories(catName)
values  ('Living'), ('Dining'), ('Bedroom'), ('Decor');

# Subcategories Data
insert into subcategories(subcatName)
Values  ('Accents'), ('Baskets'), ('Coffe & End Table'),
		('Dining Chairs'), ('Lighting'), ('Lounge Chairs'),
		('Loveseats'), ('Ottomas'), ('Pillows'),
		('Sectionals'), ('Sofas'), ('Throws'),
# 		--------------------12-----------------
		('Benches'), ('Dining Tables'), ('Stools'),
# 		--------------------15------------------
		('Beds'), ('Nightstands'),
# 		---------------------17-----------------
		('Rugs'), ('Uncatecogrized');

-- Inventory Data
insert into inventory
(Name, Retail, PerMonth)
Values  ('Burstall Artificial Plant', 55.99, 1.38), 
		('Box Cushion', 74.99, 1.64), 
        ('Kendal Pedestal', 499.00, 7.14),
        
        ('Tredal Medium Basket', 24.99, 0.73), 
		('Trundle Large Basket', 79.99, 0.83),
        
        ('Trivia Side Table', 24.99, 0.73), 
		('Taaj End Table', 79.99, 0.83), 
        ('Custom coffee Table', 649.00, 80.79),
        ('Kacia Tri Coffee Table', 299.00, 4.39),
        ('Davidson Coffee Table', 499.00, 5.49),
        ('Kacia Rectagular Coffee Table', 399.00, 6.59),
        ('Tate Coffee Table', 299.00, 4.39),
        ('Davidson Table', 299.00, 2.74),
        ('Custom End Table', 329.00, 4.39),
        ('Kacia End Table', 179.00, 4.17),
        ('Tate End Table', 129.00, 2.35),
        
        ('Metro Floor Lamp', 199.00, 2.20), 
		('Manning Talbe Lamp', 64.99, 1.93), 
        ('Micah Floor Lamp', 149.00, 2.20),
        
        ('Stirling Chair', 799.00, 8.79), 
		('Canmore Chair', 799.00, 8.79), 
        ('Dalmeny Chair', 999.00, 8.79),
        
		('Canmore Loveseat', 1499.00, 13.19), 
		('Vermillion Loveseat', 1499.00, 14.29), 
        ('Stirling Loveseat', 1499.00, 14.29),
        
        ('Melita Ottoman', 599.00, 6.59), 
		('Odessa Ottoman', 549.00, 5.49), 
        ('Oskar Ottoman', 499.00, 6.59),
        ('Nanton Ottoman', 599.00, 6.59),
        
        ('Throw Pillow', 39.99, 1.09),
        
        ('Vermillion Sofa Chaise', 2799.00, 28.59), 
		('Stirling Sectional', 3399.00, 34.09), 
        ('Eston Sofa Chaise', 2399.00, 26.39),
        ('Canmore Sectional', 3299.00, 32.99),
        ('Eston Sectional', 3299.00, 31.89),
        ('Watrous Sectional', 3399.00, 32.99),
        
        ('Speck Throw', 129.99, 2.15),
		('Cosmic Throw', 1999.00, 18.69),
        
        -- Dining
        ('Kenaston Dining Table', 699.00, 7.69), 
		('Kacia Dining Table', 499.00, 8.79),
        ('Kendall Dining Table', 849.00, 9.34), 
		('Kacia Dinette Table', 399.00, 6.11),
        ('Kendall Counter Table', 849.00, 9.34),
		
		('Fave Wall Clock',   49.99, 1.10),
        ('Penny Placemet',   4.99, 0.28), 
		('Noir Modular Wine Rack',   39.99, 0.88),
        
        ('Sisley Basket',   24.99, 0.55),
		
		('Parson Dining Chair', 249.00, 4.11),
        ('Nixon Dining Chair', 399.00, 5.49), 
		('High Back Dining Chair', 199.00, 3.29),
        ('Holi Dining Chair', 199.00, 3.29), 
		('Lyla Dining Chair', 199.00, 3.29),
		
		('Bassano Floor Lamp', 84.99, 1.93),
		
		('Holi Counter Stool', 249.00, 3.29),
        ('Lyla Counter Stool', 199.00, 3.29), 
		('Nixon Counter Stool', 349.00, 5.34),
        ('Nixon Bar Stool', 349.99, 5.34),
		
        -- Bedroom 
        
		('Shrub Alarm Clock',   49.99, 1.10), 
		
		('Truss Laundry Hamper',   59.99, 1.32), 
		('Nomad Basket',   79.99, 1.76),
        ('Ellice Laundry Hamper',   49.99, 1.10),
		
		('Stavely King Bed', 1299.00, 12.64), 
		('Emerson King Bed', 1049.00, 10.49),
		('Calmar King Bed', 1199.00, 11.54),
        ('Stavely Queen Bed', 949.00, 9.49), 
		('Emerson Queen Bed', 599.00, 7.14),
		('Calmar Queen Bed', 499.00, 6.04),
        ('Calmar Double Bed', 999.00, 9.34), 
        ('Stavely Twin Bed', 849.00, 8.49),
		('Emerson Twin Bed', 1999.00, 18.69),
        
        
		('Micah Table Lamp', 89.00, 1.97),
		('Hinton Small Floor Lamp', 9.99, 0.88),
        
		('Burrow Nightstand', 229.00, 5.82), 
		('Marcel Nightstand', 349.00, 5.34),
		('Boom Nightstand', 299.00, 4.39),
		
        -- Decor  
        ('Penny Placemat',   4.99, 0.28), 
		('30" Box Cushion ',   74.99, 1.64),
        ('Integer Clock',   89.99, 1.97), 
        
        ('Trundle Small Basket',   24.99, 0.55), 
		('Trundle Medium Basket',   24.99, 0.73),
         
        ('Manning Table Lamp', 64.99, 1.93), 
        ('Stem Floor Lamp', 200.00, 2.53), 
        ('Bassano Table Lamp', 57.99, 1.65),
        ('Manning Floor Lamp', 159.99, 2.48), 
		('Metro Table Lamp', 129.00, 1.65),
		('Lunar Table Lamp', 24.99, 0.55),
		
		('18" Vinyl Throw Pillow', 39.99, 1.09), 
        ('Bolster Pilow', 59.99, 1.09),
        ('Bassano Table Lamp', 39.99, 1.09),
        
        ('Mystic Rug', 349.00, 18.70),
        ('Bila Round Rug', 449.99, 24.75), 
        ('Seville Rug', 279.00, 15.40),
        ('Daxi Accent Rug', 299.99, 1.65),
		
        ('Ebon Throw', 149.99, 3.29);
        
-- CatInv data
insert into catinv(cat_id, inv_id, subcat_id)
values 
	(1, 1, 19), (3, 1, 19), (4, 1, 19), (1, 2, 1), (1, 3, 19), (1, 4, 2), (1, 5, 2), (4, 5, 2),(1, 6, 3), 
	(1, 7, 3), (1, 8, 3), (1,9, 3), (1, 10, 3), (1,11, 3), (1, 12, 3), (1, 13, 3), (1, 14, 19), (1, 15, 3), 
	(1, 16, 3), (3, 16, 3),(1, 17, 5), (4, 17, 5), (1, 18, 19), (1,19, 5), (4, 19, 5), (1, 20, 19), (1, 21, 6), 
	(1, 22, 6), (1, 23, 7), (1, 24, 7),(1, 25, 19), (1, 26, 8), (3, 26, 8), (1,27, 19), (1, 28, 8), (1, 29, 8), 
	(1, 30, 9), (4, 30, 9), (1, 31, 19), (1, 32, 19),(1, 32, 19), (1,  33, 19), (1, 34, 19), (1, 35, 19),
	(1, 36, 19), (1, 37, 12), (3, 37, 12), (4, 37, 12), (1, 38, 12), (4, 38, 12),

	(2, 39, 14), (2, 40, 14), (1, 41, 19), (2, 42, 14), (2, 43, 14), (2, 44, 1), (4, 44, 1), (2, 45, 1), (2, 46 , 1),
	(4, 46, 1), (2,47, 2), (4, 47, 2), (2, 48, 4), (2,49, 4), (2, 50, 4), (2, 51, 4), (2,52, 4), (2,53, 5), 
	(4,53, 5), (2,54, 15), (2,55, 15), (2, 56, 15), (2, 57, 15), 
	
	(3, 58, 1), (4, 58, 19), (3, 59, 2), (4, 59, 2), (3, 60, 2), (4, 60, 2), (3, 61,2), (4, 61, 2), (3, 62, 16),
	(3, 63, 16), (3, 64, 16),(3, 65, 16), (3, 66, 16), (3, 67, 16), (3, 68, 16), (3, 69, 16), (3, 70, 16),
	(3,71, 5), (4, 71, 5), (3, 72, 5), (4, 72, 5), (3, 73, 17), (3,74, 17), (3, 75, 19), 	

	(4,76, 1), (4, 77, 1), (4, 78, 19), (4, 79, 2), (4, 80, 2), (4, 81, 5), (4, 82, 5), (4, 83, 5), (4, 84, 5),
	(4, 85, 5), (4, 86, 5),(4, 87, 9), (4 , 88, 9), (4, 89, 5), (4, 90, 18), (4, 91, 18), (4, 92, 18), 
	(4, 93, 18), (4, 94, 12);
	

-- insert into catinv(cat_id, inv_id)
-- values 
-- 	(1, 1), (3, 1), (4, 1), (1, 2), (1, 3), (1, 4), (1, 5), (4, 5),(1, 6), (1, 7), (1, 8),
-- 	(1,9), (1, 10), (1,11), (1, 12), (1, 13), (1, 14), (1, 15), (1, 16), (3, 16), 
-- 	(1, 17), (4, 17), (1, 18), (1,19), (4, 19), (1, 20), (1, 21), (1, 22), (1, 23), (1, 24),
-- 	(1, 25), (1, 26), (3, 26), (1,27), (1, 28), (1, 29), (1, 30), (1, 31), (1, 32),
-- 	(1, 32), (1, 33), (1,34), (1, 35), (1, 36), (1,37), (3,37), (4,37), (1,38), (4,38),

-- 	(2, 39), (2, 40), (1, 41), (2, 42), (2, 43), (2, 44),(2, 75), (2, 45), (2, 46),
-- 	(4, 46), (2,47), (4, 47), (2, 48), (2,49), (2, 50), (2, 51), (2,52), (2,53), (4,53), (2,54),
-- 	(2,55), (2, 56), (2, 57), 

-- 	(3, 58), (4, 58), (3, 59), (4, 59), (3, 60), (4, 60), (3, 61), (4, 61), (3, 62), (3, 63), (3, 64),
-- 	(3, 65), (3,66), (3, 67), (3, 68), (3, 69), (3, 70), (3,71), (4, 71), (3, 72), (4, 72), (3, 73),
-- 	(3,74),  (3, 75), 	

-- 	(4,76), (4, 77), (4, 78), (4, 79), (4, 80), (4, 81), (4, 82), (4, 83), (4, 84), (4, 85), (4, 86),
-- 	(4, 87), (4 , 88), (4, 89), (4, 90), (4, 91), (4, 92), (4, 93),
-- 	(4, 94);

      
      
select name, inv_id from inventory left join catinv on inventory.ID = catinv.inv_id order by cat_id;
	  
select catinv.ID, inv_id, catName from catinv Left join categories on categories.catID = catinv.cat_id;
	  
select catinv.ID, name, catName from inventory Inner join catinv on inventory.ID = catinv.inv_id Inner Join categories on 
categories.catID = catinv.cat_id;
	  
select catinv.ID, name, catName from inventory Inner join catinv on inventory.ID = catinv.inv_id Inner Join categories on 
categories.catID = catinv.cat_id where catName like 'Living';
	  
select name,Retail, PerMonth, catName from inventory Inner join catinv on inventory.ID = catinv.inv_id Inner Join categories on categories.catID = catinv.cat_id where catName like 'Living';
	  
select inventory.ID, cat_id from inventory inner join catinv on inventory.ID = catinv.inv_id where inventory.name like '%Box Cushion%';

select inventory.ID, name, cat_id, subcat_id from inventory inner join catinv on inventory.ID = catinv.inv_id where catinv.cat_id=4 And catinv.subcat_id = 2 order by name;

select inventory.ID, name, cat_id, PerMonth
from inventory inner join catinv on inventory.ID = catinv.inv_id 
where
Case 
when subcat_id = 2 is not null then catinv.cat_id=4 And catinv.subcat_id = 2
When subcat_id = 0 then catinv.cat_id=4
end 
order by PerMonth;
 
 SELECT inventory.ID, name,Retail, PerMonth from inventory INNER JOIN catinv on inventory.ID = catinv.inv_id WHERE CASE WHEN subcat_id > 0 IS NOT NULL THEN catinv.cat_id = 1 AND catinv.subcat_id = 0 
 WHEN subcat_id = 0 THEN catinv.cat_id = 1 END ORDER BY PerMonth;
 
 SELECT inventory.ID, name,Retail, PerMonth from inventory INNER JOIN catinv on inventory.ID = catinv.inv_id WHERE CASE 
 WHEN (subcat_id = 0) > 0 THEN catinv.cat_id = 1 AND catinv.subcat_id = 0 
 WHEN (subcat_id = 0) = 0 THEN catinv.cat_id = 1 END ORDER BY PerMonth;
 
 SELECT inventory.ID, name,Retail, PerMonth from inventory INNER JOIN catinv on inventory.ID = catinv.inv_id WHERE 
 CASE WHEN (subcat_id = 3) > 0 THEN catinv.cat_id = 1 AND catinv.subcat_id = 3 WHEN (subcat_id = 3) = 0 THEN catinv.cat_id = 1 END 
 ORDER BY PerMonth;
 
SELECT inventory.ID, name,Retail, PerMonth, subcat_id = 0 from inventory INNER JOIN catinv on inventory.ID = catinv.inv_id WHERE 
CASE WHEN subcat_id = 0 then catinv.cat_id = 1 AND catinv.subcat_id = 3 
WHEN subcat_id > 0  THEN catinv.cat_id = 1 END 
ORDER BY PerMonth;