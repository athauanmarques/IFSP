-- -----------------------------------------------------
-- -----------------Consultas---------------------------
-- -----------------------------------------------------


DELIMITER $$
DROP PROCEDURE IF EXISTS ganhos_vendedor $$
CREATE PROCEDURE ganhos_vendedor (in funcionario int)

mani: BEGIN

DECLARE resultado float;

-- if (funcionario=0 && funcionario!=3) then
-- Select 'o campo é obrigatório';
-- leave main;

-- end if;

update vendedor set resultado=Comissao*qts_vendidaCD where idvendedor=funcionario; 

select resultado as Ganhos union select idvendedor;

End $$

DELIMITER ;

select * from vendedor;

 call ganhos_vendedor(2);

/*
------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------

*/

-- -----------------------------------------------------
-- CONSULTA 1 -  Transação para o caloteiro.
-- -----------------------------------------------------

delimiter $$
drop procedure if exists prc_pagtodivida$$
Create procedure prc_pagtodivida (in iddevedor int ,in divida int, in erro int)
Begin
	declare teste int default 1;
	SELECT(
	(SELECT IFNULL((SELECT codigo_devedor FROM devedor WHERE devedor.codigo_devedor=iddevedor and devedor.codigo_venda=divida),0))
	)into teste;
	if (teste=0) then 
		set erro=1; 
	end if;
	Start transaction;
		Delete from devedor where codigo_devedor=iddevedor and codigo_venda=divida;
		Update venda  set situacao = 'pago' where  venda.idvenda=divida;
	If (erro=1) then 
		select 'O pagamento não foi concluído. Verifique os parâmetros e tente novamente.';
			rollback;
		Else commit;
	end if;
End $$
delimiter ;

select * from devedor; -- SELECT ANTES DE EXECUTAR A PROCEDURE


-- -----------------------------------------------------
-- CONSULTA 5 - Aumentando preços do Fonecedor
-- -----------------------------------------------------


delimiter $$
drop procedure if exists Aumantado_preco$$
create procedure Aumantado_preco (in pos int, in verifica int)
begin
	start transaction ;
	update fornecedor set valor_de_custo=valor_de_custo*1.3 where idfornecedor=pos;
	if (verifica ='') then
		select 'Erro na atualização do preço de custo';
		rollback; -- volta com os dados interior
	else commit;
	end if;
	select * from fornecedor;
end$$


delimiter ;


Select * from fornecedor;

call Aumantado_preco(1,''); -- informando qual idfornecedor que será aumentado



