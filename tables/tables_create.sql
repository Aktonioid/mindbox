Use test;
Create table categories
(
 id int identity(1,1) primary key,
 name varchar(40)
);
Create table products
(
id int identity(1,1) primary key,
name varchar(70),
price int
);

create table prod_categ
(
id int identity(1,1) primary key,
product_id int,
category_id int,
foreign key(product_id) references products(id),
foreign key(category_id) references categories(id)
);