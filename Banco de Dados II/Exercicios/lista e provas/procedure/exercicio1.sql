-- triggers para entrada e saida de produtos (exercício 1)
-- 1.	Atualize o estoque do produto toda vez que houver uma venda(-qtde)  ou compra de produtos

use pedido16;

-- criando as triggers do exercicio 1
drop trigger entrada_produto;

-- Quando estiver alguma compra no produto
DELIMITER |
CREATE TRIGGER entrada_produto AFTER INSERT ON entrada
FOR EACH ROW
BEGIN	
	UPDATE produto 
    SET estoque_produto = estoque_produto + NEW.quantidade_entrada
    WHERE id_produto = New.id_produto_entrada;
END; 
|

-- Quando houver alguma venda no produto
delimiter;
drop trigger saida_produto;
delimiter |
CREATE TRIGGER saida_produto BEFORE INSERT ON saida
FOR EACH ROW
BEGIN	
		UPDATE produto 
		SET estoque_produto = estoque_produto - NEW.quantidade_saida
		WHERE  id_produto = NEW.id_produto_saida; 

END;
|
DELIMITER  ;
-- -----------------------------------------------------------------------------

-- inserções para testes das triggers

-- -----------------------------------------------------------------------------
select * from produto;
-- apagando entradas e saída para reinseri-las com triggers
delete from entrada;
delete from saida;

INSERT INTO `entrada` VALUES (1,1,20),(2,2,20),(3,3,20),(4,4,10),(5,5,10),(6,1,50),(7,2,50),(8,3,60),(9,4,70),(10,5,60),(11,6,20),(12,7,10),(13,8,50),(14,9,60),(15,10,10),(16,11,10),(17,12,10),(18,13,10),(19,14,10),(20,15,20),(21,16,40),(22,17,10),(23,18,10),(24,19,10),(25,20,60),(26,21,20),(27,22,20),(28,23,10),(29,24,20),(30,25,10),(31,26,10),(32,27,10),(33,28,10),(34,29,10),(35,30,10),(36,1,30),(37,2,40),(38,10,50),(39,3,60),(40,10,40),(41,11,80),(42,12,20),(43,4,30),(44,5,20),(45,6,30),(46,7,20),(47,11,20),(48,20,30),(49,30,30),(50,17,20),(51,1,20),(52,2,20),(53,3,20),(54,4,10),(55,5,10),(56,1,50),(57,2,50),(58,3,60),(59,4,70),(60,5,60),(61,6,20),(62,7,10),(63,8,50),(64,9,60),(65,10,10),(66,11,10),(67,12,10),(68,13,10),(69,14,10),(70,15,20);
INSERT INTO `saida` VALUES (1,1,131),(2,1,3),(3,2,15),(4,3,20),(5,4,10),(6,5,10),(7,6,10),(8,7,15),(9,8,20),(10,9,1),(11,10,10),(12,11,1),(13,12,1),(14,13,2),(15,14,15),(16,15,13),(17,18,12),(18,19,15),(19,20,20),(20,22,10),(21,1,1),(22,2,1),(23,3,15),(24,4,30),(25,5,10),(26,6,1),(27,7,30),(28,8,15),(29,9,20),(30,10,17),(31,11,18),(32,12,19),(33,13,15),(34,14,21),(35,15,22),(36,16,10),(37,17,12),(38,18,13),(39,19,24),(40,20,14),(41,21,17),(42,22,18),(43,23,15),(44,24,20),(45,25,10),(46,26,10),(47,27,10),(48,28,15),(49,29,20),(50,30,10),(51,1,30),(52,1,10),(53,3,15),(54,4,20),(55,2,40);


select * from produto where id_produto=1;

Select sum(quantidade_entrada) 
from entrada where id_produto_entrada = 1; -- 170

Select sum(quantidade_entrada) 
from entrada where id_produto_entrada = 1; -- 170

Select sum(quantidade_saida) from saida where id_produto_saida = 1; -- 175

-- o produto foi cadastrado com 5 em estoque.