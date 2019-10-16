drop database if exists myProject_db;
create database myProject_db;
use myProject_db;
create table Productsv3 
(ID int not null auto_increment primary key,
Name varchar(35) not null, 
Retail decimal(6, 2) not null default 0, 
PerMonth decimal (4, 2) not null default 0
);

insert into Productsv3
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
        
        
        select ID from Productsv3 where name = 'Bassano Table Lamp';
        -- select database();
-- 		show tables;
        
        
        
        
        
        
        

		