CREATE DEFINER=`root`@`localhost` PROCEDURE `AlterarProduto`(IN pidproduto INT, IN pproduto VARCHAR(50), IN ppreco DECIMAL(18,2), IN pestoque INT)

BEGIN


    UPDATE loja.produtos SET produto = pproduto, preco = ppreco, estoque = pestoque WHERE idProduto = pidproduto; 


END