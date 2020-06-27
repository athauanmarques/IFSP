-- ================ Teste Login =========================

call prVerificarLogin('VIS18456dfgd', '123456', 'visitante'); -- ok visitante
call prVerificarLogin('1247fds', '782', 'funcionario'); -- ok

call prRedifinirSenha('Athauan','amc@oi.com','321'); -- B.O
call prExcluirConta(1);


call cadastrarVistante('Athauan','visitante','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov',true);
call cadastrarVistante('caio','visitante','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov',false);
call cadastrarVistante('tayonan','visitante','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov',true);
call cadastrarFuncionario('Bruna','funcionario','vis12548-7','123456','74495-5214','1989-10-22','m','atha@br.gov', 'gerente','ge12354-1');

select * from login;
select * from usuario;
-- ================================= acervo =================

call prAdicionarAcervo('Imperio roma','Arte e a beleza Romana','permanente','2017-02-22','2017-02-25','Bragança','Rua: longa vida - 265','RJ','12365-5','Caio Alvez','4585-5462',10,200,true);
call prExcluirAcervo(1);
select * from acervo;
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





