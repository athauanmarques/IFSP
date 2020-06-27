use filmes_bd;

explain select * from ator;
-- mostra toda informações da consulta e mostrará índeces

create index ititulo on filme(titulo); 
-- criando indeces de uma tabela

create table usuario(
id int not null primary key,
sexo enum('Feminino','Masculino') not null
);

insert into usuario values(1,'Feminino');


select * from filme procedure analyse();
-- mostra toda analise de informações da tabela
-- use o programa Mysql query browser, para obter mais informações desse comando