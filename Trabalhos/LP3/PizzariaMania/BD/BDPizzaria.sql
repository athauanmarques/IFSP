-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: pizzaria
-- ------------------------------------------------------
-- Server version	5.5.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `acessos`
--
-- drop database pizzaria;
create database if not exists pizzaria;

use pizzaria;
DROP TABLE IF EXISTS `acessos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acessos` (
  `idAcessos` int(11) NOT NULL AUTO_INCREMENT,
  `acessos` varchar(300) NOT NULL,
  PRIMARY KEY (`idAcessos`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acessos`
--

LOCK TABLES `acessos` WRITE;
/*!40000 ALTER TABLE `acessos` DISABLE KEYS */;
INSERT INTO `acessos` VALUES (1,'Nome da Conta: Athauan | Tipo de Acesso: Administrado | Maquina: NOTE-ADS | Data: 15/11/2015'),(2,'Nome da Conta: Athauan | Tipo de Acesso: Administrador | Maquina: NOTE-ADS | Data:18 / 11 / 2015 | ');
/*!40000 ALTER TABLE `acessos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `idClientes` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `endereco` varchar(60) DEFAULT 'endereço não declarado',
  `telefone` varchar(15) DEFAULT NULL,
  `cidade` varchar(45) NOT NULL,
  `uf` varchar(2) DEFAULT NULL,
  `referencias` varchar(280) DEFAULT 'referencias não declarado',
  PRIMARY KEY (`idClientes`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'Caroline Martis de Oliveira','Rua Jatobá Campos, 2958','9658-7412','Bragança Paulista','SP','Centro'),(2,'Pâmela Souza Arno Espinhelle','Avenida Joana Cunha','9223-38574','São Paulo','SP','Perto em uma escola'),(3,'Kakarotto Son Goku  ','Avenida Saiyajin 3 ','8754-2356','Tokio','TK','Centro'),(4,'Stieg Larsson','Rua Khapit','3258-7412','Kiev','KV','Parque Nacional'),(5,'James \"James\" Bond','Rua Margaret Thatcher o terror da esquerda','1025-9687','Londres','LD','Em casa'),(6,'Floretina Floretina de Jesus','Avenida não sei se tu me amas','73447446','Sempre me seduz','SP','Centro'),(7,'Bruna de Carvalho','Rua General Raul Ferreira, 857','8877-7571','Bragança Paulista','SP','Centro'),(8,'Caio Castro Carvalho','Avenida Liberdade','2036-8741','Atibaia','SP','Escola'),(9,'Joana Alvez Souza  ','Avenida Paz e Luta','875-3001','Campinas','SP','São José'),(10,'Jason Mike','Rua do sabão','8700-0025','Campo Grande','RS','Mar Azul'),(11,'Ana Cristina de Jesus','Rua Jorge Poeta','1025-9687','Londres','BA','Em casa'),(12,'Usura Hanna Minaki','Avenida ocidental','2020-3685','Bragança','RS','Centro');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes_has_usuario`
--

DROP TABLE IF EXISTS `clientes_has_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes_has_usuario` (
  `clientes_idClientes` int(11) NOT NULL,
  `usuario_idUsuario` int(11) NOT NULL,
  PRIMARY KEY (`clientes_idClientes`,`usuario_idUsuario`),
  KEY `fk_clientes_has_usuario_usuario1_idx` (`usuario_idUsuario`),
  KEY `fk_clientes_has_usuario_clientes1_idx` (`clientes_idClientes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes_has_usuario`
--

LOCK TABLES `clientes_has_usuario` WRITE;
/*!40000 ALTER TABLE `clientes_has_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes_has_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedidos` (
  `idPedidos` int(11) NOT NULL AUTO_INCREMENT,
  `dataPedido` date NOT NULL,
  `custoTotal` double NOT NULL,
  `caixa` double NOT NULL,
  `qtsItens` varchar(300) NOT NULL,
  `idClientes` int(11) NOT NULL,
  PRIMARY KEY (`idPedidos`),
  KEY `idClientes` (`idClientes`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`idClientes`) REFERENCES `clientes` (`idClientes`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (1,'1995-01-02',203.02,100,'Sabor: Alho e Óleo | Quantidade: 10 | Valor: R$110',1),(2,'2015-01-02',203.02,100,'Sabor: Alho e Óleo | Quantidade: 10 | Valor: R$110',1),(3,'1998-01-02',203.02,100,'Sabor: Alho e Óleo | Quantidade: 10 | Valor: R$110',1),(4,'1995-01-02',203.02,100,'Sabor: Alho e Óleo | Quantidade: 10 | Valor: R$110',1),(5,'1995-01-02',203.02,100,'Sabor: 3 QUEIJOS| Quantidade: 1 | Valor: R$40',5),(6,'1995-01-02',203.02,100,'Sabor: PORTUGUESA | Quantidade: 11 | Valor: R$365.99',6),(7,'1995-01-02',203.02,100,'Sabor: BAURU | Quantidade: 3| Valor: R$230',7),(8,'1995-01-02',203.02,100,'Sabor: FRANGO COM REQUEIJÃO | Quantidade: 1 | Valor: R$60.00',7),(9,'1995-01-02',203.02,100,'Sabor: PORTUGUESA | Quantidade: 1 | Valor: R$35.75',8),(10,'1995-01-02',203.02,100,'Sabor: PORTUGUESA | Quantidade: 1 | Valor: R$35.75',8),(11,'1995-01-02',203.02,100,'Sabor: MUSSARELA | Quantidade: 3 | Valor: R$186.22',2),(12,'1998-01-02',203.02,100,'Sabor: Americana | Quantidade: 2 | Valor: R$60',2),(13,'2015-01-02',203.02,100,'Sabor: 4 QUEIJOS | Quantidade: 1| Valor: R$25.05',2),(14,'1995-01-02',203.02,100,'Sabor: Alho e Óleo | Quantidade: 10 | Valor: R$110',1),(15,'2015-11-18',40,100,'\nSabor: Alicci Molho | Quantidade: 1 | Valor: R$40',6);
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pizzas`
--

DROP TABLE IF EXISTS `pizzas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pizzas` (
  `idPizzas` int(11) NOT NULL AUTO_INCREMENT,
  `sabor` varchar(45) NOT NULL,
  `informacoes` varchar(345) DEFAULT 'sem informação',
  `precoG` decimal(10,0) DEFAULT '0',
  `precoM` decimal(10,0) DEFAULT '0',
  `precoP` decimal(10,0) DEFAULT '0',
  PRIMARY KEY (`idPizzas`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pizzas`
--

LOCK TABLES `pizzas` WRITE;
/*!40000 ALTER TABLE `pizzas` DISABLE KEYS */;
INSERT INTO `pizzas` VALUES (1,'Alho e Óleo','alhoorégano',11,52,18),(2,'Alicci Molho','mussarela, alicci e orégano.',40,25,12),(3,'Alho e Óleo','alhoorégano',40,25,12),(4,'3 QUEIJOS','Molho, Mussarela, Parmesão, Requeijão e Orégano.',60,33,12),(5,'Alicci Molho','mussarela, alicci e orégano.',22,15,9),(6,'4 QUEIJOS','Molho, Mussarela, Orégano, Parmesão, Requeijão e Gorgonzola.',33,21,11),(7,'AMERICA','Mussarela, Cebola, Pimentão, Champignon, Pepperoni, Molho e Orégano.',37,17,7),(8,'BAURU','Presunto, Mussarela, Requeijão, Orégano, Molho e Tomate.',51,39,25),(9,'VEGGIE','Azeitona preta fatiada, Cebola, Champignon, Molho, Mussarela, Orégano e Pimentão.',40,25,12),(10,'FRANGO GRELHADO','Tomate, Requeijão, Orégano, Molho, Mussarela, Manjericão, Azeitona preta fatiada e Frango.',40,25,12),(11,'FRANGO COM REQUEIJÃO','Frango, Cebola, Requeijão, Molho e Orégano.',62,40,19),(12,'CALABRESA ESPECIAL','Azeitona preta fatiada,Cream cheese philadelphia, Molho e Orégano.',40,25,12),(13,'CALABRESA','Mussarela, Cebola, Calabresa, Molho e Orégano',20,11,5),(14,'CATUPERONI','Molho, Mussarela, Orégano, Pepperoni, Requeijão e Parmesão.',72,66,45),(15,'PORTUGUESA','Mussarela, Cebola, Pimentão, Pepperoni, Calabresa, Champignon, Molho e Orégano.',53,25,12),(16,'PEPPERONI',' Pepperoni.',40,25,12),(17,'MUSSARELA','Molho, Mussarela e Orégano.',20,15,9),(18,'MARGHERITA','Mussarela, Molho, Orégano, Tomate e Manjericão.',30,25,15);
/*!40000 ALTER TABLE `pizzas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tabelapreco`
--

DROP TABLE IF EXISTS `tabelapreco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tabelapreco` (
  `idTabelaPreco` int(11) NOT NULL AUTO_INCREMENT,
  `preco` float NOT NULL,
  `custo` float NOT NULL,
  `quantidade` int(11) NOT NULL,
  `pedidos_idPedidos` int(11) NOT NULL,
  `pizzas_idPizzas` int(11) NOT NULL,
  PRIMARY KEY (`idTabelaPreco`,`pedidos_idPedidos`,`pizzas_idPizzas`),
  KEY `fk_tabelaPreco_pedidos1_idx` (`pedidos_idPedidos`),
  KEY `fk_tabelaPreco_pizzas1_idx` (`pizzas_idPizzas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tabelapreco`
--

LOCK TABLES `tabelapreco` WRITE;
/*!40000 ALTER TABLE `tabelapreco` DISABLE KEYS */;
/*!40000 ALTER TABLE `tabelapreco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(15) DEFAULT NULL,
  `senha` varchar(12) DEFAULT NULL,
  `nomeEmpresa` varchar(45) DEFAULT NULL,
  `funcao` varchar(45) DEFAULT NULL,
  `tipoAcesso` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `idUsuarios` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) NOT NULL,
  `funcao` varchar(60) DEFAULT NULL,
  `senha` varchar(420) NOT NULL,
  `tipoAcesso` varchar(20) NOT NULL,
  `foto` text,
  PRIMARY KEY (`idUsuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Athauan','ceo','123123','Administrador','C:\\Users\\Athauan\\Pictures\\EU@th@ (2).JPG');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pizzaria'
--

--
-- Dumping routines for database 'pizzaria'
--
/*!50003 DROP PROCEDURE IF EXISTS `AlterarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AlterarCliente`(IN pnome VARCHAR(50), IN pendereco VARCHAR(80), IN ptelefone Varchar(15),IN pcidade VARCHAR(45), IN puf VARCHAR(2), IN preferencias VARCHAR(245), in pidCliente int)
BEGIN
	
    UPDATE pizzaria.clientes SET nome = pnome, endereco = pendereco, telefone = ptelefone, cidade = pcidade, uf = puf, referencias = preferencias  where idClientes = pidCliente;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AlterarTabelarPizza` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AlterarTabelarPizza`(IN psabor VARCHAR(50), IN pinformacoes VARCHAR(80), IN pprecoG decimal, IN pprecoM decimal, IN pprecoP decimal,in pidPizzas int)
BEGIN
	
    UPDATE pizzaria.pizzas SET sabor = psabor, informacoes = pinformacoes, precoG = pprecoG, precoM = pprecoM, precoP = pprecoP where idPizzas = pidPizzas;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AlterarUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AlterarUsuario`(IN pusuario VARCHAR(20),IN pfuncao VARCHAR(45), IN psenha VARCHAR(10), IN ptipoAcesso VARCHAR(20), IN pfoto text(230),in pidUsuarios int)
BEGIN
   UPDATE pizzaria.usuarios SET usuario = pusuario, funcao = pfuncao, senha = psenha, tipoAcesso = ptipoAcesso, foto = pfoto WHERE idUsuarios = pidUsuarios;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AutenticarAcessos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AutenticarAcessos`(IN pusuario varchar(15))
BEGIN
	
      SELECT
         usuarios.funcao,
         usuarios.tipoAcesso,
         usuarios.foto
	  FROM pizzaria.usuarios WHERE usuarios.usuario LIKE CONCAT('%', pusuario, '%')
     OR usuarios.idUsuarios = pusuario;
     
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AutenticarUsuarios` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AutenticarUsuarios`(IN pusuario varchar(15), IN psenha varchar(10))
BEGIN
	
    select usuario, senha from pizzaria.usuarios where usuario = pusuario and senha = psenha;
    
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CadastrarUsuarios` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CadastrarUsuarios`(IN pusuario VARCHAR(20),IN pfuncao VARCHAR(45), IN psenha VARCHAR(10), IN ptipoAcesso VARCHAR(20), IN pfoto text(230))
BEGIN

	insert into pizzaria.usuarios(usuario, funcao, senha, tipoAcesso, foto) values (pusuario, pfuncao, psenha, ptipoAcesso, pfoto);
    select * from usuarios where idUsuarios = LAST_INSERT_ID();
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Contas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Contas`(IN pfiltro varchar(20))
BEGIN


		IF (pfiltro = "") THEN
      SELECT
         usuarios.idUsuarios,
         usuarios.usuario,
         usuarios.funcao,
		 usuarios.senha,
         usuarios.tipoAcesso,
         usuarios.foto
	  FROM pizzaria.usuarios;
   ELSE
     SELECT
        usuarios.idUsuarios,
         usuarios.usuario,
         usuarios.funcao,
		 usuarios.senha,
         usuarios.tipoAcesso,
         usuarios.foto
	 FROM pizzaria.usuarios
     WHERE usuarios.usuario LIKE CONCAT('%', pfiltro, '%')
     OR usuarios.idUsuarios = pfiltro;
     
   
   END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ExcluirCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ExcluirCliente`(IN pidClientes INT)
BEGIN

	DELETE FROM pizzaria.clientes WHERE idClientes = pidClientes;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ExcluirTabelarPizza` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ExcluirTabelarPizza`(IN pidPizzas INT)
BEGIN

	DELETE FROM pizzaria.pizzas WHERE idPizzas = pidPizzas;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ExcluirUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ExcluirUsuario`(IN pidusuario INT)
BEGIN
   DELETE FROM pizzaria.usuarios WHERE idUsuarios = pidusuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirClientes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirClientes`(IN pnome VARCHAR(50), IN pendereco VARCHAR(80), IN ptelefone Varchar(15),IN pcidade VARCHAR(45), IN puf VARCHAR(2), IN preferencias VARCHAR(245))
BEGIN

	insert into pizzaria.clientes(nome, endereco, telefone, cidade, uf, referencias) values (pnome, pendereco, ptelefone, pcidade, puf, preferencias);
    select * from clientes where idClientes = LAST_INSERT_ID();
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirTabelarPizza` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirTabelarPizza`(IN psabor VARCHAR(50), IN pinformacoes VARCHAR(80), IN pprecoG float, IN pprecoM float, IN pprecoP float)
BEGIN

	insert into pizzaria.pizzas(sabor, informacoes, precoG, precoM, precoP) values (psabor, pinformacoes, pprecoG, pprecoM, pprecoP);
    select * from pizzas where idPizzas = LAST_INSERT_ID();
    
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ListarTabelarPizza` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListarTabelarPizza`(IN pfiltro varchar(20))
BEGIN
   IF (pfiltro = "") THEN
      SELECT
         pizzas.idPizzas,
         pizzas.sabor,
         pizzas.informacoes,
		 pizzas.precoG,
         pizzas.precoM,
         pizzas.precoP
	  FROM pizzaria.pizzas;
   ELSE
     SELECT
         pizzas.idPizzas,
         pizzas.sabor,
         pizzas.informacoes,
		 pizzas.precoG,
         pizzas.precoM,
         pizzas.precoP
	 FROM pizzaria.pizzas
     WHERE pizzas.sabor LIKE CONCAT('%', pfiltro, '%')
     OR pizzas.idPizzas = pfiltro;
   END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ListragemNome` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListragemNome`()
BEGIN

   Select nome from pizzaria.clientes;
   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RelatorioPedidos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RelatorioPedidos`(IN pfiltro varchar(20))
BEGIN
   IF (pfiltro = "") THEN
      SELECT
		 pedidos.idPedidos,
         pedidos.dataPedido,
         pedidos.custoTotal,
         pedidos.caixa,
		 pedidos.qtsItens,
         pedidos.idClientes
	  FROM pizzaria.pedidos;
   ELSE
     SELECT
		 pedidos.idPedidos,
         pedidos.dataPedido,
         pedidos.custoTotal,
         pedidos.caixa,
		 pedidos.qtsItens,
         pedidos.idClientes
	 FROM pizzaria.clientes
     WHERE pizzaria.dataPedido LIKE CONCAT('%', pfiltro, '%')
     OR pizzaria.idPedidos = pfiltro;
   END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelecionarClientes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelecionarClientes`(IN pfiltro varchar(20))
BEGIN
   IF (pfiltro = "") THEN
      SELECT
         clientes.idClientes,
         clientes.nome,
         clientes.endereco,
		 clientes.telefone,
         clientes.cidade,
         clientes.uf,
         clientes.referencias
	  FROM pizzaria.clientes;
   ELSE
     SELECT
         clientes.idClientes,
         clientes.nome,
         clientes.endereco,
		 clientes.telefone,
         clientes.cidade,
         clientes.uf,
         clientes.referencias
	 FROM pizzaria.clientes
     WHERE clientes.nome LIKE CONCAT('%', pfiltro, '%')
     OR clientes.idClientes = pfiltro;
   END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-11-18 19:52:22
