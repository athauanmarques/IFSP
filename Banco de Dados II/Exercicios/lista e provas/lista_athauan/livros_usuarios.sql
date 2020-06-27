-- MySQL dump 10.13  Distrib 5.6.24, for Win32 (x86)
--
-- Host: localhost    Database: biblioteca
-- ------------------------------------------------------
-- Server version	5.6.26-log

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
-- Table structure for table `livro`
--

DROP TABLE IF EXISTS `livro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `livro` (
  `codpro` int(10) unsigned NOT NULL,
  `ideditora` int(10) unsigned NOT NULL,
  `titulo_livro` varchar(60) DEFAULT NULL,
  `ano_publicação` char(4) DEFAULT NULL,
  `autor` char(45) DEFAULT NULL,
  `tipo` char(45) DEFAULT NULL,
  PRIMARY KEY (`codpro`),
  KEY `ideditora` (`ideditora`),
  KEY `livro_FKIndex1` (`codpro`),
  CONSTRAINT `livro_ibfk_1` FOREIGN KEY (`ideditora`) REFERENCES `editora` (`ideditora`),
  CONSTRAINT `livro_ibfk_2` FOREIGN KEY (`codpro`) REFERENCES `acervo` (`codpro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livro`
--

LOCK TABLES `livro` WRITE;
/*!40000 ALTER TABLE `livro` DISABLE KEYS */;
INSERT INTO `livro` VALUES (16,2,'Use a Cabeça Java','2005',NULL,'Informatica'),(17,2,'Use a Cabeça JSP & Servlet',NULL,NULL,'Informatica'),(18,2,'Use a Cabeça PMP','2005',NULL,'Informatica'),(19,2,'Use a Cabeça HTML & XHTML',NULL,NULL,'Informatica'),(20,2,'Use a Cabeça Ajax','2004',NULL,'Informatica'),(21,2,'Use a Cabeça Padrões de Projeto','2005',NULL,'Informatica'),(22,2,'Use a Cabeça Análise e Projeto Orientado a Objeto',NULL,NULL,'Informatica'),(23,2,'Use a Cabeça SQL','2005',NULL,'Informatica'),(24,3,'Sistemas Operacionais Modernos','1999','TANENBAUM, Andrew S.','Informática'),(25,4,'Sistemas Operacionais','2000','Abraham Silberschatz, Peter Baer Galvin','Informatica'),(26,5,'Investidores Inteligentes','2008','Gustavo Cerbasi','Administração'),(27,6,'A cabeça de Steve Jobs','2008','Leander Kahney','Administração'),(28,7,'Como se tornar um vendedor Pit-Bull','2009','Luis Paulo Luppa','Administração'),(29,8,'O verdadeiro Poder','2009','Vicente Falconi Campos','Administração'),(30,9,'Transformando suor em ouro','2006','Bernardo Rocha de Rezende','Administração'),(31,7,'Mantendo os Talentos da sua Empresa','2007','Harvard Business Review','Administração'),(32,9,'Como Motivar a sua equipe','2006','Anne Bruce','Administração'),(33,10,'12 Semanas para mudar uma vida','2007','Augusto Cury','Psicologia'),(34,11,'Tecnicas de Intervenção Psicopedagógica','2008','Leila Sara, Jose Chamat','Psicologia'),(35,12,'Os Desafios da Terapia','2007','Irvin D. Yalom','Psicologia');
/*!40000 ALTER TABLE `livro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `CPF` char(20) NOT NULL DEFAULT '',
  `idTipoUsuario` int(10) unsigned NOT NULL,
  `nome` char(45) DEFAULT NULL,
  `endereco` char(45) DEFAULT NULL,
  `cidade` char(30) DEFAULT 'Bragança Paulista',
  `telefone` int(10) unsigned DEFAULT NULL,
  `datanasc` date DEFAULT NULL,
  PRIMARY KEY (`CPF`),
  KEY `idTipoUsuario` (`idTipoUsuario`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idTipoUsuario`) REFERENCES `tipousuario` (`idTipoUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('12435455667',1,'RIVALDO BATISTA','Rua Dr Cândido Rodrigues, 68','Bragança Paulista',40317845,'1985-06-12'),('21548541213',1,'Joana Almeida','Rua Campinas, 25','Bragança Paulista',88745456,'1990-05-06'),('34524575897',1,'DAIANE PIMENTEL','Av José Gomes Rocha Leal, 1498','Bragança Paulista',40047844,'1990-01-05'),('38987877624',1,'ANA LUIZA','Rua João Polidori, 426','Bragança Paulista',40343219,'1989-06-06'),('43498956854',1,'FRANCINE DORTA','Rua José Domingues, 624','Bragança Paulista',40043539,'1987-05-04'),('45412989898',1,'CÁTIA APARECIDA','Rua Cel João Leme, 1019','Bragança Paulista',40344739,'1981-05-12'),('45937579621',1,'MARIA AUGUSTA','Av Pres Humberto A C Branco, 189','Bragança Paulista',40047707,'1987-03-06'),('54132454513',3,'Aparecida Silva','Rua Piracicaba, 98','Bragança Paulista',72145789,'1987-06-08'),('54387696785',1,'BRUNO SAMPAIO','Rua Cel João Leme, 286','Bragança Paulista',40359840,'1991-05-01'),('54714785521',2,'Marcia Azevedo','Rua Suzano, 30','Bragança Paulista',95847252,'1995-02-02'),('54892321857',2,'Willian Viana','Rua São Paulo, 15','Bragança Paulista',64521478,'1986-05-06'),('55643257896',1,'LEANDRO JOSE','Rua Liberdade, 256','Bragança Paulista',40310632,'1993-12-13'),('62552145222',1,'Tiago Xavier','Rua Piracaia, 54','Bragança Paulista',98745214,'1986-05-06'),('63321144782',2,'Joao Silva','Rua Piracicaba, 15','Bragança Paulista',97854125,'1992-02-02'),('65468746871',1,'Joana Ferreira','Av. São João, 115','Bragança Paulista',69130058,'1990-12-03'),('65497821321',2,'Otavio Cunha','Rua Ubatuba, 13','Bragança Paulista',96324411,'1991-12-12'),('65644349876',1,'GABRIEL SILVA','Av Dr José Adriano Marrey Jr, 486','Bragança Paulista',40318754,'1990-11-01'),('65828290980',1,'INACIO SANTANA','Rua Arthur Siqueira, 480','Bragança Paulista',40355646,'1987-05-01'),('65851147982',1,'Maria Almeida','Rua 13 de Maio, 28','Bragança Paulista',96458712,'1993-01-06'),('67824475980',1,'GIOVANE MALENGO','Av Antônio Pires Pimentel, 1191','Bragança Paulista',40358967,'1990-06-03'),('69411585214',2,'Mariana Santos','Rua 13 de Julho, 11','Bragança Paulista',65412874,'1975-12-06'),('76755434767',1,'IVONILDO CEARÁ','Rua Br Juqueri, 59','Bragança Paulista',40314628,'1988-11-01'),('76889898864',1,'MARIA RITA','Rua Nicolino Nacaratti, 682','Bragança Paulista',40345390,'1990-06-05'),('78521453369',3,'Fabio França','Rua São Jose, 56','Bragança Paulista',94125896,'1987-03-08'),('85748484846',1,'TAINA ALVES','Rua Liberdade, 98','Bragança Paulista',40044421,'1991-01-01'),('85897501983',1,'MIGUEL ASSIS','Rua Marcelo Stefani, 142','Bragança Paulista',40351727,'1996-12-31'),('86326644878',1,'CASSIA SILVA','Rua Prof Luiz Nardy, 15','Bragança Paulista',40345739,'1985-05-04'),('86531368644',1,'ROSANGELA VASCONCELOS','Rua Policarpo Guimarães, 18','Bragança Paulista',40046249,'1986-12-02'),('87516872125',1,'Alex Pereira','Rua das flores, 22','Bragança Paulista',87412158,'1991-01-01'),('87678667791',1,'GABRIELA GODOY','Rua Adelino Campos, 87','Bragança Paulista',40342411,'1993-01-01'),('87897965764',1,'RICARDO BONIFACIO','Rua Prof Antônio DI Franco, 137','Bragança Paulista',40355326,'1985-12-27'),('89714536987',1,'Joao Silva','Rua 21 de Abril, 37','Bragança Paulista',86541278,'1990-01-05'),('98712125472',1,'Mario Augusto','Av. Primavera, 13','Bragança Paulista',68742158,'1990-01-11'),('98736121865',1,'Murilo Almeida','Rua Taubate, 44','Bragança Paulista',94654788,'1985-03-11'),('98787565454',1,'DANIEL OLIVEIRA','Rua A Siqueira, 67','Bragança Paulista',40319785,'1980-06-03');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'biblioteca'
--

--
-- Dumping routines for database 'biblioteca'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-03-21 22:11:23
