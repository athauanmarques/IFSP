CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirProduto`(IN pproduto VARCHAR(50), IN ppreco DECIMAL(18,2), IN pestoque INT)

BEGIN


    INSERT INTO loja.produtos(produto, preco, estoque) VALUES (pproduto, ppreco, pestoque);

    SELECT * FROM loja.produtos WHERE idProduto=LAST_INSERT_ID();

END