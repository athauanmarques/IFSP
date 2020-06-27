/*Metodos

============== vendas ==============
ListArrry<Vendas>vendasProdutos(); -- JAVA
ListArrry<Vendas>gerarRelatório() // inner join -- JAVA
void efetuarComprar(int idEstoque, idUsuario, int qtsEstoque) // o banco se vire de efetuar ok
void listaComprarRealizadas() -- JAVA 
=============== estoque ===============
ListArrry<estoque>exibirProdutos();
void entradaProduto(string codProduto, String produto, String marca, String descricaoProduto); ok
void editarProduto(string codProduto, String produto, String marca, String descricaoProduto); ok
void deletarProduto(int idProduto); ok

*/



drop procedure if exists prEntradaProduto;

delimiter ||
create procedure prEntradaProduto(in jCodProduto varchar(20), in jProduto varchar(80),in jMarca varchar(45), in jDescricaoProduto longtext, in jPreco real,in jQtsEstoque int)
begin
	insert into estoque(codProduto,produto,marca,descricaoProduto,preco,qtsEstoque) values (jCodProduto,jProduto,jMarca,jDescricaoProduto,jPreco,jQtsEstoque);
end;
|| delimiter ;

drop procedure if exists prDeletarProduto;

delimiter ||
create procedure prDeletarProduto(in jIdEstoque int)
begin
	delete from estoque where idEstoque = jIdEstoque;
end;
|| delimiter ;

drop procedure if exists prEditarProduto;
delimiter ||

create procedure prEditarProduto(in jIdEstoque int, in jCodProduto varchar(20), in jProduto varchar(80),in jMarca varchar(45), in jDescricaoProduto longtext, in jPreco real, in jQtsEstoque int)
begin
	UPDATE estoque set codProduto = jCodProduto and produto = jProduto and marca = jMarca and descricaoProduto = jDescricaoProduto and preco = jPreco where idEstoque = jIdEstoque;
end;
|| delimiter ;


drop procedure if exists prEfetuarCompra;

delimiter ||
create procedure prEfetuarCompra(in jIdEstoque int, in jIdUsuario int, in jQtsEstoque int)
begin
	update estoque set qtsEstoque = qtsEstoque - jQtsEstoque where idEstoque = jIdEstoque;
    insert into vendas(idEstoque_tbEstoque,idUsuario_tbUsuario,quantidadeVendas,dataVenda) values (jIdEstoque,jIdUsuario,jQtsEstoque,CURRENT_TIMESTAMP);
end;

 
|| delimiter ;



