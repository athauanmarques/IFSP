
drop database if exists banco;
create database banco;
use banco;


create table cliente(
id bigint not null auto_increment,
nome varchar(255) not null,
cpf varchar(15) not null,
primary key(id)
); --  engine= InnoDB;

set foreign_key_checks=0;

create table conta(
	idConta BIGINT NOT NULL AUTO_INCREMENT,
    numero VARCHAR(255) not null,
    saldo DOUBLE not null,
    cliente_id BIGINT NOT NULL,
    primary key (idConta),
    CONSTRAINT fk_cliente FOREIGN KEY fk_cliente ( cliente_id )
    references cliente(id)
    on delete restrict
    on update restrict
    
); -- engine= InnoDB;


set foreign_key_checks=0;

insert into cliente(nome,cpf) values("maria jose","42135144302");
insert into cliente(nome,cpf) values("jusefina pereira","52145244302");
insert into cliente(nome,cpf) values("matheus cavaleira","12145244302");

insert into conta(numero,saldo,cliente_id) values('44911-1',2300,1);
insert into conta(numero,saldo,cliente_id) values('52021-2',4500,2);
insert into conta(numero,saldo,cliente_id) values('31000-1',0,3);

select * from cliente;
select * from conta;