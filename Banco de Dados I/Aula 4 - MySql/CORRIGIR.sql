-- exclui o banco, se ja existir --
drop database if exists cliente ;

-- criando banco de dados --
create database cliente ;

-- selecionando o banco de dados --
use cliente;

-- criando tabelas
CREATE TABLE cliente
(
   CODCLIENTE INT NOT NULL auto_increment PRIMARY KEY,
   NOMECLIENTE CHAR (30),
   ENDERECO varchar(200), -- VARCHAR É LIMITE DE CARACTER--
   SEXO ENUM('FEMININO','MASCULINO'), -- VALORES ESPECIFICOS, NESTE CASO ESTA SENDO USADO FEMININO E MASCULINO--
   CIDADE CHAR(30)	DEFAULT 'Bragança Paulista', -- DEFAULT AUTO INCREMENTO
   CGC 	CHAR(30)  UNIQUE -- UNIQUE NÃO PODE REPETIR O VALOR ENSERIDO NO 'CGC'--

);

-- TESTE --

insert into cliente 
value (Null, 'Bianca', 'Rua xxx', 'FEMININO', 'Bragança Paulista','123456');
Insert into cliente 
value (Null, 'Arnaldo', 'Rua ABC', 'MASCULINO', NULL, '654321');
Insert into cliente 
value ('Pablo', 'Av. Amora', 'MASCULINO',  ,'765432');




select * from cliente;

