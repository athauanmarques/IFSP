-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema artiumSystem
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `artiumSystem` ;

-- -----------------------------------------------------
-- Schema artiumSystem
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `artiumSystem` DEFAULT CHARACTER SET utf8 ;
USE `artiumSystem` ;

-- -----------------------------------------------------
-- Table `artiumSystem`.`login`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artiumSystem`.`login` ;

CREATE TABLE IF NOT EXISTS `artiumSystem`.`login` (
  `idLogin` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `codCartao` VARCHAR(20) NOT NULL,
  `senha` LONGTEXT NOT NULL,
  `tipoAcesso` ENUM('visitante', 'funcionario') NOT NULL,
  PRIMARY KEY (`idLogin`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `artiumSystem`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artiumSystem`.`usuario` ;

CREATE TABLE IF NOT EXISTS `artiumSystem`.`usuario` (
  `idUsuario` INT NOT NULL AUTO_INCREMENT,
  `telefone` VARCHAR(12) NOT NULL,
  `dataNascimento` DATE NOT NULL,
  `sexo` VARCHAR(1) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `receberConvite` TINYINT NULL DEFAULT '0',
  `cargo` VARCHAR(80) NULL DEFAULT 'colaborador',
  `numeroRA` VARCHAR(20) NULL,
  `idLogin_tbLogin` INT NOT NULL,
  PRIMARY KEY (`idUsuario`, `idLogin_tbLogin`),
  INDEX `fk_usuario_Login_idx` (`idLogin_tbLogin` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `artiumSystem`.`acervo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artiumSystem`.`acervo` ;

CREATE TABLE IF NOT EXISTS `artiumSystem`.`acervo` (
  `idAcervo` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(45) NOT NULL,
  `descricao` LONGTEXT NULL,
  `periodo` ENUM('temporario', 'permanente') NOT NULL,
  `dataInicio` DATE NULL,
  `dataFinal` DATE NULL,
  `cidade` VARCHAR(25) NOT NULL,
  `endereco` VARCHAR(110) NOT NULL,
  `estado` VARCHAR(2) NOT NULL DEFAULT 'SP',
  `cep` VARCHAR(9) NULL,
  `responsavel` VARCHAR(25) NOT NULL,
  `telResponvel` VARCHAR(12) NOT NULL,
  `limiteReserva` INT NOT NULL,
  `maxVisitante` INT NOT NULL,
  `enviarConvites` TINYINT NULL,
  PRIMARY KEY (`idAcervo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `artiumSystem`.`reservas_convites`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artiumSystem`.`reservas_convites` ;

CREATE TABLE IF NOT EXISTS `artiumSystem`.`reservas_convites` (
  `idAcervo_tbAcervo` INT NOT NULL,
  `idUsuario_tbUsuario` INT NOT NULL,
  `reservar` INT NULL DEFAULT 0,
  `convidado` BINARY NULL DEFAULT 0,
  PRIMARY KEY (`idAcervo_tbAcervo`, `idUsuario_tbUsuario`),
  INDEX `fk_Acervo_has_usuario_usuario1_idx` (`idUsuario_tbUsuario` ASC),
  INDEX `fk_Acervo_has_usuario_Acervo1_idx` (`idAcervo_tbAcervo` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `artiumSystem`.`restauracao`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artiumSystem`.`restauracao` ;

CREATE TABLE IF NOT EXISTS `artiumSystem`.`restauracao` (
  `idRestauracao` INT NOT NULL AUTO_INCREMENT,
  `statusRestaurar` ENUM('analise', 'andamento', 'concluido', 'cancelado') NOT NULL DEFAULT 'analise',
  `prazoInicio` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `prazoFinal` DATETIME NOT NULL,
  `vezesRestaurado` INT NULL DEFAULT '0',
  `idAcervo_tbAcervo` INT NOT NULL,
  `idUsuario_tbUsuario` INT NOT NULL,
  PRIMARY KEY (`idRestauracao`, `idAcervo_tbAcervo`, `idUsuario_tbUsuario`),
  INDEX `fk_restauracao_Acervo1_idx` (`idAcervo_tbAcervo` ASC),
  INDEX `fk_restauracao_usuario1_idx` (`idUsuario_tbUsuario` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `artiumSystem`.`estoque`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artiumSystem`.`estoque` ;

CREATE TABLE IF NOT EXISTS `artiumSystem`.`estoque` (
  `idEstoque` INT NOT NULL AUTO_INCREMENT,
  `codProduto` VARCHAR(20) NOT NULL,
  `produto` VARCHAR(45) NOT NULL,
  `marca` VARCHAR(15) NOT NULL,
  `descricaoProduto` LONGTEXT NULL,
  `preco` REAL NOT NULL,
  `qtsEstoque` INT NOT NULL,
  PRIMARY KEY (`idEstoque`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `artiumSystem`.`vendas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `artiumSystem`.`vendas` ;

CREATE TABLE IF NOT EXISTS `artiumSystem`.`vendas` (
  `idEstoque_tbEstoque` INT NOT NULL,
  `idUsuario_tbUsuario` INT NOT NULL,
  `quantidadeVendas` INT NOT NULL,
  `dataVenda` DATETIME NOT NULL,
  PRIMARY KEY (`idEstoque_tbEstoque`, `idUsuario_tbUsuario`),
  INDEX `fk_estoque_has_usuario_usuario1_idx` (`idUsuario_tbUsuario` ASC),
  INDEX `fk_estoque_has_usuario_estoque1_idx` (`idEstoque_tbEstoque` ASC))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
