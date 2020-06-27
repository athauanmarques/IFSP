use academico;

drop trigger if exists altera_curso;

delimiter |

create trigger altera_curso before update on curso
for each row
begin

	IF (new.mensalidade>1.1*old.mensalidade) THEN
	SET new.mensalidade=1.1*old.mensalidade;

END IF;

end;

|

delimiter ;

update curso set mensalidade = 10000 where CODCURSO='SI';

select * from curso;
