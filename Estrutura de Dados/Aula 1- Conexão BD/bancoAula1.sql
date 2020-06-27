create database if not exists ed;

use ed;

create table if not exists carros (
    id int auto_increment not null primary key,
    nome varchar(50) not null,
    fabricante varchar(50) not null
);

select * from carros
