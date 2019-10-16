drop database if exists myProject_db;
create database myProject_db;
use myProject_db;

create table Products 
(ID int not null auto_increment primary key,
Name varchar(35) not null, 
Category varchar(35) not null, 
SubCateogry varchar(35) not null,
Retail decimal(6, 2) not null default 0, 
PerMonth decimal (4, 2) not null default 0
);

insert into Products
(Name, Category, SubCateogry, Retail, PerMonth)
Values  ('Burstall Artificial Plant','Living','Accents', 55.99, 1.38), 
		('Box Cushion','Living','Accents', 74.99, 1.64), 
        ('Kendal Pedestal','Living','Accents', 499.00, 7.14),
        
        ('Tredal Medium Basket','Living','Baskets', 24.99, 0.73), 
		('Trundle Large Basket','Living','Baskets', 79.99, 0.83),
        
        ('Trivia Side Table','Living','Coffee & End Tables', 24.99, 0.73), 
		('Taaj End Table','Living','Coffee & End Tables', 79.99, 0.83), 
        ('Custom coffee Table','Living','Coffee & End Tables', 649.00, 80.79),
        ('Kacia Tri Coffee Table','Living','Coffee & End Tables', 299.00, 4.39),
        ('Davidson Coffee Table','Living','Coffee & End Tables', 499.00, 5.49),
        ('Kacia Rectagular Coffee Table','Living','Coffee & End Tables', 399.00, 6.59),
        ('Tate Coffee Table','Living','Coffee & End Tables', 299.00, 4.39),
        ('Davidson Table','Living','Coffee & End Tables', 299.00, 2.74),
        ('Custom End Table','Living','Coffee & End Tables', 329.00, 4.39),
        ('Kacia End Table','Living','Coffee & End Tables', 179.00, 4.17),
        ('Tate End Table','Living','Coffee & End Tables', 129.00, 2.35),
        
        ('Metro Floor Lamp', 'Living', 'Lighting', 199.00, 2.20), 
		('Manning Talbe Lamp', 'Living', 'Lighting', 64.99, 1.93), 
        ('Micah Floor Lamp', 'Living', 'Lighting', 149.00, 2.20),
        
        ('Stirling Chair', 'Living', 'Lounge Chairs', 799.00, 8.79), 
		('Canmore Chair', 'Living', 'Lounge Chairs', 799.00, 8.79), 
        ('Dalmeny Chair', 'Living', 'Lounge Chairs', 999.00, 8.79),
        
		('Canmore Loveseat', 'Living', 'Loveseat', 1499.00, 13.19), 
		('Vermillion Loveseat', 'Living', 'Loveseat', 1499.00, 14.29), 
        ('Stirling Loveseat', 'Living', 'Loveseat', 1499.00, 14.29),
        
        ('Melita Ottoman', 'Living', 'Ottomans', 599.00, 6.59), 
		('Odessa Ottoman', 'Living', 'Ottomans', 549.00, 5.49), 
        ('Oskar Ottoman', 'Living', 'Ottomans', 499.00, 6.59),
        ('Nanton Ottoman', 'Living', 'Ottomans', 599.00, 6.59),
        
        ('Throw Pillow', 'Living', 'Pillows', 39.99, 1.09),
        
        ('Vermillion Sofa Chaise', 'Living', 'Sofas', 2799.00, 28.59), 
		('Stirling Sectional', 'Living', 'Sofas', 3399.00, 34.09), 
        ('Eston Sofa Chaise', 'Living', 'Sofas', 2399.00, 26.39),
        ('Canmore Sectional', 'Living', 'Sofas', 3299.00, 32.99),
        ('Eston Sectional', 'Living', 'Sofas', 3299.00, 31.89),
        ('Watrous Sectional', 'Living', 'Sofas', 3399.00, 32.99),
        
        ('Speck Throw', 'Living', 'Throws', 129.99, 2.15),
		('Cosmic Throw', 'Living', 'Throws', 1999.00, 18.69),
        
        ('Kenaston Dining Table', 'Dining', 'Dining Tables', 699.00, 7.69), 
		('Kacia Dining Table', 'Dining', 'Dining Tables', 499.00, 8.79),
        ('Kendall Dining Table', 'Dining', 'Dining Tables', 849.00, 9.34), 
		('Kacia Dinette Table', 'Dining', 'Dining Tables', 399.00, 6.11),
        ('Kendall Counter Table', 'Dining', 'Dining Tables', 849.00, 9.34),
		
		('Fave Wall Clock', 'Dining', 'Accents', 49.99, 1.10),
        ('Penny Placemet', 'Dining', 'Accents', 4.99, 0.28), 
		('Noir Modular Wine Rack', 'Dining', 'Accents', 39.99, 0.88),
        
        ('Sisley Basket', 'Dining', 'Baskets', 24.99, 0.55),
		
		('Parson Dining Chair', 'Dining', 'Dining Chairs', 249.00, 4.11),
        ('Nixon Dining Chair', 'Dining', 'Dining Chairs', 399.00, 5.49), 
		('High Back Dining Chair', 'Dining', 'Dining Chairs', 199.00, 3.29),
        ('Holi Dining Chair', 'Dining', 'Dining Chairs', 199.00, 3.29), 
		('Lyla Dining Chair', 'Dining', 'Dining Chairs', 199.00, 3.29),
		
		('Bassano Floor Lamp', 'Dining', 'Lighting', 84.99, 1.93),
		
		('Holi Counter Stool', 'Dining', 'Stools', 249.00, 3.29),
        ('Lyla Counter Stool', 'Dining', 'Stools', 199.00, 3.29), 
		('Nixon Counter Stool', 'Dining', 'Stools', 349.00, 5.34),
        ('Nixon Bar Stool', 'Dining', 'Stools', 349.99, 5.34),
		
		('Shrub Alarm Clock', 'Bedroom', 'Accents', 49.99, 1.10), 
		('Burstall Artificial Plant', 'Bedroom', 'Accents', 55.99, 1.38),
		
		('Truss Laundry Hamper', 'Bedroom', 'Baskets', 59.99, 1.32), 
		('Nomad Basket', 'Bedroom', 'Baskets', 79.99, 1.76),
        ('Ellice Laundry Hamper', 'Bedroom', 'Baskets', 49.99, 1.10),
		
		('Stavely King Bed', 'Bedroom', 'Beds', 1299.00, 12.64), 
		('Emerson King Bed', 'Bedroom', 'Beds', 1049.00, 10.49),
		('Calmar King Bed', 'Bedroom', 'Beds', 1199.00, 11.54),
        ('Stavely Queen Bed', 'Bedroom', 'Beds', 949.00, 9.49), 
		('Emerson Queen Bed', 'Bedroom', 'Beds', 599.00, 7.14),
		('Calmar Queen Bed', 'Bedroom', 'Beds', 499.00, 6.04),
        ('Calmar Double Bed', 'Bedroom', 'Beds', 999.00, 9.34), 
        ('Stavely Twin Bed', 'Bedroom', 'Beds', 849.00, 8.49),
		('Emerson Twin Bed', 'Bedroom', 'Beds', 1999.00, 18.69),
        
        ('Tate End Table', 'Bedroom', 'Coffe & End Tables', 129.00, 2.35), 
        
		('Micah Table Lamp', 'Bedroom', 'Lighting', 89.00, 1.97),
		('Hinton Small Floor Lamp', 'Bedroom', 'Lighting', 9.99, 0.88),
        
		('Burrow Nightstand', 'Bedroom', 'Nightstands', 229.00, 5.82), 
		('Marcel Nightstand', 'Bedroom', 'Nightstands', 349.00, 5.34),
		('Boom Nightstand', 'Bedroom', 'Nightstands', 299.00, 4.39),
		
		('Melita Ottoman', 'Bedroom', 'Ottomans', 599.00, 6.59), 
		
        ('Speck Throw', 'Bedroom', 'Throws', 129.99, 2.15),
		
		('Kenaston Dining Table', 'Dining', 'Dining Tables', 699.00, 7.69), 
		('Kacia Dining Table', 'Dining', 'Dining Tables', 499.00, 8.79),
        ('Kendall Dining Table', 'Dining', 'Dining Tables', 849.00, 9.34), 
		('Kacia Dinette Table', 'Dining', 'Dining Tables', 399.00, 6.11),
        ('Kendall Counter Table', 'Dining', 'Dining Tables', 849.00, 9.34), 
		
		('Fave Wall Clock', 'Dining', 'Accents', 49.99, 1.10),
        ('Penny Placemet', 'Dining', 'Accents', 4.99, 0.28), 
		('Noir Modular Wine Rack', 'Dining', 'Accents', 39.99, 0.88),
        
        ('Sisley Basket', 'Dining', 'Baskets', 24.99, 0.55),
		
		('Parson Dining Chair', 'Dining', 'Dining Chairs', 249.00, 4.11),
        ('Nixon Dining Chair', 'Dining', 'Dining Chairs', 399.00, 5.49), 
		('High Back Dining Chair', 'Dining', 'Dining Chairs', 199.00, 3.29),
        ('Holi Dining Chair', 'Dining', 'Dining Chairs', 199.00, 3.29), 
		('Lyla Dining Chair', 'Dining', 'Dining Chairs', 199.00, 3.29),
		
		('Bassano Floor Lamp', 'Dining', 'Lighting', 84.99, 1.93), 
		
        ('Holi Counter Stool', 'Dining', 'Stools', 249.00, 3.29),
        ('Lyla Counter Stool', 'Dining', 'Stools', 199.00, 3.29), 
		('Nixon Counter Stool', 'Dining', 'Stools', 349.00, 5.34),
        ('Nixon Bar Stool', 'Dining', 'Stools', 349.99, 5.34),
	
        ('Burstall Artificial Plant', 'Decor', 'Accents', 55.99, 1.38), 
		('Fave Wall Clock', 'Decor', 'Accents', 49.99, 1.10),
        ('Penny Placemat', 'Decor', 'Accents', 4.99, 0.28), 
		('30" Box Cushion ', 'Decor', 'Accents', 74.99, 1.64),
        ('Noir Modular Wine Rack', 'Decor', 'Accents', 39.99, 0.88),
        ('Integer Clock', 'Decor', 'Accents', 89.99, 1.97), 
		('Shrub Alarm Clock', 'Decor', 'Accents', 49.99, 1.10),
		
        
		('Nomad Basket', 'Decor', 'Baskets', 79.99, 1.76),
        ('Trundle Small Basket', 'Decor', 'Baskets', 24.99, 0.55), 
		('Trundle Medium Basket', 'Decor', 'Baskets', 24.99, 0.73),
		('Truss Laundry Hamper', 'Decor', 'Baskets', 59.99, 1.32),
        ('Trundle Large Basket', 'Decor', 'Baskets', 29.99, 0.83), 
        ('Sisley Basket', 'Decor', 'Baskets', 24.99, 0.55),
		('Ellice Laundry Hamper', 'Decor', 'Baskets', 49.99, 1.10),
        
        ('Micah Table Lamp', 'Decor', 'Lighting', 89.00, 1.97), 
		('Bassano Floor Lamp', 'Decor', 'Lighting', 84.00, 1.93),
		('Metro Floor Lamp', 'Decor', 'Lighting', 199.99, 2.20),
        ('Manning Table Lamp', 'Decor', 'Lighting', 64.99, 1.93), 
		('Micah Floor Lamp', 'Decor', 'Lighting', 149.00, 2.20),
		('Hinton Small Floor Lamp', 'Decor', 'Lighting', 9.99, 0.88),
        ('Stem Floor Lamp', 'Decor', 'Lighting', 200.00, 2.53), 
        ('Bassano Table Lamp', 'Decor', 'Lighting', 57.99, 1.65),
        ('Manning Floor Lamp', 'Decor', 'Lighting', 159.99, 2.48), 
		('Metro Table Lamp', 'Decor', 'Lighting', 129.00, 1.65),
		('Lunar Table Lamp', 'Decor', 'Lighting', 24.99, 0.55),
		
		('18" Vinyl Throw Pillow', 'Decor', 'Pillows', 39.99, 1.09), 
        ('Bolster Pilow', 'Decor', 'Pillows', 59.99, 1.09),
        ('Bassano Table Lamp', 'Decor', 'Pillows', 39.99, 1.09),
        
        ('Mystic Rug', 'Decor', 'Rugs', 349.00, 18.70),
        ('Bila Round Rug', 'Decor', 'Rugs', 449.99, 24.75), 
        ('Seville Rug', 'Decor', 'Rugs', 279.00, 15.40),
        ('Daxi Accent Rug', 'Decor', 'Rugs', 299.99, 1.65),
		
		('Speck Throw', 'Decor', 'Throws', 129.99, 2.15),
        ('Ebon Throw', 'Decor', 'Throws', 149.99, 3.29),
        ('Cosmic Throw', 'Decor', 'Throws', 79.99, 1.75);
        
        
        
        

        
        
        
        
        
        
        

		