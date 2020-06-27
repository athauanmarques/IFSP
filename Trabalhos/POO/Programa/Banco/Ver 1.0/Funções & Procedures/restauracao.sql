/*
==============  restauração =======================
LListArrry<Restauracao>exibirRestauracoes(); -- JAVA
istArrry<Restauracao>emAnalise(); -- JAVA
ListArrry<Restauracao>emAndamento(); -- JAVA
ListArrry<Restauracao>concluidos(); -- JAVA
cListArrry<Restauracao>ancelados(); -- JAVA
void solicitar(Data prazo, int idAcervo, int idUsuario) ok
void alterarStatus(int idAcervo, int idUsuario, string status); ok
*/
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
