drop database IF EXISTS academico;
Create database if not exists academico;
use academico;

-- criacao de tabelas 
CREATE TABLE if not exists CURSO
(
  CODCURSO  CHAR (3) NOT NULL,
  NOME    CHAR (30),
  MENSALIDADE FLOAT,
  PRIMARY KEY (CODCURSO)
);

CREATE TABLE if not exists DISCIPLINA
(    CodDisc char(5) not null,
      Nome char(30),
      CodCurso char(5),
      NroCreditos int,
      PRIMARY KEY (CodDisc),
      FOREIGN KEY (CodCurso) REFERENCES CURSO(CODCURSO) 
);

CREATE TABLE if not exists ALUNO
(
  RA	CHAR(9) ,
  RG	CHAR(9) ,
  NOME	CHAR(30),
  CODCURSO	CHAR(3),
 PRIMARY KEY (RA),
 FOREIGN KEY (CODCURSO) REFERENCES CURSO (CODCURSO) 
);

CREATE TABLE if not exists BOLETIM
(     Ra char(9) ,
      CodDisc  char(5) ,
      NotaAlu  decimal(6,2),
      PRIMARY KEY (Ra,CodDisc),
      FOREIGN KEY (Ra) REFERENCES ALUNO (Ra),
      FOREIGN KEY (CodDisc) REFERENCES DISCIPLINA(CodDisc) 
);

-- insercao de dados
insert into CURSO VALUES ('AS','ANALISE DE SISTEMAS',1000);
insert into CURSO VALUES ('CC','CIENCIA DA COMPUTACAO',950);
insert into CURSO VALUES ('SI','SISTEMAS DE INFORMACAO',800);

insert into ALUNO VALUES ('123','12345','BIANCA MARIA PEDROSA','AS ');
insert into ALUNO VALUES ('212','21234','TATIANE CITTON','AS');
insert into ALUNO VALUES ('221','22145','ALEXANDRE PEDROSA ','CC'); 
insert into ALUNO VALUES ('231','23144','ALEXANDRE MONTEIRO','CC'); 
insert into ALUNO VALUES ('321','32111','MARCIA RIBEIRO ','CC'); 
insert into ALUNO VALUES ('661','66123','JUSSARA MARANDOLA','SI'); 
insert into ALUNO VALUES ('765','76512','WALTER RODRIGUES','SI'); 

insert into DISCIPLINA values ('BD','BANCO DE DADOS','CC',4);
insert into DISCIPLINA values ('BDA','BANCO DE DADOS AVANCADOS','CC',6);
insert into DISCIPLINA values ('BDOO','BANCO DE DADOS O OBJETOS','SI',4);
insert into DISCIPLINA values ('BDS','SISTEMAS DE BANCO DE DADOS','AS',	4);
insert into DISCIPLINA values ('DBD','DESENVOLVIMENTO BANCO DE DADOS','SI',6);
insert into DISCIPLINA values ('IBD','INTRODUCAO A BANCO DE DADOS','AS',2);

insert into BOLETIM values ('123','BDS',10);
insert into BOLETIM values ('212','IBD',7.5);
insert into BOLETIM values ('231','BD',9);
insert into BOLETIM values ('231','BDA',9.6);
insert into BOLETIM values ('661','DBD',8);
insert into BOLETIM values ('765','DBD',6);


-- sintaxe Join -- 

-- Select* from aluno inner join curso using(codcurso);
-- .. * from <tabela1>inner join <tabela2> using (chavez primária da tabela2);
-- outro exemplo
-- from aluno inner join curso on aluno.codcurso.codcurso;

-- -------------------------------- organizando join ----------------------------------------------

 -- Select a.nome Aluno, c.nome Curso from aluno a inner join curso c on a.codcurso = c.codcurso;
 -- a.nome Aluno (Aluno vai ser um novo nome da tabela para ser exibida), c.nome Curso(o mesmo)
 -- from aluno a( o 'a' é tabela Aluno apilido),  inner join curso c (o mesmo) on  a.codcurso = c.codcurso;
 

-- select d.nome  disciplina,  c.nome curso -- <d.(apilido)nome(Campo) disciplina(nome da tabela)>--
-- from disciplina d inner join curso  c on d.codcurso =c.codcurso where c.nome= "Ciencia da Computação";
--   

-- -------------------------- join com 3 tabela -- exercicios -----------------------------------------

-- select a.nome 
-- from disciplina d inner join boletim  b  
-- on d.coddisc =b.coddisc 
-- inner join aluno a on b.ra=a.ra where d.nome = "Banco de Dados"; 
-- explicando
-- tabela aluno não interliga com disciplina, então tem que fazer junção disciplina com boletim, 
-- para localiza o RA where quan nome do campo disciplina

-- exer
-- select a.nome aluno
-- from boletim b  inner join aluno a on b.ra=a.ra where b.notaalu >9; -- where é o que vc ta procurando

-- exer
 -- select a.nome, d.nome, b.notaalu
 -- from curso c inner join aluno a using (codcurso)
-- 	 inner join boletim b using(ra)
-- 	 inner join disciplina d using(coddisc) -- lugar do using pode usar 'on'
-- where c.nome = "ciencia da computação";

-- ------------------------ Junção Externa esquerda (LEFT e RIGHT)--------------------------------------------
-- posições de junção de tabela


-- select * from aluno left join boletim  using (ra)
-- where boletim.notaalu  is null -- não fazem parte

-- select * from aluno RIGHT join boletim  using (ra)
-- where boletim.notaalu  is null -- não fazem parte

--  exer 
-- select * from aluno left join boletim using (ra)
-- where boletim.notaalu is null;

-- ou 

 -- select aluno.nome from aluno 
 -- where ra not in (select ra from boletim);

-- exer
-- select disciplina.nome
-- from disciplina left join boletim using(coddisc)
-- where boletim.notaalu is null;









