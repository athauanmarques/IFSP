Drop procedure if exists devedor;

DELIMITER !

CREATE PROCEDURE devedor()
BEGIN
     drop table if exists devedor;
	 create table devedor as 
		SELECT cliente.*, venda.id_venda
		FROM cliente inner join venda on id_cliente=id_cliente_venda
     	where data_vencimento < curdate() and data_pagto is null;
	Update venda 
    set status_venda ="D" 
    where data_vencimento < curdate() and data_pagto is null;
END;
!
DELIMITER ;

call devedor();