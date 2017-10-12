
CREATE TABLE animal (
	animal_id int IDENTITY(1001,1) primary key NOT NULL,
	name varchar(100) NULL,
	species varchar(100) NULL,
	is_vaccinated varchar(5) NULL,
	amount_of_food varchar(10) NULL,
	room varchar(100) NULL,
	is_adopted varchar(10) NULL,
	adoption_fee varchar(10) NULL,
	special_needs varchar(10) NULL,
	age varchar(3) NULL,
)


