-- 5)

CREATE TABLE reprovados AS SELECT * FROM boletim WHERE 0;

DESC reprovados;

UPDATE boletim SET notaAlu=10 WHERE ra=231;
DROP TRIGGER reprovar;
DELIMITER $$
CREATE TRIGGER reprovar AFTER UPDATE ON boletim
FOR EACH ROW
BEGIN
IF (new.notaAlu <> old.notaAlu) AND (new.notaAlu<6)THEN
INSERT INTO reprovados VALUES(new.ra, new.codDisc, new.notaAlu);
ELSE
DELETE FROM reprovados WHERE ra=new.ra AND codDisc=new.codDisc;
END IF;

END;
$$
DELIMITER ;

-- UPDATE BOLETIM SET CODDISC='BDD' WHERE RA='765'
UPDATE boletim
SET notaAlu=5.0
WHERE ra=765;

CREATE TABLE reprovados2 AS SELECT * FROM boletim WHERE 0;

DESC reprovados;

DELIMITER $$
CREATE TRIGGER reprovar2 AFTER INSERT ON boletim
FOR EACH ROW
BEGIN
IF (new.notaAlu<6)THEN
INSERT INTO reprovados VALUES(new.ra, new.codDisc, new.notaAlu);

END IF;

END;
$$
DELIMITER ;



INSERT INTO boletim VALUES ('231','BDOO',3);
