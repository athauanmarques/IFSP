-- Procedures

-- Essa procedure irá inserir um cliente na tabela 'clientes', passando por parâmetro os valores de nome, email e telefone.
-- Utilizando 'in' que irá pegar os dados.

DELIMITER ||

create procedure insere_cliente (in nome varchar(100), in email varchar(100), in telefone varchar(80))
BEGIN

	insert into clientes(`nome`, `email`, `telefone`) values (nome, email, telefone);

END;
||

DELIMITER ;

-- Teste
call insere_cliente('aline','bla','40');
select * from clientes;

-- --------------------------------------------------------------------------------------------------------------------------

-- Esta procedure quando chamada altera um cliente na tabela 'Cliente'. Passando por parâmetros os valores a ser atualizados.
DELIMITER !!

create procedure altera_cliente (in cod INT, in nome varchar(100), in email varchar(100), in telefone varchar(80))
BEGIN
	
	update clientes set `nome` = nome, `email` = email, `telefone` = telefone where codigo = cod;

END;
!!
DELIMITER ;

-- Teste
select * from clientes;
call altera_cliente(1,'aline','bla','40');

-- ---------------------------------------------------------------------------------------------------------------------------

-- Nesse procedure irá excluir um cliente da tabela 'Cliente', porém antes irá ser excluido de vendas pois o codigo de cliente é chave estrangeira.
DELIMITER $$

create procedure exclui_cliente (in cod INT)
BEGIN

	delete from vendas where codigo = cod; 
	delete from clientes where codigo = cod;

END;
$$

DELIMITER ;

-- Teste
call exclui_cliente(1);

-- -----------------------------------------------------------------------------------------------------------------------------

-- Nesta procedure quando chamada irá selecionar um cliente, através do nome, email ou pelo telefone, exibindo todos os dados daquele cliente
DELIMITER &&

create procedure seleciona_cliente (in filtro varchar(100))
BEGIN
	
	if filtro is null then select * from clientes;
	else select * from clientes where nome like  concat('%',filtro,'%')  or email like concat('%',filtro,'%') or telefone like concat('%',filtro,'%');

	end if;
END;
&&

DELIMITER ;

-- Teste
call seleciona_cliente('aline');
