drop database if exists pedido;
CREATE DATABASE  IF NOT EXISTS `pedido` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `pedido`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: pedido
-- ------------------------------------------------------
-- Server version	5.5.28

--
-- Table structure for table `cliente`
--
CREATE TABLE `cliente` (
  `idCLIENTE` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) DEFAULT NULL,
  `Endereco` varchar(45) DEFAULT NULL,
  `Bairro` varchar(45) DEFAULT NULL,
  `Cidade` varchar(20) DEFAULT NULL,
  `UF` char(2) DEFAULT NULL,
  `Telefone` char(10) DEFAULT NULL,
  PRIMARY KEY (`idCLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cliente`
--
INSERT INTO `cliente` VALUES (1,'ALEXANDRE BERNARDINO','RUA DONA MARIA, 123','CENTRO','BRAGANCA PAULISTA','SP','1112345678'),(2,'CAIO NASCIMENTO','RUA XV DE NOVEMBRO, 123','VILA REZENDE','PIRACICABA','SP','1998762345'),(3,'ALINE BUENO','AV. IMIGRANTES, 123','CENTRO','BRAGANCA PAULILSTA','SP','1143234323'),(4,'CASSIO RIVEIRO','RUA TRES, 123','CENTRO','ATIBAIA','SP','1198766789'),(5,'IGOR SAKAKI','AV. OROZIMBO MAIA, 121','CAMBUI','CAMPINAS','SP','1932323232'),(6,'LEONARDO RAMALHO','AV 23 DE MAIO, 111','PARAISO','SAO PAULO','SP','1191910101'),(7,'DALTON FILHO','AV. MORAES SALLES, 1234','CAMBUI','CAMPINAS','SP','1923452345'),(8,'JOAO LUIS FEIJO','AV. IMIGRANTES, 432','CENTRO','BRAGANCA PAULISTA','SP','1112122222'),(9,'ANA CAROLINA OLIVEIRA','AV. FCO LUCCHESI, 770','PENHA','BRAGANCA PAULISTA','SP','1132232233'),(10,'JOAO PAULO SILVA','RUA DO PARAISO, 80','PARAISO','SAO PAULO','SP','1123455432');

--
-- Table structure for table `pedido`
--
CREATE TABLE `pedido` (
  `idPEDIDO` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idCLIENTE` int(10) unsigned NOT NULL,
  `DataPedido` date DEFAULT NULL,
  PRIMARY KEY (`idPEDIDO`),
  KEY `PEDIDO_FKIndex1` (`idCLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;


--
-- Dumping data for table `pedido`
--
INSERT INTO `pedido` VALUES (1,1,'2014-03-01'),(2,1,'2014-03-12'),(3,1,'2014-03-22'),(4,2,'2014-04-03'),(5,2,'2014-05-13'),(6,3,'2014-04-12'),(7,3,'2014-05-13'),(8,4,'2014-04-12'),(9,5,'2014-04-12'),(10,5,'2014-05-12'),(11,6,'2014-04-11'),(12,7,'2014-04-23'),(13,9,'2014-04-25');

--
-- Table structure for table `pedido_has_produto`
--

DROP TABLE IF EXISTS `pedido_has_produto`;
CREATE TABLE `pedido_has_produto` (
  `idPEDIDO` int(10) unsigned NOT NULL,
  `idPRODUTO` int(10) unsigned NOT NULL,
  `qtde` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`idPEDIDO`,`idPRODUTO`),
  KEY `idPRODUTO` (`idPRODUTO`),
  KEY `PEDIDO_has_PRODUTO_FKIndex1` (`idPEDIDO`),
  KEY `PEDIDO_has_PRODUTO_FKIndex2` (`idPRODUTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pedido_has_produto`
--
INSERT INTO `pedido_has_produto` VALUES (1,1,5),(1,2,2),(2,2,2),(2,4,5),(3,3,3),(4,1,10),(4,2,10),(5,1,1),(5,2,1),(6,1,5),(6,2,3),(6,3,3),(7,1,5),(7,2,1),(8,1,1),(8,2,1),(8,3,1),(9,1,1),(9,2,2),(10,1,1),(11,1,1),(12,1,1);

--
-- Table structure for table `produto`
--
CREATE TABLE `produto` (
  `idProduto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(20) DEFAULT NULL,
  `Valor` float(6,2) DEFAULT NULL,
  PRIMARY KEY (`idProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produto`
--
INSERT INTO `produto` VALUES (1,'Papel A4',14.00),(2,'Cartucho HP',45.00),(3,'Etiqueta CD',17.00),(4,'Cd RW',5.00),(5,'Cd R',2.00);

-- Dump completed on 2014-05-15 11:01:39



select idpedido PEDIDO,
	   idcliente CLIENTE,
		date_format(datapedido,'%d-%m-%y') "Data do pedido"
	from pedido where month(datapedido)=3; -- (exe:3)


select idpedido PEDIDO,
	   idcliente CLIENTE,
		date_format(MAX(datapedido),'%d-%m-%y') "Data do pedido"
	from pedido group by idcliente; -- (Exe: 4)

update pedido
set datapedido ='2014-05-15' where datapedido = '2014-05-13';









