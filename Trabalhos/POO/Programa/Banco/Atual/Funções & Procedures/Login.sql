/* FEITO - REALIZAR TRATAMENTOS DE ERROS
============ Login ===============
boolean verificarLogin(String tipoUsuario, String codAcesso, String Senha) 	OK
void redifinirSenha(String nome, String Email); OK
=============== usuario =================
ListArray<Usuario> listaUsuario (); -- fazer de acordo como JAVA
void alterarUsuario(); // PESQUISAR como se faz
void deletarUsuario(int indUsuario) OK
=========== Cadastros ================
modelo login e usuario

String cadastrarVistante(String nome, String tipoUsuario, String codAcesso, String Senha, String tipoAcesso, String telefone, Date dataNascimento, String sexo, String email, 
boolean receberConvite); ok

String cadastrarFuncionario(String nome, String tipoUsuario, String codAcesso, String Senha, String tipoAcesso, String telefone, Date dataNascimento, String sexo, String email, false, String cargo, String numeroRA)
 ok
*/
use artiumsystem;

drop procedure if exists prVerificarLogin;

delimiter ||
create procedure prVerificarLogin(in jCodACartao varchar(20), in jSenha longtext)
begin
	declare verificaSenha longtext;
    declare verificaCartao varchar(100);
    declare verificaTipAcesso varchar(100);
    
    select senha from login where senha = md5(jSenha) into verificaSenha;
    select codCartao from login where codCartao = jCodACartao into verificaCartao;
    select tipoAcesso from login where codCartao = jCodACartao and tipoAcesso = jTipoUsuario into verificaTipAcesso;
    
       if verificaSenha <> md5(jSenha)then
			select 'senha esta errada';
	   elseif verificaCartao <> jCodACartao then
			select 'número de cartão esta errada';
	   elseif verificaSenha <> md5(jSenha) then
			select 'senha esta errada';
	   elseif verificaCartao = jCodACartao and verificaSenha = md5(jSenha) then
			select 'Bem-vindo';
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
create procedure  prCadastrarVistante(in jNome varchar(45),in jTipoCadastro varchar(45),in jCodAcesso varchar(45), 
in jSenha longtext, in jTelefone varchar(45),in jDataNascimento Date, in jSexo varchar(45), in jEmail varchar(45), 
in jReceberConvite boolean)
begin
 Declare novoId int;
 
	insert into login(nome,codCartao,senha) values(jNome,jCodAcesso,md5(jSenha));
	select idLogin from login where idLogin = LAST_INSERT_ID() into novoId;
	insert into usuario(tipoCadastro,telefone,dataNascimento,sexo,email,receberConvite,cargo,numeroRA,idLogin_tbLogin)
	values (jTipoCadastro,jTelefone,jDataNascimento,jSexo,jEmail,jReceberConvite,NULL,NULL,novoId);

end ;
|| delimiter ;

drop procedure if exists prCadastrarFuncionario;

Delimiter ||
create procedure  prCadastrarFuncionario(in jNome varchar(45),in jTipoCadastro varchar(45),in jCodAcesso varchar(45), 
in jSenha longtext, in jTelefone varchar(45),in jDataNascimento Date, in jSexo varchar(45), in jEmail varchar(45), 
in jCargo varchar(80), in jNumeroRA varchar(90))
begin
 Declare novoId int;
 
	insert into login(nome,codCartao,senha,tipoAcesso) values(jNome,jCodAcesso,md5(jSenha),jTipoAcesso);
	select idLogin from login where idLogin = LAST_INSERT_ID() into novoId;
	insert into usuario(tipoCadastro,telefone,dataNascimento,sexo,email,receberConvite,cargo,numeroRA,idLogin_tbLogin)
	values (jTipoCadastro,jTelefone,jDataNascimento,jSexo,jEmail,null,jCargo,jNumeroRA,novoId);

end ;
|| delimiter ;