--						 -----------------------------------------------------
-- 						 -------------------- CONSULTAS -----------------
--						 -----------------------------------------------------


-- 2) Retira espaços da tabela Riffs
SELECT TRIM('    Stairway To Heaven   ')TirandoEspacos; 

-- 1) Deixar todos os nomes de bandas em maiúsculas. 
SELECT upper( nome )Maiusculas FROM Bandas;

-- 3) JMostra qual banda que faz parte do estilo Harcore
Select * from Bandas
where Genero like '%Hardcore%';

-- 3) Junte as tabelas Melhores_albuns com Bandas
 Select* from melhores_albuns inner join Bandas using(idBandas);

-- 7)Conta a quantidade de Genero
select Genero, count(*)Quantidade from Bandas
group by Genero
order by count(*) desc
limit 1;

-- 6) Conta  quantidade de letras da palavra Maylene and the Sons of Disaster 
SELECT Length (Nome)Letras 
FROM Bandas 
WHERE Nome = 'Maylene and the Sons of Disaster';

-- 8) unie resultados 
SELECT Evento, quantidade from Premiacao WHERE quantidade = 12 
UNION  -- vai unir os resultados para serem exibidos 
SELECT Evento, quantidade from Premiacao WHERE quantidade = 1;

-- 4) Concatene Nome com Pais. e Tira 20 letras da banda 'From a Second Story Window 
SELECT CONCAT(Nome, Pais)Resultado FROM Bandas  -- vai cocatenar as palavras nome com pais
WHERE Nome = 'Pentacrostic'
union -- uni os resultados para ser mostrado
Select SUBSTRING(Nome, 20)Retirado from Bandas -- vai retirar 20 palavras 
where Nome ='From a Second Story Window';

-- ) Mostra a banda mais antiga e banda mais recente
SELECT Nome, Ano_da_formacao FROM bandas
WHERE  Ano_da_formacao = (SELECT min(Ano_da_formacao) FROM bandas) -- banda mais velha
union
SELECT Nome, Ano_da_formacao FROM bandas
WHERE  Ano_da_formacao = (SELECT max(Ano_da_formacao) FROM bandas); -- banda mais nova

-- 10) Multiplicando por 100 as quantidade de premios da tabela Premiacao
SELECT Evento, CASE Evento
  WHEN 'Billboard music awards' THEN quantidade * 100 -- quando EVento for Billboard music awards "faça" quantidade * 100; 
  WHEN 'Metal Hammer Golden God Awards' THEN quantidade * 100
  WHEN'Billboard music awards'  THEN quantidade * 100 
  WHEN'ECHO Awards'  THEN quantidade * 100
  WHEN'Kerrang!Awards'  THEN quantidade * 100
  WHEN'MTV Music Awards'  THEN quantidade * 100
  WHEN'Revolver Golden Gods Awards'  THEN quantidade * 100
-- poderiamos multiplica com valores diferentes, ou usar operadores matematicos diferentes.
  ELSE quantidade
  END -- termina a condição
'Qts de premios multiplicada por 100' -- aqui é o nome da tabela que será exibida
FROM Premiacao;
-- Este comando tem a mesma função do swicth case em C, só muda a sintaxe.

--						 -----------------------------------------------------
-- 						 -------------------- CONSULTAS EXTRAS -----------------
--						 -----------------------------------------------------

-- 11)Quantidade de bandas do anos 80;
  select count(*)QtsBanda80 from Bandas
   where Ano_da_formacao >= 1980 and Ano_da_formacao < 1990;

-- 12) Mostras a quandidade de banda de cada páis
select Pais, count(*) from Bandas
group by Pais
order by count(*) desc;


-- 13)Ordernar nomes das bandas decrescente.
select nome from bandas
order by Nome desc, nome;

-- 14)Ordernar nomes das bandas crescente.
select nome from bandas
order by 1 asc;

-- 15)Qual estilo musica que contem maior que 100 bandas.
select Genero, count(*)Quantidades from Bandas
group by Genero
having count(*) > 100
order by count(*) desc;

-- 16)Mostra os nomes das bandas 
select * from Bandas;

-- 17)Mostra todas as tabelas  
show tables;