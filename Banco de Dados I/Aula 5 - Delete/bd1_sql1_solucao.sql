create database novobd;
use novobd;
create table cliente(
   codcliente 	int not null auto_increment primary key,
   nomecliente 	char(50),
   endereco     varchar(200),
   sexo 		enum('feminino','masculino'),
   cidade 		char(30) 	default 'Braganca Paulista',
   cgc 			char(11) 	unique
);
-- teste
insert into cliente 
values (Null, 'Bianca', 'Rua XXX', 'Feminino', 'Sao Paulo','123456');
insert into cliente 
values (Null, 'Arnaldo','Rua ABC','Masculino',NULL,654321);
insert into cliente(nomecliente, endereco, sexo, cgc)
value ('Pablo','Av. Amora','homem',765432);
insert into cliente(codcliente, nomecliente, endereco,cgc)
values (10,'Marcia','Rua 25',123457);
insert into cliente values
(NULL,	'Pedro',	'Av. 23',	NULL,	NULL,	NULL);

SELECT * FROM novobd.cliente;
