drop database IF EXISTS Laboratório ;
Create database if not exists Laboratório ;
use Laboratório ;

-- criacao de tabelas 
CREATE TABLE if not exists CURSO
(
CODCURSO Char(3) not null,
Nome char(50) Null,
Mensalidade float,
primary key(CODCURSO)
);

CREATE TABLE IF NOT exists ALUNO
(
Prontuario char (8) not null,
Nome char(50) null,
CODCURSO char(3),
primary key(Prontuario),
foreign key (CODCURSO) references CURSO(CODCURSO) on delete set null

);

insert into CURSO VALUES ('AS','ANALISE DE SISTEMAS',1000);
insert into curso values ('cc', 'Ciência da computação', 950.00);
insert into CURSO values ('SI', 'SISTEMAS DE INFORMACAO', 800.00);
-- ---------------------------- aLUNOS

insert into ALUNO values ('132', 'BIANCA MARIA PEDROSA', 'as');
insert into ALUNO values ('212', 'TATIANE CITTON ', 'as');
insert into ALUNO values ('221', 'ALEXANDRE PEDROSA', 'cc');
insert into ALUNO values ('231', 'ALEXANDRE MONTEIRO ', null);
insert into ALUNO values ('321', 'MARCIA RIBEIRO ', 'cc'); -- xx não existe

