use filmes_db;


/*

------------------------------------ filmes_db.filme --------------------------------------------

*/

-- Exe - 1 
select titulo from filmes_db.filme inner join elenco on filme.filmeid = elenco.filmeid where atorid=77 ;

-- Exe - 2 
select count(*) from ator;

-- Exe - 3
select * from filmes_db.filme where titulo = 'titanic';

-- Exe - 4
select nome from filmes_db.Ator inner join elenco using(atorid) inner join filme f  using (filmeid) where f.titulo="titanic";
-- selecione campo_tabela junta com a tabela elenco usando campo_tabela_atorid junta com uma tabelaNova tablea filme f usando (filmeid) onde tabela_filme_f.titulo ="titanic";

-- Exe - 5
select f.titulo from ator a inner join elenco e using(atorid) inner join filme f using(filmeid) where a.nome like "%Schwarzenegger%";

-- Exe - 6
select ano, count(*) from filme group by ano;

-- Exe - 7
select titulo from filmes_db.filme  where ano ='1997' order by ano desc;

-- Exe -8
select a.nome, count(*) nrofilmes from ator a inner join elenco e using(atorid)
group by a.nome having nrofilmes >=10;

select a.nome, count(*) nrofilmes from ator a inner join elenco e using(atorid)
group by a.nome 
group by 2 desc limit 1;