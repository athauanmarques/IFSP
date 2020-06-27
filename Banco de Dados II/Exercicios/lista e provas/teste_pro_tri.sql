use academico;

DELIMITER ||

create PROCEDURE contaluno(out result int)
begin
	Select count(*) into result from aluno;
end;
|| DELIMITER ;

-- select contaluno(@total) set @Total=@total +1;


DELIMITER &&

CREATE FUNCTION MEDIA(a FLOAT, b float) returns float
return (a+b)/2;

&& DELIMITER ;

update boletim set MEDIA = MEDIA(nota1,nota2);

select * from boletim;