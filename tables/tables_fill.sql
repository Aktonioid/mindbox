use test;

insert categories (name) values('мониторы'),
('игровые мониторы'),
('ips мониторы'),
('кресла');

insert products (name, price) values ('huawei MateView SSN-24BZ', 12990), --офисный 
('AOC Value Line 27B2H', 12490), --офисный
('AOC Gaming C27G2ZU',24990), --игровой
('ZOMBIE neo серый', 12190), --кресла
('табуретка', 900) -- табуретка без категроии;

insert prod_categ (product_id, category_id) values
(1,1),(1,3), --huawei
(2,1),(2,3), --aoc value
(3,1),(3,2), --aoc gaming
(4,4)-- кресло
;
insert prod_categ(product_id) values (5);