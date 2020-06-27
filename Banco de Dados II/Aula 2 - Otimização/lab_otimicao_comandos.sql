explain select * from Aluno where ra=123;-- Esta cosulta é explicação da tabela
explain select * from Aluno ;

select * from aluno procedure analyse(); -- é analise dos dados da tabela aluno 

select ra, nome from aluno
where ra not in (select ra from boletim); -- quem não cursa as disciplinas

select ra, nome 
from aluno left join boletim using(ra)
where notaalu is null; -- quem não cursa as disciplinas (com left join)

explain select * from aluno where nome = 'bianca';

create index nomidx on aluno(nome); -- nome_do_indece_ on tabela(campo_da_tabela)
