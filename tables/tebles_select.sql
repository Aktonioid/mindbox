use test;


select p.id, p.name, p.price, c.name as 'category' from
	prod_categ pc
		join products p 
			on p.id = pc.product_id 
		left outer join categories c 
			on c.id = pc.category_id;