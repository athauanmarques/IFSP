delimiter %
CREATE PROCEDURE p (pval INT)
BEGIN
  DECLARE specialty CONDITION FOR SQLSTATE '45000';
  IF pval = 0 THEN
    SIGNAL SQLSTATE '01000';
  ELSEIF pval = 1 THEN
    SIGNAL SQLSTATE '45000'
      SET MESSAGE_TEXT = 'Ocorreu um erro';
  ELSEIF pval = 2 THEN
    SIGNAL specialty
      SET MESSAGE_TEXT = 'Ocorreu um erro';
  ELSE
    SIGNAL SQLSTATE '01000'
      SET MESSAGE_TEXT = 'Ocorreu uma advertência ', MYSQL_ERRNO = 1000;
    SIGNAL SQLSTATE '45000'
      SET MESSAGE_TEXT = 'Ocorreu um erro', MYSQL_ERRNO = 1001;
  END IF;
END;
%
delimiter ;

call p(1);

DELIMITER |
CREATE EVENT IF NOT EXISTS EVP ON SCHEDULE EVERY 1 HOUR STARTS DATE("2016/03/28")
DO BEGIN
		CALL P(0) ;
END
|
DELIMITER ;