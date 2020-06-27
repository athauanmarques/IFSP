-- 					Exercicio 2
-- 2.	Gere relatórios dos produtos mais vendidos

-- somar quantos foram vendidos e agrupa-las

-- select id_produto_saida,SUM(quantidade_saida) from saida group by id_produto_saida order by 2 desc limit 3;

-- selecionando o campo de grupamento neste caso é id_produto_saida
-- samando o campo de quantidade_saida da tabela saida
-- grupando por id_produto_saida
-- ordenando pela segunda tabela
-- limitando até 3 mais vendidos da tabela

DROP PROCEDURE IF EXISTS MAISVENDIDOS;
DELIMITER !

CREATE PROCEDURE MAISVENDIDOS(IN TOP INT)
BEGIN
	SELECT id_produto_saida PRODUTO , sum(quantidade_saida) TOTAL -- into OUTFILE "J:MAISVENDIDOS2.TXT"
	FROM saida
	group by id_produto_saida
	order by 2 desc
	limit TOP;
END;
!
DELIMITER ;

-- TESTE
CALL MAISVENDIDOS (3);


