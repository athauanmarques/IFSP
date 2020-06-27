delimiter |
create procedure maisvendido()
begin
SELECT id_produto_saida, sum(quantidade_saida) 
FROM pedido16.saida
group by id_produto_saida
order by 2 desc
limit 1;
end
|

call maisvendido;