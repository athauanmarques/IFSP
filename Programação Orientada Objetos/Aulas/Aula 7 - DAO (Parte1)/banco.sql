
drop database if exists banco;
create database banco;
use banco;


create table cliente(
	id BIGINT NOt NULL AUTO_INCREMENT,
    nome VARCHAR(255) not null,
    cpf varchar(15) not null,
    primary key (id)
);

-- engine = InnoBD;

insert into cliente(nome, cpf) values ('jose da Silva','3652.568.123-84');
insert into cliente(nome, cpf) values ('jPedro das Neves','258.568.785.-84');
insert into cliente(nome, cpf) values ('Maria Mariana','025.457.123.-22');

create table conta(
	id BIGINT NOT NULL AUTO_INCREMENT,
    numero VARCHAR(255) not null,
    saldo DOUBLE not null,
    cliente_id BIGINT NOT NULL,
    primary key (id),
    CONSTRAINT fk_cliente FOREIGN KEY fk_cliente ( cliente_id )
    references idCliente (id)
    on delete restrict
    on update restrict
    
);
/*


*/
-- engine = InnoBD;

-- UM cliente N CONTAS

insert into conta(numero, saldo, idCliente) values ('16456-1', 2584.60,1);
insert into conta(numero, saldo, idCliente) values ('16456-1', 2584.60,2);
insert into conta(numero, saldo, idCliente) values ('16456-1', 2584.60,3);

SELECT * FROM cliente;