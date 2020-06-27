-- inserindo dados

-- clientes
insert into clientes(nome, email, telefone) values ('Carlos Camacho','email@provedor.com.br','(11) 9 9999-5555');
insert into clientes(nome, email, telefone) values ('Felipe Reis','felipereiss@outlook.com','(11) 9 5356-5889');
insert into clientes(nome, email, telefone) values ('Aline Uzita','alinete.doidinha@hotmail.com','(11) 9 8659-2359');
insert into clientes(nome, email, telefone) values ('Victor Senna','victinho.arrasador@hotmail.com','(11) 9 8521-4687');
insert into clientes(nome, email, telefone) values ('Giovanne Barios','giovanne.lol@hotmail.com','(11) 9 4685-2165');
insert into clientes(nome, email, telefone) values ('Giovana Rechid','giovana.linda@outlook.com','(11) 9 5641-8291');
insert into clientes(nome, email, telefone) values ('Luciene Prof','luci.prof.foda@bra.edu.br','(11) 9 1234-6579');
-- Produtos
insert into Produtos(nome, preco, estoque) values ('Computador Pentium Dual Core',1500.00,15);
insert into Produtos(nome, preco, estoque) values ('Impressora Deskjet HP',599.90,150);
insert into Produtos(nome, preco, estoque) values ('Notebook Lenovo G400',1379.99,10);
insert into Produtos(nome, preco, estoque) values ('Calculadora HP C2000',150.50,90);
insert into Produtos(nome, preco, estoque) values ('Celular Samsung S5',1700.00,50);
insert into Produtos(nome, preco, estoque) values ('Hiphone S8',2900.00,20);
-- Vendas
insert into Vendas(`data`, quantidade, faturado, codigocliente, codigoproduto) values ('2014-10-29', 25, 1, 1, 1);
insert into Vendas(`data`, quantidade, faturado, codigocliente, codigoproduto) values ('2014-10-30', 20, 0, 2, 3);
insert into Vendas(`data`, quantidade, faturado, codigocliente, codigoproduto) values ('2014-11-09', 15, 1, 3, 2);
insert into Vendas(`data`, quantidade, faturado, codigocliente, codigoproduto) values ('2014-12-29', 10, 0, 4, 4);
insert into Vendas(`data`, quantidade, faturado, codigocliente, codigoproduto) values ('2014-12-02', 5, 1, 5, 5);
insert into Vendas(`data`, quantidade, faturado, codigocliente, codigoproduto) values ('2015-01-09', 1, 0, 6, 6);