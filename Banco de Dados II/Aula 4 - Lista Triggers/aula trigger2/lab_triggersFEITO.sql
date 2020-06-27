use academico;

delimiter ||

create trigger inserir_aluno after delete on aluno
for each row
begin

insert into exaluno
 values (old.ra, old.rg, old.nome, old.codcurso);

end ;

||

delimiter ;



create table reprovados as select * from boletim where 0;

delimiter ||

create trigger reprovar after update on boletim
for each row
begin
	
if ((new.notaalu <> old.notaalu) and (new.notaalu < 0)) then
	insert into reprovados values (new.ra,new.coddisc,new.notaalu);
	
	end if;

end;
||
delimiter ;

