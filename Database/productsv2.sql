drop database if exists myProject_db;
create database myProject_db;
use myProject_db;

create table Productsv2 
(ID int not null auto_increment primary key,
Name varchar(35) not null, 
SubCateogry varchar(35) not null,
Retail decimal(6, 2) not null default 0, 
PerMonth decimal (4, 2) not null default 0
);

insert into Productsv2
(Name, SubCateogry, Retail, PerMonth)
Values  ('Burstall Artificial Plant','Accents', 55.99, 1.38), 
		('Box Cushion','Accents', 74.99, 1.64), 
        ('Kendal Pedestal','Accents', 499.00, 7.14),
        
        ('Tredal Medium Basket','Baskets', 24.99, 0.73), 
		('Trundle Large Basket','Baskets', 79.99, 0.83),
        
        ('Trivia Side Table','Coffee & End Tables', 24.99, 0.73), 
		('Taaj End Table','Coffee & End Tables', 79.99, 0.83), 
        ('Custom coffee Table','Coffee & End Tables', 649.00, 80.79),
        ('Kacia Tri Coffee Table','Coffee & End Tables', 299.00, 4.39),
        ('Davidson Coffee Table','Coffee & End Tables', 499.00, 5.49),
        ('Kacia Rectagular Coffee Table','Coffee & End Tables', 399.00, 6.59),
        ('Tate Coffee Table','Coffee & End Tables', 299.00, 4.39),
        ('Davidson Table','Coffee & End Tables', 299.00, 2.74),
        ('Custom End Table','Coffee & End Tables', 329.00, 4.39),
        ('Kacia End Table','Coffee & End Tables', 179.00, 4.17),
        ('Tate End Table','Coffee & End Tables', 129.00, 2.35),
        
        ('Metro Floor Lamp',  'Lighting', 199.00, 2.20), 
		('Manning Talbe Lamp',  'Lighting', 64.99, 1.93), 
        ('Micah Floor Lamp',  'Lighting', 149.00, 2.20),
        
        ('Stirling Chair',  'Lounge Chairs', 799.00, 8.79), 
		('Canmore Chair',  'Lounge Chairs', 799.00, 8.79), 
        ('Dalmeny Chair',  'Lounge Chairs', 999.00, 8.79),
        
		('Canmore Loveseat',  'Loveseat', 1499.00, 13.19), 
		('Vermillion Loveseat',  'Loveseat', 1499.00, 14.29), 
        ('Stirling Loveseat',  'Loveseat', 1499.00, 14.29),
        
        ('Melita Ottoman',  'Ottomans', 599.00, 6.59), 
		('Odessa Ottoman',  'Ottomans', 549.00, 5.49), 
        ('Oskar Ottoman',  'Ottomans', 499.00, 6.59),
        ('Nanton Ottoman',  'Ottomans', 599.00, 6.59),
        
        ('Throw Pillow',  'Pillows', 39.99, 1.09),
        
        ('Vermillion Sofa Chaise',  'Sofas', 2799.00, 28.59), 
		('Stirling Sectional',  'Sofas', 3399.00, 34.09), 
        ('Eston Sofa Chaise',  'Sofas', 2399.00, 26.39),
        ('Canmore Sectional',  'Sofas', 3299.00, 32.99),
        ('Eston Sectional',  'Sofas', 3299.00, 31.89),
        ('Watrous Sectional',  'Sofas', 3399.00, 32.99),
        
        ('Speck Throw',  'Throws', 129.99, 2.15),
		('Cosmic Throw',  'Throws', 1999.00, 18.69),
        
        ('Kenaston Dining Table',  'Dining Tables', 699.00, 7.69), 
		('Kacia Dining Table',  'Dining Tables', 499.00, 8.79),
        ('Kendall Dining Table',  'Dining Tables', 849.00, 9.34), 
		('Kacia Dinette Table',  'Dining Tables', 399.00, 6.11),
        ('Kendall Counter Table',  'Dining Tables', 849.00, 9.34),
		
		('Fave Wall Clock',  'Accents', 49.99, 1.10),
        ('Penny Placemet',  'Accents', 4.99, 0.28), 
		('Noir Modular Wine Rack',  'Accents', 39.99, 0.88),
        
        ('Sisley Basket',  'Baskets', 24.99, 0.55),
		
		('Parson Dining Chair',  'Dining Chairs', 249.00, 4.11),
        ('Nixon Dining Chair',  'Dining Chairs', 399.00, 5.49), 
		('High Back Dining Chair',  'Dining Chairs', 199.00, 3.29),
        ('Holi Dining Chair',  'Dining Chairs', 199.00, 3.29), 
		('Lyla Dining Chair',  'Dining Chairs', 199.00, 3.29),
		
		('Bassano Floor Lamp',  'Lighting', 84.99, 1.93),
		
		('Holi Counter Stool',  'Stools', 249.00, 3.29),
        ('Lyla Counter Stool',  'Stools', 199.00, 3.29), 
		('Nixon Counter Stool',  'Stools', 349.00, 5.34),
        ('Nixon Bar Stool',  'Stools', 349.99, 5.34),
		
		('Shrub Alarm Clock',  'Accents', 49.99, 1.10), 
		('Burstall Artificial Plant',  'Accents', 55.99, 1.38),
		
		('Truss Laundry Hamper',  'Baskets', 59.99, 1.32), 
		('Nomad Basket',  'Baskets', 79.99, 1.76),
        ('Ellice Laundry Hamper',  'Baskets', 49.99, 1.10),
		
		('Stavely King Bed',  'Beds', 1299.00, 12.64), 
		('Emerson King Bed',  'Beds', 1049.00, 10.49),
		('Calmar King Bed',  'Beds', 1199.00, 11.54),
        ('Stavely Queen Bed',  'Beds', 949.00, 9.49), 
		('Emerson Queen Bed',  'Beds', 599.00, 7.14),
		('Calmar Queen Bed',  'Beds', 499.00, 6.04),
        ('Calmar Double Bed',  'Beds', 999.00, 9.34), 
        ('Stavely Twin Bed',  'Beds', 849.00, 8.49),
		('Emerson Twin Bed',  'Beds', 1999.00, 18.69),
        
        ('Tate End Table',  'Coffe & End Tables', 129.00, 2.35), 
        
		('Micah Table Lamp',  'Lighting', 89.00, 1.97),
		('Hinton Small Floor Lamp',  'Lighting', 9.99, 0.88),
        
		('Burrow Nightstand',  'Nightstands', 229.00, 5.82), 
		('Marcel Nightstand',  'Nightstands', 349.00, 5.34),
		('Boom Nightstand',  'Nightstands', 299.00, 4.39),
		
		('Melita Ottoman',  'Ottomans', 599.00, 6.59), 
		
        ('Speck Throw',  'Throws', 129.99, 2.15),
		
        ('Burstall Artificial Plant',  'Accents', 55.99, 1.38), 
		('Fave Wall Clock',  'Accents', 49.99, 1.10),
        ('Penny Placemat',  'Accents', 4.99, 0.28), 
		('30" Box Cushion ',  'Accents', 74.99, 1.64),
        ('Noir Modular Wine Rack',  'Accents', 39.99, 0.88),
        ('Integer Clock',  'Accents', 89.99, 1.97), 
		('Shrub Alarm Clock',  'Accents', 49.99, 1.10),
		
        
		('Nomad Basket',  'Baskets', 79.99, 1.76),
        ('Trundle Small Basket',  'Baskets', 24.99, 0.55), 
		('Trundle Medium Basket',  'Baskets', 24.99, 0.73),
		('Truss Laundry Hamper',  'Baskets', 59.99, 1.32),
        ('Trundle Large Basket',  'Baskets', 29.99, 0.83), 
        ('Sisley Basket',  'Baskets', 24.99, 0.55),
		('Ellice Laundry Hamper',  'Baskets', 49.99, 1.10),
        
        ('Micah Table Lamp',  'Lighting', 89.00, 1.97), 
		('Bassano Floor Lamp',  'Lighting', 84.00, 1.93),
		('Metro Floor Lamp',  'Lighting', 199.99, 2.20),
        ('Manning Table Lamp',  'Lighting', 64.99, 1.93), 
		('Micah Floor Lamp',  'Lighting', 149.00, 2.20),
		('Hinton Small Floor Lamp',  'Lighting', 9.99, 0.88),
        ('Stem Floor Lamp',  'Lighting', 200.00, 2.53), 
        ('Bassano Table Lamp',  'Lighting', 57.99, 1.65),
        ('Manning Floor Lamp',  'Lighting', 159.99, 2.48), 
		('Metro Table Lamp',  'Lighting', 129.00, 1.65),
		('Lunar Table Lamp',  'Lighting', 24.99, 0.55),
		
		('18" Vinyl Throw Pillow',  'Pillows', 39.99, 1.09), 
        ('Bolster Pilow',  'Pillows', 59.99, 1.09),
        ('Bassano Table Lamp',  'Pillows', 39.99, 1.09),
        
        ('Mystic Rug',  'Rugs', 349.00, 18.70),
        ('Bila Round Rug',  'Rugs', 449.99, 24.75), 
        ('Seville Rug',  'Rugs', 279.00, 15.40),
        ('Daxi Accent Rug',  'Rugs', 299.99, 1.65),
		
		('Speck Throw',  'Throws', 129.99, 2.15),
        ('Ebon Throw',  'Throws', 149.99, 3.29),
        ('Cosmic Throw',  'Throws', 79.99, 1.75);
        

        
        
        
        
        

        
        
        
       
        
        
        

		