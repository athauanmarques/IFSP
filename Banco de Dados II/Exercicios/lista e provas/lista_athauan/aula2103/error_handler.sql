drop database if exists bd_erro;
create database bd_erro;
use bd_erro;
create table locations (
	location VARCHAR(30) primary key,
	address1 VARCHAR(50),
	address2 VARCHAR(50),
	zipcode VARCHAR(10)
);

delimiter %
CREATE PROCEDURE sp_add_location
(	in_location VARCHAR(30),
	in_address1 VARCHAR(30),
	in_address2 VARCHAR(30),
	zipcode VARCHAR(10))
	MODIFIES SQL DATA
	BEGIN
    DECLARE duplicate_key INT DEFAULT 0;
    
    
	DECLARE CONTINUE HANDLER FOR 1062 SET duplicate_key=1;
	SET duplicate_key=0;
	INSERT INTO locations
		(location,address1,address2,zipcode)
	VALUES
		(in_location,in_address1,in_address2,zipcode);
	if duplicate_key=1 then 
		select 'Duplicidade na Chave Primária';
    else
		select 'Entrada Bem sucedida ';
	end if; 
END;
%
delimiter ;
CALL sp_add_location('loc 1','Av Francisco Lucchesi, 770','Braganca Paulista', '12929-600');


