SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `Loja_Bandas_metal` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
CREATE SCHEMA IF NOT EXISTS `principal_metal` DEFAULT CHARACTER SET utf8 ;
USE `Loja_Bandas_metal` ;

-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Bandas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Bandas` (
  `idBandas` INT NOT NULL,
  `Nome` VARCHAR(38) NULL,
  `Pais` CHAR NULL,
  `Genero` CHAR(45) NULL,
  `Ano_da_formacao` YEAR NULL,
  PRIMARY KEY (`idBandas`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Influencias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Influencias` (
  `idBandas` INT NOT NULL,
  `idInfluencias` INT NOT NULL,
  PRIMARY KEY (`idBandas`, `idInfluencias`),
  CONSTRAINT `fk_Bandas_has_Bandas_Bandas`
    FOREIGN KEY (`idBandas`)
    REFERENCES `Loja_Bandas_metal`.`Bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Bandas_has_Bandas_Bandas1`
    FOREIGN KEY (`idInfluencias`)
    REFERENCES `Loja_Bandas_metal`.`Bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Melhores_Albuns`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Melhores_Albuns` (
  `idMelhores_Albuns` INT NOT NULL,
  `Album` VARCHAR(45) NULL,
  `ano_do_lancamento` YEAR NULL,
  `Quantidades_de_vendas` FLOAT NULL,
  `Bandas_idBandas` INT NOT NULL,
  PRIMARY KEY (`idMelhores_Albuns`, `Bandas_idBandas`),
  CONSTRAINT `fk_Melhores_Albuns_Bandas1`
    FOREIGN KEY (`Bandas_idBandas`)
    REFERENCES `Loja_Bandas_metal`.`Bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Melhores_Riffs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Melhores_Riffs` (
  `idMelhores_Riffs` INT NOT NULL,
  `Musica` CHAR NULL,
  `idMelhores_Albuns` INT NOT NULL,
  PRIMARY KEY (`idMelhores_Riffs`),
  CONSTRAINT `fk_Melhores_Riffs_Melhores_Albuns1`
    FOREIGN KEY (`idMelhores_Albuns`)
    REFERENCES `Loja_Bandas_metal`.`Melhores_Albuns` (`idMelhores_Albuns`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Premiacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Premiacao` (
  `idPremiacao` INT NOT NULL,
  `Quantidade_de_premios:` INT NULL,
  `Bandas_idBandas` INT NOT NULL,
  PRIMARY KEY (`idPremiacao`),
  CONSTRAINT `fk_Premiacao_Bandas1`
    FOREIGN KEY (`Bandas_idBandas`)
    REFERENCES `Loja_Bandas_metal`.`Bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `principal_metal`.`bandas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `principal_metal`.`bandas` (
  `idBandas` INT(11) NOT NULL,
  `Nome` VARCHAR(38) NOT NULL,
  `Pais` VARCHAR(45) NOT NULL,
  `Genero` CHAR(45) NULL DEFAULT NULL,
  `Ano_da_formacao` YEAR NULL DEFAULT NULL,
  PRIMARY KEY (`idBandas`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `principal_metal`.`melhores_riffs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `principal_metal`.`melhores_riffs` (
  `posicao` INT(11) NOT NULL,
  `Musica` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`posicao`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `principal_metal`.`melhores_albuns`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `principal_metal`.`melhores_albuns` (
  `idMelhores_Albuns` INT(11) NOT NULL,
  `Album` VARCHAR(45) NULL DEFAULT NULL,
  `ano_do_lancamento` YEAR NULL DEFAULT NULL,
  `idBandas` INT(11) NOT NULL,
  `melhores_riffs_posicao` INT(11) NOT NULL,
  PRIMARY KEY (`idMelhores_Albuns`),
  CONSTRAINT `melhores_albuns_ibfk_1`
    FOREIGN KEY (`idBandas`)
    REFERENCES `principal_metal`.`bandas` (`idBandas`),
  CONSTRAINT `fk_melhores_albuns_melhores_riffs1`
    FOREIGN KEY (`melhores_riffs_posicao`)
    REFERENCES `principal_metal`.`melhores_riffs` (`posicao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Vendedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Vendedor` (
  `idVendedor` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `RA` VARCHAR(45) NULL,
  `Comissao` FLOAT NULL,
  `qst_vendida` INT NULL,
  PRIMARY KEY (`idVendedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Fornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Fornecedor` (
  `idfornecedor` INT NOT NULL,
  `Empresa` VARCHAR(45) NULL,
  `Qts_cd_fornecedor` INT NULL,
  `Valor_de_custo_cd` FLOAT NULL,
  PRIMARY KEY (`idfornecedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Estoque`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Estoque` (
  `idEstoque` INT NOT NULL,
  `Qts_Cd` INT NULL,
  `fornecedor_idfornecedor` INT NOT NULL,
  PRIMARY KEY (`idEstoque`),
  CONSTRAINT `fk_Estoque_fornecedor1`
    FOREIGN KEY (`fornecedor_idfornecedor`)
    REFERENCES `Loja_Bandas_metal`.`Fornecedor` (`idfornecedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Venda_CD`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Venda_CD` (
  `idCD` INT NOT NULL,
  `Valor_de_vendaCD` FLOAT NULL,
  `Gravadora` VARCHAR(45) NULL,
  `melhores_albuns_idMelhores_Albuns` INT(11) NOT NULL,
  `Vendedor_idVendedor` INT NOT NULL,
  `Estoque_idEstoque` INT NOT NULL,
  PRIMARY KEY (`idCD`),
  CONSTRAINT `fk_Venda_CD_melhores_albuns1`
    FOREIGN KEY (`melhores_albuns_idMelhores_Albuns`)
    REFERENCES `principal_metal`.`melhores_albuns` (`idMelhores_Albuns`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Venda_CD_Vendedor1`
    FOREIGN KEY (`Vendedor_idVendedor`)
    REFERENCES `Loja_Bandas_metal`.`Vendedor` (`idVendedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Venda_CD_Estoque1`
    FOREIGN KEY (`Estoque_idEstoque`)
    REFERENCES `Loja_Bandas_metal`.`Estoque` (`idEstoque`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Fan_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Fan_cliente` (
  `idFan_cliente` INT NOT NULL,
  `Nome_do_fan` VARCHAR(45) NULL,
  `estilo_preferencial` TINYINT(1) NULL,
  `Cpf` VARCHAR(45) NULL,
  `Rg` VARCHAR(45) NULL,
  PRIMARY KEY (`idFan_cliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Loja_Bandas_metal`.`Status_de_Compras`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Loja_Bandas_metal`.`Status_de_Compras` (
  `Vendedor_idVendedor` INT NOT NULL,
  `Fan_cliente_idFan_cliente` INT NOT NULL,
  PRIMARY KEY (`Vendedor_idVendedor`, `Fan_cliente_idFan_cliente`),
  CONSTRAINT `fk_Vendedor_has_Fan_cliente_Vendedor1`
    FOREIGN KEY (`Vendedor_idVendedor`)
    REFERENCES `Loja_Bandas_metal`.`Vendedor` (`idVendedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Vendedor_has_Fan_cliente_Fan_cliente1`
    FOREIGN KEY (`Fan_cliente_idFan_cliente`)
    REFERENCES `Loja_Bandas_metal`.`Fan_cliente` (`idFan_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `principal_metal` ;

-- -----------------------------------------------------
-- Table `principal_metal`.`influencias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `principal_metal`.`influencias` (
  `idInfluencias` INT(11) NOT NULL,
  `idBandas` INT(11) NOT NULL,
  `Fan_cliente_idFan_cliente` INT NOT NULL,
  PRIMARY KEY (`idBandas`, `idInfluencias`),
  CONSTRAINT `influencias_ibfk_1`
    FOREIGN KEY (`idInfluencias`)
    REFERENCES `principal_metal`.`bandas` (`idBandas`),
  CONSTRAINT `influencias_ibfk_2`
    FOREIGN KEY (`idBandas`)
    REFERENCES `principal_metal`.`bandas` (`idBandas`),
  CONSTRAINT `fk_influencias_Fan_cliente1`
    FOREIGN KEY (`Fan_cliente_idFan_cliente`)
    REFERENCES `Loja_Bandas_metal`.`Fan_cliente` (`idFan_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `principal_metal`.`premiacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `principal_metal`.`premiacao` (
  `idPremiacao` INT(11) NOT NULL,
  `Evento` VARCHAR(120) NOT NULL,
  `quantidade` VARCHAR(80) NOT NULL,
  `idBandas` INT(11) NOT NULL,
  PRIMARY KEY (`idPremiacao`),
  CONSTRAINT `premiacao_ibfk_1`
    FOREIGN KEY (`idBandas`)
    REFERENCES `principal_metal`.`bandas` (`idBandas`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
