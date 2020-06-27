-- 1)
use academico;

delimiter ||
create function fn_media (nota1 float, nota2 float)
returns float
return ((nota1*0.6) + (nota2*0.4));
|| delimiter ;

select fn_media(2,5) as "Média";