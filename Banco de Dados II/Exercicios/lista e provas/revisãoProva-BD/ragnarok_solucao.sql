-- Solucao da  revisao ragnarok

-- 1. Transferir zeni do personagem 1 para personagem 2
DELIMITER ||
CREATE PROCEDURE transferir_zeny (IN personagem1 VARCHAR(30), IN personagem2 VARCHAR(30), IN valor INT)
BEGIN
	-- DECLARE EXIT HANDLER FOR SQLSTATE '02003'
	UPDATE personagem SET zeny= zeny - valor WHERE nome=personagem1 and zeny >= valor;
	UPDATE personagem SET zeny= zeny + valor WHERE nome=personagem2;
END
||
DELIMITER ;

-- 2. Função que retorna um id do Personagem ao receber um nome.
DELIMITER ||
CREATE FUNCTION buscarID (nomePersonagem CHAR(30)) RETURNS INT 
READS SQL DATA
DETERMINISTIC
BEGIN 
	DECLARE idBuscado INT;
	SELECT idPersonagem FROM personagem WHERE nome = nomePersonagem INTO idBuscado;
	return idBuscado; 
END||

-- 3. Procedure para banir um personagem,...
delimiter ||
CREATE PROCEDURE banir_personagem 
(IN nick CHAR(30), IN duracaoDias INT, IN motivow CHAR(200))
BEGIN
	INSERT INTO banimento (idPersonagem, duracao, motivo) 
	VALUES (buscarID(nick), DATE_ADD(CURDATE(), INTERVAL duracaoDias DAY), motivow);
END ||

-- 4. Trigger que verifica se o personagem passou de nível e aumenta os stats caso tenha passado
DELIMITER %
CREATE TRIGGER atualizar_stats AFTER UPDATE ON `Ragnarok`.`Personagem`
FOR EACH ROW
BEGIN
 IF(NEW.levelbase > old.levelbase) THEN
  UPDATE Stats SET
   forca = forca + 5,
   agilidade = agilidade + 5,
   inteligencia = inteligencia + 5,
   destreza = destreza + 5,
   sorte = sorte + 5,
   vitalidade = vitalidade +5
  where Stats.idPersonagem =new.idPersonagem;
 END IF;
END
%
-- Procedure que verifica os banimentos que encerram durante o dia atual e os remove da tabela.
DELIMITER ||
CREATE PROCEDURE rotina_diaria()
BEGIN
	DELETE FROM banimento WHERE duracao=curdate();
END
||

-- Evento que será executado todo dia chamando a rotina_ban();
DELIMITER ||
CREATE EVENT rotina_diaria ON SCHEDULE EVERY 1 DAY
DO
BEGIN
	call ragnarok.rotina_ban();
END

||
