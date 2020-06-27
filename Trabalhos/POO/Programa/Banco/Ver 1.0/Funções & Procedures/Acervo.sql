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
