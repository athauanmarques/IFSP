/*Metodos TODOS OKs
============ acervo ====================
void adicionarAcervo(String titilo, String descricao, String periodo, DATE dataInicio
DATE dataFinal, String cidade, String endereco, String estado, String cep, String responsavel,
String telResponsavel, int limiteReserva, int maxVisitante,boolean enviarConvites); ok

void excluirAcervo(int idAcervo); ok

void editarAcervo(String titilo, String descricao, String periodo, DATE dataInicio
DATE dataFinal, String cidade, String endereco, String estado, String cep, String responsavel,
String telResponsavel, int limiteReserva, int maxVisitante,boolean enviarConvites); ok

ListArry<Acervos> exbirEventosVis();-- REALIZADO NO JAVA
ListArry<Acervos> exbirEventosFun(); -- REALIZADO NO JAVA
ListArry<Acervos> exbirEventosFunRealizados(); -- REALIZADO NO JAVA
ListArry<Acervos> exbirEventosFunEsp(int idAcervo); -- REALIZADO NO JAVA

================ reserva_convites =================== arrumar use while
modelos funcinario e acervo

void aceitarConvite(int idAcervo, idUsuario, int reservar); ok
void cancelarReserva(int idAcervo, int idUsuario); ok
listArry<Reserva_convites>(int idUsuario)  -- REALIZADO NO JAVA
void qtsReservado(int idAcervo) ok
*/
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

create procedure prAdicionarAcervo(in jTitilo varchar(35), in jDescricao longtext, 
in jCategorias varchar(45),in jAutorias varchar(30), in jOrigem varchar(30),in jMaterial varchar(30))
begin
	declare Convite boolean;
    declare novoId int;
    declare contador int default 1;
    declare contVistantes int;
	declare idConvitesTrue int;
	
    select count(idUsuario) from usuario into contVistantes;
    select enviarConvites from exposicoes where idExposicao = LAST_INSERT_ID() into Convite;
    
/*Obrigar o usuário para realizar o cadastro de exibição*/
if Convite = true  then
	insert into acervo(titulo,descricao,categorias,autorias,origem,materiais)
	values(jTitilo,jDescricao,jCategorias,jAutorias,jOrigem,jMaterial);
	select idInventario from acervo where idInventario = LAST_INSERT_ID() into novoId;
    while contador <= contVistantes do 
		insert into reservas_convites(exposicoes_idExposicao,idUsuario_tbUsuario,reservar,convidado)values(novoId,contador,0,true);
		set contador = contador + 1;
	END WHILE ;
    
else
	insert into acervo(titulo,descricao,categorias,autorias,origem,materiais)
	values(jTitilo,jDescricao,jCategorias,jAutorias,jOrigem,jMaterial);
	select idInventario from acervo where idInventario = LAST_INSERT_ID() into novoId;
    while contador <= contVistantes do 
		insert into reservas_convites(exposicoes_idExposicao,idUsuario_tbUsuario,reservar,convidado)values(novoId,contador,0,false);
		set contador = contador + 1;
	END WHILE ;
end if;

end;
|| delimiter ;

drop procedure if exists prAdicionarExposicoes;

delimiter ||
create procedure prAdicionarExposicoes(in jPeriodo varchar(25),in jDataInicio DATE,in jDataFinal DATE,in jCidade VARCHAR(25),
in jEndereco VARCHAR(110),in jEstado VARCHAR(2),in jCep VARCHAR(9),in jResponsavel varchar(25),in jTelResponvel varchar(12),
in jLimiteReserva int,in jMaxVisitante int,in jEnviarConvites TINYINT)
begin
	Declare idAcervo int;
	select idInventario from acervo where idInventario = last_insert_id() into idAcervo;
    insert into exposicoes(periodo,dataInicio,dataFinal,cidade,endereco,estado,cep,responsavel,telResponvel,limiteReserva,maxVisitante,enviarConvites,acervo_idInventario)
    values (jPeriodo,jDataInicio,jDataFinal,jCidade,jEndereco,jEstado,jCep,jResponsavel,jTelResponvel,jLimiteReserva,jMaxVisitante,jEnviarConvites,idAcervo);
end;
|| delimiter ;

drop procedure if exists prExcluirExposicao;

delimiter ||

create procedure prExcluirExposicao(in jIdAcervo int)
begin
	delete from acervo where idInventario = jIdAcervo;
    delete from exposicoes where idExposicao = jIdAcervo;
end;

|| delimiter ;
