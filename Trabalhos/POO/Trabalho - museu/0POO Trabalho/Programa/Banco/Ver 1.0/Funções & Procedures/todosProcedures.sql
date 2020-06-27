 use artiumsystem;

-- |====================================================================================|
-- |========================== Login & Usuario =========================================|
-- |====================================================================================|



drop procedure if exists prVerificarLogin;

delimiter ||
create procedure prVerificarLogin(in jCodACartao varchar(20), in jSenha longtext,in jTipoUsuario varchar(80), out result varchar(80))
begin
	declare verificaSenha longtext;
    declare verificaCartao varchar(100);
    declare verificaTipAcesso varchar(100);
    
    select senha from login where senha = md5(jSenha) into verificaSenha;
    select codCartao from login where codCartao = jCodACartao into verificaCartao;
    select tipoAcesso from login where codCartao = jCodACartao and tipoAcesso = jTipoUsuario into verificaTipAcesso;
    
       if verificaSenha <> md5(jSenha) and verificaTipAcesso = 'funcionario'then
			select result ='senha esta errada';
	   elseif verificaCartao <> jCodACartao and verificaTipAcesso = 'funcionario' then
			select result = 'número de cartão esta errada';
	   elseif verificaSenha <> md5(jSenha) and verificaTipAcesso = 'visitante' then
			select result = 'senha esta errada';
	   elseif verificaCartao <> jCodACartao and verificaTipAcesso = 'visitante' then
			select result = 'número de cartão esta errada';
	   elseif verificaCartao = jCodACartao and verificaSenha = md5(jSenha) and verificaTipAcesso = 'visitante' then
			select result = 'Bem-vindo visitante';
		elseif verificaCartao = jCodACartao and verificaSenha = md5(jSenha) and verificaTipAcesso = 'funcionario' then
			select result = 'Bem-vindo funcionario';
	   else
		select result = 'tente novamente, verifique o tipo de usuario';
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



