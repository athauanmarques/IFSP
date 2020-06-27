-- criando banco
drop database if exists loja;
create database loja;

-- utilizando o banco
use loja;

-- criando tabelas
create table clientes 
(
	codigo int auto_increment not null,
	nome varchar(100),
	email varchar(100),
	telefone varchar(80),
	primary key (codigo)
);

create table produtos
(
	codigo int auto_increment not null,
	nome varchar(100),
	preco decimal(10,2),
	estoque int,
	primary key (codigo)
);

create table vendas
(
	codigo int auto_increment not null,
	`data` date,
	quantidade int,
	faturado bit,
	codigocliente int,
	codigoproduto int,
	primary key (codigo),
	foreign key (codigocliente) REFERENCES clientes(codigo),
	foreign key (codigoproduto) REFERENCES Produtos(codigo)
);