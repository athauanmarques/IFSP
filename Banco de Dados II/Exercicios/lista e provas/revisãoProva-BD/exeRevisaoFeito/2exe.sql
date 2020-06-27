/*
2.	Faça uma função para retornar o id de um personagem. Esta função recebe como
parâmetro o nome do personagem. Exemplo:
SELECT buscarID("Elder Ravoc");
*/
drop function if exists fn_BuscarID;

delimiter ||
create function fn_BuscarID(fnNome varchar(100)) Returns int
begin
	declare idBuscado int; 
	select idPersonagem from personagem where nome = fnNome into idBuscado;
    return idBuscado;
end;

|| delimiter ;

select nome,idPersonagem from personagem;

select fn_BuscarID('Aline') as 'Buscador de ID';