use ragnarok;
select * from personagem;
start transaction; -- começando a transaction
update idpersonagem set zeny = zeny - 100 where idpersonagem=1;
update idpersonagem set zeny = zeny + 100 where idpersonagem=2;
select * from personagem;
-- utilize sempre 2 tipos de update positivo e negativo
-- rollback; -- defaz o comando que foi feito
commit; -- salva dentro do banco


-- if /else (commit /rolback)
