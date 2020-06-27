
/*
1.	Criar uma procedure para transferir zennys de um personagem para outro. Para esta procedure passar como parâmetros nome do personagem 1, nome do personagem 2 e valor. Exemplo:
CALL transferir_zeny('Abdaisim Trader','Abrest', 20000);
*/
drop procedure if exists pr_transferirZenny;
delimiter ||
create procedure pr_transferirZenny(in person1 varchar(100), in person2 varchar(100),in vlrZenny int)
begin
	UPDATE personagem set zeny = zeny + vlrZenny where nome = person2;
    UPDATE personagem set zeny = zeny - vlrZenny where nome = person1;
	
end;

|| delimiter ;

select nome,zeny from personagem where nome = 'Abdaisim Trader' union select nome,zeny from personagem where nome = 'Abrest';

call pr_transferirZenny('Abdaisim Trader','Abrest', 20000);
