-- 4.	Gere relatórios dos produtos mais vendidos (top 5)
delimiter $$
create procedure relatorio()
begin
select id_produto_saida, sum(quantidade_saida) 
into outfile "F:relatorio.txt" from saida 
group by id_produto_saida 
order by 2 desc 
limit 5;
end; 
$$
delimiter ;
drop procedure if exists relatorio;
call relatorio();
