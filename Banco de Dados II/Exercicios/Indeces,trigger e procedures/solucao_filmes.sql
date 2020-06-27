-- Solução da lista filmes 
-- Ex1 
select filme.titulo
from filme inner join elenco 
on filme.filmeid=elenco.filmeid
where elenco.atorid=77;

-- Ex2
select count(*) from ator;

-- Ex3
select * from filme where titulo='Titanic';

-- Ex4
select a.nome
from ator a inner join elenco e using(atorid) 
     inner join filme f using(filmeid)
where f.titulo='Titanic';

-- Ex5
select f.titulo
from ator a inner join elenco e using(atorid) 
     inner join filme f using(filmeid)
where a.nome='Arnold Schwarzenegger';

-- Ex 6
select ano, count(ano)
from filme
group by ano;

-- Ex7 
select titulo
from filme 
where ano=1997
order by titulo;

-- Ex8




-- Ex9 


