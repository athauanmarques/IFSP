
-- ON DELETE cascate apaga todos estão relacionado com outra tabelas
-- ON DELETE no action não afeta outras tabelas, sem nada tbm é este comando

-- delete from aluno where codcurso='cc';

-- Teste

select * from curso;
select * from alunos;


drop trigger if exists Deletar_Aluno;


DELIMITER $$

CREATE TRIGGER deletar_aluno Before DELETE ON Curso -- ta criando uma trigge deleta antes a tabelas curso
FOR EACH ROW -- fazer isso a cada linha
BEGIN   
DELETE FROM aluno WHERE codcurso=old.codcurso;
END;
$$
DELIMITER ;

-- _______________________________________________________________________________________________________________________________________

DELIMITER $$

CREATE TRIGGER alterar_curso BEFORE UPDATE ON curso
FOR EACH ROW
BEGIN

IF(new.mensalidade> 1.1*old.mensalidade) THEN  -- calculando as porcentagem
SET new.mensalidade=1.1*old.mensalidade; -- set possue apena new

END IF;

END;

$$

UPDATE curso SET mensalidade=5000 WHERE codcurso='si';

-- _______________________________________________________________________________________________________________________________________

-- delimiter pode ser usa por " | "," # ","  $$ " e "!";

DELIMITER !

CREATE PROCEDURE contaluno(OUT result INT) -- result é um criação de uma variavel que é do tipo int
BEGIN -- condição
SELECT COUNT(*) INTO result FROM aluno;
END

!

DELIMITER;

call contaluno(@xx);
select @xx;
select * from aluno;

-- s é uma varialve que contem char 20 

DELIMITER $$
CREATE FUNCTION hello (s CHAR(20)) 
RETURNS CHAR(50)
RETURN CONCAT('Hello, ',s,'!');

end
$$

dELIMITER ;

select hello("Bianca");

-- _______________________________________________________________________________________________________________________________________



create table sex_alunos like aluno;
create * from sex_alunos;

delimiter !!

create trigger excluir_aluno before delete on aluno
for each row
begin
insert into ex_alunos values (old.ra, old.rg, old.nome, old.codcurso);
end

!!

delimiter ;

delete from aluno where ra='123';
select * from ex_alunos;