-- 4)

use academico;
drop procedure if exists prMensalidade;

delimiter ||
create procedure prMensalidade (in curso char(3), in taxa float)
begin

	update curso set mensalidade = mensalidade*(1+taxa) where codcuro=curso;

end;
||
delimiter ; 

call prMensalidade('cc',0.7);