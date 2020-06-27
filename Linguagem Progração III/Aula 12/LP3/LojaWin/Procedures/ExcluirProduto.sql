CREATE DEFINER=`root`@`localhost` PROCEDURE `ExcluirProduto`(IN pidproduto INT)

BEGIN

     DELETE FROM loja.produtos WHERE idProduto = pidproduto;

END