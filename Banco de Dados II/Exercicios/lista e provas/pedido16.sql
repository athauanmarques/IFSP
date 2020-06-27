-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: pedido15
-- ------------------------------------------------------
-- Server version	5.7.10-log
Drop database pedido16;

Create database pedido16;
Use pedido16;
--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `id_cliente` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome_cliente` varchar(50) NOT NULL,
  `cpf_cliente` char(14) NOT NULL,
  `endereco_cliente` varchar(100) DEFAULT 'Endereço não cadastrado',
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` VALUES (1,'Luís Azevedo Santos','881.082.532-25','Rua Santa Cecília, 1078, Birigüi-SP'),(2,'Eduarda Santos Pereira','723.148.831-52','Vila São Lucas, 1199, Fortaleza-CE'),(3,'Miguel Cardoso Almeida','316.413.931-49','Rua Maria Luiza Fernandes, 382, Guarujá-SP'),(4,'Breno Costa Fernandes','690.487.093-18','Rua Irmã Rosali Guimarães Wanderley, 300, Natal-RN'),(5,'Kauã Gomes Silva','951.284.804-02','Rua J 67, 1153, Goiânia-GO'),(6,'Vinicius Santos Ribeiro','452.316.300-63','Quadra QNL 05 Conjunto H, 381, Taguatinga-DF'),(7,'Julia Souza Alves','327.591.717-01','Rua da Lagoa, 379, Teófilo Otoni-MG'),(8,'Rafael Barbosa Rocha','881.519.582-35','Rua Verônica, 566, Belo Horizonte-MG'),(9,'Igor Pereira Almeida','688.401.670-13','Avenida Cruz e Souza, 1290, São José-SC'),(10,'Rodrigo Almeida Araujo','628.152.296-68','Vila Buriti, 1579, Manaus-AM'),(11,'Ágatha Goncalves Martins','420.500.484-24','Avenida Severo Conde Y Conde, 1283, Guarujá-SP'),(12,'Matilde Barros Castro','630.633.217-02','Rua Piracura, 180, Guarulhos-SP'),(13,'Douglas Goncalves Cavalcanti','838.285.410-97','Rua Professora Helena Moura Lacerda, 899'),(14,'Erick Goncalves Barbosa','899.269.448-25','Rua Marilza Paranhos, 1181, Vitória-ES'),(15,'Júlio Ribeiro Costa','281.430.220-56','Rua Afonso Monticelli, 1484, Varginha-MG'),(16,'Sofia Almeida Sousa','471.578.060-70','Rua Desembargador Oscar Dantas, 330, Salvador-BA'),(17,'Felipe Cavalcanti Goncalves','284.649.286-70','Rua Mondaí, 648, São Paulo-SP'),(18,'Beatriz Barbosa Barros','393.588.663-22','Avenida Santa Tecla, 1498, Bagé-RS'),(19,'Melissa Castro Barros','350.846.920-43','Rua Teresina, 383, Belo Horizonte-MG'),(20,'Leonor Sousa Carvalho','125.198.921-70','Estrada Baptista Bossato, 302, Sarandi-PR'),(21,'Pedro Melo Dias','626.102.484-74','Rua Amarati, 866, Recife-PE'),(22,'Aline Goncalves Souza','440.753.289-02','Avenida Rio Verde, 684, Aparecida de Goiânia-GO'),(23,'Lara Martins Almeida','521.073.332-70','Rua Vinte e Sete, 1548, Itabira-MG'),(24,'Rafaela Barbosa Rodrigues','459.441.492-30','Avenida Doutor Israel Pinheiro Silva, 619, Luziânia-GO'),(25,'Luiza Silva Martins','796.605.454-36','Quadra QR 404 Conjunto 13, 1818, Samambaia-DF'),(26,'Leonor Pereira Barros','832.918.931-74','Rua Lemos de Brito, 157, Alvorada-RS'),(27,'Gabriela Silva Fernandes','719.221.334-93','Travessa Serralheiro, 911, Fortaleza-CE'),(28,'Diego Santos Martins','667.958.840-58','Vila Regis, 176, Natal-RN'),(29,'Camila Gomes Dias','456.499.279-10','Rua Lisanto, 391, Hortolândia-SP'),(30,'Ana Melo Ferreira','147.145.561-00','Quadra QS 12 Conjunto 05A, 1144, Riacho Fundo-DF'),(31,'Nicolas Rodrigues Azevedo','916.582.962-06','Rua Rafael Correia Sampaio, 1904, São Paulo-SP'),(32,'Breno Alves Goncalves','501.988.465-09','Avenida Fernão Dias, 1685, Governador Valadares-MG'),(33,'Miguel Ribeiro Silva','284.339.547-09','Rua Manoel Domingues Monteiro, 617, Cachoeiro de Itapemirim-ES'),(34,'Manuela Cunha Melo','191.076.557-03','Servidão Pedro Pereira Magro, 1198, Petrópolis-RJ'),(35,'Victor Cardoso Martins','336.135.582-62','Rua Quatorze, 1367, Jundiaí-SP'),(36,'Larissa Barbosa Rocha','199.289.815-40','Rua Tenente-Brigadeiro Francisco de Assis C. de Mello, 203, Curitiba-PR'),(37,'Julieta Azevedo Cardoso','471.382.805-05','Rua Q, 987, Montes Claros-MG'),(38,'Evelyn Goncalves Cardoso','641.057.320-05','Rua Primeiro-Tenente José Maria Pinto Duarte, 8, Guarulhos-SP'),(39,'Bianca Sousa Rocha','937.221.237-71','Rua Angaíba, 1993, São Paulo-SP'),(40,'Amanda Silva Cavalcanti','391.768.051-31','Rua Mundinho Ferraz, 99, Teresina-PI'),(41,'Kaua Costa Pereira','333.680.337-35','Travessa Domingos, 449, Itabira-MG'),(42,'Camila Gomes Oliveira','268.071.425-36','Avenida Moita Bonita, 1328, Guarulhos-SP'),(43,'Sarah Melo Barbosa','475.090.044-38','Rua Cirilo de Abreu, 1670, Sete Lagoas-MG'),(44,'Anna Goncalves Ferreira','551.592.336-79','Escada dos Girassóis, 1431, Vitória-ES'),(45,'Tânia Rodrigues Barbosa','119.916.569-71','Rua D, 1437, São Bernardo do Campo-SP'),(46,'Thiago Gomes Souza','167.674.605-67','Rua Centenário, 1586, Campo Largo-PR'),(47,'Sofia Correia Castro','302.670.412-17','Rua Alto do Cruzeiro, 419, Salvador-BA'),(48,'Samuel Martins Silva','431.567.210-69','Rua São Paulo, 159, Nova Iguaçu-RJ'),(49,'Vitor Melo Pinto','507.415.405-76','Rua Garças, 330, Laranjeiras do Sul-PR'),(50,'Rebeca Azevedo Alves','218.825.093-15','Rua Presidente Doutor Juscelino Kubitschek de Oliveira, 279, Itu-SP');

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
CREATE TABLE `fornecedor` (
  `id_fornecedor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cnpj_fornecedor` varchar(45) DEFAULT NULL,
  `nome_fornecedor` varchar(50) DEFAULT NULL,
  `endereco_fornecedor` varchar(100) DEFAULT NULL,
  `contato_fornecedor` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
--
-- Dumping data for table `fornecedor`
--

INSERT INTO `fornecedor` VALUES (1,'28.284.656/0001-00','Polofire','Vila André Luís, 1351, Salvador-BA','(19) 6609-5659'),(2,'18.548.255/0001-59','Kaymm','Avenida dos Pinheirais, 755, Araucária-PR','(11) 5852-6276'),(3,'44.263.878/0001-95','Golden Z','Rua Gonçalves Dias, 1657, Pará de Minas-MG','(71) 2844-5101'),(4,'25.442.404/0001-66','Demixo','Rua Raul Pimazoni, 1015, Marília-SP','(41) 4970-5369'),(5,'17.410.677/0001-09','Trishots','Rua José Acioli, 1281, São Paulo-SP','(37) 2275-8649'),(6,'35.077.633/0001-82','Mecahood','Avenida Cândido Gafree, 1654, Santos-SP','(11) 5077-2638'),(7,'57.365.288/0001-15','Grandepad','Travessa Santa Cruz, 724, Ponta Grossa-PR','(42) 7845-9060'),(8,'91.234.132/0001-33','Pixonyx','Rua Tupis, 1971, Coronel Fabriciano-MG','(31) 3187-7539'),(9,'54.727.789/0001-06','Pentavee','Rua Antônio de Oliveira Sobrinho, 185, Maringá-PR','(44) 6113-2229'),(10,'60.693.918/0001-95','Canimbu','Quadra 1105 Sul Alameda 30, 709, Palmas-TO','(63) 5752-3992'),(11,'12.623.159/0001-41','Quilia','Rua Ida Radiante Bonfanti, 547, São Paulo-SP','(11) 6618-4333'),(12,'30.937.847/0001-68','Kado','Rua Doutor Batista Pereira, 1357, Santos-SP','(11) 9284-5969'),(13,'32.324.307/0001-34','Mastag','Rua Glauco Velasques, 1342, Rio de Janeiro-RJ','(21) 8932-5907'),(14,'45.504.451/0001-02','Plaset','Avenida Dezesseis de Julho, 443, Macapá-AP','(96) 3995-7746'),(15,'33.744.224/0001-67','Gamalist','Rua Francisco de Almeida, 1835, São Gonçalo-RJ','(21) 6515-9250'),(16,'14.719.598/0001-88','Betatype','Rua Luiza Isidoro, 274, Três Rios-RJ','(24) 3780-8475'),(17,'80.132.876/0001-20','Demizz','Rua Burnier, 481, Belo Horizonte-MG','(31) 3525-9635'),(18,'36.275.663/0001-66','YouBR','Rua 37, 256, Aparecida de Goiânia-GO','(62) 5621-5160'),(19,'48.252.489/0001-15','Forelounge','Avenida Brasília, 516, Gurupi-TO','(63) 3909-8094'),(20,'01.704.223/0001-00','Kazz','Conjunto Green Ville II, 459, Belém-PA','(91) 2781-3373');

--
-- Table structure for table `produto`
--

CREATE TABLE `produto` (
  `id_produto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_grupo_produto` int(10) unsigned NOT NULL,
  `nome_produto` varchar(50) NOT NULL,
  `codigo_barra_produto` char(13) DEFAULT 'Não possui',
  `preco_custo_produto` double DEFAULT NULL,
  `preco_venda_produto` double NOT NULL,
  `estoque_produto` int(11) DEFAULT '0',
  PRIMARY KEY (`id_produto`)
);

--
-- Dumping data for table `produto`
--

INSERT INTO `produto` VALUES (1,1,'Webcam Logitech C310','3964329785766',44.91,89.9,5),(2,1,'Webcam Creative Live! Cam Connect HD','4872568943756',46.22,99.65,12),(3,1,'Webcam Microsoft LifeCam HD-6000','9340089693146',53.91,59.99,25),(4,1,'Webcam Microsoft LifeCam Cinema','9057120895614',44.1,84,46),(5,1,'Webcam Genius WideCam F100','7230418586384',39,51,27),(6,1,'Webcam Microsoft LifeCam Studio','8378391932810',110,156,4),(7,1,'Webcam Logitech HD C615','2378232837823',122,178,8),(8,1,'Webcam HP HD-5210','0434586345702',110.59,175.99,10),(9,1,'Webcam Logitech HD Pro Webcam C920','0109827462358',150,278.5,5),(10,1,'WebCam Multilaser WC040','7627597183465',63.21,89.9,7),(11,2,'Mouse Óptico Preto MO031 Multilaser','3745243562788',7.5,13.9,0),(12,2,'Mouse Leadership Black Ops','7489237409127',3.77,7,2),(13,2,'Mouse Óptico Multilaser MO149 Gamer','6234960578265',22,39.99,47),(14,2,'Mouse Mini Óptico Preto MO097','4638587296475',10.37,14.99,55),(15,2,'Mouse Genius GX Gila','7758183209172',150.22,316,17),(16,2,'Mouse Óptico ZM-M300 Zalman','5376154989811',17.89,48,78),(17,2,'Mouse Óptico Microsoft Mobile 3500 GMF','1528215137169',48.99,79,43),(18,2,'Mouse Esfera Sapinho JetLine','9570211671743',2.39,4.5,15),(19,2,'Mouse Leadership Clamshe 979','9900169705913',39.54,59.9,23),(20,2,'Mouse Bungee Apuri Roc-15-310 Roccat','5553311568672',79.99,184.67,4),(21,3,'Headset Razer Tiamat','7331498602955',577.28,1049.9,2),(22,3,'Headset TT Esports Dracco Captain Preto','6704132328441',250,438,12),(23,3,'Headset Gold Vizar','1800330202895',376,429.89,17),(24,3,'Headset Corsair Vengeance 1500V2','3764237025291',300,413.01,24),(25,3,'Headset SteelSeries Guild Wars 261282','1558328142578',289.9,413.01,30),(26,3,'Headset Thrustmaster Y-250C','6146526954814',344.9,404.91,0),(27,3,'Headset Turtle Beach X32 ','7280466950326',250,399.99,27),(28,3,'Headset SteelSeries Sibéria V2','9847569817465',278,389.9,33),(29,3,'Headset Thermaltake TT Shock','1987435698423',395.9,459.85,14),(30,3,'Headset Corsair Rampage VI','7564239876598',678.9,1200,5);
--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
CREATE TABLE `compra` (
  `id_compra` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `data_compra` date DEFAULT NULL,
  `nota_fiscal_compra` varchar(45) DEFAULT NULL,
  `id_fornecedor_compra` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id_compra`),
  KEY `id_fornecedor_compra` (`id_fornecedor_compra`),
  CONSTRAINT `compra_ibfk_1` FOREIGN KEY (`id_fornecedor_compra`) REFERENCES `fornecedor` (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `compra`
--

INSERT INTO `compra` VALUES (1,'2015-01-23','908236472938-34',1),(2,'2015-03-03','867235986356-98',2),(3,'2015-02-22','980672309869-22',3),(4,'2015-08-08','098136498304-03',4),(5,'2015-05-11','098436514904-66',5),(6,'2015-01-20','908236472938-34',1),(7,'2015-03-20','867235986356-98',2),(8,'2015-06-06','980672309869-22',3),(9,'2015-07-07','098136498304-03',4),(10,'2015-08-09','098436514904-66',5),(11,'2015-08-13','198436751490-16',6),(12,'2015-09-08','298436514904-00',7),(13,'2015-09-01','398436514904-20',8),(14,'2015-09-01','498436514904-24',9),(15,'2015-09-01','598436514904-45',10),(16,'2015-04-20','698436514904-81',11),(17,'2015-09-01','798436514904-82',12),(18,'2015-09-01','898436514904-78',13),(19,'2015-09-01','998436514904-34',14),(20,'2015-09-01','008436514904-12',15),(21,'2015-09-01','000436514904-24',16),(22,'2015-09-01','090436514904-54',17),(23,'2015-09-02','090436514904-45',18),(24,'2015-09-02','008436514904-21',19),(25,'2015-09-02','098132514904-14',20),(26,'2015-09-02','908236472938-34',1),(27,'2015-09-02','867235986356-98',2),(28,'2015-09-02','980672309869-47',3),(29,'2015-09-02','098136498304-01',4),(30,'2015-09-02','098436514904-61',5),(31,'2015-09-02','098436514904-11',6),(32,'2015-09-02','098436514904-20',7),(33,'2015-09-02','098436514904-79',8),(34,'2015-09-02','098436514904-36',9),(35,'2015-09-02','098436514904-47',10),(36,'2015-09-02','098436514904-89',11),(37,'2015-09-02','098436514904-10',12),(38,'2015-09-02','098436514904-11',13),(39,'2015-08-08','098436514904-12',14),(40,'2015-08-08','098436514904-13',15),(41,'2015-08-08','098436514904-82',16),(42,'2015-08-08','098436514904-39',17),(43,'2015-08-08','098436514904-12',18),(44,'2015-08-08','098436514904-39',19),(45,'2015-08-08','098436514904-17',20),(46,'2015-08-08','900236070938-34',1),(47,'2015-08-08','067035986306-08',1),(48,'2015-08-08','900672309809-02',1),(49,'2015-08-08','008136498304-03',2),(50,'2015-08-08','090436510904-06',2),(51,'2015-08-08','190036701494-00',2),(52,'2015-08-08','208436514904-00',2),(53,'2015-08-08','398436510001-20',2),(54,'2015-08-08','498436514900-24',2),(55,'2015-08-08','598436514904-45',3),(56,'2015-08-08','698436514903-81',3),(57,'2015-08-08','798436514904-82',3),(58,'2015-08-08','898436514905-78',3),(59,'2015-08-08','998436514904-34',3),(60,'2015-08-08','008436514906-12',3),(61,'2015-08-08','000436514907-24',3),(62,'2015-08-08','090436514904-54',3),(63,'2015-08-08','990436514908-45',3),(64,'2015-08-08','708436514909-21',3),(65,'2015-08-08','308132514900-14',4),(66,'2015-08-08','908236470908-34',4),(67,'2015-08-08','800205986356-08',4),(68,'2015-08-08','940602309860-07',4),(69,'2015-08-08','038136498304-01',4),(70,'2015-08-08','018436514904-60',4),(71,'2015-08-08','041436514904-10',4),(72,'2015-08-08','092436514904-00',4),(73,'2015-08-08','028436514904-09',4),(74,'2015-08-08','018436514904-30',4),(75,'2015-08-08','008036514904-07',5);

--
-- Table structure for table `entrada`
--

DROP TABLE IF EXISTS `entrada`;
CREATE TABLE `entrada` (
  `id_compra_entrada` int(10) unsigned NOT NULL,
  `id_produto_entrada` int(10) unsigned NOT NULL,
  `quantidade_entrada` int(11) NOT NULL,
  PRIMARY KEY (`id_compra_entrada`,`id_produto_entrada`),
  KEY `id_produto_entrada` (`id_produto_entrada`),
  CONSTRAINT `entrada_ibfk_1` FOREIGN KEY (`id_compra_entrada`) REFERENCES `compra` (`id_compra`),
  CONSTRAINT `entrada_ibfk_2` FOREIGN KEY (`id_produto_entrada`) REFERENCES `produto` (`id_produto`)
);

--
-- Dumping data for table `entrada`
--

INSERT INTO `entrada` VALUES (1,1,20),(2,2,20),(3,3,20),(4,4,10),(5,5,10),(6,1,50),(7,2,50),(8,3,60),(9,4,70),(10,5,60),(11,6,20),(12,7,10),(13,8,50),(14,9,60),(15,10,10),(16,11,10),(17,12,10),(18,13,10),(19,14,10),(20,15,20),(21,16,40),(22,17,10),(23,18,10),(24,19,10),(25,20,60),(26,21,20),(27,22,20),(28,23,10),(29,24,20),(30,25,10),(31,26,10),(32,27,10),(33,28,10),(34,29,10),(35,30,10),(36,1,30),(37,2,40),(38,10,50),(39,3,60),(40,10,40),(41,11,80),(42,12,20),(43,4,30),(44,5,20),(45,6,30),(46,7,20),(47,11,20),(48,20,30),(49,30,30),(50,17,20),(51,1,20),(52,2,20),(53,3,20),(54,4,10),(55,5,10),(56,1,50),(57,2,50),(58,3,60),(59,4,70),(60,5,60),(61,6,20),(62,7,10),(63,8,50),(64,9,60),(65,10,10),(66,11,10),(67,12,10),(68,13,10),(69,14,10),(70,15,20);




--
-- Table structure for table `venda`
--


--
-- Table structure for table `vendedor`
--
CREATE TABLE `vendedor` (
  `id_vendedor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome_vendedor` varchar(50) NOT NULL,
  `cpf_vendedor` char(14) NOT NULL,
  `endereco_vendedor` varchar(100) DEFAULT 'Endereço não cadastrado',
  PRIMARY KEY (`id_vendedor`)
);

--
-- Dumping data for table `vendedor`
--

INSERT INTO `vendedor` VALUES (1,'Marina Costa Sousa','510.907.187-05','Avenida Dom Orlando Chaves, 724, Várzea Grande-MT'),(2,'Luana Costa Almeida','834.654.412-06','Avenida Primavera, 1102, Goiânia-GO'),(3,'Sophia Cavalcanti Carvalho','937.433.482-84','Rua Luiz Brambilla, 1089, Curitiba-PR'),(4,'Arthur Azevedo Costa','982.356.302-06','Rua Félix Antônio da Silva, 607, São Gonçalo-RJ'),(5,'Nicolas Martins Cunha','711.728.859-07','Rua Ângelo Capricho, 837, São Paulo-SP');

CREATE TABLE `venda` (
  `id_venda` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_cliente_venda` int(10) unsigned NOT NULL,
  `id_vendedor_venda` int(10) unsigned NOT NULL,
  `data_venda` date DEFAULT NULL,
  `data_pagto` date DEFAULT NULL,
  `status_venda` char(1) DEFAULT NULL,
  `data_vencimento` date DEFAULT NULL,
  PRIMARY KEY (`id_venda`),
  KEY `id_cliente_venda` (`id_cliente_venda`),
  KEY `id_vendedor_venda` (`id_vendedor_venda`),
  CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`id_cliente_venda`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`id_vendedor_venda`) REFERENCES `vendedor` (`id_vendedor`)
);

