-- passo a passo para importar dados csv em bd

-- 1 Criar o BD
-- exemplo
create database novo;
use novo;
create table pessoa(
	id int primary key,
    nome varchar(100),
    endereco varchar(100));
    
select * from pessoa;

-- 2 Preparar/selecionar os dados em csv
-- obs linha de cabecalho no csv facilita a importacao
-- SALVAR como .xa

-- 3 Associar CADA tabela COM O .CSV correspondente através do comando importe 
--  através do menu do workbench (botao direito do mouse sobre a tabela) ou o comando

LOAD data infile "C:\Pasta1.csv" into table pessoa;