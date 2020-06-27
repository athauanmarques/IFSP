-- copias de tabela

create table copialuno like aluno; -- copia estrutura

create table copiaaluno as select * from aluno; -- uma copia exata da tabela

-- view armazenar consulta referente a tabela foi criada (create view aluno)

create view viewAlunos as select * from aluno;


