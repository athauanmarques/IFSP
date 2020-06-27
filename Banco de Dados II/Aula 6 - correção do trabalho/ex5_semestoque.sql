drop procedure if exists sem_estoque;

delimiter $$
create procedure sem_estoque()
begin
select nome_produto, estoque_produto into outfile "j:sem_estoque.txt" 
from produto 
where estoque_produto = 0;
end;
$$
delimiter ;


call sem_estoque();

