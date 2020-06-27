delimiter $$
create procedure  devedores()
begin  
drop table if exists devedores;
create table devedores as 
select cliente.* 
from venda inner join cliente 
     on id_cliente=id_cliente_venda
where data_pagto < curdate() and status_venda<>'p';
end;
$$
delimiter ;
-- teste
call devedores();
select * from devedores;