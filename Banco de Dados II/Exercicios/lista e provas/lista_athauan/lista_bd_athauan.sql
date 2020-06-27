
-- 2.	Crie uma visão (emprestimos_realizados) que mostre:
--  o nome do usuario, título do livro, data de emprestimo, devolução e entrega de todos os empréstimos realizados na biblioteca.

use biblioteca;
drop view if exists vw_emprestimos_realizados;
create view vw_emprestimos_realizados as select nome,data_emprestimo,data_devolucao,data_entrega
from biblioteca.emprestimo inner join biblioteca.usuario;

select nome,data_emprestimo,data_devolucao,data_entrega from vw_emprestimos_realizados;

-- 3.	Crie uma visão (emprestimos_atrasados) que mostre todos os empréstimos atrasados com base na visão empréstimos realizados.

drop view if exists vw_emprestimos_atrasados;
create view vw_emprestimos_atrasados as select *, DATEDIFF(data_entrega,data_devolucao) atraso 
from  vw_emprestimos_realizados where DATEDIFF(data_entrega,data_devolucao)  < 0 or data_entrega IS NULL
ORDER BY data_entrega;

select * from vw_emprestimos_atrasados;

-- 4.	 Crie uma visão (quantidade_emprestimos_usuario) que mostre a quantidade de emprestimos realizados por cada usuário.

drop view if exists vw_quantidade_emprestimos_usuario;
create view vw_quantidade_emprestimos_usuario as select nome, qts_emprestado from usuario;

select * from vw_quantidade_emprestimos_usuario;

-- 5.	Crie um procedimento de cadastro de empréstimos, que receba o código do usuário e do livro como parâmetros de entrada. 
-- A data de empréstimo e devolução devem ser definidas automaticamente pelo banco de dados, por exemplo, data de empréstimo = hoje, 
-- e a data de devolução = 30 dias após o a data de empréstimo. Dica: Usar as funções curdate() e adddate() do MySQL
drop procedure if exists pd_emprestimo;
delimiter ||

create procedure pd_emprestimo (in idusuario int, in idlivro int, in data_entregou date) 
begin
	insert into emprestimo(data_emprestimo,data_entrega, data_devolucao,usuario_idusuario,livro_idlivro) values (curdate(), data_entregou,adddate(NOW(), INTERVAL 30 DAY),idusuario,idlivro);
 
end;

|| delimiter ;

call pd_emprestimo(4,7,'2016.03.30');
select * from emprestimo inner join usuario where livro_idlivro =7;

-- 6.	Crie um procedimento para devolver um livro, que receba o código do empréstimo como parâmetro de entrada. 
-- A data de entrega deve ser preenchida automaticamente pelo banco de dados (hoje).Dica: Usar a função curdate() do MySQL.

Delimiter ||

create procedure pd_devolver_livro (in pd_idemprestimo int)
begin
	update emprestimo set data_devolucao = 
    
    date(NOW(), INTERVAL 30 DAY) where idemprestimo = pd_idemprestimo;
end;

|| Delimiter ;

-- 7.	Crie uma função que retorne a quantidade vezes que determinado livro foi emprestado. 
-- É necessário receber o código do livro como parâmetro de entrada.
drop function if exists conta_emprestimos;

Delimiter ||

	create function conta_emprestimos (idlivro int) returns int
    begin
    declare x int;
		select count(idlivro) into x from emprestimo where idlivro=2;
        return x;
    end;
    
|| delimiter ;

-- teste
select conta_emprestimos(5);
-- 8.	Crie um gatilho que incremente a quantidade de livros emprestados para um determinado usuário (campo da tabela usuario). 
-- O gatilho deve ser ativado toda vez que ocorrer uma inserção na tabela de empréstimo.

Delimiter ||

	create trigger tr_qts_livro after insert on usuario 
    for each row
    begin
		insert into usuario(qts_emprestado) value ();
    end;
    
|| delimiter ;
