-- tudo ok crud do banco



use artiumSystem;
-- ============================================================= Teste CRUD =============================================================

-- *********************** Inserts **************************

-- usuario & login
insert into login(nome,codCartao,senha,tipoAcesso) values('Athauan','VIS18456dfgd',md5('123456'),'visitante');
insert into usuario(telefone,dataNascimento,sexo,email,receberConvite,cargo,numeroRA,idLogin_tbLogin)values ('9874521','1989-10-22','m','Athauan@oi.com',true,'CEO','2154-8',1);

-- vendas & estoque
insert into estoque(codProduto,produto,marca,descricaoProduto,preco,qtsEstoque) values ('25157-8','leite','longa vida','é muito bom',125.2,10);
insert into vendas(idEstoque_tbEstoque,idUsuario_tbUsuario,quantidadeVendas,dataVenda) values (1,1,101,'2017-09-03');

-- acervo
insert into acervo(titulo,descricao,periodo,dataInicio,dataFinal,cidade,endereco,estado,cep,responsavel,telResponvel,limiteReserva,maxVisitante,enviarConvites)
values('Imperio Romano','Arte e a beleza Romana','permanente','2017-02-22','2017-02-25','Bragança','Rua: longa vida - 265','RJ','12365-5','Caio Alvez','4585-5462',10,200,true);

-- reservas_convites
insert into reservas_convites(idAcervo_tbAcervo,idUsuario_tbUsuario,reservar,convidado)values(1,1,1,true);

-- restauracao
insert into restauracao(statusRestaurar,prazoFinal,vezesRestaurado,idAcervo_tbAcervo,idUsuario_tbUsuario) 
values ('analise','2017-02-02',0,1,1);

/*
-- *********************** Updade **************************
update login set nome = 'Bruna' where idLogin = 1;
select * from login;

update usuario set sexo = 'f' where idUsuario =1;
select * from usuario;

update acervo set responsavel = 'Camila'where idAcervo =1;
select * from acervo;

update restauracao set vezesRestaurado ='2000' where idRestauracao =1;
select * from restauracao;

update estoque set produto = 'Macarrão' where idEstoque =1;
select * from estoque;
*/
-- *********************** Delete **************************

/* Tudo ok
Delete from login where idlogin =1;
select * from usuario;

Delete from usuario where idUsuario =1;
select * from usuario;

Delete from acervo where idAcervo =1;
select * from acervo;

Delete from restauracao where idRestauracao =1;
select * from restauracao;

Delete from estoque where idEstoque =1;
select * from estoque;

*/

-- *********************** Consultas **************************
/*
select * from login inner join usuario;
select idLogin from login where idLogin = LAST_INSERT_ID();
 
select * from estoque inner join vendas;
select * from acervo;
select * from restauracao;
select * from reservas_convites innser join usuario, acervo;

*/




