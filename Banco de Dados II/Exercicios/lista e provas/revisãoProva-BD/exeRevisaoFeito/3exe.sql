/*
3.	Faça uma procedure para inserir o banimento de um personagem. Passar como parâmetros o nome do personagem, 
a duração do banimento em dias e o motivo.
Dentro da rotina, inserir um registro na tabela banimento com os dados passados. 
Exemplo:
CALL banir_personagem('Victor', 10, 'Imitou de forma ousada o Cirilo da novela Carrossel');
*/

   drop procedure if exists pr_banimento; 
   
delimiter ||
	create procedure pr_banimento(in nomePerson varchar(30), in diasBan int, in motivoBam varchar(200))
    begin
     insert into banimento(idPersonagem, duracao, motivo) values (fn_BuscarID(nomePerson),DATE_ADD(CURDATE(), INTERVAL diasBan DAY),motivoBam);
    end;

|| delimiter ;

select * from banimento;

call pr_banimento('Aline',10,'bom');