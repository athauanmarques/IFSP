-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: artiumsystem
-- ------------------------------------------------------
-- Server version	5.7.19-log

Drop Database if exists artiumsystem;
create database artiumsystem;
use artiumsystem;

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
-- Table structure for table `acervo`
--

DROP TABLE IF EXISTS `acervo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acervo` (
  `idAcervo` int(11) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(45) NOT NULL,
  `descricao` longtext,
  `periodo` enum('temporario','permanente') NOT NULL,
  `dataInicio` date DEFAULT NULL,
  `dataFinal` date DEFAULT NULL,
  `cidade` varchar(25) NOT NULL,
  `endereco` varchar(110) NOT NULL,
  `estado` varchar(2) NOT NULL DEFAULT 'SP',
  `cep` varchar(9) DEFAULT NULL,
  `responsavel` varchar(25) NOT NULL,
  `telResponvel` varchar(12) NOT NULL,
  `limiteReserva` int(11) NOT NULL,
  `maxVisitante` int(11) NOT NULL,
  `enviarConvites` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idAcervo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acervo`
--

LOCK TABLES `acervo` WRITE;
/*!40000 ALTER TABLE `acervo` DISABLE KEYS */;
/*!40000 ALTER TABLE `acervo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estoque`
--

DROP TABLE IF EXISTS `estoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estoque` (
  `idEstoque` int(11) NOT NULL AUTO_INCREMENT,
  `codProduto` varchar(20) NOT NULL,
  `produto` varchar(45) NOT NULL,
  `marca` varchar(15) NOT NULL,
  `descricaoProduto` longtext,
  `preco` double NOT NULL,
  `qtsEstoque` int(11) NOT NULL,
  PRIMARY KEY (`idEstoque`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estoque`
--

LOCK TABLES `estoque` WRITE;
/*!40000 ALTER TABLE `estoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login` (
  `idLogin` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `codCartao` varchar(20) NOT NULL,
  `senha` longtext NOT NULL,
  `tipoAcesso` enum('visitante','funcionario') NOT NULL,
  PRIMARY KEY (`idLogin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservas_convites`
--

DROP TABLE IF EXISTS `reservas_convites`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reservas_convites` (
  `idAcervo_tbAcervo` int(11) NOT NULL,
  `idUsuario_tbUsuario` int(11) NOT NULL,
  `reservar` int(11) DEFAULT '0',
  `convidado` binary(1) DEFAULT '0',
  PRIMARY KEY (`idAcervo_tbAcervo`,`idUsuario_tbUsuario`),
  KEY `fk_Acervo_has_usuario_usuario1_idx` (`idUsuario_tbUsuario`),
  KEY `fk_Acervo_has_usuario_Acervo1_idx` (`idAcervo_tbAcervo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservas_convites`
--

LOCK TABLES `reservas_convites` WRITE;
/*!40000 ALTER TABLE `reservas_convites` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservas_convites` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restauracao`
--

DROP TABLE IF EXISTS `restauracao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `restauracao` (
  `idRestauracao` int(11) NOT NULL AUTO_INCREMENT,
  `statusRestaurar` enum('analise','andamento','concluido','cancelado') NOT NULL DEFAULT 'analise',
  `prazoInicio` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `prazoFinal` datetime NOT NULL,
  `vezesRestaurado` int(11) DEFAULT '0',
  `idAcervo_tbAcervo` int(11) NOT NULL,
  `idUsuario_tbUsuario` int(11) NOT NULL,
  PRIMARY KEY (`idRestauracao`,`idAcervo_tbAcervo`,`idUsuario_tbUsuario`),
  KEY `fk_restauracao_Acervo1_idx` (`idAcervo_tbAcervo`),
  KEY `fk_restauracao_usuario1_idx` (`idUsuario_tbUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restauracao`
--

LOCK TABLES `restauracao` WRITE;
/*!40000 ALTER TABLE `restauracao` DISABLE KEYS */;
/*!40000 ALTER TABLE `restauracao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `telefone` varchar(12) NOT NULL,
  `dataNascimento` date NOT NULL,
  `sexo` varchar(1) NOT NULL,
  `email` varchar(45) NOT NULL,
  `receberConvite` tinyint(4) DEFAULT '0',
  `cargo` varchar(80) DEFAULT 'colaborador',
  `numeroRA` varchar(20) DEFAULT NULL,
  `idLogin_tbLogin` int(11) NOT NULL,
  PRIMARY KEY (`idUsuario`,`idLogin_tbLogin`),
  KEY `fk_usuario_Login_idx` (`idLogin_tbLogin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendas`
--

DROP TABLE IF EXISTS `vendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vendas` (
  `idEstoque_tbEstoque` int(11) NOT NULL,
  `idUsuario_tbUsuario` int(11) NOT NULL,
  `quantidadeVendas` int(11) NOT NULL,
  `dataVenda` datetime NOT NULL,
  PRIMARY KEY (`idEstoque_tbEstoque`,`idUsuario_tbUsuario`),
  KEY `fk_estoque_has_usuario_usuario1_idx` (`idUsuario_tbUsuario`),
  KEY `fk_estoque_has_usuario_estoque1_idx` (`idEstoque_tbEstoque`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendas`
--

LOCK TABLES `vendas` WRITE;
/*!40000 ALTER TABLE `vendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-12 14:43:23


drop procedure if exists prVerificarLogin;

delimiter ||
create procedure prVerificarLogin(in jCodACartao varchar(20), in jSenha longtext,in jTipoUsuario varchar(80), out msg varchar(80))
begin
	declare verificaSenha longtext;
    declare verificaCartao varchar(100);
    declare verificaTipAcesso varchar(100);
    
    select senha from login where senha = md5(jSenha) into verificaSenha;
    select codCartao from login where codCartao = jCodACartao into verificaCartao;
    select tipoAcesso from login where codCartao = jCodACartao and tipoAcesso = jTipoUsuario into verificaTipAcesso;
    
       if verificaSenha <> md5(jSenha) and verificaTipAcesso = 'funcionario'then
			set msg = 'senha esta errada';
	   elseif verificaCartao <> jCodACartao and verificaTipAcesso = 'funcionario' then
			set msg = 'número de cartão esta errada';
	   elseif verificaSenha <> md5(jSenha) and verificaTipAcesso = 'visitante' then
			set msg = 'senha esta errada';
	   elseif verificaCartao <> jCodACartao and verificaTipAcesso = 'visitante' then
			set msg = 'número de cartão esta errada';
	   elseif verificaCartao = jCodACartao and verificaSenha = md5(jSenha) and verificaTipAcesso = 'visitante' then
			set msg = 'visitante';
		elseif verificaCartao = jCodACartao and verificaSenha = md5(jSenha) and verificaTipAcesso = 'funcionario' then
			set msg = 'funcionario';
	   else
		set msg = 'tente novamente, verifique o tipo de usuario';
end if;
		select msg;
	end;

|| delimiter ;

drop procedure if exists prRedifinirSenha;

delimiter ||
create procedure prRedifinirSenha(in jNome varchar(200), in jEmail varchar(100), in novaSenha longtext)
begin
	declare verificarNome longtext;
    declare verificarEmail varchar(100);
    declare verificarId int;
    
    select nome from login where nome = jNome into verificarNome;
    select email from usuario where email = jEmail into verificarEmail;
    select idUsuario from usuario where email = jEmail into verificarId; 
    
    if jNome = verificarNome and jEmail = verificarEmail then
		update login set senha = md5(novaSenha) where idLogin = verificarId;
        select 'Nova senha efetuado com sucesso';
	else
		select 'não localizado';
	end if;
end;

|| delimiter ;


drop procedure if exists prExcluirConta;

delimiter ||

create procedure prExcluirConta(in jIdUsuario int)
begin
	delete from usuario where idUsuario = jIdUsuario;
	delete from login where idLogin = jIdUsuario;
end ;

|| delimiter ;

drop procedure if exists prCadastrarVistante;;

Delimiter ||
create procedure  prCadastrarVistante(in jNome varchar(45),in jTipoAcesso varchar(45),in jCodAcesso varchar(45), 
in jSenha longtext, in jTelefone varchar(45),in jDataNascimento Date, in jSexo varchar(45), in jEmail varchar(45), 
in jReceberConvite boolean)
begin
 Declare novoId int;
 
	 insert into login(nome,codCartao,senha,tipoAcesso) values(jNome,jCodAcesso,md5(jSenha),jTipoAcesso);
	select idLogin from login where idLogin = LAST_INSERT_ID() into novoId;
	insert into usuario(telefone,dataNascimento,sexo,email,receberConvite,cargo,numeroRA,idLogin_tbLogin)
	values (jTelefone,jDataNascimento,jSexo,jEmail,jReceberConvite,NULL,NULL,novoId);

end ;
|| delimiter ;

drop procedure if exists prCadastrarFuncionario;;

Delimiter ||
create procedure  prCadastrarFuncionario(in jNome varchar(45),in jTipoAcesso varchar(45),in jCodAcesso varchar(45), 
in jSenha longtext, in jTelefone varchar(45),in jDataNascimento Date, in jSexo varchar(45), in jEmail varchar(45), 
in jCargo varchar(80), in jNumeroRA varchar(90))
begin
 Declare novoId int;
 
	insert into login(nome,codCartao,senha,tipoAcesso) values(jNome,jCodAcesso,md5(jSenha),jTipoAcesso);
	select idLogin from login where idLogin = LAST_INSERT_ID() into novoId;
	insert into usuario(telefone,dataNascimento,sexo,email,receberConvite,cargo,numeroRA,idLogin_tbLogin)
	values (jTelefone,jDataNascimento,jSexo,jEmail,null,jCargo,jNumeroRA,novoId);

end ;
|| delimiter ;

drop procedure if exists prQtsReservados;

delimiter ||
create procedure prQtsReservados(in idEventos int) 
begin
	declare total int;
	select count(reservar) from reservas_convites where reservar = 1 and idAcervo_tbAcervo = idEventos;
end ;
|| delimiter ;

drop procedure if exists prReservarEvento;

delimiter ||
create procedure prReservarEvento(in jIdAcervo int, jIdUsuario int)
begin
	update reservas_convites set reservar = 1 where idAcervo_tbAcervo = jIdAcervo and idUsuario_tbUsuario = jIdUsuario;
end;
|| delimiter ;


drop procedure if exists prCancelarReserva;

delimiter ||
create procedure prCancelarReserva(in jIdAcervo int, jIdUsuario int)
begin
	update reservas_convites set reservar = 0 where idAcervo_tbAcervo = jIdAcervo and idUsuario_tbUsuario = jIdUsuario;
end;
|| delimiter ;


drop procedure if exists prAdicionarAcervo;

delimiter ||

create procedure prAdicionarAcervo(in jTitilo varchar(35), in jDescricao longtext, in jPeriodo varchar(20), in jDataInicio DATE,
in jDataFinal DATE,in jCidade varchar(35), in jEndereco longtext, in jEstado varchar(2), in jCep varchar(25), in jResponsavel varchar(60),
in jTelResponsavel varchar(25),in jLimiteReserva int, in jMaxVisitante int,in jEnviarConvites boolean)
begin
	declare enviarConvites boolean;
    declare novoId int;
    declare contador int default 1;
    declare contVistantes int;
	declare idConvitesTrue int;
	
    select count(idUsuario) from usuario into contVistantes;
    

if jPeriodo = 'permanente' and jEnviarConvites = true  then
	insert into acervo(titulo,descricao,periodo,dataInicio,dataFinal,cidade,endereco,estado,cep,responsavel,telResponvel,limiteReserva,maxVisitante,enviarConvites)
	values(jTitilo,jDescricao,jPeriodo,null,null,jCidade,jEndereco,jEstado,jCep,jResponsavel,jTelResponsavel,jLimiteReserva,jMaxVisitante,jEnviarConvites);
	select idAcervo from acervo where idAcervo = LAST_INSERT_ID() into novoId;
    while contador <= contVistantes do 
		insert into reservas_convites(idAcervo_tbAcervo,idUsuario_tbUsuario,reservar,convidado)values(novoId,contador,0,true);
		set contador = contador + 1;
	END WHILE ;
    
elseif jPeriodo = 'permanente' and jEnviarConvites = false  then
	insert into acervo(titulo,descricao,periodo,dataInicio,dataFinal,cidade,endereco,estado,cep,responsavel,telResponvel,limiteReserva,maxVisitante,enviarConvites)
	values(jTitilo,jDescricao,jPeriodo,null,null,jCidade,jEndereco,jEstado,jCep,jResponsavel,jTelResponsavel,jLimiteReserva,jMaxVisitante,jEnviarConvites);
	select idAcervo from acervo where idAcervo = LAST_INSERT_ID() into novoId;
    while contador <= contVistantes do 
		insert into reservas_convites(idAcervo_tbAcervo,idUsuario_tbUsuario,reservar,convidado)values(novoId,contador,0,false);
		set contador = contador + 1;
	END WHILE ;

elseif jPeriodo = 'temporario' and jEnviarConvites = true  then
	insert into acervo(titulo,descricao,periodo,dataInicio,dataFinal,cidade,endereco,estado,cep,responsavel,telResponvel,limiteReserva,maxVisitante,enviarConvites)
	values(jTitilo,jDescricao,jPeriodo,jDataInicio,jDataFinal,jCidade,jEndereco,jEstado,jCep,jResponsavel,jTelResponsavel,jLimiteReserva,jMaxVisitante,jEnviarConvites);
	select idAcervo from acervo where idAcervo = LAST_INSERT_ID() into novoId;
    while contador <= contVistantes do 
		insert into reservas_convites(idAcervo_tbAcervo,idUsuario_tbUsuario,reservar,convidado)values(novoId,contador,0,true);
		set contador = contador + 1;
	END WHILE ;
elseif jPeriodo = 'temporario' and jEnviarConvites = false  then
	insert into acervo(titulo,descricao,periodo,dataInicio,dataFinal,cidade,endereco,estado,cep,responsavel,telResponvel,limiteReserva,maxVisitante,enviarConvites)
	values(jTitilo,jDescricao,jPeriodo,jDataInicio,jDataFinal,jCidade,jEndereco,jEstado,jCep,jResponsavel,jTelResponsavel,jLimiteReserva,jMaxVisitante,jEnviarConvites);
	while contador <= contVistantes do 
		insert into reservas_convites(idAcervo_tbAcervo,idUsuario_tbUsuario,reservar,convidado)values(novoId,contador,0,false);
		set contador = contador + 1;
	END WHILE ;
end if;

end;
|| delimiter ;


drop procedure if exists prExcluirAcervo;

delimiter ||

create procedure prExcluirAcervo(in jIdAcervo int)
begin
	delete from acervo where idAcervo = jIdAcervo;
end;

|| delimiter ;

drop procedure if exists prSolicitarRestauracao;

DELIMITER ||
create procedure prSolicitarRestauracao(in jPrazo date, in jIdAcervo int, in jIdUsuario int)
begin
	insert into restauracao(statusRestaurar,prazoFinal,vezesRestaurado,idAcervo_tbAcervo,idUsuario_tbUsuario) 
    values ('analise',jPrazo,0,jIdAcervo,jIdUsuario);
end;
|| delimiter ||

drop procedure if exists prAlterarStatus;

DELIMITER ||
create procedure prAlterarStatus(in jStatus varchar(30), in jIdAcervo int, in jIdUsuario int)
begin
	update restauracao set statusRestaurar = jStatus where idAcervo_tbAcervo = jIdAcervo and idUsuario_tbUsuario = jIdUsuario;
end;
|| delimiter ||


drop procedure if exists prEntradaProduto;

delimiter ||
create procedure prEntradaProduto(in jCodProduto varchar(20), in jProduto varchar(80),in jMarca varchar(45), in jDescricaoProduto longtext, in jPreco real,in jQtsEstoque int)
begin
	insert into estoque(codProduto,produto,marca,descricaoProduto,preco,qtsEstoque) values (jCodProduto,jProduto,jMarca,jDescricaoProduto,jPreco,jQtsEstoque);
end;
|| delimiter ;

drop procedure if exists prDeletarProduto;

delimiter ||
create procedure prDeletarProduto(in jIdEstoque int)
begin
	delete from estoque where idEstoque = jIdEstoque;
end;
|| delimiter ;

drop procedure if exists prEditarProduto;
delimiter ||

create procedure prEditarProduto(in jIdEstoque int, in jCodProduto varchar(20), in jProduto varchar(80),in jMarca varchar(45), in jDescricaoProduto longtext, in jPreco real, in jQtsEstoque int)
begin
	UPDATE estoque set codProduto = jCodProduto and produto = jProduto and marca = jMarca and descricaoProduto = jDescricaoProduto and preco = jPreco where idEstoque = jIdEstoque;
end;
|| delimiter ;


drop procedure if exists prEfetuarCompra;

delimiter ||
create procedure prEfetuarCompra(in jIdEstoque int, in jIdUsuario int, in jQtsEstoque int)
begin
	update estoque set qtsEstoque = qtsEstoque - jQtsEstoque where idEstoque = jIdEstoque;
    insert into vendas(idEstoque_tbEstoque,idUsuario_tbUsuario,quantidadeVendas,dataVenda) values (jIdEstoque,jIdUsuario,jQtsEstoque,CURRENT_TIMESTAMP);
end;

 
|| delimiter ;




