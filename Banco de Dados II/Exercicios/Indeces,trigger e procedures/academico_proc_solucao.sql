
Drop database if exists academico;
Create database if not exists academico;
use academico;


-- criacao de tabelas
CREATE TABLE if not exists CURSO
(
  CODCURSO  CHAR (3) NOT NULL,
  NOME    CHAR (30),
  MENSALIDADE FLOAT,
  TOTALUNOS INT,
  PRIMARY KEY (CODCURSO)
);

CREATE TABLE if not exists DISCIPLINA
(    CodDisc char(5) not null,
      Nome char(30),
      CodCurso char(5),
      NroCreditos int,
      PRIMARY KEY (CodDisc),
      FOREIGN KEY (CodCurso) REFERENCES CURSO(CODCURSO)   on delete cascade on update cascade
);

CREATE TABLE if not exists ALUNO
(
  RA	CHAR(9) NOT NULL,
  RG	CHAR(9) NOT NULL,
  NOME	CHAR(30),
  CODCURSO	CHAR(3),
 PRIMARY KEY (RA),
 FOREIGN KEY (CODCURSO) REFERENCES CURSO (CODCURSO)       on delete cascade on update cascade
);

CREATE TABLE if not exists BOLETIM
(     Ra char(9) NOT NULL,
      CodDisc  char(5) NOT NULL,
      Nota1 float,
      Nota2 float,
      Media float,
      PRIMARY KEY (Ra,CodDisc),
      FOREIGN KEY (Ra) REFERENCES ALUNO (Ra)       on delete cascade on update cascade,
      FOREIGN KEY (CodDisc) REFERENCES DISCIPLINA(CodDisc)        on delete cascade on update cascade
);
create table exalunos like aluno;

create table reprovados as select * from boletim where 0;

-- triggers e procedures 
delimiter |
Create function media_ponderada (a float, b float) returns float
        return ( (a * 0.4) + (b * 0.6));
|
delimiter ;

delimiter |
create trigger deletar_aluno after delete on aluno
for each row
begin	
	insert into exalunos 
    values(old.ra,old.rg,old.nome,old.codcurso);
    update curso set nroalunos=nroalunos-1 where codcurso = old.codcurso;
end;
|

create trigger avaliar1 after update on boletim
for each row
BEGIN
    if((new.Media <> old.Media) and (new.Media < 6)) then
		insert into reprovados values (new.ra,new.coddisc,new.Media);
	else	
		delete from reprovados 
        where ra=new.ra and coddisc=new.coddisc;
    end if;
end;
|

create trigger avaliar2 after insert on boletim
for each row
BEGIN
    if(new.Media < 6) then
		insert into reprovados values (new.ra,new.coddisc,new.Media);
	end if;
end;
|

create trigger inserir_alunos after insert on aluno
for each row
begin
	update curso set totalunos=totalunos+1 where codcurso = new.codcurso;
end;
|
delimiter ;

-- insercao de dados

-- delete from curso;
insert into CURSO VALUES ('AS','ANALISE DE SISTEMAS',1000, 0);
insert into CURSO VALUES ('CC','CIENCIA DA COMPUTACAO',950, 0);
insert into CURSO VALUES ('SI','SISTEMAS DE INFORMACAO',800, 0);

-- delete from aluno;
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

insert into BOLETIM values ('123','BDS',10, 3, null);
insert into BOLETIM values ('212','IBD',7.5,5, null);
insert into BOLETIM values ('231','BD',9, 8, null);
insert into BOLETIM values ('231','BDA',9.6, 6, null);
insert into BOLETIM values ('661','DBD',8,4, null);
insert into BOLETIM values ('765','DBD',6,5, null);