--
-- Dumping data for table `venda`
--

INSERT INTO `venda` VALUES (1,1,1,'2015-11-20','2015-12-19',NULL,'2015-12-20'),(2,2,2,'2015-11-20','2015-12-19',NULL,'2015-12-20'),(3,3,3,'2015-11-20','2015-12-19',NULL,'2015-12-20'),(4,4,4,'2015-11-20','2015-12-19',NULL,'2015-12-20'),(5,5,5,'2015-11-20','2015-12-19',NULL,'2015-12-20'),(6,1,1,'2015-12-19','2016-01-19',NULL,'2016-01-18'),(7,2,2,'2015-12-19','2016-01-19',NULL,'2016-01-18'),(8,3,3,'2015-12-19','2016-01-19',NULL,'2016-01-18'),(9,4,4,'2015-12-19','2016-01-19',NULL,'2016-01-18'),(10,5,5,'2015-12-19','2016-01-19',NULL,'2016-01-18'),(11,6,1,'2015-12-19','2016-01-19',NULL,'2016-01-18'),(12,7,2,'2015-12-19','2016-01-19',NULL,'2016-01-18'),(13,8,3,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(14,9,4,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(15,10,5,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(16,11,1,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(17,12,2,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(18,13,3,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(19,14,4,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(20,15,5,'2016-01-06','2016-02-05',NULL,'2016-02-05'),(21,16,1,'2016-02-05','2016-03-04',NULL,'2016-03-06'),(22,17,2,'2016-02-05','2016-03-04',NULL,'2016-03-06'),(23,18,3,'2016-02-05','2016-03-04',NULL,'2016-03-06'),(24,19,4,'2016-02-05','2016-03-04',NULL,'2016-03-06'),(25,20,5,'2016-02-05','2016-03-04',NULL,'2016-03-06'),(26,21,1,'2016-02-29',NULL,NULL,'2016-03-30'),(27,22,2,'2016-02-29',NULL,NULL,'2016-03-30'),(28,23,3,'2016-02-29',NULL,NULL,'2016-03-30'),(29,24,4,'2016-02-29',NULL,NULL,'2016-03-30'),(30,25,5,'2016-02-29',NULL,NULL,'2016-03-30'),(31,26,1,'2016-02-29',NULL,NULL,'2016-03-30'),(32,27,2,'2016-02-29',NULL,NULL,'2016-03-30'),(33,28,3,'2016-02-29',NULL,NULL,'2016-03-30'),(34,29,4,'2016-02-29',NULL,NULL,'2016-03-30'),(35,30,5,'2016-02-29',NULL,NULL,'2016-03-30'),(36,31,1,'2016-02-29',NULL,NULL,'2016-03-30'),(37,32,2,'2016-02-29',NULL,NULL,'2016-03-30'),(38,33,3,'2016-02-29',NULL,NULL,'2016-03-30'),(39,34,4,'2016-02-29',NULL,NULL,'2016-03-30'),(40,35,5,'2016-02-29',NULL,NULL,'2016-03-30'),(41,36,1,'2016-02-29',NULL,NULL,'2016-03-30'),(42,37,2,'2016-02-29',NULL,NULL,'2016-03-30'),(43,38,3,'2016-02-29',NULL,NULL,'2016-03-30'),(44,39,4,'2016-02-29',NULL,NULL,'2016-03-30'),(45,40,5,'2016-02-29',NULL,NULL,'2016-03-30'),(46,41,1,'2016-02-29',NULL,NULL,'2016-03-30'),(47,42,2,'2016-02-29',NULL,NULL,'2016-03-30'),(48,43,3,'2016-02-29',NULL,NULL,'2016-03-30'),(49,44,4,'2016-02-29',NULL,NULL,'2016-03-30'),(50,45,5,'2016-02-29',NULL,NULL,'2016-03-30'),(51,46,1,'2016-02-29',NULL,NULL,'2016-03-30'),(52,47,2,'2016-02-29',NULL,NULL,'2016-03-30'),(53,48,3,'2016-02-29',NULL,NULL,'2016-03-30'),(54,49,4,'2016-02-29',NULL,NULL,'2016-03-30'),(55,50,5,'2016-02-29',NULL,NULL,'2016-03-30'),(56,1,1,'2016-02-29',NULL,NULL,'2016-03-30'),(57,2,2,'2016-02-29',NULL,NULL,'2016-03-30'),(58,3,3,'2016-02-29',NULL,NULL,'2016-03-30'),(59,4,4,'2016-02-29',NULL,NULL,'2016-03-30'),(60,5,5,'2016-02-29',NULL,NULL,'2016-03-30');

--
-- Table structure for table `saida`
--

CREATE TABLE `saida` (
  `id_venda_saida` int(10) unsigned NOT NULL,
  `id_produto_saida` int(10) unsigned NOT NULL,
  `quantidade_saida` int(11) NOT NULL,
  PRIMARY KEY (`id_venda_saida`,`id_produto_saida`),
  KEY `id_produto_saida` (`id_produto_saida`),
  CONSTRAINT `saida_ibfk_1` FOREIGN KEY (`id_venda_saida`) REFERENCES `venda` (`id_venda`),
  CONSTRAINT `saida_ibfk_2` FOREIGN KEY (`id_produto_saida`) REFERENCES `produto` (`id_produto`)
);

--
-- Dumping data for table `saida`
--

INSERT INTO `saida` VALUES (1,1,131),(2,1,3),(3,2,15),(4,3,20),(5,4,10),(6,5,10),(7,6,10),(8,7,15),(9,8,20),(10,9,1),(11,10,10),(12,11,1),(13,12,1),(14,13,2),(15,14,15),(16,15,13),(17,18,12),(18,19,15),(19,20,20),(20,22,10),(21,1,1),(22,2,1),(23,3,15),(24,4,30),(25,5,10),(26,6,1),(27,7,30),(28,8,15),(29,9,20),(30,10,17),(31,11,18),(32,12,19),(33,13,15),(34,14,21),(35,15,22),(36,16,10),(37,17,12),(38,18,13),(39,19,24),(40,20,14),(41,21,17),(42,22,18),(43,23,15),(44,24,20),(45,25,10),(46,26,10),(47,27,10),(48,28,15),(49,29,20),(50,30,10),(51,1,30),(52,1,10),(53,3,15),(54,4,20),(55,2,40);
