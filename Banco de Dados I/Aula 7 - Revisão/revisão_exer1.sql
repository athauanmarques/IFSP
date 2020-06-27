drop database if exists curriculo;
Create database if not exists curriculo;
use curriculo;

create table if not exists empresa
(
codEmpresa int (3) not null,
nome_da_empresa varchar (30),
Localidade     char(60),
CNPJ		int(12),
primary key (codEmpresa)

);

create table if not exists vaga
(
codVaga int (3) not null,
nome_vaga char (30),
periodo char (12),
codEmpresa int (3) not null,
primary key (codVaga) ,
foreign key (codEmpresa) references empresa(codEmpresa)

);


create table if not exists candidato
(
CPF int (8) not null,
Nome char (30),
Fone int (12),
RG int(12),
primary key (CPF)

);


Create table if not exists inscrever
(

codEmpresa int (3) not null,
CPF int (8) not null,
codVaga int (3) not null,
foreign key (codVaga) references vaga(codVaga),
foreign key (codEmpresa) references empresa(codEmpresa),
foreign key (CPF) references candidato(CPF)


);

-- TÁ FEITO ERA PARA FAZER ENGENHARIA DO DER


