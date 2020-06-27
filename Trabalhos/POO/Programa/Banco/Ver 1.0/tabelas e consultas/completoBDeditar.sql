-- |====================================================================================|
-- |========================== Banco de dados =========================================|
-- |====================================================================================|



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

 use artiumsystem;

-- |====================================================================================|
-- |========================== Login & Usuario =========================================|
-- |====================================================================================|

drop procedure if exists prVerificarLogin;

delimiter ||
create procedure prVerificarLogin(in jCodACartao varchar(20), in jSenha longtext,in jTipoUsuario varchar(80))
begin
	declare verificaSenha longtext;
    declare verificaCartao varchar(100);
    declare verificaTipAcesso varchar(100);
    
    select senha from login where senha = md5(jSenha) into verificaSenha;
    select codCartao from login where codCartao = jCodACartao into verificaCartao;
    select tipoAcesso from login where codCartao = jCodACartao and tipoAcesso = jTipoUsuario into verificaTipAcesso;
    
       if verificaSenha <> md5(jSenha) and verificaTipAcesso = 'funcionario'then
			select 'senha esta errada';
	   elseif verificaCartao <> jCodACartao and verificaTipAcesso = 'funcionario' then
			select 'número de cartão esta errada';
	   elseif verificaSenha <> md5(jSenha) and verificaTipAcesso = 'visitante' then
			select 'senha esta errada';
	   elseif verificaCartao <> jCodACartao and verificaTipAcesso = 'visitante' then
			select 'número de cartão esta errada';
	   elseif verificaCartao = jCodACartao and verificaSenha = md5(jSenha) and verificaTipAcesso = 'visitante' then
			select 'Bem-vindo visitante';
		elseif verificaCartao = jCodACartao and verificaSenha = md5(jSenha) and verificaTipAcesso = 'funcionario' then
			select 'Bem-vindo funcionario';
	   else
		select 'tente novamente, verifique o tipo de usuario';
end if;

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

-- |====================================================================================|
-- |========================= Acervo & reserva_convites ================================|
-- |====================================================================================|

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


-- |====================================================================================|
-- |================================= restauração ======================================|
-- |====================================================================================|
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

-- |====================================================================================|
-- |============================ estoque & vendas ======================================|
-- |====================================================================================|


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



-- |====================================================================================|
-- |=========================== Inserts inicial ========================================|
-- |====================================================================================|

call cadastrarVistante('Athauan','visitante','vis1248-7','123456','74495-5214','1989-10-22','m','atha@br.gov',true);
call cadastrarVistante('caio','visitante','vis52548-8','kikoMais','8547-6987','1991-06-12','m','cainho@br.gov',false);
call cadastrarVistante('tayonan','visitante','vis2758-0','tayoFrz2','3257-8752','1992-01-02','m','atha@br.gov',true);
call cadastrarFuncionario('Bruna','funcionario','fun25793-7','buhStart','9985-3274','1992-05-27','m','atha@br.gov', 'gerente','ge12354-1');
call prAdicionarAcervo('Imperio romano','Arte e a beleza Romana','permanente','2017-02-22','2017-02-25','Bragança','Rua: longa vida - 265','RJ','12365-5','Caio Alvez','4585-5462',10,200,true);
call reservarEvento(2, 1);
call prSolicitarRestauracao('2017-09-05',1,2);
call prEntradaProduto('25157-8','leite','longa vida','é muito bom',125.2,10);
call prEfetuarCompra(1,1,3);

