-- Autores: Fernando Piniani e Vitor


SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';
SET GLOBAL event_scheduler = ON;


DROP DATABASE IF EXISTS `Ragnarok`;
-- -----------------------------------------------------
-- Schema Ragnarok
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Ragnarok` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `Ragnarok` ;

-- -----------------------------------------------------
-- Table `Ragnarok`.`Conta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ragnarok`.`Conta` (
    `idConta` INT NOT NULL AUTO_INCREMENT,
    `login` CHAR(30) NOT NULL,
    `senha` CHAR(255) NOT NULL,
    `email` CHAR(50) NOT NULL,
    `dataCriacao` DATE NOT NULL,
    `dataNascimento` DATE NOT NULL,
    `cash` INT UNSIGNED NOT NULL DEFAULT 1,
    PRIMARY KEY (`idConta`)
)  ENGINE=InnoDB;


-- -----------------------------------------------------
-- Table `Ragnarok`.`Guilda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ragnarok`.`Guilda` (
    `idGuilda` INT NOT NULL AUTO_INCREMENT,
    `nome` CHAR(30) NOT NULL,
    `level` INT NOT NULL DEFAULT 1,
    `numeroMembros` INT NOT NULL DEFAULT 1,
    PRIMARY KEY (`idGuilda`)
)  ENGINE=InnoDB;


-- -----------------------------------------------------
-- Table `Ragnarok`.`Personagem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ragnarok`.`Personagem` (
    `idPersonagem` INT NOT NULL AUTO_INCREMENT,
    `nome` CHAR(30) NOT NULL,
    `classe` ENUM('Aprendiz', 'Arqueiro', 'Gatuno', 'Mago', 'Espadachim', 'Mercador', 'Novico') NOT NULL,
    `levelBase` INT NOT NULL DEFAULT 1,
    `levelClasse` INT NOT NULL DEFAULT 1,
    `zeny` INT UNSIGNED NOT NULL DEFAULT 100,
    `idGuilda` INT NULL,
    `idPersonagem2` INT NULL,
    `idConta` INT NOT NULL,
    `Lider` INT NULL,
    PRIMARY KEY (`idPersonagem`),
    UNIQUE INDEX `nome_UNIQUE` (`nome` ASC),
    INDEX `fk_Personagem_Guilda1_idx` (`idGuilda` ASC),
    INDEX `fk_Personagem_Personagem1_idx` (`idPersonagem2` ASC),
    INDEX `fk_Personagem_Conta1_idx` (`idConta` ASC),
    INDEX `fk_Personagem_Guilda2_idx` (`Lider` ASC),
    CONSTRAINT `fk_Personagem_Guilda1` FOREIGN KEY (`idGuilda`)
        REFERENCES `Ragnarok`.`Guilda` (`idGuilda`)
        ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT `fk_Personagem_Personagem1` FOREIGN KEY (`idPersonagem2`)
        REFERENCES `Ragnarok`.`Personagem` (`idPersonagem`)
        ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT `fk_Personagem_Conta1` FOREIGN KEY (`idConta`)
        REFERENCES `Ragnarok`.`Conta` (`idConta`)
        ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT `fk_Personagem_Guilda2` FOREIGN KEY (`Lider`)
        REFERENCES `Ragnarok`.`Guilda` (`idGuilda`)
        ON DELETE NO ACTION ON UPDATE NO ACTION
)  ENGINE=InnoDB;


-- -----------------------------------------------------
-- Table `Ragnarok`.`Stats`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ragnarok`.`Stats` (
    `idStats` INT NOT NULL AUTO_INCREMENT,
    `agilidade` INT NOT NULL DEFAULT 1,
    `forca` INT NOT NULL DEFAULT 1,
    `inteligencia` INT NOT NULL DEFAULT 1,
    `destreza` INT NOT NULL DEFAULT 1,
    `sorte` INT NOT NULL DEFAULT 1,
    `vitalidade` INT NOT NULL DEFAULT 1,
    `idPersonagem` INT NOT NULL,
    PRIMARY KEY (`idStats`),
    INDEX `fk_Status_Personagem1_idx` (`idPersonagem` ASC),
    CONSTRAINT `fk_Status_Personagem1` FOREIGN KEY (`idPersonagem`)
        REFERENCES `Ragnarok`.`Personagem` (`idPersonagem`)
        ON DELETE NO ACTION ON UPDATE NO ACTION
)  ENGINE=InnoDB;


-- -----------------------------------------------------
-- Table `Ragnarok`.`Habilidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ragnarok`.`Habilidade` (
    `idHabilidade` INT NOT NULL AUTO_INCREMENT,
    `nome` CHAR(60) NOT NULL,
    `tipo` ENUM('Passiva', 'Ativa') NOT NULL,
    `distancia` ENUM('Longa', 'Curta', 'Auto') NOT NULL,
    `spBase` INT NOT NULL DEFAULT 1,
    `classe` ENUM('Aprendiz', 'Arqueiro', 'Gatuno', 'Mago', 'Espadachim', 'Mercador', 'Novico') NOT NULL,
    PRIMARY KEY (`idHabilidade`)
)  ENGINE=InnoDB;


-- -----------------------------------------------------
-- Table `Ragnarok`.`Personagem_has_Habilidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ragnarok`.`Personagem_has_Habilidade` (
    `idPersonagem` INT NOT NULL,
    `idHabilidade` INT NOT NULL,
    `nivel` INT NOT NULL DEFAULT 1,
    PRIMARY KEY (`idPersonagem` , `idHabilidade`),
    INDEX `fk_Personagem_has_Habilidade_Habilidade1_idx` (`idHabilidade` ASC),
    INDEX `fk_Personagem_has_Habilidade_Personagem1_idx` (`idPersonagem` ASC),
    CONSTRAINT `fk_Personagem_has_Habilidade_Personagem1` FOREIGN KEY (`idPersonagem`)
        REFERENCES `Ragnarok`.`Personagem` (`idPersonagem`)
        ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT `fk_Personagem_has_Habilidade_Habilidade1` FOREIGN KEY (`idHabilidade`)
        REFERENCES `Ragnarok`.`Habilidade` (`idHabilidade`)
        ON DELETE NO ACTION ON UPDATE NO ACTION
)  ENGINE=InnoDB;


-- -----------------------------------------------------
-- Table `Ragnarok`.`Banimento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ragnarok`.`Banimento` (
    `idBanimento` INT NOT NULL AUTO_INCREMENT,
    `motivo` CHAR(200) NOT NULL,
    `duracao` DATE NOT NULL,
    `idPersonagem` INT NOT NULL,
    PRIMARY KEY (`idBanimento`),
    UNIQUE INDEX `fk_Banimento_Personagem1_idx` (`idPersonagem` ASC),
    CONSTRAINT `fk_Banimento_Personagem1` FOREIGN KEY (`idPersonagem`)
        REFERENCES `Ragnarok`.`Personagem` (`idPersonagem`)
        ON DELETE NO ACTION ON UPDATE NO ACTION
)  ENGINE=InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


