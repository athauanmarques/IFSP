DELIMITER &&
CREATE PROCEDURE venda (in quant int, in codCliente int, codProduto int)
BEGIN
	
		INSERT INTO vendas (codigoCliente, `data`,  codigoProduto, quantidade) VALUES (codCliente, curdate(),codProduto, quant);
		UPDATE produtos SET estoque = estoque - quant WHERE codigo = codProduto;
	
END;
&&

DELIMITER ;