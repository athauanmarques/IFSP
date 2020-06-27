delimiter &
create function comissao(xx int) returns int(11)
begin
declare result int;
select  round(sum(s.quantidade_saida * p.preco_venda_produto),2) * 0.15 into result
from    venda v inner join saida s on v.id_venda = s.id_venda_saida
           inner join produto p on p.id_produto = s.id_produto_saida
where  v.id_vendedor_venda=xx;
return result;
end;
&
delimiter ;

-- teste
select comissao(1);