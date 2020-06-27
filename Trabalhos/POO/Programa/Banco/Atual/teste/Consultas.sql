-- ================ Teste Login =========================

call prVerificarLogin('VIS18456dfgd', '123456', 'visitante'); -- ok visitante
call prVerificarLogin('1247fds', '782', 'funcionario'); -- ok

call prRedifinirSenha('Athauan','amc@oi.com','321'); -- B.O
call prExcluirConta(1);
/*
in jNome varchar(45),in jTipoCadastro varchar(45),in jCodAcesso varchar(45), 
in jSenha longtext, in jTelefone varchar(45),in jDataNascimento Date, in jSexo varchar(45), in jEmail varchar(45), 
in jReceberConvite boolean*/
call cadastrarVistante('Athauan','visitante','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov',true);
call cadastrarVistante('caio','visitante','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov',false);
call cadastrarVistante('tayonan','visitante','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov',true);
call cadastrarFuncionario('Bruna','funcionario','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov', 'gerente','ge12354-1');

select * from login;
select * from usuario;
-- ================================= acervo & exposição =================
call prAdicionarAcervo('Vai corithians','Vencer e vencer','Futebol','timão','São paulo','Bola decorativa');
call prAdicionarExposicoes('temporario','2017-02-02','2017-02-10','Bragança','avenida louca','sp','12541-14','Caio','4025361',10,100,true);
call prExcluirExposicao(1);
select * from acervo;
select * from exposicoes;
-- ================================= acervo =================
call reservarEvento(2, 1);
select * from reservas_convites;
delete from reservas_convites;
-- =====================  restauracao =======================
call prSolicitarRestauracao('2017-09-05',1,2);
call prAlterarStatus('concluido',1,2);
select * from restauracao;

-- =================== venda e estoque ===================
call prEntradaProduto('25157-8','leite','longa vida','é muito bom',125.2,10);
call prEditarProduto(1,'25157-8','leite','longa vida','é o melhor do mercado',125.2,10);
call prDeletarProduto(1);
call prEfetuarCompra(1,1,5);

select * from estoque;
select * from vendas;





