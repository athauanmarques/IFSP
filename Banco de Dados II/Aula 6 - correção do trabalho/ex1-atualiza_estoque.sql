-- triggers para entrada e saida de produtos (exercício 1)

use db;

select * from produto;

DELIMITER |
CREATE TRIGGER entrada_produto AFTER INSERT ON entrada
FOR EACH ROW
BEGIN	
	UPDATE produto SET estoque_produto = estoque_produto + 	NEW.quantidade_entrada WHERE id_produto = NEW.id_produto_entrada;
END; 
| 
DELIMITER  ;

INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (1, 1, 20);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (2, 2, 20);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (3, 3, 20);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (4, 4, 10);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (5, 5, 10);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (6, 1, 50);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (7, 2, 50);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (8, 3, 60);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (9, 4, 70);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (10, 5, 60);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (11, 6, 20);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (12, 7, 10);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (13, 8, 50);
INSERT INTO db.entrada (id_compra_entrada, id_produto_entrada, quantidade_entrada) VALUES (14, 9, 60);

select * from produto;

DELIMITER |
CREATE TRIGGER saida_produto BEFORE INSERT ON saida
FOR EACH ROW
BEGIN	
DECLARE contador int(10); 	

SELECT estoque_produto INTO contador FROM produto 
WHERE id_produto = NEW.id_produto_saida;	

IF NEW.quantidade_saida <= contador  THEN
UPDATE produto 
SET estoque_produto = estoque_produto - NEW.quantidade_saida
WHERE  id_produto = NEW.id_produto_saida; 
ELSE 		
SET NEW.quantidade_saida = contador;		
UPDATE produto SET estoque_produto = 0		
WHERE  id_produto = NEW.id_produto_saida;	
END IF;
END;
|DELIMITER  ;

INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (1, 1, 131);
INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (2, 1, 3);
INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (3, 2, 15);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (4, 3, 20);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (5, 4, 10);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (6, 5, 10);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (7, 6, 10);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (8, 7, 15);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (9, 8, 20);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (10, 9, 1);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (11, 10, 10);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (12, 11, 1);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (13, 12, 1);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (14, 13, 2);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (15, 14, 15);
 INSERT INTO db.saida (id_venda_saida, id_produto_saida, quantidade_saida) VALUES (16, 15, 13);

select * from produto;
