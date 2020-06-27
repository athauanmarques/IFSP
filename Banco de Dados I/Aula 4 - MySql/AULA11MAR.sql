-- exclui o banco, se ja existir
drop database if exists academico;

-- criando banco de dados
create database academico;

-- selecionando o banco de dados
use academico;

-- criando tabelas
CREATE TABLE CURSO
(
   CODCURSO CHAR (3) NOT NULL,
   NOME CHAR (30),
   MENSALIDADE DECIMAL(6,2),
   PRIMARY KEY(CODCURSO)
);

CREATE TABLE ALUNO
(
  RA		CHAR(9) NOT NULL  PRIMARY KEY ,
  RG		CHAR(9) NOT NULL,
  NOME		CHAR(30),
  CODCURSO	CHAR(3) NULL,
  FOREIGN KEY (CODCURSO) REFERENCES CURSO (CODCURSO)
  -- ON DELETE NO ACTION
);

-- INSERINDO DADOS
INSERT INTO CURSO 
   VALUES ('AS','ANALISE DE SISTEMAS',1000);
INSERT INTO CURSO(CODCURSO,NOME)
   VALUES ('CC','CIENCIA DA COMPUTACAO');
INSERT INTO CURSO (MENSALIDADE,CODCURSO,NOME)
   VALUES (123,'SI','SISTEMAS DE INFORMACAO');

insert into aluno(ra,rg,nome,codcurso)
   values ('121','123','Bianca','AS');

insert into aluno(ra,rg,nome,codcurso)
   values ('122','234','GIL','AS');

