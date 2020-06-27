drop trigger if exists deletar_aluno;
drop trigger if exists deletar_boletim;

delimiter |

create trigger deletar_aluno before delete on curso
for each row
begin
    delete from disciplina where codcurso=old.codcurso;
    delete from aluno where codcurso=old.codcurso;
end;
|
create trigger deletar_boletim before delete on disciplina
for each row
begin
	delete from boletim where coddisc=old.coddisc;
end;
|

delimiter ;

delete from curso where codcurso='as';

select * from curso;

