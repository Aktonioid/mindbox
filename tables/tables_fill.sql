use test;

insert categories (name) values('��������'),
('������� ��������'),
('ips ��������'),
('������');

insert products (name, price) values ('huawei MateView SSN-24BZ', 12990), --������� 
('AOC Value Line 27B2H', 12490), --�������
('AOC Gaming C27G2ZU',24990), --�������
('ZOMBIE neo �����', 12190), --������
('���������', 900) -- ��������� ��� ���������;

insert prod_categ (product_id, category_id) values
(1,1),(1,3), --huawei
(2,1),(2,3), --aoc value
(3,1),(3,2), --aoc gaming
(4,4)-- ������
;
insert prod_categ(product_id) values (5);