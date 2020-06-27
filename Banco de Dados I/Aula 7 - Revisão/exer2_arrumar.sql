drop database if exists loja;
create database if not exists loja;
use loja;

create table if not exists Empregado
(

CodEmp char(3) not null,
NomeEmp char(30),
SenhaEmp int(6),
primary key (CodEmp)
);

create table if not exists Produto
(
CodigoTipoProd char(3) not null,
NumeroProd		int(12),
DescricaoProd	char(120),
PrecoProd		float(60),
primary key (CodigoTipoProd),
foreign key (CodTipoProd) references TipoProd(CodTipoProd) 
);

create table if not exists TipoProd
(
CodTipoProd char(3) not null,
DescricaoTipoProd char(120),
primary key (DescricaoTipoProd),
foreign key (CodTipoProd) references TipoProd(CodTipoProd) 

);

create table if not exists Venda
(
NumeroNF int(18) not null,
DataVenda datetime(10),
CodReg  int (14),
CodEmp	int (14),
primary key (NumeroNF),
foreign key (CodigoReg) references Registradora(CodigoReg),
foreign key (CodEmp) references Empregado(CodEmp)

);


create table if not exists ItemVenda
(
NumeroNF int(18) not null,
CodigoTipoProd int(10),
NumeroProd  int (14),
QtdeItem	int (14),
PrecoItem float(12),

foreign key (NumeroNF) references Venda(NumeroNF),
foreign key (CodTipoProd) references TipoProd(CodTipoProd) 

);


create table if not exists Registradora
(
CodReg int(3) not null,
SaldoReg float(100),
foreign key (NumeroNF) references Venda(NumeroNF),
foreign key (CodTipoProd) references TipoProd(CodTipoProd) 

);










