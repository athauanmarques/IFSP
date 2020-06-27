-- Exercício 3 -- Sugestão de compras produtos sem estoque
DROP PROCEDURE IF EXISTS compraproduto;
DELIMITER !

CREATE PROCEDURE compraproduto()
BEGIN
    -- para gerar resultado em arquivo txt outfile
	SELECT * into OUTFILE "i:sugestaocompras.TXT"
	FROM produto where estoque_produto = 0;
END;
!
DELIMITER ;

-- TESTE
CALL compraproduto();