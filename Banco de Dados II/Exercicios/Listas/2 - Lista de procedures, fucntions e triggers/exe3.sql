-- 3)

use academico;
drop procedure if exists pr_buscarAluno;
Delimiter || 
create procedure pr_buscarAluno (in busca int)
begin

	declare msg char(30);
    set msg = " ";
    select nome from aluno where ra=busca;
    
    if(msg=" ") then 
		select "não existe";
    else 
		select "Existe";
        
end if;
end ;
|| delimiter ;

select pr_buscarAluno('5');