SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `DiscMetal` ;
CREATE SCHEMA IF NOT EXISTS `DiscMetal` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `DiscMetal` ;

-- -----------------------------------------------------
-- Table `DiscMetal`.`melhores_riffs`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`melhores_riffs` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`melhores_riffs` (
  `posicao` INT NOT NULL,
  `Musica` VARCHAR(45) NULL,
  PRIMARY KEY (`posicao`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`bandas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`bandas` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`bandas` (
  `idBandas` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `Pais` VARCHAR(45) NULL,
  `Genero` VARCHAR(180) NULL,
  `Ano_da_formacao` YEAR NULL,
  PRIMARY KEY (`idBandas`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`premiacao`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`premiacao` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`premiacao` (
  `idPremiacao` INT NOT NULL,
  `Evento` VARCHAR(120) NULL,
  `quantidade` VARCHAR(80) NULL,
  `bandas_idBandas` INT NOT NULL,
  PRIMARY KEY (`idPremiacao`),
  INDEX `fk_premiacao_bandas1_idx` (`bandas_idBandas` ASC),
  CONSTRAINT `fk_premiacao_bandas1`
    FOREIGN KEY (`bandas_idBandas`)
    REFERENCES `DiscMetal`.`bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`melhores_albuns`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`melhores_albuns` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`melhores_albuns` (
  `idMelhores_Albuns` INT NOT NULL,
  `Album` VARCHAR(45) NULL,
  `ano_do_lancamento` YEAR NULL,
  `melhores_riffs_posicao` INT NOT NULL,
  `bandas_idBandas` INT NOT NULL,
  PRIMARY KEY (`idMelhores_Albuns`),
  INDEX `fk_melhores_albuns_melhores_riffs_idx` (`melhores_riffs_posicao` ASC),
  INDEX `fk_melhores_albuns_bandas1_idx` (`bandas_idBandas` ASC),
  CONSTRAINT `fk_melhores_albuns_melhores_riffs`
    FOREIGN KEY (`melhores_riffs_posicao`)
    REFERENCES `DiscMetal`.`melhores_riffs` (`posicao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_melhores_albuns_bandas1`
    FOREIGN KEY (`bandas_idBandas`)
    REFERENCES `DiscMetal`.`bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`fan_cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`fan_cliente` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`fan_cliente` (
  `idfan_cliente` INT NOT NULL,
  `nome_do_cliente` VARCHAR(45) NULL,
  `estilo_preferencial` TINYINT(1) NULL,
  `cpf` VARCHAR(45) NULL,
  `rg` VARCHAR(45) NULL,
  PRIMARY KEY (`idfan_cliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`influencias`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`influencias` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`influencias` (
  `bandas_idBandas` INT NOT NULL,
  `bandas_idBandas1` INT NOT NULL,
  `fan_cliente_idfan_cliente` INT NOT NULL,
  PRIMARY KEY (`bandas_idBandas`, `bandas_idBandas1`),
  INDEX `fk_bandas_has_bandas_bandas2_idx` (`bandas_idBandas1` ASC),
  INDEX `fk_bandas_has_bandas_bandas1_idx` (`bandas_idBandas` ASC),
  INDEX `fk_influencias_fan_cliente1_idx` (`fan_cliente_idfan_cliente` ASC),
  CONSTRAINT `fk_bandas_has_bandas_bandas1`
    FOREIGN KEY (`bandas_idBandas`)
    REFERENCES `DiscMetal`.`bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_bandas_has_bandas_bandas2`
    FOREIGN KEY (`bandas_idBandas1`)
    REFERENCES `DiscMetal`.`bandas` (`idBandas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_influencias_fan_cliente1`
    FOREIGN KEY (`fan_cliente_idfan_cliente`)
    REFERENCES `DiscMetal`.`fan_cliente` (`idfan_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`vendedor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`vendedor` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`vendedor` (
  `idvendedor` INT NOT NULL,
  `nome_vendedor` VARCHAR(45) NULL,
  `RA` VARCHAR(45) NULL,
  `Comissao` VARCHAR(45) NULL,
  `qts_vendidaCD` VARCHAR(45) NULL,
  PRIMARY KEY (`idvendedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`fornecedor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`fornecedor` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`fornecedor` (
  `idfornecedor` INT NOT NULL,
  `empresa` VARCHAR(45) NULL,
  `qts_cd_fornecedor` int(45) NULL,
  `valor_de_custo` FLOAT NULL,
  PRIMARY KEY (`idfornecedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`estoque`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`estoque` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`estoque` (
  `idestoque` INT NOT NULL,
  `Quantidade_de_cds` INT NULL,
  `fornecedor_idfornecedor` INT NOT NULL,
  PRIMARY KEY (`idestoque`),
  INDEX `fk_estoque_fornecedor1_idx` (`fornecedor_idfornecedor` ASC),
  CONSTRAINT `fk_estoque_fornecedor1`
    FOREIGN KEY (`fornecedor_idfornecedor`)
    REFERENCES `DiscMetal`.`fornecedor` (`idfornecedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`venda_cd`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`venda_cd` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`venda_cd` (
  `idvenda_cd` INT NOT NULL,
  `valor_de_venda` FLOAT NULL,
  `gravadora` VARCHAR(45) NULL,
  `melhores_albuns_idMelhores_Albuns` INT NOT NULL,
  `vendedor_idvendedor` INT NOT NULL,
  `estoque_idestoque` INT NOT NULL,
  PRIMARY KEY (`idvenda_cd`),
  INDEX `fk_venda_cd_melhores_albuns1_idx` (`melhores_albuns_idMelhores_Albuns` ASC),
  INDEX `fk_venda_cd_vendedor1_idx` (`vendedor_idvendedor` ASC),
  INDEX `fk_venda_cd_estoque1_idx` (`estoque_idestoque` ASC),
  CONSTRAINT `fk_venda_cd_melhores_albuns1`
    FOREIGN KEY (`melhores_albuns_idMelhores_Albuns`)
    REFERENCES `DiscMetal`.`melhores_albuns` (`idMelhores_Albuns`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_venda_cd_vendedor1`
    FOREIGN KEY (`vendedor_idvendedor`)
    REFERENCES `DiscMetal`.`vendedor` (`idvendedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_venda_cd_estoque1`
    FOREIGN KEY (`estoque_idestoque`)
    REFERENCES `DiscMetal`.`estoque` (`idestoque`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DiscMetal`.`Status_de_Compras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DiscMetal`.`Status_de_Compras` ;

CREATE TABLE IF NOT EXISTS `DiscMetal`.`Status_de_Compras` (
  `vendedor_idvendedor` INT NOT NULL,
  `fan_cliente_idfan_cliente` INT NOT NULL,
  PRIMARY KEY (`vendedor_idvendedor`, `fan_cliente_idfan_cliente`),
  INDEX `fk_vendedor_has_fan_cliente_fan_cliente1_idx` (`fan_cliente_idfan_cliente` ASC),
  INDEX `fk_vendedor_has_fan_cliente_vendedor1_idx` (`vendedor_idvendedor` ASC),
  CONSTRAINT `fk_vendedor_has_fan_cliente_vendedor1`
    FOREIGN KEY (`vendedor_idvendedor`)
    REFERENCES `DiscMetal`.`vendedor` (`idvendedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vendedor_has_fan_cliente_fan_cliente1`
    FOREIGN KEY (`fan_cliente_idfan_cliente`)
    REFERENCES `DiscMetal`.`fan_cliente` (`idfan_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

--						 -----------------------------------------------------
-- 						 -------------------- Dados Bandas -----------------
--						 ---------------------------------------------------

insert into bandas values   (1,'ACDC','australia','heavy metal',1973);
insert into Bandas values   (2,'Accept',' alemanha','heavy metal',1968);
insert into Bandas values   (3,'Acid Drinkers ','austria','heavy metal',1986);
insert into Bandas values   (4,'Acrassicauda',' Iraque','heavy metal', 2001);
insert into Bandas values   (5,'Aerosmith',' EUA','heavy metal',1970);
insert into Bandas values   (6,'Airged L amh',' grecia','heavy metal',1987);
insert into Bandas values   (7,'Alcatrazz','Eua','heavy metal',1993);
insert into Bandas values   (8,'Alice Cooper',' EUA','heavy metal', 1964);
insert into Bandas values   (9,'Allen-Lande',' EUA','heavy metal',2005);
insert into Bandas values   (10,'Alice in Chains','EUA','heavy metal', 1987);
insert into Bandas values   (11,'Almah','brasil','heavy metal', 2006);
insert into Bandas values   (12,'Angel Witch',' Inglaterra','heavy metal', 1977);
insert into Bandas values   (13,'Animetal','Japão','heavy metal', 1996);
insert into Bandas values   (14,'Anthrax',' EUA','heavy metal', 1981);
insert into Bandas values   (15,'Angra','brasil','heavy metal', 1991);
insert into Bandas values   (16,'Anvil','Canadá','heavy metal', 1973);
insert into Bandas values   (17,'Arghon','brasil','heavy metal', 2002);
insert into Bandas values   (18,'Armored Saint' ,'EUA','heavy metal', 1982);
insert into Bandas values   (19,'Asgard Legionnaires', 'catar', 'heavy metal',2002);
insert into Bandas values   (20,'Atland','Espanha','Heavy Metal', 2000);
insert into Bandas values   (21,'Atomgods','Reino Unido','heavy metal', 1980);
insert into Bandas values   (22,'Avenged',' EUA','heavy metal', 1999);
insert into Bandas values   (23,'Avian','EUA','heavy metal', 2002);
insert into Bandas values   (24,'Axxis','Alemanha','heavy metal', 1988);
insert into Bandas values   (25,'Bang Tango','EUA','heavy metal' ,1987);
insert into Bandas values   (26,'Barren Cross',' EUA','heavy metal', 1984);
insert into Bandas values   (27,'Battleaxe',' Britanica','heavy metal', 1980);
insert into Bandas values   (28,'Bitches Sin', 'Britanica','heavy metal', 1980);
insert into Bandas values   (29,'Black Label society','EUA','heavy metal', 1998);
insert into Bandas values   (30,'Black Sabbath',' reino unido','heavy metal',1966);
insert into Bandas values   (31,'Black Tide','EUA','heavy metal', 2004);
insert into Bandas values   (32,'Blaze Bayley',' Britanica','heavy metal', 1963);
insert into Bandas values   (33,'Blue Öyster Cult',' EUA ','heavy metal',1960);
insert into Bandas values   (34,'Bride',' EUA','heavy metal', 1983);
insert into Bandas values   (35,'Brown Brigade',' Canada','heavy metal', 2006);
insert into Bandas values   (36,'Budgie ','Reino Unido','heavy metal', 1968);
insert into Bandas values   (37,'Carnivora ','Noruega','heavy metal', 1999);
insert into Bandas values   (38,'Chastain',' EUA','heavy metal', 1984);
insert into Bandas values   (39,'Chateaux',' Inglaterra','heavy metal', 1981);
insert into Bandas values   (40,'Chevy ','Inglaterra','heavy metal', 1979);
insert into Bandas values   (41,'Chickenfoot',' Mexico','heavy metal', 2008);
insert into Bandas values   (42,'Chrome Division',' Noruega','heavy metal', 2004); 
insert into Bandas values   (44,'Crossfire ','Bélgica','heavy metal', 1981);
insert into Bandas values   (45,'Crucified Barbara ','Suécia','heavy metal', 1998 );
insert into Bandas values   (46,'Crystal Viper',' Polônia ','heavy metal',2003 );
insert into Bandas values   (47, 'Deep Purple','grã-bretanha','heavy metal',1968);
insert into Bandas values   (48,'Def Leppard ','grã-bretanha','heavy metal', 1977);
insert into Bandas values   (49,'Demon', 'grã-bretanha' ,'heavy metal',1980); 
insert into Bandas values   (50,'Diamond Head','grã-bretanha' ,'heavy metal',1976);
insert into Bandas values   (51,'Dio ','EUA ','heavy metal',1982);
insert into Bandas values   (52,'Disturbed', 'EUA','heavy metal', 1994);
insert into Bandas values   (53,'Dokken' ,'EUA','heavy metal', 1978);
insert into Bandas values   (54,'Dr.Sin' ,'brasil','heavy metal',1992);
insert into Bandas values   (55,'E.F.Band',' Suécia','heavy metal', 1979);
insert into Bandas values   (56,'Early Man',' EUA ','heavy metal',2005);
insert into Bandas values   (57,'Earth',' EUA','heavy metal', 1989);
insert into Bandas values   (58,'Ecliptyka','brasil','heavy metal', 2000);
insert into Bandas values   (59,'Elixir' ,'Reino Unido ','heavy metal',1983);
insert into Bandas values   (60,'Edguy',' Alemanha ','heavy metal',1992);
insert into Bandas values   (61,'Europe',' Suécia','heavy metal', 1994 );
insert into Bandas values   (62,'Factor VIII',' Panamá','heavy metal', 1995);
insert into Bandas values   (63,'Fastway',' Reino Unido ','heavy metal',1983);
insert into Bandas values   (64,'Fight',' EUA ','heavy metal',1993);
insert into Bandas values   (65,'Five Finger Death Punch',' EUA ','heavy metal',2005);
insert into Bandas values   (66,'Fozzy ','EUA ','heavy metal',1999);
insert into Bandas values   (67,'Freak Kitchen',' Suécia','heavy metal', 1994 );
insert into Bandas values   (68,'Frozen Fire','brasil','heavy metal', 1999);
insert into Bandas values   (69,'Ghost ','Suécia','heavy metal', 2008);
insert into Bandas values   (70,'Gillan',' Inglaterra','heavy metal', 1978);
insert into Bandas values   (71,'Gigantour',' EUA','heavy metal', 2005);
insert into Bandas values   (72,'Girlschool',' Reino Unido','heavy metal', 1978);
insert into Bandas values   (73,'Gogmagog ','Reino Unido','heavy metal', 1985);
insert into Bandas values   (74,'Grave Digger',' Alemanha ','heavy metal',1980);
insert into Bandas values   (75,'Grim Reaper',' Reino Unido','heavy metal', 1979);
insert into Bandas values   (76,'Guns N Roses' ,'EUA' ,'heavy metal',1985);
insert into Bandas values   (77,'Halestorm ','eua','heavy metal', 1997);
insert into Bandas values   (78,'Hazy Hamlet','brasil','heavy metal', 1999);
insert into Bandas values   (79,'Heaven and Hell ','Reino Unido','heavy metal', 2006);
insert into Bandas values   (80,'Helstar',' EUA ','Heavy Metal',1982);
insert into Bandas values   (81,'Herald nacionalidade','Estônia ','heavy metal',2000);
insert into Bandas values   (82,'Holder of Souls','brasil','heavy metal', 2001);
insert into Bandas values   (83,'Hellish War','brasil','Heavy Metal', 1995);
insert into Bandas values   (84,'Hangar','brasil','heavy metal', 1997);
insert into Bandas values   (85,'Iced Earth',' EUA ','Heavy Metal',1984);
insert into Bandas values   (86,'Impellitteri',' EUA','Heavy Metal', 1987);
insert into Bandas values   (87,'Iron Maiden ','Reino Unido','Heavy Metal', 1975);
insert into Bandas values   (88,'Ivory Gates ','brasil','heavy metal',2002);
insert into Bandas values   (89,'Jag Panzer ','EUA ','Heavy Metal',1983);
insert into Bandas values   (90,'Jorn' ,'Noruega ','Heavy Metal',2000);
insert into Bandas values   (91,'Judas Priest',' Reino Unido','heavy metal', 1969);
insert into Bandas values   (92,'Keel',' EUA' ,'Heavy Metal',1983);
insert into Bandas values   (93,'King Diamond ',' Dinamarca' ,'heavy metal',1979);
insert into Bandas values   (94,'Kiss',' EUA','heavy metal', 1973);
insert into Bandas values   (95,'Knorkator', 'Alemanha ','heavy metal',1994);
insert into Bandas values   (96,'Lamia','Cazaquistão','heavy metal', 1989);
insert into Bandas values   (97,'Led Zeppelin',' Reino Unido','heavy metal', 1968);
insert into Bandas values   (98,'Living Colour',' EUA','heavy metal', 1984);
insert into Bandas values  (99,'Lordi','Finlândia','heavy metal', 1992);
insert into Bandas values  (100,'Loudness ','Japão ','heavy metal',1991);
insert into Bandas values  (101,'Madame Saatan','brasil','heavy metal', 2002);
insert into Bandas values  (102,'Manowar' ,'EUA ','heavy metal',1980);
insert into Bandas values  (103,'Marya Roxx ','Estônia' ,'heavy metal',2002);
insert into Bandas values  (104,'Massacration','brasil','heavy metal', 2004);
insert into Bandas values  (105,'Matanza','brasil','heavy metal', 1996);
insert into Bandas values  (106,'Megadeth',' EUA ','heavy metal',1983);
insert into Bandas values  (107,'Mercyful Fate',' Dinamarca' ,'heavy metal',1981);
insert into Bandas values  (108,'Metallica ','EUA','heavy metal', 1981);
insert into Bandas values  (109,'Metalsteel',' Eslovênia','heavy metal', 2000 );
insert into Bandas values  (110,'Mnemic',' Dinarmarca','heavy metal', 1998);
insert into Bandas values  (111,'Mötley Crüe',' EUA','heavy metal', 1981);
insert into Bandas values  (112,'Motörhead ','Reino Unido ','heavy metal',1975);
insert into Bandas values  (114,'Nattvind' ,'Finlândia','heavy metal', 1994);
insert into Bandas values  (115,'zarNaeth',' Reino Unido','heavy metal', 1968);
insert into Bandas values  (116,'Nattvindens Gråt ','Finlândia','heavy metal', 1994);
insert into Bandas values  (117,'Neblina ','angola','heavy metal', 2000);
insert into Bandas values  (118,'Nevermore','EUA','heavy metal', 1991);
insert into Bandas values  (119,'Nightingale',' Suécia','heavy metal', 1995 );
insert into Bandas values  (120,'Ostrogoth ' ,'Bélgica','heavy metal', 1976 );
insert into Bandas values  (121,'Overdose','brasil','heavy metal', 1983);
insert into Bandas values  (122,'Ozzy Osbourne ','Reino Unido','heavy metal', 1968);
insert into Bandas values  (123,'Pantera',' EUA','heavy metal', 1981);
insert into Bandas values  (124,'Paradox',' Alemanha ','heavy metal',1986);
insert into Bandas values  (125,'Pentagram' ,'EUA ','heavy metal',1971);
insert into Bandas values  (126,'Poisonblack ','Finlândia ','heavy metal',2000);
insert into Bandas values  (127,'Portrait','brasil','heavy metal', 1989);
insert into Bandas values  (128,'Prong',' EUA','heavy metal', 1986);
insert into Bandas values  (129,'Poison',' EUA','heavy metal', 1983);
insert into Bandas values  (130,'Queen',' Reino Unido','heavy metal', 1971);
insert into Bandas values  (131,'Queensrÿche' ,'EUA','heavy metal', 1981);
insert into Bandas values  (132,'Quiet Riot',' EUA','heavy metal', 1975);
insert into Bandas values  (133,'Racer X',' EUA ','heavy metal',1985);
insert into Bandas values  (134,'Rainbow',' Reino Unido','heavy metal', 1975);
insert into Bandas values  (135,'Ramp',' Portugal','heavy metal', 1989);
insert into Bandas values  (136,'Rata Blanca',' Argentina ','heavy metal',1986);
insert into Bandas values  (137,'Raven ','Reino Unido ','heavy metal',1975);
insert into Bandas values  (138,'Riot',' EUA ','heavy metal',1975);
insert into Bandas values  (139,'Rosa de Saron','brasil','heavy metal', 1988);
insert into Bandas values  (140,'Rondinelli',' EUA ','heavy metal',1984);
insert into Bandas values  (141,'Royal Hunt ','Dinamarca ','heavy metal',1989);
insert into Bandas values  (142,'Running Wild',' Alemanha','heavy metal', 1976);
insert into Bandas values  (143,'Salário Mínimo ','brasil','heavy metal',1981);
insert into Bandas values  (144,'Samson' ,'Reino Unido','heavy metal', 1977);
insert into Bandas values  (145,'Sanatorium ','Macedônia','heavy metal', 1987 );
insert into Bandas values  (146,'Santa Maria',' Rússia ','heavy metal',1992);
insert into Bandas values  (147,'Santuário ','brasil','heavy metal',1982);
insert into Bandas values  (148,'Savatage ','EUA ','heavy metal',1979);
insert into Bandas values  (149,'Saxon',' Reino Unido ','heavy metal',1976);
insert into Bandas values  (150,'Scorpions ','Alemanha','heavy metal', 1965);
insert into Bandas values  (151,'Sentenced ','Finlândia ','heavy metal',1989);
insert into Bandas values  (152,'Shadowside','brasil','heavy metal', 2001);
insert into Bandas values  (153, 'Shaman ','brasil','heavy metal',2000);
insert into Bandas values  (154,'Siissisoq',' Cronelândia ','heavy metal',1998);
insert into Bandas values  (155,'Skid Row ','EUA ','heavy metal',1986);
insert into Bandas values  (156,'Skyclad ','Reino Unido','heavy metal', 1990);
insert into Bandas values  (157,'Slayer ','EUA ','heavy metal',1981);
insert into Bandas values  (158,'Slipknot',' EUA','heavy metal', 1995);
insert into Bandas values  (159,'Spartan Warrior',' Reino Unido','heavy metal',1991 );
insert into Bandas values  (160,'Steel Warrior ','Brasil','heavy metal',1996 );
insert into Bandas values  (161,'Steely Heaven ','brasil','heavy metal',1994 );
insert into Bandas values  (162,'Stress','brasil','heavy metal', 1974);
insert into Bandas values  (163,'Stryper',' EUA ','heavy metal',1983);
insert into Bandas values  (164,'Suicidal Angels',' Grécia','heavy metal', 2001);
insert into Bandas values  (165,'System of a Down ','EUA ','heavy metal',1992);
insert into Bandas values  (166,'Taking Dawn ','EUA ','heavy metal',2007);
insert into Bandas values  (167,'Tang Dynasty',' China ','heavy metal',1988);
insert into Bandas values  (168,'Tenacious D ','EUA ','heavy metal',1994);
insert into Bandas values  (169,'Teräsbetoni',' Finlândia ','heavy metal',2002 );
insert into Bandas values  (170,'Testament',' EUA','heavy metal', 1983);
insert into Bandas values  (171,'Thin Lizzy',' Irlanda','heavy metal', 1969 );
insert into Bandas values  (172,'Tierra Santa',' Espanha','heavy metal', 1997);
insert into Bandas values  (173,'Trivium ','EUA ','heavy metal',2000);
insert into Bandas values  (174,'Tribuzy','brasil','heavy metal', 2004);
insert into Bandas values  (175,'Twisted Sister',' EUA' ,'heavy metal',1972);
insert into Bandas values  (176,'U.D.O.',' Alemanha','heavy metal', 1987);
insert into Bandas values  (177,'UFO ','Reino Unido ','heavy metal',1969);
insert into Bandas values  (178,'Ugly Kid Joe ','EUA','heavy metal', 1989);
insert into Bandas values  (179,'Umphrey s McGee ','EUA ','heavy metal',1998);
insert into Bandas values  (180,'Uriah Heep',' Reino Unido','heavy metal', 1969);
insert into Bandas values  (181,'Van Halen',' EUA ','heavy metal',1974);
insert into Bandas values  (182,'Vasco da Gama',' Portugal','heavy metal', 1980);
insert into Bandas values  (183,'Vengeance ','Paises Baixos','heavy metal', 1983);
insert into Bandas values  (184,'Vênus ','brasil','heavy metal',1982);
insert into Bandas values  (185,'Vinnie Vincent Invasion',' EUA ','heavy metal',1984);
insert into Bandas values  (186,'Viper','brasil','heavy metal', 1985);
insert into Bandas values  (187,'Virgin Steele',' EUA ','heavy metal',1981);
insert into Bandas values  (188,'Vision Divine',' Itália','heavy metal', 1998);
insert into Bandas values  (189,'Volbeat',' Dinarmaca','heavy metal', 2001);
insert into Bandas values  (190,'W.A.S.P.','EUA','heavy metal', 1982);
insert into Bandas values  (191,'W.C. Noise ','Portugal ','heavy metal',1990);
insert into Bandas values  (192,'Warhorse ','Reino Unido ','heavy metal',1970);
insert into Bandas values  (193,'Warrant',' EUA ','heavy metal',1984);
insert into Bandas values  (194,'White Skull',' Itália','heavy metal', 1988);
insert into Bandas values  (195,'Whitesnake',' Reino Unido','heavy metal', 1978);
insert into Bandas values  (196,'Winter s Bane ','EUA ','heavy metal',1990);
insert into Bandas values  (197,'Witchfinder General ','Reino Unido','heavy metal', 1979);
insert into Bandas values  (198,'Wizard',' Alemanha','heavy metal', 1989);
insert into Bandas values  (199,'Wizzard ','Finlândia ','heavy metal',1995);
insert into Bandas values  (200,'Wolfmother',' Austrália','heavy metal', 2000);
insert into Bandas values  (201,'Wolfsbane ','Reino Unido','heavy metal', 1984);
insert into Bandas values  (202,'Xeque-Mate',' Portugal ','heavy metal',1979);
insert into Bandas values  (203,'X Japan ','Japão' ,'heavy metal',1982);
insert into Bandas values  (204,'Y&T ','EUA ','heavy metal',1974);
insert into Bandas values  (205,'Zenobia',' Espanha ','heavy metal',2002);
insert into Bandas values  (206,'3,14...','Azerbaijão','doom metal', 2002);
insert into Bandas values  (207,'Aardtmann op Vuurtopberg',' Países Baixos ','doom metal',2004);
insert into Bandas values  (208,'Aarni2 ','Finlândia','doom metal', 1998);
insert into Bandas values  (209,'Acrimony3',' Reino Unido','doom metal', 1991);
insert into Bandas values  (210,'Alien Boys',' Alemanha ','doom metal',1987);
insert into Bandas values  (211,'Anathema',' Reino Unido','doom metal', 1990);
insert into Bandas values  (212,'As Divine Grace','Finlândia','doom metal',1990);
insert into Bandas values  (213,'Avrigus',' Austrália ','doom metal',1995);
insert into Bandas values  (214,'Barathrum',' Finlândia','doom metal', 1990);
insert into Bandas values  (215,'Black Sabbath',' Reino Unido' ,'doom metal',1968);
insert into Bandas values  (216,'Burning Witch','Estados Unidos','doom metal',1990);
insert into Bandas values  (217,'Candlemass','Suécia','doom metal', 1984);
insert into Bandas values  (218,'Carpathian Full Moon',' Noruega','doom metal', 1993);
insert into Bandas values  (219,'Cathedral',' Reino Unido ','doom metal',1989);
insert into Bandas values  (220,'Celestial Season','Países Baixos','doom metal', 1991);
insert into Bandas values  (221,'Chalice','Austrália','doom metal', 1996);
insert into Bandas values  (222,'Cryptal Darkness',' Austrália ','doom metal',1993);
insert into Bandas values  (223,'Cultura Tres','Venezuela ','doom metal',2006);
insert into Bandas values  (224,'Darkwell','Áustria ','doom metal',1999);
insert into Bandas values  (225,'Dirge','França ','doom metal',1994);
insert into Bandas values  (226,'diSEMBOWELMENT',' Austrália','doom metal', 1989);
insert into Bandas values  (227,'Draconian','Suécia','doom metal', 1994);
insert into Bandas values (228,'Earth','Estados Unidos','doom metal', 1989);
insert into Bandas values (229,'Electric Wizard' ,'Reino Unido ','doom metal',1993);
insert into Bandas values (230,'Estatic Fear',' Áustria ','doom metal',1994);
insert into Bandas values (231,'Eternal Elysium',' Japão','doom metal', 1991);
insert into Bandas values (232,'Eyehategod',' Estados Unidos ','doom metal',1998);
insert into Bandas values (233,'Fallen',' Noruega ','doom metal',1996);
insert into Bandas values (234,'Forest of Shadows','Suécia','doom metal', 1997);
insert into Bandas values (235,'Forgotten Tomb','Itália ','doom metal',1999);
insert into Bandas values (236,'Frailty',' Letônia ','doom metal',2003);
insert into Bandas values (237,'Garadama',' Japão ','doom metal',1994);
insert into Bandas values (238,'Garden of Silence','França','doom metal', 1992);
insert into Bandas values (239,'The Gathering','Países Baixos','doom metal', 1989);
insert into Bandas values (240,'Ghost','Suécia','doom metal', 2008);
insert into Bandas values (241,'How Like a Winter','Itália ','doom metal',1995);
insert into Bandas values (242,'Inmemorial',' Peru','doom metal', 1993);
insert into Bandas values (243,'Iron Monkey',' Reino Unido ','doom metal',1994);
insert into Bandas values (244,'Katatonia','Suécia','doom metal', 1991);
insert into Bandas values (245,'Kimaera','Líbano ','doom metal',2000);
insert into Bandas values (246,'Lake of Tears','Suécia','doom metal', 1994);
insert into Bandas values (247,'My Dying Bride',' Reino Unido ','doom metal',1990);
insert into Bandas values (248,'Mythological Cold Towers','Brasil','doom metal', 1994);
insert into Bandas values (249,'Nortt',' Dinamarca','doom metal', 1995);
insert into Bandas values (250,'The Obsessed','Estados Unidos','doom metal', 1976);
insert into Bandas values (251,'October Tide','Suécia','doom metal', 1995);
insert into Bandas values (252,'Öröm','Hungria','doom metal', 1998);
insert into Bandas values (253,'Paradise Lost',' Reino Unido ','doom metal',1988);
insert into Bandas values (254,'Paramaecium','Austrália ','doom metal',1991);
insert into Bandas values (255,'Pentacrostic','Brasil ','doom metal',1989);
insert into Bandas values (256,'Pentagram','Estados Unidos','doom metal', 1971);
insert into Bandas values (257,'Place of Skulls','Estados Unidos','doom metal', 2000);
insert into Bandas values (258,'Poema Arcanus',' Chile','doom metal', 1991);
insert into Bandas values (259,'Rusty Souls','Suécia ','doom metal',2001);
insert into Bandas values (260,'Rwake',' Estados Unidos ','doom metal',1996);
insert into Bandas values (261,'Saint Vitus',' Estados Unidos ','doom metal',1978);
insert into Bandas values (262,'Salem',' Israel ','doom metal',1985);
insert into Bandas values (263,'Shape of Despair',' Finlândia ','doom metal',1995);
insert into Bandas values (264,'Skepticism',' Finlândia' ,'doom metal',1991);
insert into Bandas values (265,'Solitude Aeturnus','Estados Unidos','doom metal', 1987);
insert into Bandas values (266,'Solstice',' Reino Unido','doom metal', 1990);
insert into Bandas values (267,'Stabat Mater',' Finlândia ','doom metal',2001);
insert into Bandas values (268,'Sunn O)))',' Estados Unidos ','doom metal',1998);
insert into Bandas values (269,'Theatre of Tragedy','Noruega ','doom metal',1992);
insert into Bandas values (270,'Thergothon','Finlândia ','doom metal',1989);
insert into Bandas values (271,'Type O Negative','Estados Unidos','doom metal', 1983);
insert into Bandas values (272,'Whispering Forest','Estónia ','doom metal',1995);
insert into Bandas values (273,'Witchfinder General ','Reino Unido', 'doom metal',1979);
insert into Bandas values (274,'Worship',' Alemanha','doom metal', 1999);
insert into Bandas values (275,'Yearning',' Finlândia ','doom metal',1994);
insert into Bandas values (276,'Yob','Estados Unidos','doom metal', 2000);
insert into Bandas values (277,'Astarte ','Grécia','black metal', 1995);
insert into Bandas values (278,'The Abyss',' Suécia','black metal', 1994);
insert into Bandas values (279,'Alastis',' suíça','black metal', 1989);
insert into Bandas values (280,'Alcest',' franca','black metal',2000);
insert into Bandas values (281,'Ancient',' noruega ','black metal',1992);
insert into Bandas values (282,'...And Oceans',' Finlândia','black metal', 1995);
insert into Bandas values (283,'Anorexia Nervosa',' franca' ,'black metal',1995);
insert into Bandas values (284,'Antestor',' Noruega ','black metal',1990);
insert into Bandas values (285,'Aradia',' malásia ','black metal',1991);
insert into Bandas values (286,'Arckanum ','suíça','black metal', 1992);
insert into Bandas values (287,'Arcturus',' Noruega','black metal', 1987);
insert into Bandas values (288,'Aryan Terrorism ','Ucrânia','black metal', 2002);
insert into Bandas values (289,'Averse Sefira',' EUA ','black metal',1996);
insert into Bandas values (290,'Axis of Advance',' Canadá ','black metal',1998);
insert into Bandas values (291,'Barathrum','Finlândia ','black metal',1990);
insert into Bandas values (292,'Bathory','Suécia' ,'black metal',1983);
insert into Bandas values (293,'Behemoth ','polônia','black metal', 1991);
insert into Bandas values (294,'Belphegor',' Áustria','black metal', 1991);
insert into Bandas values (295,'Bestial Mockery',' Suécia','black metal', 1995);
insert into Bandas values (296,'Bestial Warlust',' Austrália','black metal', 1993);
insert into Bandas values (297,'Borknagar',' Noruega ','black metal',1995);
insert into Bandas values (298,'Burzum',' Noruega','black metal', 1991);
insert into Bandas values (299,'Cadaveria ','tália','black metal', 2001);
insert into Bandas values (300,'Carpathian Forest',' Noruega' ,'black metal',1992);
insert into Bandas values (301,'Carpe Tenebrum',' Noruega','black metal', 1997);
insert into Bandas values (302,'Catamenia',' Finlândia' ,'black metal',1995);
insert into Bandas values (303,'Celtic Frost',' suíça' ,'black metal',1984);
insert into Bandas values (304,'Chthonic',' Taiwan ','black metal',1995);
insert into Bandas values (305,'Cradle of Filth',' reino unido ','black metal',1991);
insert into Bandas values (306,'Crimson Moonlight',' Suécia ','black metal',1997);
insert into Bandas values (307,'Dark Funeral',' Suécia' ,'black metal',1993);
insert into Bandas values (308,'Darkest Hate Warfront','brasil','black metal', 2001);
insert into Bandas values (309,'Darkthrone',' Noruega','black metal', 1987);
insert into Bandas values (310,'Darkwoods My Betrothed ','Finlândia','black metal', 1992);
insert into Bandas values (311,'Demoniac nova ','Zelândia ','black metal',1993);
insert into Bandas values (312,'Dimmu Borgir',' Noruega','black metal', 1993);
insert into Bandas values (313,'Dissection',' Suécia','black metal', 1989);
insert into Bandas values (314,'Emperor',' Noruega','black metal', 1991);
insert into Bandas values (315,'Enthroned ','Bélgica','black metal', 1993);
insert into Bandas values (316,'Equilibrium',' Alemanha','black metal', 2003);
insert into Bandas values (317,'Esgaroth ','Brasil ','black metal',2004);
insert into Bandas values (318,'Falkenbach',' Alemanha','black metal', 1995);
insert into Bandas values (319,'Finntroll ','Finlândia','black metal', 1997);
insert into Bandas values (320,'Forgotten Tomb',' Itália ','black metal',1999);
insert into Bandas values (321,'The Furor',' Austrália ','black metal',2002);
insert into Bandas values (322,'Goatwhore ','EUA ','black metal',1997);
insert into Bandas values (323,'God Dethroned ','países baixos','black metal', 1991);
insert into Bandas values (324,'Gorgoroth',' Noruega ','black metal',1992);
insert into Bandas values (325,'Graveland ','polônia','black metal', 1992);
insert into Bandas values (326,'Graveworm ','Itália ','black metal',1997);
insert into Bandas values (327,'Hellhammer ','suíça','black metal', 1982);
insert into Bandas values (328,'Horde',' Austrália','black metal', 1994);
insert into Bandas values (329,'Illnath ','Dinamarca','black metal', 1997);
insert into Bandas values (330,'Immortal ','Noruega','black metal', 1990);
insert into Bandas values (331,'Immortal Souls ','Finlândia ','black metal',1991);
insert into Bandas values (332,'Impaled Nazarene',' Finlândia ','black metal',1990);
insert into Bandas values (333,'Inner Circle',' Noruega','black metal', 1992);
insert into Bandas values (334,'Janaza ','Iraque','black metal', 2010);
insert into Bandas values (335,'Judas Iscariot',' EUA ','black metal',1992);
insert into Bandas values (336,'Katharsis',' Alemanha','black metal', 1994);
insert into Bandas values (337,'The Kovenant',' Noruega','black metal', 1992);
insert into Bandas values (338,'Limbonic Art ','Noruega ','black metal',1993);
insert into Bandas values (339,'Lord Belial ','Suécia','black metal', 1992);
insert into Bandas values (340,'Lucifugum',' Ucrânia','black metal', 1995);
insert into Bandas values (341,'Marduk',' Suécia','black metal', 1990);
insert into Bandas values (342,'Master s Hammer ','republica checa','black metal', 1987);
insert into Bandas values (343,'Mayhem',' Noruega','black metal', 1984);
insert into Bandas values (344,'Mercyful Fate',' Dinamarca','black metal', 1981);
insert into Bandas values (345,'Moonspell ','Portugal','black metal', 1989);
insert into Bandas values (346,'Mütiilation',' franca','black metal', 1991);
insert into Bandas values (347,'Naglfar',' Suécia','black metal', 1992);
insert into Bandas values (348,'Nargaroth',' Alemanha','black metal', 1999);
insert into Bandas values (349,'Nokturnal Mortum',' Ucrânia','black metal', 1994);
insert into Bandas values (350,'Nothnegal',' maldivas','black metal', 2006);
insert into Bandas values  (351,'Bang Tango','Estados Unidos', 'Funk Metal','1987');
insert into Bandas values  (352,'Cornbugs','Estados Unidos', 'Funk Metal','1987');
insert into Bandas values (353,'Clutch','Estados Unidos', 'Funk Metal','1990');
insert into Bandas values (354,'Extreme','Estados Unidos', 'Funk Metal',' 1990');
insert into Bandas values (355,'Infectious Grooves','Estados Unidos', 'Funk Metal','1990');
insert into Bandas values (356,'Janes Addiction','Estados Unidos', 'Funk Metal','1991');
insert into Bandas values (357,'Living Colour','Estados Unidos', 'Funk Metal','1984');
insert into Bandas values (358,'Mr. Bungle','Estados Unidos', 'Funk Metal','1986');
insert into Bandas values (359,'Porno for Pyros',' Estados Unidos', 'Funk Metal','1993 ');
insert into Bandas values (360,'Praxis','Estados Unidos', 'Funk Metal','1992');
insert into Bandas values (361,'Primus','Estados Unidos', 'Funk Metal','1984');
insert into Bandas values (362,'Suicidal Tendencies','Estados Unidos', 'Funk Metal','1981');
insert into Bandas values (363,'Lofofora','França ', 'Funk Metal','1989');
insert into Bandas values (364,'Linea 77','Italia', 'Funk Metal','1993');
insert into Bandas values (365,'Agathocles','Bélgica','Grindcore','1985');
insert into Bandas values (366,'Agoraphobic Nosebleed','Estados Unidos',' Grindcore ','1994');
insert into Bandas values (367,'Anal Cunt','Estados Unidos','Grindcore','1998');
insert into Bandas values (368,'Antidemon','Brasil',' Grindcore ','1994');
insert into Bandas values (369,'Asesino','México',' Grindcore ','2002');
insert into Bandas values (370,'Assück','Estados Unidos',' Grindcore ','1987');
insert into Bandas values (371,'Benümb','Estados Unidos',' Grindcore ','1994');
insert into Bandas values (372,'Blood Duster','Austrália',' Grindcore ','1991');
insert into Bandas values (373,'Bolt Thrower','Reino Unido',' Grindcore ','1986');
insert into Bandas values (374,'Brujeria','México',' Grindcore ','1989');
insert into Bandas values (375,'Brutal Truth','Estados Unidos',' Grindcore ','1990');
insert into Bandas values (376,'Carcass','Reino Unido',' Grindcore ','1985');
insert into Bandas values (377,'Cattle Decapitation','Estados Unidos',' Grindcore','1996');
insert into Bandas values (378,'Cephalic Carnage','Estados Unidos',' Grindcore','1992');
insert into Bandas values (379,'The County Medical Examiners','Estados Unidos','Grindcore','2001');
insert into Bandas values (380,'Cripple Bastards','Itália',' Grindcore ','1988');
insert into Bandas values (381,'Dahmer','Canadá',' Grindcore ','1955');
insert into Bandas values (382,'Disrupt','Estados Unidos',' Grindcore','1987');
insert into Bandas values (383,'Dropdead','Estados Unidos',' Grindcore','1990');
insert into Bandas values (384,'Electro Hippies','1985',' Grindcore ','1985');
insert into Bandas values (385,'Exit-13','Estados Unidos',' Grindcore','1989');
insert into Bandas values (386,'Extreme Noise Terror','Reino Unido',' Grindcore ','1985');
insert into Bandas values (387,'F.U.B.A.R.','Países Baixos',' Grindcore ','2000');
insert into Bandas values (388,'Flattbush','Estados Unidos',' Grindcore','1993');
insert into Bandas values (389,'Fuck the Facts','Canadá',' Grindcore ','1997');
insert into Bandas values (390,'General Surgery','Suécia',' Grindcore ','1989');
insert into Bandas values (391,'Gore Beyond Necropsy','Japão',' Grindcore ','1989');
insert into Bandas values (392,'Gut','Alemanha',' Grindcore ','1991');
insert into Bandas values (393,'Hellnation','Estados Unidos',' Grindcore','1989');
insert into Bandas values (394,'Jig-Ai','Republica Checa',' Grindcore ','2004'); 
insert into Bandas values (395,'Kill the Client','Estados Unidos',' Grindcore','2002');
insert into Bandas values (396,'Lärm','Países Baixos',' Grindcore ','1982');
insert into Bandas values (397,'Leng Tche','Bélgica',' Grindcore ','2001');
insert into Bandas values (398,'The Locust','Estados Unidos',' Grindcore','1995');
insert into Bandas values (399,'Misery Index','Estados Unidos',' Grindcore','2001');
insert into Bandas values (401,'Napalm Death','Reino Unido',' Grindcore ','1981');
insert into Bandas values (402,'Nasum','Suécia',' Grindcore ','1992');
insert into Bandas values (403,'Necrobutcher','Brasil',' Grindcore ','1988');
insert into Bandas values (404,'Patareni','Cróacia',' Grindcore ','1996');
insert into Bandas values (405,'Pig Destroyer','Estados Unidos',' Grindcore','1997');
insert into Bandas values (406,'Regurgitate','Suécia',' Grindcore ','1990');
insert into Bandas values (407,'S.O.B.','Japão',' Grindcore ','1993');
insert into Bandas values (408,'Siege','Estados Unidos',' Grindcore','1983');
insert into Bandas values (409,'Skinless','Estados Unidos',' Grindcore','1992');
insert into Bandas values (410,'Soilent Green','Estados Unidos',' Grindcore','1988');
insert into Bandas values (411,'Subtera','Brasil',' Grindcore ','2000');
insert into Bandas values (412,'Terrorizer','Estados Unidos',' Grindcore','1987');
insert into Bandas values (413,'8stops7','Estados Unidos','Metal Alernativo','1998');
insert into Bandas values (414,'10 Years','Estados Unidos','Metal Alernativo','1999');
insert into Bandas values (415,'30 Seconds to Mars ','Estados Unidos','Metal Alernativo','2002');	
insert into Bandas values (416,'Alice in Chains','Estados Unidos','Metal Alernativo','1987');
insert into Bandas values (417,'Alien Ant Farm','Estados Unidos','Metal Alernativo','1995');
insert into Bandas values (418,'Allele','Estados Unidos','Metal Alernativo','2002');
insert into Bandas values (419,'Alter Bridge','Estados Unidos','Metal Alernativo','2004');
insert into Bandas values (420,'Audioslave','Estados Unidos','Metal Alernativo','2001');
insert into Bandas values (421,'A Perfect Circle','Estados Unidos','Metal Alernativo','1999');
insert into Bandas values (422,'Avenged Sevenfold','Estados Unidos','Metal Alernativo','1999');
insert into Bandas values (423,'Breaking Benjamin','Estados Unidos','Metal Alernativo','1998');
insert into Bandas values (424,'Chevelle','Estados Unidos','Metal Alernativo','1995');
insert into Bandas values (425,'CKY','Estados Unidos','Metal Alernativo','1998');
insert into Bandas values (426,'Cold','Estados Unidos','Metal Alernativo','1996');
insert into Bandas values (427,'Crossfade','Estados Unidos','Metal Alernativo','1999');
insert into Bandas values (428,'Dead by Sunrise','Estados Unidos','Metal Alernativo','2005');
insert into Bandas values (429,'Demon Hunter','Estados Unidos','Metal Alernativo','2000');
insert into Bandas values (430,'The Exies','Estados Unidos','Metal Alernativo','1997');
insert into Bandas values (431,'Fair to Midland','Estados Unidos','Metal Alernativo','1998');
insert into Bandas values (432,'Faith No More','Estados Unidos','Metal Alernativo','1981');
insert into Bandas values (433,'Filter','Estados Unidos','Metal Alernativo','1992');
insert into Bandas values (434,'Halestorm','Estados Unidos','Metal Alernativo','1997');
insert into Bandas values (435,'Hater','Estados Unidos','Metal Alernativo','1993');
insert into Bandas values (436,'Helmet','Estados Unidos','Metal Alernativo','1989');
insert into Bandas values (437,'Hurt','Estados Unidos','Metal Alernativo','2000');
insert into Bandas values (438,'In This Moment','Estados Unidos','Metal Alernativo','2005');
insert into Bandas values (439,'Jonah33','Estados Unidos','Metal Alernativo','2002');
insert into Bandas values (440,'Ministry','Estados Unidos','Metal Alernativo','1981');
insert into Bandas values (441,'My Ruin','Estados Unidos','Metal Alernativo','1999');
insert into Bandas values (442,'Orgy','Estados Unidos','Metal Alernativo','1997');
insert into Bandas values (443,'Puddle of Mudd','Estados Unidos','Metal Alernativo','1993');
insert into Bandas values (444,'Scars of Life','Estados Unidos','Metal Alernativo','2000');
insert into Bandas values (445,'Shinedown','Estados Unidos','Metal Alernativo','2001');
insert into Bandas values (446,'Skillet','Estados Unidos','Metal Alernativo','1996');
insert into Bandas values (447,'Soundgarden','Estados Unidos','Metal Alernativo','1984');
insert into Bandas values (448,'Stone Sour','Estados Unidos','Metal Alernativo','2006');
insert into Bandas values (449,'Systematic','Estados Unidos','Metal Alernativo','1966');
insert into Bandas values (450,'Tool','Estados Unidos','Metal Alernativo','1990');
insert into Bandas values (451,'Unsane','Estados Unidos','Metal Alernativo','1988');
insert into Bandas values (452,'Velvetcut','Filândia','Metal Alernativo','1999');
insert into Bandas values (453,'Nickelback','Canadá','Metal Alernativo','1995');
insert into Bandas values (454,'Crucified Barbara','Suécia','Metal Alernativo','1998');
insert into Bandas values (455,'DefRage','Estónia','Metal Alernativo','2007');
insert into Bandas values (456,'Die Happy','Alemanha','Metal Alernativo','1993');
insert into Bandas values (457,'Fruto Sagrado','Brasil','Metal Alernativo','1998');
insert into Bandas values (458,'HND','Estónia','Metal Alernativo','2006');
insert into Bandas values (459,'Lacuna Coil','Itália','Metal Alernativo','1994');
insert into Bandas values (460,'Milhouse','Brasil','Metal Alernativo','2006');
insert into Bandas values (461,'Rancore','Brasil','Metal Alernativo','2001');
insert into Bandas values (462,'Sick Puppies', 'Austrália ','Metal Alernativo','1997');
insert into Bandas values (463,'Steriogram', 'Austrália ','Metal Alernativo','1999');
insert into Bandas values (464,'Three Days Grace','Canadá','Metal Alernativo','1997');
insert into Bandas values (465,'Tihuana','Brasil','Metal Alernativo','1999');
insert into Bandas values (466,'Body Count','Estados Unidos','Rap Metal','1990');
insert into Bandas values (467,'Cypress Hill','Estados Unidos','Rap Metal','1988');
insert into Bandas values (468,'Dog Eat Dog','Estados Unidos','Rap Metal','1990');
insert into Bandas values (469,'East West','Estados Unidos','Rap Metal','1993');
insert into Bandas values (470,'Grade 8','Estados Unidos','Rap Metal','1996');
insert into Bandas values (471,'Kid Rock','Estados Unidos','Rap Metal','1991');
insert into Bandas values (472,'Rage Against the Machine','Estados Unidos','Rap Metal','1991');
insert into Bandas values (473,'Clawfinger','Suécia','Rap Metal','1981');
insert into Bandas values (474,'Panik','Alemanha','Rap Metal','2007');
insert into Bandas values (475,'2pu','Polônia','Nu Metal','2001');
insert into Bandas values (476,'2x','Chlie','Nu Metal','1994');
insert into Bandas values (477,'36 Crazyfists','Estados Unidos','Nu Metal','1994');
insert into Bandas values (478,'3rd Strike','Estados Unidos','Nu Metal','1995');
insert into Bandas values (479,'4Lyn','Alemanha','Nu Metal','1995');
insert into Bandas values (480,'A.N.I.M.A.L.','Argentina','Nu Metal','1992'); 
insert into Bandas values (481,'Adema','Estados Unidos','Nu Metal','2000');
insert into Bandas values (482,'American Head Charge','Estados Unidos','Nu Metal','1997');
insert into Bandas values (483,'Ametria','Polônia','Nu Metal','1993');
insert into Bandas values (484,'AqME','França','Nu Metal','1999');
insert into Bandas values (485,'Back-On','Japão','Nu Metal','2002');
insert into Bandas values (486,'Big Ass','Tailândia','Nu Metal','1997'); 
insert into Bandas values (487,'Black Light Burns','Estados Unidos','Nu Metal','1995');
insert into Bandas values (488,'Black Sonic','Liechtenstein','Nu Metal','2003');
insert into Bandas values (489,'Blindside','Suécia','Nu Metal','1994');
insert into Bandas values (490,'Blindspott','Nova Zelândia','Nu Metal','1997');
insert into Bandas values (491,'Brian "Head" Welch','Estados Unidos','Nu Metal','2008'); 
insert into Bandas values (492,'Cabezones','Argentina','Nu Metal','1994');
insert into Bandas values (493,'Candy ','Venezuela','Nu Metal','1998');
insert into Bandas values (494,'Carajo','Argentina','Nu Metal','2001'); 
insert into Bandas values (495,'Chimaira','Estados Unidos','Nu Metal','1998');
insert into Bandas values (496,'Choldra','Brasil','Nu Metal','2000');
insert into Bandas values (497,'Coal Chamber','Estados Unidos','Nu Metal','1994');
insert into Bandas values (498,'Coma','Romênia','Nu Metal','1999'); 
insert into Bandas values (499,'Crazy Town','Estados Unidos','Nu Metal','1995'); 
insert into Bandas values (501,'Crosscut','Alemanha','Nu Metal','1992');
insert into Bandas values (502,'D espairsRay','Japão','Nu Metal','1999');
insert into Bandas values (503,'Deftones','Estados Unidos','Nu Metal','1998');
insert into Bandas values (504,'Disturbed','Estados Unidos','Nu Metal','1996');
insert into Bandas values (505,'Dope','Estados Unidos','Nu Metal','1997');
insert into Bandas values (506,'Drowning Pool','Estados Unidos','Nu Metal','1996');
insert into Bandas values (507,'Dry Cell','Estados Unidos','Nu Metal','1998');
insert into Bandas values (508,'Dry Kill Logic','Estados Unidos','Nu Metal','1993');
insert into Bandas values (509,'Earshot','Estados Unidos','Nu Metal','1999'); 
insert into Bandas values (510,'Ektomorf','Hungria','Nu Metal','1994');
insert into Bandas values (511,'Element Eighty','Estados Unidos','Nu Metal','2000');
insert into Bandas values (512,'Emil Bulls','Alemanha','Nu Metal','1995');
insert into Bandas values (513,'Eths','França','Nu Metal','1999');
insert into Bandas values (514,'Evanescence','Estados Unidos','Nu Metal','1995');
insert into Bandas values (515,'Exilia','Itália','Nu Metal','1998');
insert into Bandas values (516,'Falling Up','Estados Unidos','Nu Metal','2002');
insert into Bandas values (517,'Flaw','Estados Unidos','Nu Metal','1995');
insert into Bandas values (518,'Flyleaf','Estados Unidos','Nu Metal','2000');
insert into Bandas values (519,'Flymore','Rússia','Nu Metal','2002'); 
insert into Bandas values (520,'Forever Never','Reino Unido','Nu Metal','2004');
insert into Bandas values (521,'FreakMind','Espanha','Nu Metal','2001'); 
insert into Bandas values (522,'Fyeld','Bulgária','Nu Metal','1998');
insert into Bandas values (523,'The Gazette','Japão','Nu Metal','2002'); 
insert into Bandas values (524,'Godsmack','Estados Unidos','Nu Metal','1995');
insert into Bandas values (525,'Grade','Estados Unidos','Nu Metal','1996');
insert into Bandas values (526,'Grinspoon','Austrália','Nu Metal','1995');
insert into Bandas values (527,'Guano Apes','Alemanha','Nu Metal','1994');
insert into Bandas values (528,'Head Phones President','Japão','Nu Metal','1999');
insert into Bandas values (529,'Headplate','Suécia','Nu Metal','1993');	
insert into Bandas values (530,'Hollywood Undead','Estados Unidos','Nu Metal','2005');
insert into Bandas values (531,'Ill Niño','Estados Unidos','Nu Metal','1998');
insert into Bandas values (532,'In Flames','Suécia','Nu Metal','1990');
insert into Bandas values (533,'Incubus','Estados Unidos','Nu Metal','1991');
insert into Bandas values (534,'Insolence','Estados Unidos','Nu Metal','1995');
insert into Bandas values (535,'iRAe','Argentina','Nu Metal','1997'); 
insert into Bandas values (536,'Jerk','Austrália','Nu Metal','1998');
insert into Bandas values (537,'Kittie','Cabadá','Nu Metal','1996');
insert into Bandas values (538,'Korn','Estados Unidos','Nu Metal','1993');
insert into Bandas values (539,'Libra','Chile','Nu Metal','2002');
insert into Bandas values (540,'Limp Bizkit','Estados Unidos','Nu Metal','1995');
insert into Bandas values (541,'Linea','Itália','Nu Metal','1993'); 
insert into Bandas values (542,'Linkin Park','Estados Unidos','Nu Metal','1996');
insert into Bandas values (543,'Lostprophets','Reino Unido','Nu Metal','1997');
insert into Bandas values (544,'Machine Head','Estados Unidos','Nu Metal','1992');
insert into Bandas values (545,'Maximum the Hormone','Japão','Nu Metal','1998');
insert into Bandas values (546,'Molotov','México','Nu Metal','1995');
insert into Bandas values (547,'Mudvayne','Estados Unidos','Nu Metal','1996');
insert into Bandas values (548,'Mushroomhead','Estados Unidos','Nu Metal','1993');
insert into Bandas values (549,'Mypollux','França','Nu Metal','2001');
insert into Bandas values (550,'Naio Ssaion','Eslovênia','Nu Metal','1999');
insert into Bandas values (551,'NdNo','Espanha','Nu Metal','1997');
insert into Bandas values (552,'Nonpoint','Estados Unidos','Nu Metal','1997');
insert into Bandas values (553,'Oblivion Dust','Japão','Nu Metal','1996'); 
insert into Bandas values (554,'One Minute Silence','Irlanda','Nu Metal','1995');
insert into Bandas values (555,'Otep','Estados Unidos','Nu Metal','2000'); 
insert into Bandas values (556,'P.O.D.','Estados Unidos','Nu Metal','1992');
insert into Bandas values (557,'Papa Roach','Estados Unidos','Nu Metal','1993');
insert into Bandas values (558,'Passenger','Suécia','Nu Metal','1995');
insert into Bandas values (559,'Pillar','Estados Unidos','Nu Metal','1998');
insert into Bandas values (560,'Pleymo','França','Nu Metal','1997');
insert into Bandas values (561,'Powerman','Estados Unidos','Nu Metal','1991');
insert into Bandas values (562,'Primer','Estados Unidos','Nu Metal','1997'); 
insert into Bandas values (563,'Project','Estados Unidos','Nu Metal','1996');
insert into Bandas values (564,'Puya','Porto Rico','Nu Metal','1988');
insert into Bandas values (565,'Qbo','México','Nu Metal','2001');
insert into Bandas values (566,'Red','Estados Unidos','Nu Metal','2004');
insert into Bandas values (567,'Rekiem','Chile','Nu Metal','1995');
insert into Bandas values (568,'Resorte','México','Nu Metal','1995');
insert into Bandas values (569,'Ribo','Chile','Nu Metal','2001');
insert into Bandas values (570,'Rodox','Brasil','Nu Metal','2002');
insert into Bandas values (571,'Saliva','Estados Unidos','Nu Metal','1996');
insert into Bandas values (572,'Seether','África do Sul','Nu Metal','1999');
insert into Bandas values (573,'Sevendust','Estados Unidos','Nu Metal','1994');
insert into Bandas values (574,'Skindred','Reino Unido','Nu Metal','1998');
insert into Bandas values (575,'Slapshock','Filipinas','Nu Metal','1997');
insert into Bandas values (576,'Slaves on Dope','Canadá','Nu Metal','1994');
insert into Bandas values (577,'Slipknot','Estados Unidos','Nu Metal','1995'); 
insert into Bandas values (578,'Slot','Rússia','Nu Metal','2002');
insert into Bandas values (579,'Snot','Estados Unidos','Nu Metal','1995');
insert into Bandas values (580,'Soulfly','Brasil','Nu Metal','1997');
insert into Bandas values (581,'SoundTrash','Espanha','Nu Metal','1999');
insert into Bandas values (582,'Spineshank','Estados Unidos','Nu Metal','1996');
insert into Bandas values (583,'Staind','Estados Unidos','Nu Metal','1995');
insert into Bandas values (584,'Static-X','Estados Unidos','Nu Metal','1997');
insert into Bandas values (585,'Sunk Loto','Austrália','Nu Metal','1997');
insert into Bandas values (586,'Superheist','Austrália','Nu Metal','1997');
insert into Bandas values (587,'System of a Down','Estados Unidos','Nu Metal','1994');
insert into Bandas values (588,'Taproot','Estados Unidos','Nu Metal','1997');
insert into Bandas values (589,'Thousand Foot Krutch','Canadá','Nu Metal','1997'); 
insert into Bandas values (590,'Tracktor Bowling','Rússia','Nu Metal','1996');
insert into Bandas values (591,'Trapt','Estados Unidos','Nu Metal','1997');
insert into Bandas values (592,'Tribal Ink','Suécia','Nu Metal','2002');
insert into Bandas values (593,'Trust Company','Estados Unidos','Nu Metal','1997');
insert into Bandas values (594,'Twelvestep','Suécia','Nu Metal','2004');
insert into Bandas values (595,'Twin Method','Reino Unido','Nu Metal','2003');
insert into Bandas values (596,'Unformal','Azerbaijão','Nu Metal','2000');
insert into Bandas values (597,'Xkrude','Espanha','Nu Metal','1997');
insert into Bandas values (598,'Yaksa','China','Nu Metal','1997');
insert into Bandas values (599,'100 Demons','Estados Unidos','Metalcore','2000');
insert into Bandas values (600,'25 ta Life','Estados Unidos','Metalcore','1991');
insert into Bandas values (601,'A Day to Remember','Estados Unidos','Metalcore','2003');
insert into Bandas values (602,'A Skylit Drive','Estados Unidos','Metalcore','2005');
insert into Bandas values (603,'Alesana','Estados Unidos','Metalcore','2004');
insert into Bandas values (604,'All Shall Perish','Estados Unidos','Metalcore','2002');
insert into Bandas values (605,'All That Remains','Estados Unidos','Metalcore','1998');
insert into Bandas values (606,'Atreyu','Estados Unidos','Metalcore','1998');
insert into Bandas values (607,'Attack Attack!','Estados Unidos','Metalcore','2007'); 
insert into Bandas values (608,'Between the Buried and Me','Estados Unidos','Metalcore','2000');
insert into Bandas values (609,'The Black Dahlia Murder','Estados Unidos','Metalcore','2000');
insert into Bandas values (610,'Black Veil Brides','Estados Unidos','Metalcore','2006');
insert into Bandas values (611,'Bleeding Through','Estados Unidos','Metalcore','1999');
insert into Bandas values (612,'Bloodlined Calligraphy','Estados Unidos','Metalcore','2002');
insert into Bandas values (613,'Burnt by the Sun','Estados Unidos','Metalcore','1999');
insert into Bandas values (614,'Bury Your Dead','Estados Unidos','Metalcore','2001');
insert into Bandas values (615,'Chelsea Grin','Estados Unidos','Metalcore/Deathcore','2007');
insert into Bandas values (616,'Coalesce','Estados Unidos','Metalcore','1994');
insert into Bandas values (617,'Converge','Estados Unidos','Metalcore','1990');
insert into Bandas values (618,'Darkest Hour','Estados Unidos','Metalcore','1995');
insert into Bandas values (619,'Drop Dead, Gorgeous ','Estados Unidos','Metalcore','2004');
insert into Bandas values (620,'Earth Crisis','Estados Unidos','Metalcore','1991');
insert into Bandas values (621,'Eighteen Visions','Estados Unidos','Metalcore','1995');
insert into Bandas values (622,'Emarosa','Estados Unidos','Metalcore','2006');
insert into Bandas values (623,'Death by Stereo','Estados Unidos','Metalcore','1996');
insert into Bandas values (624,'Escape the Fate','Estados Unidos','Metalcore','2004');
insert into Bandas values (625,'Evergreen Terrace','Estados Unidos','Metalcore','1999');
insert into Bandas values (626,'Every Time I Die','Estados Unidos','Metalcore','1998');
insert into Bandas values (627,'Eyes Set to Kill','Estados Unidos','Metalcore','2003');
insert into Bandas values (628,'From a Second Story Window','Estados Unidos','Metalcore','2002');
insert into Bandas values (629,'From Autumn to Ashes','Estados Unidos','Metalcore','2007');
insert into Bandas values (630,'God Forbid','Estados Unidos','Metalcore','1996');
insert into Bandas values (631,'Greeley Estates','Estados Unidos','Metalcore','2002');
insert into Bandas values (632,'Hatebreed','Estados Unidos','Hardcore','1993');
insert into Bandas values (633,'Horse the Band','Estados Unidos','Metalcore','1999');
insert into Bandas values (634,'Miss May I','Estados Unidos','Metalcore','2006');
insert into Bandas values (635,'Misery Signals','Estados Unidos','Metalcore','2002');
insert into Bandas values (636,'Motionless in White','Estados Unidos','Metalcore','2005');
insert into Bandas values (637,'Mutiny Within','Estados Unidos','Metalcore','2002');
insert into Bandas values (638,'A Plea for Purging','Estados Unidos','Metalcore','2006');
insert into Bandas values (639,'Poison the Well','Estados Unidos','Metalcore','1997');
insert into Bandas values (640,'Prayer for Cleansing','Estados Unidos','Metalcore','1996');
insert into Bandas values (641,'Still Remains','Estados Unidos','Metalcore','2002');
insert into Bandas values (642,'Swarm of the Lotus','Estados Unidos','Metalcore','1998');
insert into Bandas values (643,'Suicide Silence','Estados Unidos','Metalcore/Deathcore','2002');
insert into Bandas values (644,'Times of Grace','Estados Unidos','Metalcore','2010');
insert into Bandas values (645,'Trivium','Estados Unidos','Metalcore','2000');
insert into Bandas values (646,'Unearth','Estados Unidos','Metalcore','1998');
insert into Bandas values (647,'Walls of Jericho','Estados Unidos','Metalcore','1998');
insert into Bandas values (648,'We Came as Romans','Estados Unidos','Metalcore','2005');
insert into Bandas values (649,'Woe, Is Me','Estados Unidos','Metalcore','2009');
insert into Bandas values (650,'The Word Alive','Estados Unidos','Metalcore','2008');
insert into Bandas values (651,'The Agonist','Canadá','Metalcore','2004');
insert into Bandas values (652,'Buried Inside','Canadá','Metalcore','1997');
insert into Bandas values (653,'KEN Mode','Canadá','Metalcore','1999');
insert into Bandas values (654,'Blind Witness','Canadá','Metalcore','2005');
insert into Bandas values (655,'Parkway Drive', 'Austrália','Metalcore','2002'); 
insert into Bandas values (656,'I Killed The Prom Queen', 'Austrália','Metalcore','2000'); 
insert into Bandas values (657,'Architects','Reino Unido','Metalcore','2004');
insert into Bandas values (658,'Asking Alexandria','Reino Unido','Metalcore','2008');
insert into Bandas values (659,'Bring Me the Horizon','Reino Unido','Metalcore','2004');
insert into Bandas values (660,'Bullet for My Valentine','Reino Unido','Metalcore','1998');
insert into Bandas values (661,'Caliban', 'Alemanha','Metalcore','1997');
insert into Bandas values (662,'Heaven Shall Burn', 'Alemanha','Metalcore','1996');
insert into Bandas values (663,'Deadlock', 'Alemanha','Metalcore','1997');
insert into Bandas values (664,'Eminence', 'Brasil','Metalcore','1995');
insert into Bandas values (665,'Gloria', 'Brasil','Metalcore','2002');
insert into Bandas values (666,'Point of No Return', 'Brasil','Metalcore','2006');
insert into Bandas values (667,'Project46', 'Brasil','Metalcore','2010');
insert into Bandas values (668,'Burst', 'Suécia','Metalcore','1993');
insert into Bandas values (669,'Sarea', 'Suécia','Metalcore','2005');
insert into Bandas values (670,'Sonic Syndicate', 'Suécia','Metalcore','2002');
insert into Bandas values (671,'Ofensiva', 'Espanha','Metalcore','2004'); 
insert into Bandas values (672,'Pin Drop Violence', 'Índia','Metalcore','2000'); 
insert into Bandas values (673,'Deny', 'Argentina','Metalcore','2007');  
insert into Bandas values (674,'Hopes Die Last ','Itália','Metalcore','2004'); 
insert into Bandas values (675,'Amatory', 'Rússia','Metalcore','2001'); 
insert into Bandas values (676,'TwentyInchBurial', 'Portugal','Metalcore','2000'); 
insert into Bandas values (677,'As We Fight', 'Dinamarca','Metalcore','2001'); 
insert into Bandas values (678,'Mnemic','Dinamarca',' Metal industrial','2000');
insert into Bandas values (679,'American Head Charge','Estados Unidos',' Metal industrial','1997');
insert into Bandas values (680,'Bizarra Locomotiva','Portugal',' Metal industrial','1993');
insert into Bandas values (681,'Black Light Burns','Estados Unidos',' Metal industrial','2005'); 
insert into Bandas values (682,'Celldweller','Estados Unidos',' Metal industrial','1999');
insert into Bandas values (683,'Coming Soon','Letónia',' Metal industrial','2005');
insert into Bandas values (684,'Crossbreed','Estados Unidos',' Metal industrial','1996');
insert into Bandas values (685,'Dagoba','França',' Metal industrial','2000');
insert into Bandas values (686,'DespairsRay','Japão',' Metal industrial','1999');
insert into Bandas values (687,'Deadstar Assembly','Estados Unidos',' Metal industrial','2001');
insert into Bandas values (688,'Deathstats','Suécia',' Metal industrial','2001');
insert into Bandas values (689,'Dirge','França',' Metal industrial','1994');
insert into Bandas values (690,'Eisbrecher','Alemanha','Metal industrial','2003');
insert into Bandas values (691,'Emigrate','Alemanha',' Metal industrial','2005');
insert into Bandas values (692,'Filter','Estados Unidos','Metal industrial','1992'); 
insert into Bandas values (693,'Flymore','Rússia','Metal industrial','2002'); 
insert into Bandas values (694,'Godflesh','Reino Unido',' Metal industrial','1998');
insert into Bandas values (695,'Gothminister','Dinamarca',' Metal industrial','1999');
insert into Bandas values (696,'Hanzel und Gretyl','Estados Unidos',' Metal industrial','1993');
insert into Bandas values (697,'Jerk','Austrália',' Metal industrial','1998'); 
insert into Bandas values (698,'Kidneythieves','Estados Unidos',' Metal industrial','1998');
insert into Bandas values (699,'KMFDM','Alemanha',' Metal industrial','1984');
insert into Bandas values (700,'Caspian','Estados Unidos','Post-Metal','2003');
insert into Bandas values (701,'Dirge','França','Post-Metal','1994'); 
insert into Bandas values (702,'Godflesh','Reino Unido','Post-Metal','1998');
insert into Bandas values (703,'If These Trees Could Talk','Estados Unidos','Post-Metal','2006');
insert into Bandas values (704,'Indukti','Polónia','Post-Metal','1999');
insert into Bandas values (705,'Isis','Estados Unidos','Post-Metal','1997');
insert into Bandas values (706,'Jesu','Reino Unido','Post-Metal','2003');
insert into Bandas values (707,'Les Discrets','França','Post-Metal','2003');
insert into Bandas values (708,'Neurosis','estados Unidos','Post-Metal','1985');
insert into Bandas values (709,'The Ocean','Alemanha','Post-Metal','2000');
insert into Bandas values (710,'Whispering Forest','Estónia','Post-Metal','1995');
insert into Bandas values (711,'Amon Amarth','Suécia','Viking Metal','1992');
insert into Bandas values (712,'Ásmegin','Noruega','Viking Metal','1998');
insert into Bandas values (713,'Bathory','Suécia','Viking Metal','1983');
insert into Bandas values (714,'Black Messiah','Alemanha','Viking Metal','1992');
insert into Bandas values (715,'Einherjer','Noruega','Viking Metal','1993');
insert into Bandas values (716,'Ensiferum','Filândia','Viking Metal','1995');
insert into Bandas values (717,'Enslaved','Noruega','Viking Metal','1991');
insert into Bandas values (718,'Equilibrium','Alemanha','Viking Metal','2003');
insert into Bandas values (719,'Falkenbach','Alemanha','Viking Metal','1995');
insert into Bandas values (720,'Gwydion','Portugal','Viking Metal','1995');
insert into Bandas values (721,'Heidevolk','Guéldria','Viking Metal','2002');
insert into Bandas values (722,'Isengard','Noruega','Viking Metal','1989');
insert into Bandas values (723,'Månegarm','Suécia','Viking Metal','1995');
insert into Bandas values (724,'Moonsorrow','Filândia','Viking Metal','1995');
insert into Bandas values (725,'Myrkgrav','Noruega','Viking Metal','2003');
insert into Bandas values (726,'Otyg','Suécia','Viking Metal','1995');
insert into Bandas values (727,'Runic','Espanha','Viking Metal','2001');
insert into Bandas values (728,'Storm','Noruega','Viking Metal','1993');
insert into Bandas values (729,'Thrudvangar','Alemanha','Viking Metal','2003');
insert into Bandas values (730,'Thyrfing','Suécia','Viking Metal','1995');
insert into Bandas values (731,'Turisas','Filância','Viking Metal','1997');
insert into Bandas values (732,'Týr','Ilhas Faroé','Viking Metal','1998');
insert into Bandas values (733,'Vintersorg','Suécia','Viking Metal','1994');
insert into Bandas values (734,'Adagio','França','Metal Progressivo','2000');
insert into Bandas values (735,'Age of Silence','Noruega','Metal Progressivo','2004');
insert into Bandas values (736,'Alchemist','Austrália','Metal Progressivo','1991');
insert into Bandas values (737,'Aletheian','Estados Unidos','Metal Progressivo','1997');
insert into Bandas values (738,'Alla Polacca','Portugal','Metal Progressivo','2001');
insert into Bandas values (739,'Almah','Brasil','Metal Progressivo','2006');
insert into Bandas values (740,'Ambeon','Países Baixos','Metal Progressivo','2001');
insert into Bandas values (741,'Amorphis','Filândia','Metal Progressivo','1990');
insert into Bandas values (742,'Andromeda','Suécia','Metal Progressivo','1999');
insert into Bandas values (743,'Angra','Brasil','Metal Progressivo','1991');
insert into Bandas values (744,'Animals as Leaders','Estados Unidos','Metal Progressivo','2007');
insert into Bandas values (745,'Ansata','Brasil','Metal Progressivo','1997');
insert into Bandas values (746,'Arghon','Brasil','Metal Progressivo','2002');
insert into Bandas values (747,'ARK','Noruega','Metal Progressivo','2000');
insert into Bandas values (748,'Atheist','Estados Unidos','Metal Progressivo','1984');
insert into Bandas values (749,'Ayreon','Países Baixos','Metal Progressivo','1995');
insert into Bandas values (750,'Balkandji','Bulgária','Metal Progressivo','1999');
insert into Bandas values (751,'Behold... The Arctopus','Estados Unidos','Metal Progressivo','2002');
insert into Bandas values (752,'Between the Buried and Me','Estados Unidos','Metal Progressivo','2000');
insert into Bandas values (753,'Callenish Circle','Países Baixos','Metal Progressivo','1992');
insert into Bandas values (754,'Caravellus','Brasil','Metal Progressivo','2002');
insert into Bandas values (755,'Carbonized','Suécia','Metal Progressivo','1988');
insert into Bandas values (756,'Carnivora','Noruega','Metal Progressivo','1999');
insert into Bandas values (757,'Circle II Circle','Estados Unidos','Metal Progressivo','2001');
insert into Bandas values (758,'Circus Maximus','Noruega','Metal Progressivo','2000');
insert into Bandas values (759,'Control Denied','Estados Unidos','Metal Progressivo','1995');
insert into Bandas values (760,'Crimson Lotus','Filândia','Metal Progressivo','1997');
insert into Bandas values (761,'Cynic','Estados Unidos','Metal Progressivo','1987');
insert into Bandas values (762,'Disillusion','Alemanha','Metal Progressivo','1994');
insert into Bandas values (763,'Dream Theater','Estados Unidos','Metal Progressivo','1985');
insert into Bandas values (764,'Dir en grey','Japão','Metal Progressivo','1997');
insert into Bandas values (765,'Echoes of Eternity','Estados Unidos','Metal Progressivo','2005');
insert into Bandas values (766,'Edge of Sanity','Suécia','Metal Progressivo','1989');
insert into Bandas values (767,'Electro Quarterstaff','Canadá','Metal Progressivo','2001');
insert into Bandas values (768,'Elegy','Países Baixos','Metal Progressivo','1989');
insert into Bandas values (769,'Epica','Países Baixos','Metal Progressivo','2002');
insert into Bandas values (770,'Evergrey','Suécia','Metal Progressivo','1996');
insert into Bandas values (771,'Fates Warning','Estados Unidos','Metal Progressivo','1986');
insert into Bandas values (772,'Green Carnation','Noruega','Metal Progressivo','1990');
insert into Bandas values (773,'Guilt Machine','Países Baixos','Metal Progressivo','2009');
insert into Bandas values (774,'Gojira','França','Metal Progressivo','1996');
insert into Bandas values (775,'Hangar','Brasil','Metal Progressivo','1997');
insert into Bandas values (776,'Indukti','Polónia','Metal Progressivo','1999');
insert into Bandas values (777,'Ingray','Estados Unidos','Metal Progressivo','1996');
insert into Bandas values (778,'Isis','Estados Unidos','Metal Progressivo','1997');
insert into Bandas values (779,'Ivory Gates','Brasil','Metal Progressivo','2002');
insert into Bandas values (780,'Kamelot','Estados Unidos','Metal Progressivo','1991');
insert into Bandas values (781,'Liquid Tension Experiment','Estados Unidos','Metal Progressivo','1998');
insert into Bandas values (782,'Lost Forever','Brasil','Metal Progressivo','1997');
insert into Bandas values (783,'Magician','Brasil','Metal Progressivo','2000');
insert into Bandas values (784,'Magnitude 9','Estados Unidos','Metal Progressivo','1997');
insert into Bandas values (785,'Mastodon','Estados Unidos','Metal Progressivo','1999');
insert into Bandas values (786,'Meshuggah','Suécia','Metal Progressivo','1987');
insert into Bandas values (787,'Mindflow','Brasil','Metal Progressivo','2003');
insert into Bandas values (788,'The Minibosses','Estados Unidos','Metal Progressivo','2000');
insert into Bandas values (789,'Mnemic','Dinamarca','Metal Progressivo','1998');
insert into Bandas values (790,'Morbidick','Portugal','Metal Progressivo','1994');
insert into Bandas values (791,'MullMuzzler','Estados Unidos','Metal Progressivo','1999');
insert into Bandas values (792,'Myrath','Tunísia','Metal Progressivo','2001');
insert into Bandas values (793,'Naamah','Polónia','Metal Progressivo','1996');
insert into Bandas values (794,'Neblina','Angola','Metal Progressivo','2000'); 
insert into Bandas values (795,'Nevermore','Estados Unidos','Metal Progressivo','1991');
insert into Bandas values (796,'Nightingale','Suécia','Metal Progressivo','1995');
insert into Bandas values (797,'Opeth','Suécia','Metal Progressivo','1990');
insert into Bandas values (798,'Orphaned Land','Israel','Metal Progressivo','1991');
insert into Bandas values (799,'OSI','Estados Unidos','Metal Progressivo','2003');
insert into Bandas values (801,'Oficina G3','Brasil','Metal Progressivo','1987');
insert into Bandas values (802,'Pagans Mind','Noruega','Metal Progressivo','2000');
insert into Bandas values (803,'Pain of Salvation','Suécia','Metal Progressivo','1991');
insert into Bandas values (804,'Pan.Thy.Monium','Suécia','Metal Progressivo','1996');
insert into Bandas values (805,'Planet X','Estados Unidos','Metal Progressivo','1999');
insert into Bandas values (806,'Power of Omens','Estados Unidos','Metal Progressivo','1994');
insert into Bandas values (807,'Protest the Hero','Canadá','Metal Progressivo','1999');
insert into Bandas values (808,'Prototype','Estados Unidos','Metal Progressivo','1994');
insert into Bandas values (809,'Queensrÿche','Estados Unidos','Metal Progressivo','1981');
insert into Bandas values (811,'Querubes','Paraguai','Metal Progressivo','2010');
insert into Bandas values (812,'Qutin','Irã','Metal Progressivo','2002');
insert into Bandas values (813,'Red Harvest','Noruega','Metal Progressivo','2002');
insert into Bandas values (814,'Redemption','Estados Unidos','Metal Progressivo','2000');
insert into Bandas values (815,'Reigngold','Suécia','Metal Progressivo','1991');
insert into Bandas values (816,'Riverside','Polónia','Metal Progressivo','2001');
insert into Bandas values (817,'Royal Hunt','Dinamarca','Metal Progressivo','1989');
insert into Bandas values (818,'Salim Ghazi Saeedi','Irã','Metal Progressivo','1981');
insert into Bandas values (819,'Savatage','Estados Unidos','Metal Progressivo','1979');
insert into Bandas values (820,'Secret Sphere','Itália','Metal Progressivo','1997');
insert into Bandas values (821,'Shadow Gallery','Estados Unidos','Metal Progressivo','1988');
insert into Bandas values (822,'SikTh','Reino Unido','Metal Progressivo','2001');
insert into Bandas values (823,'Star One','Países Baixos','Metal Progressivo','2002');
insert into Bandas values (824,'Stream of Passion','Países Baixos','Metal Progressivo','2005');
insert into Bandas values (825,'Sun Caged','Países Baixos','Metal Progressivo','1999');
insert into Bandas values (826,'Superior','Alemanha','Metal Progressivo','1988');
insert into Bandas values (827,'Symphony X','Estados Unidos','Metal Progressivo','1994');
insert into Bandas values (828,'Tang Dynasty','China','Metal Progressivo','2008');
insert into Bandas values (829,'ThanatoSchizO','Portugal','Metal Progressivo','1997');
insert into Bandas values (830,'Threshold','Reino Unido','Metal Progressivo','1988');
insert into Bandas values (831,'Theocracy','Estados Unidos','Metal Progressivo','2002');
insert into Bandas values (832,'Time Machine','Itália','Metal Progressivo','1992');
insert into Bandas values (833,'Tool','Estados Unidos','Metal Progressivo','1990'); 
insert into Bandas values (834,'Tourniquet','Estados Unidos','Metal Progressivo','1989');
insert into Bandas values (835,'Voivod','Canadá','Metal Progressivo','1981');
insert into Bandas values (836,'Warmen','Filândia','Metal Progressivo','2000');
insert into Bandas values (837,'Watchtower','Estados Unidos','Metal Progressivo','1982');
insert into Bandas values (838,'Winds','Noruega','Metal Progressivo','1998');
insert into Bandas values (839,'Without Face','Hungria','Metal Progressivo','1997');
insert into Bandas values (840,'Xystus','Países Baixos','Metal Progressivo','1999');
insert into Bandas values (841,'Aesma Daeva','Estados Unidos','Metal sinfônico','1998');
insert into Bandas values (842,'After Forever','Países Baixos', 'Metal sinfônico','1995');
insert into Bandas values (843,'Almora','Turquia','Metal sinfônico','2001');
insert into Bandas values (844,'Andre Matos','Brasil','Metal sinfônico','2006');
insert into Bandas values (845,'Apocalyptica','Filândia','Metal sinfônico','1993');
insert into Bandas values (846,'Atargatis','Alemanha','Metal sinfônico','1997');	
insert into Bandas values (847,'Autumn','Países Baixos','Metal sinfônico','1995');
insert into Bandas values (848,'Delain','Países Baixos','Metal sinfônico','2002');
insert into Bandas values (849,'Coronatus','Alemanha','Metal sinfônico','2007');
insert into Bandas values (850,'Divinefire','Filândia/Suécia','Metal sinfônico cristã','2004');
insert into Bandas values (851,'Epica','Países Baixos','Metal sinfônico','2002');
insert into Bandas values (852,'Galneryus','Japão','Metal sinfônico','2001');
insert into Bandas values (853,'HB','Filândia','Metal sinfônico Cristã','2002');
insert into Bandas values (854,'Imperia','Países Baixos','Metal sinfônico','2003');
insert into Bandas values (855,'Leaves Eyes','Alemanha/Noruega','Metal sinfônico','2003');
insert into Bandas values (856,'Mägo de Oz','Espanha','Metal sinfônico','1989');
insert into Bandas values (857,'Midnattsol','Alemanha/Noruega','Metal sinfônico','2003');
insert into Bandas values (858,'Moi dix Mois','Japão','Metal sinfônico','2002'); 
insert into Bandas values (859,'Rain Fell Within','Estados Unidos', 'Metal sinfônico','1996');
insert into Bandas values (860,'Rage','Alemanha','Metal sinfônico','1984');
insert into Bandas values (861,'ReVamp','Países Baixos','Metal sinfônico','2009');
insert into Bandas values (862,'Secret Sphere','Itália','Metal sinfônico','1997');
insert into Bandas values (863,'Sirenia', 'Noruega','Metal sinfônico','2001');
insert into Bandas values (864,'Therion', 'Suécia','Metal sinfônico','1987');
insert into Bandas values (865,'Tarja Turunen', 'Filândia','Metal sinfônico','1996');
insert into Bandas values (866,'Stream of Passion','Países Baixos','Metal sinfônico','2005');
insert into Bandas values (867,'Within Temptation','Países Baixos','Metal sinfônico','1996');
insert into Bandas values (868,'Waltari','Filândia','Avant-garde metal sinfônico','1986');
insert into Bandas values (869,'Living Sacrifice','Estados Unidos','Metalcore Cristão','1989'); 
insert into Bandas values (870,'War of Ages','Estados Unidos','Metalcore Cristão','2002'); 
insert into Bandas values (871,'Underoath','Estados Unidos','Metal Cristão','1993'); 
insert into Bandas values (872,'Zao','Estados Unidos','Metal Cristão','1993'); 
insert into Bandas values (873,'Sinai Beach','Estados Unidos','Metal Cristão','2000'); 
insert into Bandas values (874,'Oh, Sleeper','Estados Unidos','Metal Cristão','2006'); 
insert into Bandas values (875,'Norma Jean','Estados Unidos','Metal Cristão','1997'); 
insert into Bandas values (876,'Maylene and the Sons of Disaster','Estados Unidos','Metal Cristão','2004'); 
insert into Bandas values (877,'Memphis May Fire','Estados Unidos','Metal Cristão','2006'); 
insert into Bandas values (878,'Killswitch Engage','Estados Unidos','Metalcore Cristão','1999'); 
insert into Bandas values (879,'Haste the Day','Estados Unidos','Metal Cristão','2001'); 
insert into Bandas values (880,'Demon Hunter','Estados Unidos','Metal Cristão','2000'); 
insert into Bandas values (881,'The Devil Wears Prada','Estados Unidos','Metal Cristão','2005'); 
insert into Bandas values (882,'As I Lay Dying','Estados Unidos','Metal Cristão','2000'); 
insert into Bandas values (883,'Blessthefall','Estados Unidos','Metal Cristão','2003'); 
insert into Bandas values (884,'The Chariot','Estados Unidos','Metal Cristão','2003'); 
insert into Bandas values (885,'Becoming the Archetype','Estados Unidos','Metal Cristão','1999'); 
insert into Bandas values (886,'August Burns Red','Estados Unidos','Metal Cristão','2003'); 
insert into Bandas values (887,'Figure Four','Estados Unidos','Metal Cristão','1994'); 
insert into Bandas values (888,'Oficina G3','Estados Unidos','Metal Cristão','1987'); 
insert into Bandas values (889,'xDEATHSTARx ','Estados Unidos','Metal Cristão','2002'); 
insert into Bandas values (890,'Knorkator','Alemanha',' Metal industrial','1994');
insert into Bandas values (891,'The Kovenant','Noruega',' Metal industrial','1992');
insert into Bandas values (892,'L Âme Immortelle','Áustria',' Metal industrial','1996');
insert into Bandas values (893,'Lard','Estados Unidos',' Metal industrial','1998');
insert into Bandas values (894,'Machinae Supremacy','Suécia',' Metal industrial','2000');
insert into Bandas values (895,'Maldita','Brasil',' Metal industrial','2001');
insert into Bandas values (896,'Marilyn Manson','Estados Unidos',' Metal industrial','1989');
insert into Bandas values (897,'Megaherz','Alemanha',' Metal industrial','1993');
insert into Bandas values (898,'Ministry','Estados Unidos',' Metal industrial','1981'); 
insert into Bandas values (899,'The Mist','Brasil',' Metal industrial','1986');
insert into Bandas values (900,'Moi Dix Mois','Japão',' Metal industrial','2002');
insert into Bandas values (901,'Nine Inch Nails','Estados Unidos',' Metal industrial','1988');
insert into Bandas values (902,'No-Big-Silence','Estónia',' Metal industrial','1989');
insert into Bandas values (903,'Oomph!','Alemanha',' Metal industrial','1989');
insert into Bandas values (904,'Orgy','Estados Unidos',' Metal industrial','1997'); 
insert into Bandas values (905,'Pain','Suécia',' Metal industrial','1997');
insert into Bandas values (906,'Pitchshifter','Reino Unido',' Metal industrial','1989');
insert into Bandas values (907,'Prong','Estados Unidos',' Metal industrial','1986');
insert into Bandas values (908,'Rammstein','Alemanha',' Metal industrial','1994');
insert into Bandas values (909,'Rob Zombie','Estados Unidos',' Metal industrial','1985');
insert into Bandas values (910,'Ruoska','Finlância',' Metal industrial','2002');
insert into Bandas values (911,'Samael','Suiça',' Metal industrial','1987');
insert into Bandas values (912,'Scorn ','Reino Unido',' Metal industrial','1991');
insert into Bandas values (913,'Strapping Young Lad','Canadá',' Metal industrial','1994');
insert into Bandas values (914,'Tronn','Brasil',' Metal industrial','1999');
insert into Bandas values (915,'Old Man s Child ','Noruega ','black metal',1993);
insert into Bandas values (916,'Primordial',' Irlanda','black metal', 1987);
insert into Bandas values (917,'Rotting Christ', ' Grécia' ,'black metal',1987);
insert into Bandas values (918,'Salem ','Israel ','black metal',1985);
insert into Bandas values (919,'Sarcófago',' Brasil ','black metal',1985);
insert into Bandas values (920,'Satyricon',' Noruega','Black Metal', 1991);
insert into Bandas values (921,'Samael ','suíça ','black metal',1987);
insert into Bandas values (922,'Setherial ','Suécia ','black metal',1994);
insert into Bandas values (923,'Skyfire',' Suécia','black metal', 1995);
insert into Bandas values (924,'Skyforger ','Letônia ','black metal',1995);
insert into Bandas values (925,'Susperia',' Noruega ','black metal',1995);
insert into Bandas values (926,'Thyrfing ','Suécia ','black metal',1995);
insert into Bandas values (927,'Tormentor',' Hungria','black metal', 1986);
insert into Bandas values (928,'Triptykon',' suíça','black metal', 2008);
insert into Bandas values (929,'Ulver ','Noruega ','black metal',1993);
insert into Bandas values (930,'Unearthly',' Brasil ','black metal',1998);
insert into Bandas values (931,'Venom',' reino unido','black metal', 1979);
insert into Bandas values (932,'Vintersorg ','Suécia ','black metal',1994);
insert into Bandas values (933,'Vreid',' Noruega ','black metal',2004);
insert into Bandas values (934,'Vulcano ','basil' ,'black metal',1981);
insert into Bandas values (935,'Watain',' Suécia','black metal', 1998);
insert into Bandas values (936,'Windir',' Noruega' ,'black metal',1994);
insert into Bandas values (937,'Xasthur',' EUA','black metal', 1995 );
insert into Bandas values (938,'Zyklon','Noruega','black metal', 1998);
insert into Bandas values (939,'Abaddon Incarnate',' Irlanda','death metal', 1994);
insert into Bandas values (940,'Abscess','EUA ','death metal',1994);
insert into Bandas values (941,'Amputated Genitals ','Colômbia','death metal', 2003);
insert into Bandas values (942,'Alchemist ','Austrália','death metal', 1987);
insert into Bandas values (943,'Altar',' países baixos','death metal', 1990);
insert into Bandas values (944,'Amorphis ','Finlândia ','death metal',1990);
insert into Bandas values (945,'Anal Blast',' EUA','death metal', 1994);
insert into Bandas values (946,'As Blood Runs Black',' eua ','death metal',2004);
insert into Bandas values (947,'Asesino',' México','death metal', 2002);
insert into Bandas values (948,'At the Gates',' Suécia','death metal', 1990);
insert into Bandas values (949,'Atrocity',' Alemanha ','death metal',1988);
insert into Bandas values (950,'Azarath',' polônia','death metal', 1988);
insert into Bandas values (951,'Becoming the Archetype',' EUA ','death metal',1999);
insert into Bandas values (952,'Behemoth',' polônia','death metal', 1991);
insert into Bandas values (953,'Bloodbath',' suecia ','death metal',1999);
insert into Bandas values (954,'Blood Stain Child',' Japão','death metal', 2000);
insert into Bandas values (955,'Bolt Thrower ','reino unido','death metal', 1986);
insert into Bandas values (956,'Brujeria','México','death metal', 1989);
insert into Bandas values (957,'Callenish Circle',' países baixos','detah metal', 1992);
insert into Bandas values (958,'Cancer',' reino unido','death metal', 1987);
insert into Bandas values (959,'Cannibal Corpse',' EUA ','death metal',1998);
insert into Bandas values (960,'Carcass','reino unido','death metal', 1985);
insert into Bandas values (961,'Carnal Forge ','suecia','death metal', 1997);
insert into Bandas values (962,'Children of Bodom',' Finlândia ','death metal',1993);
insert into Bandas values (963,'Criminal',' Chile ','death metal',1991);
insert into Bandas values (964,'Claustrofobia',' Brasil ','death metal',1994);
insert into Bandas values (965,'Consolation ','países baixos','death metal', 1989);
insert into Bandas values (966,'Crematory',' Alemanha ','death metal',1991);
insert into Bandas values (967,'Crionics',' polônia','death metal', 1997);
insert into Bandas values (978,'Cryptopsy',' Canadá', 'death metal',1992);
insert into Bandas values (979,'Dahmer ','Canadá','death metal', 1995);
insert into Bandas values (980,'Dauntless ','Finlândia','death metal', 1991);
insert into Bandas values (981,'Deceased ','EUA ','death metal',1984);
insert into Bandas values (982,'Deicide',' EUA' ,'death metal',1987);
insert into Bandas values (983,'Demilich',' Finlândia ','death metal',1990);
insert into Bandas values (984,'Demilich',' Finlândia','death metal', 1990);
insert into Bandas values (985,'Demonoid',' suecia','death metal', 2002);
insert into Bandas values (986,'Dethklok', 'Eua','death metal', 2006);
insert into Bandas values (987,'Dies Irae',' polônia','death metal', 1992);
insert into Bandas values (988,'Disarmonia Mundi',' Itália','death metal', 2000);
insert into Bandas values (989,'Disembowelment',' Austrália ','death metal',1989);
insert into Bandas values (990,'Disgrace and Terror',' Brasil ','death metal',2001);
insert into Bandas values (991,'Disillusion',' Alemanha ','death metal',1994);
insert into Bandas values (992,'Edge of Sanity',' suecia','death metal', 1989);
insert into Bandas values (993,'Eternal Tears of Sorrow',' Finlândia','death metal', 1994);
insert into Bandas values (994,'Extreme Noise Terror',' reino unido','death metal', 1985);
insert into Bandas values (995,'Fleshcrawl',' Alemanha','death metal', 1987);
insert into Bandas values (996,'From a Second Story Window ','EUA','death metal', 2002);
insert into Bandas values (997,'Fuck the Facts ','Canadá','death metal', 1997);
insert into Bandas values (998,'The Gathering',' países baixos ','death metal',1989);
insert into Bandas values (999,'Glass Casket',' EUA ','death metal',2001);
insert into Bandas values (1000,'God Macabre',' suecia ','death metal',1988);
insert into Bandas values (1001,'Gorgasm',' EUA','death metal', 1994);
insert into Bandas values (1002,'Haggard', 'Alemanha ','detah metal',1991);
insert into Bandas values (1003,'Hate',' polônia ','death metal',1990);
insert into Bandas values (1004,'Headhunter D.C. ','Brasil ','death metal',1997);
insert into Bandas values (1005,'Immolation',' EUA ','death metal',1988);
insert into Bandas values (1006,'Impious',' suecia ','death metal',1994);
insert into Bandas values (1007,'Inmemorial ','peru','death metal', 1993);
insert into Bandas values (1008,'Izegrim',' países baixos','death metal', 1996);
insert into Bandas values (1009,'Job for a Cowboy','eua','death metal',2003);
insert into Bandas values (1010,'Kalmah ','Finlândia','death metal', 1999);
insert into Bandas values (1011,'Kimaera ','Líbano ','death metal',2000);
insert into Bandas values (1012,'Krisiun',' Brasil','death metal', 1990);
insert into Bandas values (1013,'Liers in Wait',' suecia ','death metal',1990);
insert into Bandas values (1014,'Lost Soul',' polonia ','death metal',1991);
insert into Bandas values (1015,'Melechesh',' palestina','death metal', 1993);
insert into Bandas values (1016,'Murder Squad ','suecia','death metal', 1993);
insert into Bandas values (1017,'Nahemah ','Espanha ','death metal',1997);
insert into Bandas values (1018,'NEFormat',' Cazaquistão','death metal', 2003);
insert into Bandas values (1019,'obskure','brasil','death metal',1989);
insert into Bandas values (1020,'Aeternitas','alemanha','Gothici1 Metal',1999);
insert into Bandas values (1021,'charon','finlandia','gothic metal',1992);
insert into Bandas values (1022,'deligth','polonia','gothic metal',1997);
insert into Bandas values (1023,'Flowing Tears','alemanha','gothic metal',1994);
insert into Bandas values (1024,'Malice Mizer','japao','gothic metal',1992);
insert into Bandas values (1025,'Naamah','polonia','gothic metal',1996);
insert into Bandas values (1026,'Of The Archaengel','brasil','gothic metal',1992);
insert into Bandas values (1027,'penumbra','franca','gothic metal',1996);
insert into Bandas values (1028,'Reflexion','polonia','Gothic Metal',1997);
insert into Bandas values (1029,'sirenia','noruega','gothic metal',2001);
insert into Bandas values (1030,'The Wounded','paixes baixos','gothic metal',1998);
insert into Bandas values (1031,'UnSun','polonia','gothic metal',1998);
insert into Bandas values (1032,'vampiria','argentina','gothic metal',1997);
insert into Bandas values (1033,'agent steel','Eua','speed metal',1994);
insert into Bandas values (1034,'black tide','Eua','speed metal',2004);
insert into Bandas values (1035,'chome division','noruega','speed metal',2004);
insert into Bandas values (1036,'Exciter','canada','speed metal',1978);
insert into Bandas values (1037,'Galneryus','japao','speed metal',2001);
insert into Bandas values (1038,'Hibria','brasil','speed metal',1996);
insert into Bandas values (1039,'Iron Fire','dineamrca','speed metal',1995);
insert into Bandas values (1040,'Judas Priest','reino unido','speed metal',1969);
insert into Bandas values (1041,'King Diamond','dinemarca','speed metal',1979);
insert into Bandas values (1042,'Motörhead','reino unido','speed metal',1975);
insert into Bandas values (1043,'Paradox','alemanha','speed metal',1986);
insert into Bandas values (1044,'Razor','canada','speed metal',1983);
insert into Bandas values (1045,'Acid Drinkers','polonia','trash metal',1986);
insert into Bandas values (1046,'Black Tide','eua','trash metal',2004);
insert into Bandas values (1047,'Cavalera Conspiracy','eua','trash metal',2007);
insert into Bandas values (1048,'Turmion Kätilöt','Finlândia',' Metal industrial','2003');
insert into Bandas values (1049,'Undercover Slut','França',' Metal Industrial','2000');
insert into Bandas values (1050,'White Zombie','Estados Unidos',' Metal industrial','1985');
insert into Bandas values (1051,'Zeromancer','Noruega',' Metal industrial','1999');
insert into Bandas values (1052,'Die Krupps','Alemanha',' Post-Metal','1980');
--						 -----------------------------------------------------
-- 						 -------------------- Dados Premio -----------------
--						 ---------------------------------------------------
insert into Premiacao values(1,'Billboard music awards',1,5);
insert into Premiacao values(2,'ECHO Awards',4,108);
insert into Premiacao values(3,'Kerrang!Awards',5,150);
insert into Premiacao values(4,'MTV Music Awards',12,542);
insert into Premiacao values(5,'MTV Music Awards',12,12);
insert into Premiacao values(6,'Metal Hammer Golden God Awards',1,611);
insert into Premiacao values(7,'Metal Hammer Golden God Awards',1,211);
insert into Premiacao values(8,'Metal Hammer Golden God Awards',1,658);
insert into Premiacao values(9,'Metal Hammer Golden God Awards',1,774);
insert into Premiacao values(10,'Metal Hammer Golden God Awards',1,448);
insert into Premiacao values(11,'Metal Hammer Golden God Awards',1,30);
insert into Premiacao values(12,'Metal Hammer Golden God Awards',1,253);
insert into Premiacao values(13,'Metal Hammer Golden God Awards',1,10);
insert into Premiacao values(14,'Metal Hammer Golden God Awards',1,87);
insert into Premiacao values(15,'Metal Hammer Golden God Awards',1,91);
insert into Premiacao values(16,'Revolver Golden Gods Awards',3,422);
insert into Premiacao values(17,'Revolver Golden Gods Awards',2,65);
insert into Premiacao values(18,'Revolver Golden Gods Awards',2,909);
insert into Premiacao values(19,'Revolver Golden Gods Awards',3,47);
--						 -----------------------------------------------------
-- 						 -------------------- Dados Riffs -----------------
--						 ---------------------------------------------------
insert into melhores_riffs(posicao,Musica) values (1,'Stairway To Heaven');
insert into melhores_riffs(posicao,Musica) values (2,' Master of Puppets'); 
insert into melhores_riffs(posicao,Musica) values (3,'Crazy Train');  
insert into melhores_riffs(posicao,Musica) values (4,'Raining Blood'); 
insert into melhores_riffs(posicao,Musica) values (5,'Number of the Beast');
--						 -----------------------------------------------------
-- 						 -------------------- Fornecedor -----------------
--						 ---------------------------------------------------
insert into Fornecedor values (1,'ForMidia','52',15);
insert into Fornecedor values (2,'Novo Milênio',1852,18.90);
insert into Fornecedor values (3,'Tecnomidia','575',12.58);
insert into Fornecedor values (4,'Discmidia','852',16.33);
insert into Fornecedor values (5,'VM2','2052',18.00);

--						 -----------------------------------------------------
-- 						 -------------------- Estoque -----------------
--						 ---------------------------------------------------
insert into Estoque values (1,'20',1);
insert into Estoque values (2,'562',2);
insert into Estoque values (3,'0',3);
insert into Estoque values (4,'400',4);
insert into Estoque values (5,'365',5);
--						 -----------------------------------------------------
-- 						 -------------------- Melhores_albuns -----------------
--						 ---------------------------------------------------
insert into  melhores_albuns Values (1,'Master of Puppets',1986,2,108);
insert into  melhores_albuns Values (2,'The Number of the Beast',1982,5,87);
insert into  melhores_albuns Values (3,'Blizzard of Ozz',1980,3,122);
insert into  melhores_albuns Values (4,'Reign in Blood',1986,4,157);
insert into  melhores_albuns Values (5,'Led Zeppelin II',1969,1,97);
--						 -----------------------------------------------------
-- 						 -------------------- Vendedor -----------------
--						 ---------------------------------------------------
insert into vendedor values (1,'Athauan Marques',468001-6,3.75,785); 
insert into vendedor values (2,'Mirrelli Cifarelli',488001-7,1.25,330); 

--						 -----------------------------------------------------
-- 						 -------------------- Venda_Cd -----------------
--						 ---------------------------------------------------
insert into Venda_CD values (1,30.23,'Universal Music',1,1,5);
insert into Venda_CD values (2,29.67,'Disney Music Group',2,2,1);
insert into Venda_CD values (3,68.25,'Sony Music',2,2,2);
insert into Venda_CD values (4,32.33,'Roadrunner Records',1,1,3);
insert into Venda_CD values (5,18.03,'Nuclear Records',2,2,4);
insert into Venda_CD values (6,28.33,'EMI',1,2,5);
insert into Venda_CD values (7,58.90,'Warner Music Group',2,1,3);




/*
  `idfornecedor` INT NOT NULL,
  `empresa` VARCHAR(45) NULL,
  `qts_cd_fornecedor` VARCHAR(45) NULL,
  `valor_de_custo` FLOAT NULL,

*/

-- consultas


