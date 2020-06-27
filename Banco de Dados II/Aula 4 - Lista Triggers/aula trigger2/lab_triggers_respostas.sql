-- Lista de triggers 

-- b. Copiar alunos excluidos em exalunos
use academico;
create table exalunos like aluno;
delimiter |
create trigger insert_exaluno after delete on aluno
for each row
begin	
	insert into exalunos 
    values(old.ra,old.rg,old.nome,old.codcurso);
end;
|
delimiter ;
-- teste
delete from aluno where ra='123';

-- e. copiar alunos com media < 6 para reprovados
create table reprovados as
select * from boletim where 0;

Delimiter $$
create trigger reprovar after update on boletim
for each row
BEGIN
    if((new.notaalu <> old.notaalu) and (new.notaalu < 6)) then
		insert into reprovados values (new.ra,new.coddisc,new.notaalu);
	end if;
end;
$$

-- teste
update boletim set notaalu =4.0 where ra=765;

Delimiter $$
create trigger reprovar2 after insert on boletim
for each row
BEGIN
    if(new.notaalu < 6) then
		insert into reprovados values (new.ra,new.coddisc,new.notaalu);
	end if;
end;
$$
delimiter ;
-- teste
insert into boletim values ('221','BDOO',9);
insert into boletim values ('231','BDOO',4);
