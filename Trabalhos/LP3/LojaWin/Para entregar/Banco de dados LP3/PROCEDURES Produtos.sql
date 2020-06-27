DELIMITER ||

create procedure insere_produto (in nome varchar(100), in preco decimal(10,2), in estoque int)
BEGIN

	insert into produtos(`nome`, `preco`, `estoque`) values (nome, preco, estoque);

END;
||

DELIMITER ;

-- Teste

call insere_produto('celular iphone', 1000.50, 20);

select * from produtos;

-- --------------------------------------------------------------------------------------------------------------------------

-- Esta procedure quando chamada altera um cliente na tabela 'Cliente'. Passando por parâmetros os valores a ser atualizados.
DELIMITER !!

create procedure altera_produto (in cod INT, in nome varchar(100), in preco decimal(10,2), in estoque int)
BEGIN
	
	update produtos set `nome` = nome, `preco` = preco, `estoque` = estoque where codigo = cod;

END;
!!
DELIMITER ;

-- Teste

call altera_produto (1,'celular ibosta', 150.50, 40);

select * from produtos;

-- ---------------------------------------------------------------------------------------------------------------------------

-- Nesse procedure irá excluir um cliente da tabela 'Cliente', porém antes irá ser excluido de vendas pois o codigo de cliente é chave estrangeira.
DELIMITER $$

create procedure exclui_produto (in cod INT)
BEGIN

	delete from produtos where codigo = cod;

END;
$$

DELIMITER ;

-- Teste
call exclui_produto(1);

-- -----------------------------------------------------------------------------------------------------------------------------

-- Nesta procedure quando chamada irá selecionar um cliente, através do nome, email ou pelo telefone, exibindo todos os dados daquele cliente
DELIMITER &&

create procedure seleciona_produto (in filtro varchar(100))
BEGIN
	
	if filtro is null then select * from produtos;
	else select * from produtos where nome like  concat('%',filtro,'%');

	end if;
END;
&&

DELIMITER ;

-- Teste
call seleciona_produto('ip');