-- INSERTS DA TABELA CONTA
USE ragnarok;
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('batata123', md5(23513865), 'sacco1@terra.com.br', '2011-10-06', '1985-12-05');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('sinhodastreva200', md5(26426271), 'adeilson@ufba.br', '2010-02-23', '1987-09-09');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('partido2', md5(37274077), '2000adri@uol.com.br', '2010-11-27', '1997-01-26');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('trabalhador49', md5(638215), 'acdsantos@uol.com.br', '2012-08-16', '1999-10-15');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('mextrekami3', md5(64002352), 'airton_tulio@onda.com.br', '2012-12-05', '1984-07-19');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('gohan23', md5(74850158), 'ale_andre@hotmail.com', '2012-09-09', '1994-11-08');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('brothafrom', md5(38214296), 'alrilan@supridad.com.br', '2009-06-26', '1996-08-25');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('anothamotha12', md5(1578434), 'alvaroj@ieg.com.br', '2009-10-15', '1998-05-01');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('tiodaspipoca17', md5(12426240), 'askklove@hotmail.com', '2009-07-19', '1991-09-18');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('obemsucedido', md5(75790377), 'lu_lu@nutecnet.com.br', '2011-11-08', '1993-06-07');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('filhaodomacarrao', md5(39154515), 'andreadler@hotmail.com', '2011-08-25', '1995-03-11');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('nopainogain', md5(50002321), 'ags@linkexpress.com.br', '2011-05-01', '1988-07-28');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('trombadinha5', md5(13366459), 'barthodias@uol.com.br', '2013-09-18', '1990-04-04');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('vendedordealma25', md5(76730596), 'augusto.galvao@transportes.gov.br', '2013-06-07', '1992-01-21');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('vendedordelama19', md5(87578402), 'bene.villa@uol.com.br', '2013-03-11', '1985-05-10');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('parceiro4ever', md5(50942540), 'vibrasom@zaz.com.br', '2010-07-28', '1987-02-14');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('s3mpr3l1nd4', md5(14306678), 'careca@globo.com.br', '2010-04-17', '1989-11-03');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('ajudaaitio', md5(25154484), 'akinaga@bol.com.br', '2010-01-21', '1999-03-20');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('semmaldade', md5(88518621), 'carlitojorge@gmail.com', '2012-05-10', '1984-12-24');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('soinjurias', md5(99366427), 'clfmad@ig.com.br', '2012-02-27', '1986-09-13');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('borbulhador13', md5(62730565), 'cicero_boliche@zipmail.com.br', '2012-11-03', '1996-01-02');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('rainhadaperdicao', md5(26094703), 'estabil@terra.com.br', '2009-03-20', '1998-10-06');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('hotdog30', md5(36942509), 'kevin@gold.com.br', '2009-12-24', '2000-07-23');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('reipele21', md5(306647), 'darcy@atribuna.com.br', '2009-09-13', '1993-11-07');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('futebolemulher', md5(81705023), 'dudu.jara@zipmail.com.br', '2010-01-10', '1998-08-24');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('romario87', md5(92552829), 'ueharajp@yahoo.com.br', '2010-10-14', '1991-12-13');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('pelecalado', md5(55916967), 'sousamacedo@bol.com.br', '2012-02-03', '1993-09-17');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('eumpoeta32', md5(19281105), 'eliane_tulio@onda.com.br', '2012-11-20', '1995-06-06');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('umildads3mpre', md5(30128911), 'elimardantas@hotmail.com', '2012-08-24', '1988-10-23');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('naoligo', md5(93493048), 'strike@base.com.br', '2009-12-13', '1990-07-27');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('troteiro', md5(4340855), 'ericopfusco@terra.com.br', '2009-09-02', '1992-04-16');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('100limits', md5(67704992), 'eugenioCarvalho@terra.com.br', '2009-06-06', '1985-08-05');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('reidocassino', md5(31069130), 'fharruda@zaz.com.br', '2011-10-23', '1987-05-09');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('matadordedragao', md5(41916936), 'frr@svn.com.br', '2011-07-27', '1989-02-26');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('ourofino16', md5(5281074), 'f.b.rezende@terra.com.br', '2011-04-16', '1999-06-15');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('alegriadviver', md5(68645211), 'navalrj@ruralrj.com.br', '2013-08-05', '1984-03-19');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('assimnaoda', md5(79493017), 'fbc@bmrio.com.br', '2013-05-09', '1986-12-08');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('rockeiro1', md5(42857155), 'fegobol@hotmail.com', '2013-02-26', '1996-04-25');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('rockeiro45', md5(6221293), 'fepabol@fepabol.com.br', '2010-06-15', '1998-01-01');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('naometoca2', md5(17069099), 'lima_feliph@uol.com.br', '2010-03-19', '1991-10-18');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('lindomar23', md5(80433236), 'bueno_fernando@hotmail.com', '2010-12-08', '1993-02-07');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('subzero34', md5(43797374), 'castroneto.adv@hotmail.com', '2012-04-25', '1995-11-11');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('brasileiro9', md5(54645180), 'fe_2802@hotmail.com', '2012-01-01', '1988-03-28');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('capitaonascimento2', md5(18009318), 'flavio_ramalho@onda.om.br', '2012-10-18', '1990-12-17');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('kratos44', md5(81373455), 'rei@stc.com.br', '2009-02-07', '1992-09-21');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('bomdguerra', md5(92221261), 'fred.parmentier@hotmail.com', '2009-11-11', '1985-01-10');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('gudofwar', md5(55585399), 'geovaniruvieri@ig.com.br', '2009-08-28', '1990-10-22');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('abracador', md5(84467444), 'germano@interconect.com.br', '2010-12-12', '1992-07-11');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('killermachine99', md5(47831582), 'gmpetean@zipmail.com.br', '2010-09-01', '1985-11-28');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('narutouzumak', md5(11195720), 'jold@linkexpress.com.br', '2012-01-18', '1987-08-04');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('sasukedom4u', md5(22043526), 'djoogi@zaz.com.br', '2012-10-22', '1997-05-21');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('orochimaru32', md5(85407663), 'heliodefreitas@terra.com.br', '2012-07-11', '1999-09-10');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('natsu43', md5(48771801), 'igorpizzoli@yahoo.com.br', '2009-11-28', '1984-06-14');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('pseudojapones', md5(59619607), 'hudin@bol.com.br', '2009-08-04', '1994-03-03');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('babaca21', md5(22983745), 'mindo@globo.com', '2009-05-21', '1996-07-20');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('narutero23', md5(86347882), 'hermes@conection.com.br', '2011-09-10', '1998-04-24');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('pernilongo2', md5(97195688), 'ibraga@globo.com', '2011-06-14', '1991-08-13');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('mestredascamas', md5(60559826), 'ivosouzabr@aol.com', '2011-03-03', '1993-05-02');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('abatataaolado', md5(23923964), 'jack.sampaio@yahoo.com.br', '2013-07-20', '1995-02-06');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('loginrandom', md5(34771770), 'jacquecostabh@globo.com', '2013-04-24', '1988-06-23');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('naoseioqbotar', md5(98135907), 'thiago.y@giga.ocn.ne.jp', '2010-01-13', '1990-03-12');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('inovacaosempre', md5(61500045), 'janicecouto@ig.com.br', '2010-05-02', '1992-12-16');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('jeffinhow21', md5(72347851), 'wilmajoao@yahoo.com.br', '2010-02-06', '1985-04-05');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('markosmestre', md5(35711989), 'bigbarbosa@uol.com.br', '2012-11-23', '1987-01-22');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('vitaoescorpiao', md5(99076126), 'juliocesar.costa@eds.com', '2012-03-12', '1989-10-26');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('vendoherbalife2', md5(9923933), 'koloss@koloss.com.br', '2012-12-16', '1999-02-15');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('superbrhue', md5(73288070), 'laisaf@globo.com', '2009-04-05', '1984-11-04');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('estereotipo27', md5(36652208), 'lea@globo.com', '2009-01-22', '1986-08-08');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('tipicotroll46', md5(47500014), 'juliana@abordo.com.br', '2009-10-26', '1996-12-25');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('gmbabaca98', md5(10864152), 'kredig@terra.com.br', '2011-02-15', '1998-09-01');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('jatomeiban3x', md5(74228289), 'koloss@koloss.com.br', '2011-11-04', '2000-06-18');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('insano40', md5(85076095), 'Leogush@attglobal.net', '2011-08-08', '1993-10-07');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('anonymous34', md5(48440233), 'labraao@stivip.com.br', '2013-12-25', '1995-04-11');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('vdevingaca', md5(66270254), 'depaula@interprov.com', '2010-06-22', '1993-01-21');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('bdebeleza', md5(29634392), 'lucasguilherme@hotmail.com', '2010-03-11', '1986-05-10');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('cdecoracao', md5(92998529), 'lorete@prestes.com.br', '2012-07-28', '1988-02-14');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('palmeirenseroxo2', md5(3846336), 'lukaneves@globo.com', '2012-04-04', '1998-11-03');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('curitiaehnois', md5(67210473), 'lbarata@bbvbrasil.com.br', '2012-01-21', '2000-03-20');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('soupetista11', md5(30574611), 'lhbiondi@gmail.com', '2009-05-10', '1985-12-24');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('dilmasaidopoder', md5(41422417), 'lu@ambr.com.br', '2009-02-14', '1995-04-13');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('holaamigo123', md5(4786555), 'magicbow@terra.com.br', '2009-11-03', '1997-01-02');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('getout98', md5(68150692), 'm.kury@uol.com.br', '2011-03-20', '1999-10-06');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('bandidao56', md5(78998498), 'vieira@globo.com', '2011-12-24', '1992-02-23');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('surfista39', md5(42362636), 'masouza@terra.com.br', '2011-09-13', '1994-11-12');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('advogadobelo98', md5(5726774), 'mtakada@canalvip.com.br', '2013-01-02', '1996-08-16');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('datena', md5(16574580), 'mrapha13@yahoo.com.br', '2013-10-06', '1989-12-05');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('silviosants2', md5(79938717), 'mamaluka@globo.com', '2010-07-23', '1991-09-22');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('guridapesada', md5(43302855), 'mario_boliche@hotmail.com', '2010-11-12', '1993-06-26');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('mamadeirabionica', md5(54150661), 'nilsonwada@hotmail.com', '2010-08-16', '1986-10-15');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('boiafria9', md5(17514799), 'paulof@ucb.br', '2012-12-05', '1988-07-04');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('mendigo67', md5(80878936), 'paulostrike@bol.com.br', '2012-09-22', '1990-04-08');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('proplayer2', md5(91726742), 'jerferson@escelsa.com.br', '2012-06-26', '2000-08-25');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('hamilton12', md5(55090880), 'rafanh1977@terra.com.br', '2009-10-15', '1985-05-14');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('kdminecraft', md5(18455018), 'rei@stc.com.br', '2009-07-04', '1987-12-13');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('bugouaquiadmin9', md5(58389087), 'renatoboliche@hotmail.com', '2012-02-03', '1990-09-17');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('attwhore20', md5(21753225), 'renatobrfla@bol.com.br', '2012-11-20', '1992-06-06');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('onlyone71', md5(32601031), 'strikeboy@uol.com.br', '2012-08-24', '1985-10-23');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('espantalho', md5(95965168), 'rodrigoboliche@globo.com', '2009-12-13', '1987-07-27');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('xbatmanx', md5(6812975), 'rogerio_max@hotmail.com', '2009-09-02', '1989-04-16');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('whatislove', md5(70177112), 'rubenselias@bol.com.br', '2009-06-06', '1999-08-05');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('kickass2013', md5(33541250), 'roselicostadossantos@hotmail.com', '2011-10-23', '1984-05-09');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('oilusionista1', md5(44389056), 'rcfmaia@uol.com.br', '2011-07-27', '1986-02-26');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('jackdotitanic', md5(7753194), 'sady.souza@yahoo.com.br', '2011-04-16', '1996-06-15');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('tiomcdonalds', md5(71117331), 'guter@solar.com.br', '2013-08-05', '1998-03-19');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('pokergod47', md5(81965137), 'maline@abc.mre.gov.br', '2013-05-09', '2000-12-08');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('queroemagrecer5', md5(45329275), 'smcanela@uol.com.br', '2013-02-26', '1993-04-25');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('brigadeiro', md5(8693413), 'strikems@zaz.com.br', '2010-06-15', '1995-01-01');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('halflife3', md5(19541219), 'tarik@globo.com', '2010-03-19', '1988-10-18');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('gabenewell', md5(82905356), 'tpinheiro@fischeramerica.com.br', '2010-12-08', '1990-02-07');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('kdasgata5', md5(46269494), 'titilavolei@hotmail.com', '2012-04-25', '1992-11-11');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('xuxa8000', md5(57117300), 'veracals@terra.com.br', '2012-01-01', '1985-03-28');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('gatinhassanhada', md5(20481438), 'vericapone@yahoo.com', '2012-10-18', '1987-12-17');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('paidefamilia', md5(83845575), 'wagner@accus.com.br', '2009-02-07', '1989-09-21');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('killerbe32', md5(94693381), 'wconrad@terra.com.br', '2009-11-11', '1999-01-10');
INSERT INTO Conta (login, senha, email, dataCriacao, dataNascimento) VALUES ('risos86', md5(58057519), 'joaowilma@superig.com.br', '2009-08-28', '1984-10-27');

-- INSERTS DA TABELA GUILDA

INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Alliance of Fire', 25, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Army of Skulls', 13, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Breaking Away', 2, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Damned Nightmare', 5, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Diretoria Sinistra', 25, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Forgotten Realms', 22, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Oxente Mainha', 25, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Red Order', 23, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Super Amiguitos', 18, 0);
INSERT INTO guilda(nome, level, numeroMembros) VALUES ('Witches of Ice', 24, 0);

-- INSERTS DA TABELA HABILIDADE

INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Fingir de Morto', 'Ativa', 'Aprendiz', 'Auto', 20);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Habilidades Basicas', 'Passiva', 'Aprendiz', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Primeiros Socorros', 'Ativa', 'Aprendiz', 'Auto', 10);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Furto', 'Ativa', 'Gatuno', 'Curta', 20);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Envenenar', 'Ativa', 'Gatuno', 'Curta', 30);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Pericia em Esquiva', 'Passiva', 'Gatuno', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Ataque Duplo', 'Passiva', 'Gatuno', 'Curta', 30);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Arremessar Pedra', 'Passiva', 'Gatuno', 'Longa', 10);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Chutar Areia', 'Ativa', 'Gatuno ', 'Curta', 20);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Chuva de Flechas', 'Ativa', 'Arqueiro', 'Longa', 20);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Concentracao', 'Ativa', 'Arqueiro', 'Auto', 30);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Olhos de Aguia', 'Passiva', 'Arqueiro', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Precisao', 'Passiva', 'Arqueiro', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Rajada de Flechas', 'Ativa', 'Arqueiro', 'Longa', 40);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Disparo Violento', 'Ativa', 'Arqueiro', 'Longa', 30);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Pericia com Espadas', 'Passiva', 'Espadachim', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Impacto Explosivo', 'Ativa', 'Espadachim', 'Curta', 15);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Golpe Fulminante', 'Ativa', 'Espadachim', 'Curta', 20);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Vigor', 'Ativa', 'Espadachim', 'Auto', 25);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Provocar', 'Ativa', 'Espadachim', 'Longa', 15);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Aumentar Recuperacao de HP', 'Passiva', 'Espadachim', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Aumentar Recuperacao de SP', 'Passiva', 'Mago', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Lancas de Fogo', 'Ativa', 'Mago', 'Longa', 55);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Lancas de Gelo', 'Ativa', 'Mago', 'Longa', 55);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Barreira de Fogo', 'Ativa', 'Mago', 'Curta', 30);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Rajada Congelante', 'Ativa', 'Mago', 'Longa', 35);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Tempestade de Raios', 'Ativa', 'Mago', 'Longa', 60);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Comercio', 'Ativa', 'Mercador', 'Auto', 10);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Usar Carrinho', 'Passiva', 'Mercador', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Desconto', 'Passiva', 'Mercador', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Mammonita', 'Ativa', 'Mercador', 'Curta', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Aumentar Capacidade de Carga', 'Passiva', 'Mercador', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Identificar Item', 'Ativa', 'Mercador', 'Auto', 10);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Protecao Divina', 'Passiva', 'Novico', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Curar', 'Ativa', 'Novico', 'Longa', 30);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Bencao', 'Ativa', 'Novico', 'Longa', 40);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Medicar', 'Ativa', 'Novico', 'Longa', 20);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Flagelo do Mal', 'Passiva', 'Novico', 'Auto', 0);
INSERT INTO Habilidade (nome, tipo, classe, distancia, spBase) VALUES ('Aumentar Agilidade', 'Ativa', 'Novico', 'Longa', 35);

-- INSERTS DA TABELA PERSONAGEM

INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Abdaisim Trader', 'Gatuno', 32, 43, 38880, 8, 51, NULL, 8);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Abrest', 'Espadachim', 90, 30, 283680, NULL, 108, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Admah Ojhei', 'Gatuno', 46, 30, 62192, NULL, 18, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Adrio Adan', 'Gatuno', 5, 17, 16445, 2, 75, NULL, 2);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Ahikawaa', 'Mercador', 42, 7, 70518, 7, 50, NULL, 7);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Aikuh', 'Mago', 1, 47, 3616, 9, 107, NULL, 9);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Aldeilson junior', 'Arqueiro', 37, 30, 290524, 2, 83, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Aldo Onos', 'Arqueiro', 95, 17, 929955, 4, 25, NULL, 4);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Alemao du Morro', 'Espadachim', 91, 35, 546637, 1, 83, NULL, 1);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Alemoones', 'Espadachim', 50, 22, 397200, 3, 25, NULL, 3);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Amf Fire', 'Novico', 26, 31, 3978, 2, 9, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Anemon', 'Novico', 84, 21, 175560, 4, 66, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Angelo Re Paldino', 'Mercador', 26, 32, 121004, 2, 60, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Angelzsita', 'Mercador', 84, 19, 553644, 4, 2, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Anin Anon', 'Novico', 80, 37, 224720, 1, 60, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Anjo Celestial', 'Novico', 39, 24, 185094, 3, 2, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Apollyons', 'Arqueiro', 15, 33, 104325, 2, 101, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Ariela Warlord', 'Arqueiro', 73, 23, 649116, 4, 43, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Arigaro Peak', 'Espadachim', 69, 38, 352590, 1, 101, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Arthos Nill', 'Mago', 31, 19, 40021, 7, 92, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Arthuriito', 'Espadachim', 89, 9, 287292, 9, 34, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Artistck', 'Gatuno', 26, 42, 194064, 2, 10, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Artus Fugit', 'Gatuno', 84, 29, 789684, 4, 67, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Astrollax', 'Mago', 60, 38, 96600, 3, 51, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Aztharoth Assassin', 'Mago', 19, 28, 67393, 5, 108, NULL, 5);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Bahiiano Broker', 'Mercador', 15, 43, 146475, 2, 51, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Bampall', 'Mercador', 73, 33, 124246, 4, 108, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Barvest Fugit', 'Novico', 12, 15, 1644, 10, 108, NULL, 10);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Belog', 'Novico', 70, 2, 145180, 2, 50, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Benudito', 'Mago', 26, 2, 7124, 2, 75, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Bernard Dragontooth', 'Mago', 84, 39, 185724, 4, 17, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Blood Ov Nazarene', 'Aprendiz', 60, 48, 265200, 3, 1, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Boladao Sniiper', 'Aprendiz', 19, 38, 120783, 5, 58, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Braghy', 'Gatuno', 15, 3, 38625, 10, 78, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Brandon Lee', 'Aprendiz', 93, 7, 77097, 3, 70, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Brister', 'Novico', 52, 47, 143832, 5, 12, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Bruwn', 'Mago', 88, 30, 616176, 9, 103, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Bubbly Terrivel', 'Mago', 47, 17, 420133, NULL, 45, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Caballero Blakc Sirius', 'Mercador', 43, 35, 221751, 8, 103, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Carlos Falow', 'Mercador', 2, 22, 14188, 10, 45, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Carlos Rusherr', 'Mercador', 79, 30, 276658, NULL, 53, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Carolina La Princesa', 'Mercador', 38, 20, 206682, 2, 110, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Castainha', 'Novico', 34, 35, 56338, 10, 53, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Celeroni', 'Novico', 92, 25, 330648, 1, 110, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Charas Lavron', 'Aprendiz', 88, 40, 863456, 9, 53, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Chimia no Pao', 'Aprendiz', 47, 27, 82203, NULL, 110, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Choqo', 'Gatuno', 43, 16, 339055, 5, 76, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Chrome Warrior', 'Mercador', 45, 44, 97470, 10, 77, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Chrono Soujiro', 'Mercador', 4, 31, 16412, 1, 19, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Chuyx', 'Gatuno', 79, 40, 498648, NULL, 3, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Cjar On Bahea', 'Gatuno', 38, 30, 313462, 2, 60, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Clana Neton', 'Arqueiro', 34, 45, 151878, 10, 3, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Coruja Of Judah', 'Arqueiro', 92, 32, 589168, 1, 60, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Crixus Ousado', 'Espadachim', 88, 50, 230736, 9, 3, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Curan Dera', 'Espadachim', 47, 37, 214273, NULL, 60, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Cyrrax The Knight', 'Gatuno', 89, 50, 798241, 9, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dakrios Halielona', 'Aprendiz', 6, 24, 55176, 4, 17, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2, lider) VALUES ('Dala Khane', 'Aprendiz', 64, 11, 72512, 6, 74, NULL, 6);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Damballa Fenriz', 'Espadachim', 40, 20, 133680, 5, 58, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dangerous herb', 'Espadachim', 98, 10, 517342, 7, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Darce Wesleyan', 'Mago', 94, 25, 140718, 4, 58, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dark Raven Sniper', 'Mago', 53, 37, 79818, 3, 77, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Darkness atlas', 'Novico', 14, 47, 108766, 1, 45, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dead Sword', 'Novico', 72, 37, 698832, 3, 102, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Demix Asan', 'Aprendiz', 68, 2, 402832, NULL, 45, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dentiinhu', 'Aprendiz', 27, 39, 212247, 2, 102, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Desai', 'Gatuno', 23, 7, 93817, 10, 45, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Destruvtor', 'Gatuno', 81, 44, 487296, 1, 102, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Devardek', 'Mago', 57, 3, 468825, NULL, 86, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Devastador of ra', 'Mago', 58, 7, 137982, 1, 85, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Donovan Thor', 'Novico', 73, 39, 186953, 5, 77, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Doug Mata Kenok', 'Mercador', 32, 29, 143936, 7, 19, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dracui', 'Espadachim', 68, 12, 593912, NULL, 110, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Drextel', 'Espadachim', 27, 49, 18117, 2, 52, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Drooeda', 'Mago', 23, 17, 158447, 10, 110, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Druid Demonit', 'Mago', 81, 4, 714906, 1, 52, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Druidazynha', 'Aprendiz', 99, 30, 321948, 9, 93, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dweenger', 'Aprendiz', 58, 17, 300962, 1, 35, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Dynahoe', 'Arqueiro', 73, 49, 392083, 5, 27, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Eduzim Knight', 'Gatuno', 32, 39, 233856, 7, 84, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Einardt', 'Novico', 68, 22, 104992, NULL, 60, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Ekaton', 'Novico', 27, 9, 93987, 2, 2, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Elder Ravoc', 'Arqueiro', 3, 18, 17070, 1, 101, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Eldor Kevi', 'Arqueiro', 61, 8, 465247, 3, 43, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Elite of Night', 'Espadachim', 39, 17, 227604, 3, 87, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Elvephrius', 'Mercador', 76, 45, 8892, 8, 88, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Emoo Darkness Soul', 'Mercador', 35, 35, 71890, 10, 30, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Epiion', 'Novico', 31, 50, 256432, 7, 88, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Escroto', 'Novico', 89, 37, 18601, 9, 30, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Esngoloide', 'Aprendiz', 85, 5, 546295, 6, 88, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Esquard', 'Aprendiz', 44, 42, 368016, 8, 30, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Eucarys', 'Espadachim', 20, 1, 11460, 7, 14, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Extremis', 'Espadachim', 78, 41, 195780, 9, 71, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Fernin Coree', 'Gatuno', 76, 5, 222452, 8, 38, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Fisters', 'Gatuno', 35, 45, 170240, 10, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Foxi Man', 'Arqueiro', 31, 10, 33542, 7, 38, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Frozen Blayck', 'Arqueiro', 89, 47, 268691, 9, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Galax hunter', 'Espadachim', 85, 15, 785145, 6, 38, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Geeffin', 'Espadachim', 44, 2, 51656, 8, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Ghostxx', 'Novico', 20, 11, 67660, 7, 79, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Golankas Tath', 'Novico', 78, 1, 414960, 9, 21, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Goodang Steels', 'Mago', 76, 15, 436012, 8, 103, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Great Fugit', 'Mago', 35, 2, 268590, 10, 45, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Guilherme Paralyzer', 'Mercador', 31, 20, 120652, 7, 103, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Guttokzz', 'Mercador', 89, 7, 518781, 9, 45, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Haggor Goldenaxe', 'Gatuno', 65, 16, 522470, 8, 29, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Hampa', 'Gatuno', 24, 6, 239400, 10, 86, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Harcalion Vidy', 'Espadachim', 9, 21, 22437, 7, 109, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Harry Macpott', 'Espadachim', 67, 8, 296810, 10, 51, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Haseo Rullex', 'Aprendiz', 62, 31, 37386, 5, 84, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Healer Killer', 'Novico', 21, 21, 53340, 7, 26, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Hell Sarith Ossy', 'Novico', 37, 45, 102379, 2, 43, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Hera Law', 'Novico', 95, 32, 446880, 4, 100, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Hidrak', 'Arqueiro', 94, 48, 654898, 3, 13, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Hitkina Slim', 'Arqueiro', 11, 22, 79134, 9, 30, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Horuss Iv', 'Arqueiro', 69, 9, 630039, NULL, 87, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Hunter Sheep', 'Espadachim', 65, 27, 347685, 8, 30, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Hypnus Warlord', 'Espadachim', 24, 14, 174864, 10, 87, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Ignak Kron', 'Novico', 99, 23, 940005, 9, 71, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Istubar Soul', 'Novico', 40, 3, 64880, 4, 78, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jaguarr', 'Mago', 56, 27, 103544, 10, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jarkky', 'Mago', 15, 14, 56790, 1, 37, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jeff Ewo Fluxo', 'Mercador', 11, 32, 44, 9, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jefis Pirexkis', 'Mercador', 69, 19, 133929, NULL, 37, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jeron zard', 'Novico', 65, 37, 530335, 8, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jetro Salazar', 'Novico', 24, 24, 2304, 10, 37, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jolthead', 'Arqueiro', 99, 33, 228195, 9, 21, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Juanki', 'Arqueiro', 58, 23, 246036, NULL, 78, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Juanyta', 'Mago', 19, 5, 162963, 6, 8, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jubileio dos Andaimes', 'Mago', 77, 45, 39578, 8, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jubilut dos Andaimes', 'Mercador', 73, 10, 491436, 5, 8, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jubrento', 'Mercador', 32, 50, 277408, 7, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Jumentao', 'Novico', 28, 15, 136836, 4, 8, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Kathzody', 'Novico', 86, 2, 586864, 6, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Keraco Homanith', 'Aprendiz', 82, 20, 249444, 3, 8, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Khena', 'Aprendiz', 41, 7, 378143, 9, 114, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Khepler', 'Aprendiz', 3, 41, 3480, NULL, 56, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Killer Of Darkness', 'Aprendiz', 19, 15, 26353, 6, 73, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Kirogenix', 'Aprendiz', 77, 5, 255948, 8, 15, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Klato Knight', 'Gatuno', 73, 20, 696566, 5, 73, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Kloasch', 'Gatuno', 32, 7, 47328, 7, 15, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Knight Age', 'Arqueiro', 28, 25, 215516, 4, 73, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Knight Bloody Axe', 'Arqueiro', 86, 12, 828524, 6, 15, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Knight da Ricaria', 'Espadachim', 25, 47, 201725, 1, 15, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Kubilai Khan', 'Espadachim', 83, 34, 498, 4, 72, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Kyller The Knight', 'Aprendiz', 78, 7, 481962, 10, 105, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Laaw Cat', 'Mago', 63, 26, 31374, 6, 49, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lady Ditxiry', 'Arqueiro', 19, 26, 165262, 6, 74, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lady Liz', 'Arqueiro', 77, 13, 48895, 8, 16, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lady Murder', 'Mercador', 53, 22, 150732, 7, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Legna Pao', 'Mercador', 12, 12, 57372, 9, 57, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lenhador Cabreiro', 'Novico', 8, 27, 7992, 6, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Leo em Neptera', 'Novico', 66, 31, 340098, 7, 114, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Leskita Palli', 'Mago', 64, 31, 214592, 7, 24, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Leyzerus', 'Mago', 23, 18, 121670, 9, 81, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lider Deswa', 'Mercador', 19, 36, 28652, 6, 24, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lightwolf Audio', 'Mercador', 77, 23, 265265, 8, 81, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Liink Mage', 'Gatuno', 53, 32, 299662, 7, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Liry', 'Gatuno', 12, 22, 91092, 9, 7, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Loko Maldiito', 'Arqueiro', 8, 37, 30472, 6, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lord Porkye', 'Arqueiro', 9, 41, 71667, 7, 64, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lost El Knight', 'Aprendiz', 64, 41, 394432, 7, 89, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lothur', 'Aprendiz', 23, 28, 186300, 9, 31, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Luci Fer Diamond', 'Espadachim', 98, 37, 30282, 8, 15, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lucius Pendragon', 'Espadachim', 57, 27, 128022, 10, 72, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Lucy shindoy', 'Mago', 53, 42, 448592, 7, 15, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Luna Lovvegood', 'Mago', 12, 29, 55740, 2, 6, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Magexztx', 'Mago', 73, 13, 480486, 4, 63, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Magic Cristy', 'Arqueiro', 10, 46, 8180, 8, 39, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Magin Hatuna Matata', 'Arqueiro', 68, 33, 187340, 10, 96, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Maguitronsk', 'Mercador', 44, 42, 218416, 9, 80, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Maiic Taisson', 'Mercador', 3, 32, 20703, NULL, 22, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Malina Willtorn', 'Novico', 98, 47, 305662, 8, 80, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Mana Asafis', 'Novico', 57, 37, 288192, 10, 22, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Maniatic Dementor', 'Aprendiz', 53, 2, 67522, 7, 80, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Manow Sharingan', 'Aprendiz', 12, 39, 38532, 9, 22, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Matador de Novisos', 'Novico', 32, 6, 304896, 8, 34, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Mathewz Coelho', 'Mercador', 90, 46, 131850, 10, 91, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Matusalenss', 'Espadachim', 27, 29, 153927, 3, 67, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Mauro Kiu', 'Espadachim', 85, 16, 649230, 5, 9, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Mauve Aardvark', 'Mago', 81, 34, 312336, 2, 67, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Milordy', 'Mago', 40, 21, 231720, 4, 9, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Miusa', 'Aprendiz', 16, 30, 128032, 3, 108, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Morphine Law', 'Aprendiz', 74, 20, 735486, 4, 107, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Mottita Shadowbolt', 'Arqueiro', 32, 16, 74816, 8, 99, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Mudao Da Rodoviaria', 'Gatuno', 90, 6, 384750, 10, 41, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Muriartti', 'Novico', 27, 39, 229797, 3, 17, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Myth Panzyr', 'Novico', 85, 26, 38080, 5, 74, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Naranus Thob', 'Arqueiro', 61, 35, 162077, 4, 58, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Naruto Encatando', 'Arqueiro', 20, 25, 91880, 6, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Neft Jire', 'Espadachim', 16, 40, 12992, 3, 58, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Nepton Kipiok', 'Espadachim', 74, 27, 203426, 5, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Neuklotic prock', 'Arqueiro', 75, 34, 517725, 6, 114, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Neve', 'Gatuno', 72, 44, 227952, 4, 82, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Neverlines', 'Gatuno', 31, 31, 158193, 6, 24, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Niikeen', 'Arqueiro', 27, 49, 35667, 3, 82, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Nilan Sath', 'Arqueiro', 85, 36, 276930, 5, 24, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Nobilis Fox', 'Mercador', 61, 45, 333487, 4, 8, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Noob Zika', 'Mercador', 20, 35, 148080, 6, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Nynas', 'Novico', 16, 50, 57952, 3, 8, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Nyro Okael', 'Novico', 74, 37, 411366, 5, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Nytrox Tunadow', 'Novico', 99, 27, 781704, 8, 42, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Odinndios', 'Aprendiz', 95, 42, 390830, 5, 100, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Olivia Caveira', 'Aprendiz', 54, 32, 326754, 7, 42, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Optimus Prime Boricua', 'Gatuno', 50, 47, 113450, 4, 100, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Orbro', 'Gatuno', 9, 37, 37854, 6, 42, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Oroshi Yashiro', 'Arqueiro', 5, 2, 2120, 3, 100, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Osbourner', 'Gatuno', 45, 32, 114795, 9, 107, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Oz Constatine', 'Aprendiz', 61, 6, 169458, 4, 9, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Ozsyz', 'Aprendiz', 20, 43, 94300, 6, 66, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Paladino Locao', 'Espadachim', 95, 2, 657780, 5, 50, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Pato Linu', 'Espadachim', 54, 42, 478494, 7, 107, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Penzhiito', 'Mago', 50, 7, 253950, 4, 50, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Percy Snape', 'Mago', 9, 44, 63144, 6, 107, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Pese Alva', 'Novico', 9, 6, 10125, 6, 99, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Pexuma', 'Novico', 66, 43, 621390, 9, 41, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Pey Wazowsk', 'Mercador', 25, 33, 33800, NULL, 98, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Pham Shilin', 'Mercador', 41, 7, 64739, 6, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Piigtom Thor', 'Mercador', 99, 47, 348084, 8, 57, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Podoslk', 'Novico', 95, 12, 924730, 5, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Popoto Massa Obeso', 'Novico', 54, 49, 90234, 7, 57, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Powder Kokain', 'Aprendiz', 50, 17, 394450, 4, 115, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Pricezinha of Mage', 'Aprendiz', 9, 2, 52839, 9, 27, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Quebraquee', 'Arqueiro', 69, 39, 287109, 1, 102, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Queen Daliiz', 'Arqueiro', 28, 26, 170744, 3, 44, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Queen Tahina', 'Espadachim', 24, 44, 55584, NULL, 102, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Raixkid', 'Espadachim', 82, 31, 348746, 2, 44, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Razael Archivaris', 'Mago', 78, 49, 36738, 10, 102, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Raziek El', 'Mago', 37, 36, 89096, 1, 44, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Reazem', 'Aprendiz', 13, 45, 60021, NULL, 28, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Robert Lancaster', 'Aprendiz', 71, 35, 465334, 2, 85, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Roosevelt Franklin', 'Mercador', 69, 49, 480999, 1, 52, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Rosir Calderon', 'Mercador', 28, 36, 249424, 3, 109, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Royal Gibri', 'Novico', 24, 4, 123024, NULL, 52, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Royal Maxwell', 'Novico', 82, 41, 579166, 2, 109, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Royal Pala Soul', 'Arqueiro', 58, 50, 537776, 1, 93, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Roychross', 'Arqueiro', 17, 40, 20553, 3, 35, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Saatan Pikaachuu', 'Espadachim', 13, 5, 96551, NULL, 93, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Saint Sorc', 'Espadachim', 71, 42, 664844, 2, 35, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Sama Jaja', 'Gatuno', 69, 9, 674889, 1, 2, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Santixz', 'Gatuno', 28, 46, 48104, 3, 59, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Satros Mar', 'Mago', 4, 5, 15708, 2, 43, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Saya Jean	', 'Mago', 62, 45, 363568, 4, 100, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Sector Flame', 'Mercador', 58, 10, 120756, 1, 43, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Senhorita Chocolate', 'Mercador', 17, 50, 68323, 3, 100, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Shamarax', 'Novico', 13, 15, 3081, NULL, 43, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Shargraoth', 'Novico', 71, 2, 154354, 2, 100, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Shockzwave', 'Novico', 74, 43, 500610, 5, 86, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Silverwolfe', 'Novico', 32, 30, 278464, 8, 28, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Sir Thiscopali', 'Espadachim', 27, 3, 131625, 3, 61, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Sir Zifohaw', 'Espadachim', 85, 43, 579020, 5, 3, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Skybolt Hauzidawn', 'Arqueiro', 2, 17, 14078, NULL, 20, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Slashy Star', 'Arqueiro', 60, 4, 538560, 2, 77, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Snifflin Hannibal', 'Mercador', 36, 13, 42660, 1, 61, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Sniper Calo', 'Mercador', 94, 3, 293468, 3, 3, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Southytt', 'Aprendiz', 94, 12, 679714, 3, 110, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Spear Jonathan', 'Aprendiz', 52, 49, 287092, 6, 52, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Starcaser', 'Novico', 11, 39, 82038, 8, 109, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Strongiloide', 'Mago', 47, 22, 79618, 1, 85, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Sudendett', 'Mago', 6, 9, 21786, 3, 27, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Suitiz', 'Mercador', 2, 27, 19698, NULL, 85, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Syfex Lewter', 'Mercador', 60, 14, 107160, 2, 27, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tala Menininho', 'Gatuno', 36, 23, 143820, 1, 11, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Teixeira', 'Gatuno', 94, 13, 557608, 3, 68, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Thah Gold', 'Novico', 92, 27, 584108, 2, 35, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Thigor Rura', 'Novico', 51, 14, 422586, 4, 92, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Thotoxz Audio', 'Aprendiz', 47, 32, 211688, 1, 35, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tio San', 'Aprendiz', 6, 19, 38646, 3, 92, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tony wgo', 'Espadachim', 81, 28, 700650, 2, 76, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tour Zang', 'Espadachim', 40, 18, 23480, 4, 18, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Toxic Bloodz', 'Mago', 36, 33, 244980, 1, 76, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Trigger Zeta', 'Mago', 94, 20, 821748, 3, 18, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tron Erviega', 'Arqueiro', 73, 27, 510708, 4, 87, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Trotter', 'Aprendiz', 10, 10, 12320, 8, 63, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tuka Ousado', 'Aprendiz', 68, 50, 215492, 10, 5, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tulasus', 'Gatuno', 64, 15, 600768, 7, 63, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Tuzne', 'Gatuno', 23, 2, 30452, 9, 5, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Ty Rullez', 'Arqueiro', 19, 20, 143298, 6, 63, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Ultimo Angel', 'Arqueiro', 20, 24, 33920, 7, 62, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Unholy Kaldheart', 'Novico', 15, 47, 118035, 2, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Vallilo on Neptera', 'Mercador', 73, 37, 715838, 4, 37, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Van Helsin', 'Espadachim', 10, 20, 40420, 8, 13, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Vaquero Romo', 'Espadachim', 68, 7, 406572, 10, 70, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Victor Lacqua', 'Mago', 64, 25, 140608, 7, 13, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Vladimir Gorbachev', 'Mago', 23, 12, 95082, 9, 70, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Wargray', 'Aprendiz', 98, 21, 621614, 8, 54, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('William Dragonslav', 'Mercador', 39, 1, 330330, 3, 61, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Winchester Impala', 'Mercador', 55, 25, 478335, 9, 78, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Wolfrikc', 'Mercador', 14, 12, 8876, NULL, 20, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Wonderweeiss', 'Novico', 10, 30, 68520, 8, 78, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Wymoon Sorc', 'Novico', 68, 17, 597652, 10, 20, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Xnina', 'Arqueiro', 44, 26, 43912, 9, 4, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Yepeto', 'Arqueiro', 3, 16, 8805, NULL, 61, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Victor', 'Arqueiro', 83, 7, 106157, 4, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Zaecru', 'Arqueiro', 42, 44, 135072, 6, 7, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Zahos', 'Espadachim', 38, 12, 358492, 3, 65, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Zaviel', 'Espadachim', 96, 49, 131616, 5, 7, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Aline', 'Novico', 72, 8, 257760, 4, 106, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Alex', 'Espadachim', 95, 50, 334305, 4, 95, NULL);
INSERT INTO Personagem (nome, classe, levelBase, levelClasse, zeny, idGuilda, idConta, idPersonagem2) VALUES ('Bianca', 'Mercador', 33, 28, 257400, 9, 96, NULL);




