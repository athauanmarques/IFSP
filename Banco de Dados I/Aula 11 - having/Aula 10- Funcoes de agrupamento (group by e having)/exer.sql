-- contar as quantidades inseridas de um tabela especifico (se aplica numero 2 exercicio)
-- select count(*) from filmes_db.ator;
-- select count(*) from filmes_db.filmes;
-- select count(*) from filmes_db.elenco;

-- exer 1
-- select filme.titulo
-- from filme inner join elenco on filme.filmeid=elenco.filmeid  -- on e using(idTableça) são mesma coisa
-- where elenco.atorid=77;

-- exer 2
-- select count(*)oi from ator; -- oi que escrevi é o nome que coloquei

-- exer 3
-- select * from filme where titulo='Titanic';

-- exer 4 b-- nao roda esta porra
-- select a.nome -- selecionar o nome do campo que quer pegar
-- from ator a inner join elenco e using(atorid)
-- inner join filme f using(filmeid)
-- where f.titulo='Titanic';

-- sexer 5 -- roda mas não parece nada

-- select f.titulo
-- from ator a inner join elenco e using(atorid)
-- inner join filme f using(filmeid)
-- where a.nome='Arnold Schwarzenegger';

-- exer 6

-- select ano, count(ano) -- selecionando ano e contando ano
-- from filme
-- group  by ano; -- grupar as contagem por ano (semore usa duas tabelas para cria um grupo unico)

-- outro - qts atore tem um filme

-- select ano, count(filmeid) -- selecionando ano e contando ano
-- from elenco
-- group  by filmeid; -- grupar as contagem por ano (semore usa duas tabelas para cria um grupo unico)

select ano, count(filmeid)
from elenco inner join filme using(filmeid)
group  by filmeid
 
order by 2 desc;


select titulo, count(filmeid) atores
from elenco inner join filme using(filmeid)
group  by filmeid
having atores>20 -- havind é um condição que é usando com colunas diferentes
order by atores desc;

-- exercicio 7

select titulo
from filme
where ano=1997
order by titulo;

-- exe 8

select nome, count(atorid) filme --  nome do campo (nome) contar id da tabela(atorid) campo da outra tabela
from elenco inner join ator using(atorid)
group  by atorid
having filme>10 -- havind é um condição que é usando com colunas diferentes
order by filme desc;

-- exer 9

update filme
set ano = 1997
where filme.titulo = 'independence day';



