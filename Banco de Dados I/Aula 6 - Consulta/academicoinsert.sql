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



-- Consulta com condição

-- select  nome,ra
-- from aluno
-- where CODCURSO ='as';

-- consulta explicitamente  o campo de daddo

-- ------------------ upper e betwee -------------------
-- Where upper(codcurso)='AS' converte para maiuscula

-- between (Seleciona condições entre dois valores)
-- Veja sintaxe abaixo:

-- select * from curso
-- where mensalidade >= 1000 and mensalidade <= 1500;

-- ou

-- select * from curso
-- where mensalidade between 1000 and mensalidade <= 1500;

-- ------------ LIKE ------------------
-- Utilizam curingas (parecido com) Selecione os curso NOME contenham a palavra 'SISTEMAS'
-- Sintaxe abaixo:

 -- Select * from curso
 -- where nome like '%SISTEMAS%' -- ELE BUSCA TODA PALAVRA Q CONTE "SISTEMAS"

-- ------------------------- IN -----------------------
-- SELECIONAR UM DETERMINADO TABELA, ser ligar selects

-- Sintaxe:

-- Select * from aluno
-- where codcurso in ('AS','CC');
-- OU
-- Select * from aluno
-- where codcurso not in ('AS','CC'); -- todos alunos menos 'AS' E 'CC'

-- outro exemplo:

-- select * from aluno;
-- select * from boletim;

-- select nome from aluno
-- where ra not in (select ra from boletim); -- mostrar ra do aluno que não estão no boletim 

-- -------------------CONSULTA COM ORDENAÇÃO-----------------------

-- Sintaxe ordenado em orde alfabértica

-- select * from aluno
-- order by codcurso desc, nome -- crescente

-- select * from aluno
-- order by codcurso desc, nome desc-- descrescente

-- -------- outro exemplo

-- atribuindo apelido:
-- Select a.nome
-- from aluno a;

-- select A.nome, A.ra
-- from aluno A     -- A é uma paelido
-- where A.codcurso='AS' -- A é uma apelido
-- order by 1 ;  -- ordenando por numero de ra crescente

-- select A.nome, A.ra
-- from aluno A     -- A é uma paelido
-- where A.codcurso='AS' -- A é uma apelido
-- order by 1 desc;  -- ordenando por numero de ra descrescente

-- ----------FUNÇÕES: contador e calculos numéricos ----------------------
-- para saber  qts numeros de linha alunos
-- * para qual coluna

-- select count(*) from aluno; -- qts colunas estão nos alunos
-- para saber o valor médio de uma coluna

-- para saber o médio da coluna
-- select avg(mensalidade) from curso;-- avg é uma função  da média só aplica valor numéricos
-- select * from curso; 

-- select round(avg(mensalidade),2) from curso; -- round redondamento e numero de casas neste caso é "2" 
-- select * from curso; 

-- para obter valores distintos em uma coluna
-- select distinct(codcurso) from aluno;
-- ou
-- select count(distinct(codcurso)) from aluno;

-- ---------------- PARA SABER O MAIO VALOR ------------------
-- sintaxe
-- Select * from curso;
-- select nome from curso 
-- where mensalidade = (select max(mensalidade) from curso);

-- Outro modo 
-- Select * from curso;
-- select nome, mensalidade from curso 
-- order by mensalidade desc limit 1; -- limit 1 só vai mostra um valor maior da mensalidade

-- -----------------------PARA SABER A MENOR--------------------------------------

-- Select * from curso;
-- select nome from curso 
-- where mensalidade = (select MIN(mensalidade) from curso); -- MIM para saber o menor valor



Select * from aluno
where codcurso in ('AS','CC','SI');

