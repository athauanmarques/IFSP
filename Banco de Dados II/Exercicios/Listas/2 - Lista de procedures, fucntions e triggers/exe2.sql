-- 2)
use academico;

create table exAluno like aluno;

drop trigger if exists tr_exAluno;

delimiter ||
create trigger tr_exAluno after Delete on aluno
for each row
begin
	insert into exAluno values (old.RG, old.RG, old.Nome, old.CODCURSO);
end; 

|| delimiter ;

delete from aluno where ra = '123';

