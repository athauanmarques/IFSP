-- Exercício 4 Comissao vendedor
DROP PROCEDURE IF EXISTS comissao;
DELIMITER !

CREATE PROCEDURE comissao(IN taxa float(4,2))
BEGIN
	select  v.id_vendedor_venda,  
        round(sum(s.quantidade_saida * p.preco_venda_produto),2) total,
        round(sum(s.quantidade_saida * p.preco_venda_produto),2) * taxa comissao
	from venda v inner join saida s on v.id_venda = s.id_venda_saida
        inner join produto p on p.id_produto = s.id_produto_saida
	group by v.id_vendedor_venda;
END;
!
DELIMITER ;

-- TESTE
CALL comissao(5/100);