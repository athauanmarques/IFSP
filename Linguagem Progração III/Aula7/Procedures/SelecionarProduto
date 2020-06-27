CREATE DEFINER=`root`@`localhost` PROCEDURE `SelecionarProduto`(IN pfiltro VARCHAR (20))

BEGIN

   
IF(pfiltro="")THEN SELECT
 
    produtos.idProduto,

     produtos.produto,

     produtos.preco,

     produtos.estoque

     FROM loja.produtos;

   ELSE SELECT

     produtos.idProduto,

     produtos.produto,

     produtos.preco,

     produtos.estoque

     FROM loja.produtos

     WHERE produtos.produto LIKE concat('%', pfiltro ,'%');

   END IF;

END