-- INSERTS DA TABELA STATS

INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (32, 6, 10, 10, 6, 10, 1);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (45, 18, 90, 18, 18, 45, 2);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (46, 9, 15, 15, 9, 15, 3);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 1, 1, 1, 1, 1, 4);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 14, 8, 42, 8, 21, 5);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (0, 1, 0, 0, 1, 0, 6);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (37, 37, 7, 7, 7, 12, 7);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (95, 95, 19, 19, 19, 31, 8);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (45, 18, 91, 18, 18, 45, 9);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (25, 10, 50, 10, 10, 25, 10);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 13, 5, 5, 26, 13, 11);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 42, 16, 16, 84, 42, 12);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 8, 5, 26, 5, 13, 13);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (21, 28, 16, 84, 16, 42, 14);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 40, 16, 16, 80, 40, 15);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (7, 19, 7, 7, 39, 19, 16);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 15, 3, 3, 3, 5, 17);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (73, 73, 14, 14, 14, 24, 18);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (34, 13, 69, 13, 13, 34, 19);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 31, 6, 6, 31, 10, 20);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (44, 17, 89, 17, 17, 44, 21);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (26, 5, 8, 8, 5, 8, 22);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (84, 16, 28, 28, 16, 28, 23);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 60, 12, 12, 60, 20, 24);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 19, 3, 3, 19, 6, 25);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 5, 3, 15, 3, 7, 26);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 24, 14, 73, 14, 36, 27);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 6, 2, 2, 12, 6, 28);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 35, 14, 14, 70, 35, 29);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 26, 5, 5, 26, 8, 30);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 84, 16, 16, 84, 28, 31);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 15, 15, 15, 15, 15, 32);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 4, 4, 4, 4, 4, 33);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 3, 5, 5, 3, 5, 34);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (23, 23, 23, 23, 23, 23, 35);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 26, 10, 10, 52, 26, 36);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 88, 17, 17, 88, 29, 37);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (9, 47, 9, 9, 47, 15, 38);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 14, 8, 43, 8, 21, 39);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (0, 0, 0, 2, 0, 1, 40);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 26, 15, 79, 15, 39, 41);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (9, 12, 7, 38, 7, 19, 42);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 17, 6, 6, 34, 17, 43);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 46, 18, 18, 92, 46, 44);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (22, 22, 22, 22, 22, 22, 45);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 11, 11, 11, 11, 11, 46);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (43, 8, 14, 14, 8, 14, 47);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 15, 9, 45, 9, 22, 48);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (1, 1, 0, 4, 0, 2, 49);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (79, 15, 26, 26, 15, 26, 50);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (38, 7, 12, 12, 7, 12, 51);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (34, 34, 6, 6, 6, 11, 52);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (92, 92, 18, 18, 18, 30, 53);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (44, 17, 88, 17, 17, 44, 54);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (23, 9, 47, 9, 9, 23, 55);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (89, 17, 29, 29, 17, 29, 56);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (1, 1, 1, 1, 1, 1, 57);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 16, 16, 16, 16, 16, 58);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (20, 8, 40, 8, 8, 20, 59);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (49, 19, 98, 19, 19, 49, 60);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 94, 18, 18, 94, 31, 61);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 53, 10, 10, 53, 17, 62);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 7, 2, 2, 14, 7, 63);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 36, 14, 14, 72, 36, 64);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 17, 17, 17, 17, 17, 65);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 6, 6, 6, 6, 6, 66);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (23, 4, 7, 7, 4, 7, 67);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (81, 16, 27, 27, 16, 27, 68);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 57, 11, 11, 57, 19, 69);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 58, 11, 11, 58, 19, 70);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 36, 14, 14, 73, 36, 71);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 10, 6, 32, 6, 16, 72);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (34, 13, 68, 13, 13, 34, 73);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 5, 27, 5, 5, 13, 74);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 23, 4, 4, 23, 7, 75);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 81, 16, 16, 81, 27, 76);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (24, 24, 24, 24, 24, 24, 77);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 14, 14, 14, 14, 14, 78);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (73, 73, 14, 14, 14, 24, 79);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (32, 6, 10, 10, 6, 10, 80);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 34, 13, 13, 68, 34, 81);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 13, 5, 5, 27, 13, 82);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 3, 0, 0, 0, 1, 83);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (61, 61, 12, 12, 12, 20, 84);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 7, 39, 7, 7, 19, 85);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 25, 15, 76, 15, 38, 86);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 11, 7, 35, 7, 17, 87);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 15, 6, 6, 31, 15, 88);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 44, 17, 17, 89, 44, 89);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (21, 21, 21, 21, 21, 21, 90);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 11, 11, 11, 11, 11, 91);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 4, 20, 4, 4, 10, 92);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (39, 15, 78, 15, 15, 39, 93);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (76, 15, 25, 25, 15, 25, 94);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (35, 7, 11, 11, 7, 11, 95);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (31, 31, 6, 6, 6, 10, 96);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (89, 89, 17, 17, 17, 29, 97);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (42, 17, 85, 17, 17, 42, 98);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (22, 8, 44, 8, 8, 22, 99);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 10, 4, 4, 20, 10, 100);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 39, 15, 15, 78, 39, 101);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 76, 15, 15, 76, 25, 102);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (7, 35, 7, 7, 35, 11, 103);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (7, 10, 6, 31, 6, 15, 104);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (22, 29, 17, 89, 17, 44, 105);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (65, 13, 21, 21, 13, 21, 106);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (24, 4, 8, 8, 4, 8, 107);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 1, 9, 1, 1, 4, 108);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (33, 13, 67, 13, 13, 33, 109);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 15, 15, 15, 15, 15, 110);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 10, 4, 4, 21, 10, 111);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (7, 18, 7, 7, 37, 18, 112);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 47, 19, 19, 95, 47, 113);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (94, 94, 18, 18, 18, 31, 114);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 11, 2, 2, 2, 3, 115);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (69, 69, 13, 13, 13, 23, 116);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (32, 13, 65, 13, 13, 32, 117);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 4, 24, 4, 4, 12, 118);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 49, 19, 19, 99, 49, 119);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 20, 8, 8, 40, 20, 120);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 56, 11, 11, 56, 18, 121);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 15, 3, 3, 15, 5, 122);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 3, 2, 11, 2, 5, 123);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 23, 13, 69, 13, 34, 124);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 32, 13, 13, 65, 32, 125);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 12, 4, 4, 24, 12, 126);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (99, 99, 19, 19, 19, 33, 127);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (58, 58, 11, 11, 11, 19, 128);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 19, 3, 3, 19, 6, 129);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 77, 15, 15, 77, 25, 130);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 24, 14, 73, 14, 36, 131);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 10, 6, 32, 6, 16, 132);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 14, 5, 5, 28, 14, 133);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 43, 17, 17, 86, 43, 134);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (20, 20, 20, 20, 20, 20, 135);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 10, 10, 10, 10, 10, 136);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (0, 0, 0, 0, 0, 0, 137);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 4, 4, 4, 4, 4, 138);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 19, 19, 19, 19, 19, 139);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (73, 14, 24, 24, 14, 24, 140);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (32, 6, 10, 10, 6, 10, 141);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (28, 28, 5, 5, 5, 9, 142);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (86, 86, 17, 17, 17, 28, 143);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 5, 25, 5, 5, 12, 144);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (41, 16, 83, 16, 16, 41, 145);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 19, 19, 19, 19, 19, 146);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 63, 12, 12, 63, 21, 147);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 19, 3, 3, 3, 6, 148);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (77, 77, 15, 15, 15, 25, 149);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 17, 10, 53, 10, 26, 150);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 4, 2, 12, 2, 6, 151);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (1, 4, 1, 1, 8, 4, 152);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 33, 13, 13, 66, 33, 153);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 64, 12, 12, 64, 21, 154);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 23, 4, 4, 23, 7, 155);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 6, 3, 19, 3, 9, 156);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 25, 15, 77, 15, 38, 157);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (53, 10, 17, 17, 10, 17, 158);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 2, 4, 4, 2, 4, 159);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 8, 1, 1, 1, 2, 160);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (9, 9, 1, 1, 1, 3, 161);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 16, 16, 16, 16, 16, 162);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 5, 5, 5, 5, 5, 163);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (49, 19, 98, 19, 19, 49, 164);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (28, 11, 57, 11, 11, 28, 165);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 53, 10, 10, 53, 17, 166);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 12, 2, 2, 12, 4, 167);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 73, 14, 14, 73, 24, 168);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 10, 2, 2, 2, 3, 169);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (68, 68, 13, 13, 13, 22, 170);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 14, 8, 44, 8, 22, 171);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (0, 1, 0, 3, 0, 1, 172);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 49, 19, 19, 98, 49, 173);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 28, 11, 11, 57, 28, 174);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 13, 13, 13, 13, 13, 175);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 3, 3, 3, 3, 3, 176);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 16, 6, 6, 32, 16, 177);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (22, 30, 18, 90, 18, 45, 178);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 5, 27, 5, 5, 13, 179);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (42, 17, 85, 17, 17, 42, 180);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 81, 16, 16, 81, 27, 181);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 40, 8, 8, 40, 13, 182);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 4, 4, 4, 4, 4, 183);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 18, 18, 18, 18, 18, 184);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (32, 32, 6, 6, 6, 10, 185);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (90, 18, 30, 30, 18, 30, 186);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 13, 5, 5, 27, 13, 187);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 42, 17, 17, 85, 42, 188);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (61, 61, 12, 12, 12, 20, 189);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (20, 20, 4, 4, 4, 6, 190);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 3, 16, 3, 3, 8, 191);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (37, 14, 74, 14, 14, 37, 192);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (75, 75, 15, 15, 15, 25, 193);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (72, 14, 24, 24, 14, 24, 194);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (31, 6, 10, 10, 6, 10, 195);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (27, 27, 5, 5, 5, 9, 196);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (85, 85, 17, 17, 17, 28, 197);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 20, 12, 61, 12, 30, 198);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 6, 4, 20, 4, 10, 199);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 8, 3, 3, 16, 8, 200);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 37, 14, 14, 74, 37, 201);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 49, 19, 19, 99, 49, 202);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (23, 23, 23, 23, 23, 23, 203);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 13, 13, 13, 13, 13, 204);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (50, 10, 16, 16, 10, 16, 205);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (9, 1, 3, 3, 1, 3, 206);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 5, 1, 1, 1, 1, 207);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (45, 9, 15, 15, 9, 15, 208);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 15, 15, 15, 15, 15, 209);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 5, 5, 5, 5, 5, 210);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (47, 19, 95, 19, 19, 47, 211);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (27, 10, 54, 10, 10, 27, 212);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 50, 10, 10, 50, 16, 213);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (1, 9, 1, 1, 9, 3, 214);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (1, 4, 1, 1, 9, 4, 215);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 33, 13, 13, 66, 33, 216);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 8, 5, 25, 5, 12, 217);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 13, 8, 41, 8, 20, 218);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (24, 33, 19, 99, 19, 49, 219);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 47, 19, 19, 95, 47, 220);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 27, 10, 10, 54, 27, 221);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 12, 12, 12, 12, 12, 222);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 2, 2, 2, 2, 2, 223);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (69, 69, 13, 13, 13, 23, 224);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (28, 28, 5, 5, 5, 9, 225);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 4, 24, 4, 4, 12, 226);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (41, 16, 82, 16, 16, 41, 227);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 78, 15, 15, 78, 26, 228);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (7, 37, 7, 7, 37, 12, 229);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 3, 3, 3, 3, 3, 230);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 17, 17, 17, 17, 17, 231);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 23, 13, 69, 13, 34, 232);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (7, 9, 5, 28, 5, 14, 233);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 12, 4, 4, 24, 12, 234);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (16, 41, 16, 16, 82, 41, 235);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (58, 58, 11, 11, 11, 19, 236);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 17, 3, 3, 3, 5, 237);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 2, 13, 2, 2, 6, 238);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (35, 14, 71, 14, 14, 35, 239);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (69, 13, 23, 23, 13, 23, 240);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (28, 5, 9, 9, 5, 9, 241);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (0, 4, 0, 0, 4, 1, 242);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 62, 12, 12, 62, 20, 243);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 19, 11, 58, 11, 29, 244);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 5, 3, 17, 3, 8, 245);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 6, 2, 2, 13, 6, 246);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 35, 14, 14, 71, 35, 247);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 37, 14, 14, 74, 37, 248);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (6, 16, 6, 6, 32, 16, 249);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 5, 27, 5, 5, 13, 250);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (42, 17, 85, 17, 17, 42, 251);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 2, 0, 0, 0, 0, 252);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (60, 60, 12, 12, 12, 20, 253);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (9, 12, 7, 36, 7, 18, 254);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (23, 31, 18, 94, 18, 47, 255);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (23, 23, 23, 23, 23, 23, 256);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 13, 13, 13, 13, 13, 257);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 5, 2, 2, 11, 5, 258);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (9, 47, 9, 9, 47, 15, 259);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (1, 6, 1, 1, 6, 2, 260);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (0, 0, 0, 2, 0, 1, 261);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (15, 20, 12, 60, 12, 30, 262);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (36, 7, 12, 12, 7, 12, 263);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (94, 18, 31, 31, 18, 31, 264);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 46, 18, 18, 92, 46, 265);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (10, 25, 10, 10, 51, 25, 266);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (11, 11, 11, 11, 11, 11, 267);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (1, 1, 1, 1, 1, 1, 268);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (40, 16, 81, 16, 16, 40, 269);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (20, 8, 40, 8, 8, 20, 270);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (7, 36, 7, 7, 36, 12, 271);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 94, 18, 18, 94, 31, 272);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (73, 73, 14, 14, 14, 24, 273);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 2, 2, 2, 2, 2, 274);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (17, 17, 17, 17, 17, 17, 275);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (64, 12, 21, 21, 12, 21, 276);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (23, 4, 7, 7, 4, 7, 277);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 19, 3, 3, 3, 6, 278);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (20, 20, 4, 4, 4, 6, 279);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 7, 3, 3, 15, 7, 280);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (18, 24, 14, 73, 14, 36, 281);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (5, 2, 10, 2, 2, 5, 282);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (34, 13, 68, 13, 13, 34, 283);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (12, 64, 12, 12, 64, 21, 284);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (4, 23, 4, 4, 23, 7, 285);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (24, 24, 24, 24, 24, 24, 286);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (9, 13, 7, 39, 7, 19, 287);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 18, 11, 55, 11, 27, 288);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 4, 2, 14, 2, 7, 289);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (2, 5, 2, 2, 10, 5, 290);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (13, 34, 13, 13, 68, 34, 291);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (44, 44, 8, 8, 8, 14, 292);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (3, 3, 0, 0, 0, 1, 293);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (83, 83, 16, 16, 16, 27, 294);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (42, 42, 8, 8, 8, 14, 295);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (19, 7, 38, 7, 7, 19, 296);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (48, 19, 96, 19, 19, 48, 297);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (14, 36, 14, 14, 72, 36, 298);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (47, 19, 95, 19, 19, 47, 299);
INSERT INTO Stats (agilidade, destreza, forca, sorte, inteligencia, vitalidade, idPersonagem) VALUES (8, 11, 6, 33, 6, 16, 300);


