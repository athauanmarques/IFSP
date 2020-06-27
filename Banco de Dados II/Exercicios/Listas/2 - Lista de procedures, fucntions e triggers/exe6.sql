ALTER TABLE curso ADD nroAlunos INT DEFAULT 0;
SELECT * FROM curso;

DELIMITER $
CREATE TRIGGER inserir_alunos AFTER INSERT ON aluno
FOR EACH ROW
BEGIN
	UPDATE curso SET nroAlunos=nroAlunos+1 WHERE codCurso = new.codCurso;
END ; 
$
DELIMITER ;

-- teste
INSERT INTO aluno VALUES('001','1123','Solemar','AS');
SELECT * FROM aluno;
UPDATE aluno SET nome='SOLEMAR SILVA' WHERE ra='001';
SELECT * FROM aluno;

DROP TRIGGER insert_exaluno;

DELIMITER |
CREATE TRIGGER insert_exaluno AFTER DELETE ON aluno
FOR EACH ROW
BEGIN
	INSERT INTO exalunos VALUES(old.ra, old.rg, old.nome,old.codcurso);
	UPDATE curso SET nroAlunos=norAlunos-1 WHERE codCurso=old.codCurso;
END;
|
DELIMITER ;
