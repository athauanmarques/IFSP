Delimiter &&
create procedure fechar_conta()
begin
update venda
set status_venda = 'D'
where data_pagto<=curdate();
end;
&&

delimiter ;

update venda set status_venda = '';

call fechar_conta();