-- INSERTS DA TABELA PERSONAGEM_HAS_HABILIDADE

INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (1, 8, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (1, 9, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (1, 4, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (2, 21, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (2, 19, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (2, 20, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (3, 7, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (3, 8, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (3, 9, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (4, 5, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (4, 6, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (4, 7, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (5, 30, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (5, 31, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (5, 32, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (6, 24, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (6, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (6, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (7, 13, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (7, 14, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (7, 15, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (8, 13, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (8, 10, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (8, 11, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (9, 16, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (9, 17, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (9, 18, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (10, 16, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (10, 20, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (10, 21, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (11, 38, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (11, 39, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (11, 34, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (12, 38, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (12, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (12, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (13, 29, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (13, 30, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (13, 31, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (14, 29, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (14, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (14, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (15, 38, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (15, 39, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (15, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (16, 38, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (16, 36, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (16, 37, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (17, 12, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (17, 13, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (17, 14, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (18, 12, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (18, 15, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (18, 10, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (19, 21, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (19, 16, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (19, 17, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (20, 22, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (20, 23, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (20, 24, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (21, 16, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (21, 17, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (21, 18, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (22, 5, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (22, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (22, 7, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (23, 5, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (23, 9, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (23, 4, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (24, 27, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (24, 22, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (24, 23, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (25, 27, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (25, 24, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (25, 25, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (26, 30, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (26, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (26, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (27, 30, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (27, 28, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (27, 31, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (28, 36, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (28, 37, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (28, 38, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (29, 37, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (29, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (29, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (30, 23, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (30, 24, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (30, 25, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (31, 23, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (31, 27, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (31, 22, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (32, 6, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (32, 1, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (32, 2, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (33, 6, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (33, 3, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (33, 4, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (34, 5, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (34, 6, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (34, 7, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (35, 3, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (35, 4, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (35, 5, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (36, 36, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (36, 37, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (36, 38, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (37, 25, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (37, 26, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (37, 27, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (38, 25, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (38, 22, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (38, 23, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (39, 28, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (39, 29, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (39, 30, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (40, 28, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (40, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (40, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (41, 31, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (41, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (41, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (42, 31, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (42, 28, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (42, 29, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (43, 34, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (43, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (43, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (44, 34, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (44, 37, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (44, 38, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (45, 4, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (45, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (45, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (46, 4, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (46, 1, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (46, 2, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (47, 7, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (47, 9, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (47, 4, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (48, 33, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (48, 28, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (48, 29, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (49, 33, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (49, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (49, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (50, 7, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (50, 8, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (50, 9, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (51, 7, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (51, 4, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (51, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (52, 10, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (52, 11, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (52, 12, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (53, 10, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (53, 13, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (53, 14, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (54, 19, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (54, 20, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (54, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (55, 19, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (55, 17, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (55, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (56, 7, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (56, 9, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (56, 4, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (57, 6, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (57, 1, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (57, 2, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (58, 6, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (58, 4, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (58, 5, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (59, 19, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (59, 20, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (59, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (60, 19, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (60, 16, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (60, 17, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (61, 22, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (61, 23, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (61, 24, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (62, 22, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (62, 26, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (62, 27, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (63, 38, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (63, 39, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (63, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (64, 38, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (64, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (64, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (65, 2, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (65, 3, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (65, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (66, 2, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (66, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (66, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (67, 8, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (67, 9, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (67, 4, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (68, 8, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (68, 6, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (68, 7, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (69, 24, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (69, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (69, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (70, 27, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (70, 22, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (70, 23, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (71, 34, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (71, 35, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (71, 36, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (72, 28, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (72, 29, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (72, 30, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (73, 17, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (73, 18, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (73, 19, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (74, 17, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (74, 20, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (74, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (75, 26, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (75, 27, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (75, 22, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (76, 26, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (76, 24, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (76, 25, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (77, 6, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (77, 1, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (77, 2, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (78, 6, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (78, 1, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (78, 2, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (79, 10, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (79, 11, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (79, 12, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (80, 4, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (80, 5, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (80, 6, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (81, 35, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (81, 36, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (81, 37, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (82, 35, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (82, 39, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (82, 34, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (83, 15, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (83, 10, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (83, 11, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (84, 15, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (84, 12, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (84, 13, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (85, 20, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (85, 16, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (85, 17, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (86, 28, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (86, 29, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (86, 30, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (87, 28, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (87, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (87, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (88, 37, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (88, 38, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (88, 39, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (89, 37, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (89, 34, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (89, 35, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (90, 1, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (90, 2, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (90, 3, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (91, 1, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (91, 5, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (91, 6, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (92, 20, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (92, 21, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (92, 16, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (93, 20, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (93, 16, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (93, 17, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (94, 4, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (94, 5, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (94, 6, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (95, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (95, 7, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (95, 8, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (96, 13, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (96, 14, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (96, 15, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (97, 13, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (97, 10, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (97, 11, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (98, 16, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (98, 17, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (98, 18, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (99, 16, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (99, 20, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (99, 21, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (100, 38, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (100, 39, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (100, 34, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (101, 38, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (101, 34, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (101, 35, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (102, 22, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (102, 23, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (102, 24, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (103, 22, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (103, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (103, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (104, 31, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (104, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (104, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (105, 31, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (105, 29, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (105, 30, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (106, 5, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (106, 6, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (106, 7, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (107, 5, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (107, 9, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (107, 7, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (108, 18, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (108, 19, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (108, 20, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (109, 19, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (109, 20, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (109, 21, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (110, 5, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (110, 6, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (110, 1, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (111, 38, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (111, 34, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (111, 35, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (112, 34, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (112, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (112, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (113, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (113, 37, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (113, 35, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (114, 15, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (114, 11, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (114, 12, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (115, 11, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (115, 12, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (115, 13, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (116, 11, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (116, 14, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (116, 15, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (117, 20, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (117, 21, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (117, 16, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (118, 20, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (118, 18, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (118, 19, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (119, 36, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (119, 37, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (119, 38, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (120, 36, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (120, 38, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (120, 39, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (121, 26, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (121, 27, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (121, 22, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (122, 26, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (122, 23, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (122, 24, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (123, 29, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (123, 30, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (123, 31, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (124, 29, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (124, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (124, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (125, 38, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (125, 39, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (125, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (126, 38, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (126, 36, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (126, 37, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (127, 12, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (127, 13, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (127, 14, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (128, 12, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (128, 14, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (128, 11, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (129, 22, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (129, 23, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (129, 24, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (130, 22, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (130, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (130, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (131, 31, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (131, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (131, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (132, 31, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (132, 28, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (132, 29, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (133, 34, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (133, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (133, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (134, 34, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (134, 37, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (134, 38, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (135, 4, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (135, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (135, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (136, 5, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (136, 6, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (136, 1, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (137, 5, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (137, 1, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (137, 2, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (138, 1, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (138, 2, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (138, 3, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (139, 1, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (139, 4, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (139, 5, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (140, 7, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (140, 8, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (140, 9, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (141, 7, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (141, 4, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (141, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (142, 10, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (142, 11, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (142, 12, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (143, 10, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (143, 13, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (143, 11, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (144, 16, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (144, 17, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (144, 18, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (145, 17, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (145, 18, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (145, 19, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (146, 3, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (146, 6, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (146, 1, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (147, 27, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (147, 25, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (147, 26, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (148, 13, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (148, 14, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (148, 15, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (149, 13, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (149, 11, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (149, 12, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (150, 29, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (150, 30, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (150, 31, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (151, 29, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (151, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (151, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (152, 38, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (152, 39, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (152, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (153, 36, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (153, 34, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (153, 35, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (154, 22, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (154, 23, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (154, 24, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (155, 22, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (155, 25, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (155, 26, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (156, 31, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (156, 32, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (156, 33, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (157, 31, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (157, 29, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (157, 30, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (158, 5, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (158, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (158, 7, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (159, 5, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (159, 8, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (159, 9, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (160, 14, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (160, 15, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (160, 10, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (161, 12, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (161, 10, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (161, 11, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (162, 1, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (162, 2, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (162, 3, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (163, 1, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (163, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (163, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (164, 20, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (164, 21, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (164, 16, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (165, 20, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (165, 17, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (165, 18, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (166, 23, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (166, 24, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (166, 25, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (167, 24, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (167, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (167, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (168, 24, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (168, 25, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (168, 26, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (169, 13, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (169, 14, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (169, 15, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (170, 13, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (170, 11, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (170, 12, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (171, 29, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (171, 30, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (171, 31, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (172, 29, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (172, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (172, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (173, 38, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (173, 39, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (173, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (174, 38, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (174, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (174, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (175, 2, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (175, 3, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (175, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (176, 2, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (176, 6, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (176, 3, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (177, 35, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (177, 36, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (177, 37, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (178, 29, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (178, 30, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (178, 31, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (179, 18, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (179, 19, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (179, 20, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (180, 18, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (180, 21, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (180, 16, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (181, 27, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (181, 22, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (181, 23, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (182, 27, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (182, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (182, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (183, 4, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (183, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (183, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (184, 1, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (184, 2, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (184, 3, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (185, 11, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (185, 12, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (185, 13, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (186, 5, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (186, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (186, 7, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (187, 36, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (187, 37, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (187, 38, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (188, 36, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (188, 34, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (188, 35, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (189, 10, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (189, 11, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (189, 12, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (190, 10, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (190, 13, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (190, 14, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (191, 19, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (191, 20, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (191, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (192, 19, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (192, 21, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (192, 18, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (193, 11, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (193, 15, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (193, 10, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (194, 9, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (194, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (194, 5, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (195, 9, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (195, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (195, 7, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (196, 12, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (196, 13, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (196, 14, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (197, 12, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (197, 10, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (197, 11, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (198, 28, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (198, 29, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (198, 30, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (199, 28, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (199, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (199, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (200, 37, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (200, 38, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (200, 39, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (201, 38, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (201, 39, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (201, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (202, 38, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (202, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (202, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (203, 2, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (203, 3, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (203, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (204, 2, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (204, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (204, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (205, 8, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (205, 9, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (205, 4, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (206, 8, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (206, 5, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (206, 6, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (207, 11, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (207, 12, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (207, 13, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (208, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (208, 7, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (208, 8, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (209, 4, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (209, 5, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (209, 6, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (210, 4, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (210, 2, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (210, 3, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (211, 17, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (211, 18, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (211, 19, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (212, 17, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (212, 20, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (212, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (213, 26, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (213, 27, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (213, 22, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (214, 26, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (214, 23, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (214, 24, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (215, 35, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (215, 36, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (215, 37, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (216, 36, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (216, 37, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (216, 38, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (217, 30, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (217, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (217, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (218, 32, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (218, 33, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (218, 28, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (219, 32, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (219, 29, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (219, 30, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (220, 35, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (220, 36, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (220, 37, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (221, 35, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (221, 38, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (221, 39, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (222, 5, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (222, 6, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (222, 1, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (223, 2, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (223, 3, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (223, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (224, 12, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (224, 13, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (224, 14, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (225, 12, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (225, 15, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (225, 10, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (226, 21, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (226, 16, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (226, 17, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (227, 21, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (227, 18, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (227, 19, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (228, 24, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (228, 25, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (228, 26, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (229, 24, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (229, 22, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (229, 23, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (230, 1, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (230, 2, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (230, 3, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (231, 1, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (231, 3, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (231, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (232, 30, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (232, 31, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (232, 32, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (233, 30, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (233, 33, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (233, 28, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (234, 39, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (234, 34, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (234, 35, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (235, 39, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (235, 37, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (235, 38, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (236, 13, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (236, 14, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (236, 15, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (237, 13, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (237, 10, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (237, 11, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (238, 16, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (238, 17, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (238, 18, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (239, 16, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (239, 18, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (239, 19, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (240, 6, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (240, 7, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (240, 8, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (241, 6, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (241, 4, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (241, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (242, 22, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (242, 23, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (242, 24, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (243, 22, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (243, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (243, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (244, 31, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (244, 32, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (244, 33, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (245, 31, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (245, 28, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (245, 29, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (246, 34, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (246, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (246, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (247, 34, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (247, 37, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (247, 38, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (248, 34, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (248, 35, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (248, 36, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (249, 35, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (249, 36, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (249, 37, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (250, 18, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (250, 19, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (250, 20, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (251, 18, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (251, 20, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (251, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (252, 14, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (252, 15, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (252, 10, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (253, 14, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (253, 12, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (253, 13, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (254, 30, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (254, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (254, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (255, 30, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (255, 33, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (255, 28, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (256, 6, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (256, 1, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (256, 2, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (257, 1, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (257, 2, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (257, 3, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (258, 34, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (258, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (258, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (259, 23, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (259, 24, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (259, 25, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (260, 23, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (260, 26, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (260, 27, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (261, 32, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (261, 33, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (261, 28, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (262, 32, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (262, 30, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (262, 31, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (263, 6, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (263, 7, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (263, 8, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (264, 6, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (264, 8, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (264, 9, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (265, 38, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (265, 39, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (265, 34, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (266, 38, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (266, 35, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (266, 36, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (267, 2, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (267, 3, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (267, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (268, 2, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (268, 6, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (268, 1, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (269, 21, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (269, 16, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (269, 17, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (270, 21, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (270, 18, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (270, 19, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (271, 24, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (271, 25, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (271, 26, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (272, 24, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (272, 25, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (272, 26, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (273, 12, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (273, 13, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (273, 14, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (274, 4, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (274, 5, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (274, 6, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (275, 4, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (275, 1, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (275, 2, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (276, 4, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (276, 5, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (276, 6, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (277, 4, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (277, 7, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (277, 8, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (278, 13, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (278, 14, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (278, 15, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (279, 11, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (279, 12, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (279, 13, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (280, 36, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (280, 37, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (280, 38, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (281, 30, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (281, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (281, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (282, 19, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (282, 20, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (282, 21, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (283, 19, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (283, 16, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (283, 17, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (284, 22, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (284, 23, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (284, 24, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (285, 22, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (285, 26, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (285, 27, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (286, 5, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (286, 6, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (286, 1, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (287, 32, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (287, 28, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (287, 29, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (288, 28, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (288, 29, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (288, 30, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (289, 28, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (289, 31, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (289, 32, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (290, 37, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (290, 38, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (290, 39, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (291, 37, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (291, 35, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (291, 36, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (292, 11, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (292, 12, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (292, 13, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (293, 11, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (293, 12, 5);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (293, 15, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (294, 14, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (294, 15, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (294, 10, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (295, 14, 1);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (295, 11, 10);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (295, 12, 2);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (296, 17, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (296, 18, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (296, 19, 9);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (297, 17, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (297, 21, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (297, 16, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (298, 39, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (298, 34, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (298, 35, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (299, 19, 7);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (299, 21, 6);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (299, 16, 8);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (300, 33, 4);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (300, 28, 3);
INSERT INTO Personagem_has_Habilidade (idPersonagem, idHabilidade, nivel) VALUES (300, 29, 5);

-- ADICIONANDO AS PROCEDURES, FUNCTIONS, TRIGGERS e EVENTOS. 


-- transferir zeni do personagem 1 para personagem 2
DELIMITER ||
CREATE PROCEDURE transferir_zeny (IN personagem1 VARCHAR(30), IN personagem2 VARCHAR(30), IN valor INT)
BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '02003'
		BEGIN
			ROLLBACK;
		END;
	START TRANSACTION;
		UPDATE personagem SET zeny= zeny - valor WHERE nome=personagem1;
		UPDATE personagem SET zeny= zeny + valor WHERE nome=personagem2;
	COMMIT;
END
||
DELIMITER ;

-- função retorna o bonus padrao sobre um valor doado. 
DELIMITER ||
CREATE FUNCTION calcular_bonificacao (valor_doado DECIMAL)
RETURNS DECIMAL
NO SQL DATA:
BEGIN
 RETURN valor_doado * 0.1;
END
||

DELIMITER $$

-- Realiza o casamento de dois personagens
CREATE DEFINER=`root`@`localhost` PROCEDURE `casamento`(IN personagem1 INT, IN personagem2 INT)
BEGIN
 START TRANSACTION;
  UPDATE personagem SET idPersonagem2 = personagem1 WHERE idPersonagem = personagem2;
  UPDATE personagem SET idPersonagem2 = personagem2 WHERE idPersonagem = personagem1;
 COMMIT;
END
$$


DELIMITER $$
-- Insere o cash na conta de um personagem.
CREATE DEFINER=`root`@`localhost` PROCEDURE `inserir_cash`(IN conta INT, IN valor DECIMAL)
BEGIN
 UPDATE Conta
 SET cash = cash + valor + calcular_bonificacao(valor)
 WHERE idConta = conta;
END
$$

DELIMITER $$
-- Gera um relatório dos personagens mais ricos do jogo.
CREATE DEFINER=`root`@`localhost` PROCEDURE `personagens_ricos`()
BEGIN
 SELECT p.nome as 'Personagem', zeny as 'Zeny ($$$$)', 
  classe as 'Classe', g.nome as 'Guilda'
 FROM personagem p INNER JOIN guilda g using (idGuilda)
 ORDER BY zeny DESC
 LIMIT 10;
END
$$

-- Trigger que verifica se o personagem passou de nível e aumenta os stats caso tenha passado
DELIMITER %
CREATE TRIGGER atualizar_status AFTER UPDATE ON `Ragnarok`.`Personagem`
FOR EACH ROW
BEGIN
 IF(NEW.levelbase > old.levelbase) THEN
  UPDATE Stats SET
   forca = forca + 5,
   agilidade = agilidade + 5,
   inteligencia = inteligencia +5,
   destreza = destreza +5,
   sorte = sorte +5,
   vitalidade = vitalidade +5
  where Stats.idPersonagem =new.idPersonagem;
 END IF;
END
%

-- Função que retorna um id do jogador ao receber um nome.
DELIMITER ||
CREATE FUNCTION buscarID (nomePersonagem CHAR(30)) RETURNS INT 
READS SQL DATA
DETERMINISTIC
BEGIN 
	DECLARE idBuscado INT;
	SELECT idPersonagem FROM personagem WHERE nome = nomePersonagem INTO idBuscado;
	return idBuscado; 
END||

-- Procedure para banir um personagem, caso ele já estejá banido o tempo  e banimento e o motivo são adicionados ao primeiro banimento.
DELIMITER ||
CREATE PROCEDURE banir_personagem 
(IN nick CHAR(30), IN duracaoDias INT, IN motivow CHAR(200))
BEGIN
	DECLARE EXIT HANDLER FOR SQLSTATE '23000' 
		BEGIN
			UPDATE banimento SET duracao = DATE_ADD(duracao, INTERVAL duracaoDias DAY), 
										motivo = concat(motivo, concat(' + ', motivow)) 
										WHERE buscarID(nick) = idPersonagem;
		END;

	INSERT INTO banimento (idPersonagem, duracao, motivo) 
	VALUES (buscarID(nick), DATE_ADD(CURDATE(), INTERVAL duracaoDias DAY), motivow);

END ||

-- Desbane um personagem qualquer que esteja banido.
DELIMITER ||
CREATE PROCEDURE desbanir_personagem (IN nome CHAR(30)) 
BEGIN
	DELETE FROM banimento WHERE idPersonagem = buscarID(nome);
END ||

-- Procedure que verifica os banimentos que encerram durante o dia atual e os remove da tabela.
DELIMITER ||
CREATE PROCEDURE rotina_ban ()
BEGIN
	DECLARE terminado BOOLEAN DEFAULT FALSE;
	DECLARE i CHAR(30);
	DECLARE desbanidos CURSOR FOR SELECT idPersonagem FROM banimento WHERE duracao = curdate();
	DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET terminado = TRUE;
	OPEN desbanidos;	
	repetir:LOOP
		IF terminado THEN
			LEAVE repetir;
		END IF;
		FETCH desbanidos INTO i;
		DELETE FROM banimento WHERE idPersonagem = i;
	END LOOP;		
	CLOSE desbanidos;
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
