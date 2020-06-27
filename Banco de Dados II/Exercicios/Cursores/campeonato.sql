drop database if exists campeonato;
create database campeonato;
use campeonato;
create table resultados_sp(
	id int auto_increment primary key,
    
    campeonato char(30),
    datajogo datetime,
    estadio char(30),
    adversario char(30),
    pontos_sp int,
    pontos_adv int,
    resultado char(10) 
);
insert into resultados_sp(campeonato, datajogo, adversario,pontos_sp,pontos_adv, resultado, estadio)
 values
 ("Copa São Paulo", "2016-01-03 14:00","Paulista",4,0,"vitoria","Arena Barueri"),
 ("Copa São Paulo", "2016-01-05 21:00","Tiradentes-CE",7,0,"vitoria","Arena Barueri"),
 ("Copa São Paulo", "2016-01-07 16:00","Audax-SP",3,1,"vitoria","Arena Barueri"),
 ("Copa São Paulo", "2016-01-10 18:30","Taboão da Serra",2,2,"empate","Arena Barueri"),
 ("Copa São Paulo", "2016-01-14 19:00","Figueirense",1,0,"vitoria","Arena Barueri"),
 ("Copa São Paulo", "2016-01-17 19:30","Rondonópolis",4,0,"vitoria","Francisco Ribeiro Nogueira"),
 ("Amistosos", "2016-01-20 21:00","Cerro Porteno",1,0,"vitoria","Defensores del Chaco"),
 ("Copa São Paulo","2016-01-20 19:30","Flamengo",2,0,"derrota","Arena Barueri"),
 ("Paulista", "2016-01-30 19:30","Red Bull Brasil",1,1,"empate","Moisés Lucarelli"),
 ("Libertadores","2016-02-03 21:45","U. Cesar Vallejo",1,1,"empate","Mansiche"),
 ("Paulista","2016-02-06 17:00","Água Santa",4,1,"vitoria","Pacaembu"),
 ("Libertadores","2016-02-16 21:45", "U. Cesar Vallejo",1,0,"vitoria","Pacaembu"),
 ("Paulista","2016-02-14 17:00", "Corinthians",0,2,"derrota","Arena Corinthians"),
 ("Libertadores","2016-02-17 19:30", "The Strongest",0,1,"derrota","Pacaembu "),
 ("Paulista","2016-02-21 17:00","Rio Claro",1,0,"vitoria","Pacaembu"),
 ("Paulista", "2016-02-24 19:30","Grêmio Novorizontino",2,0,"vitoria","Pacaembu"),
 ("Paulista", "2016-02-27 19:30","Ponte Preta",0,1,"derrota","Moisés Lucarelli"),
 ("Paulista", "2016-03-01 20:30","Mogi Mirim",2,0,"vitoria","Pacaembu"),
 ("Paulista", "2016-03-05 16:00","São Bernardo",1,3,"derrota","Pacaembu"),
 ("Libertadores","2016-03-10 19:30", "River Plate",1,1,"empate","Monumental de Núñez"),
 ("Paulista","2016-03-13 11:00", "Palmeiras",0,2,"derrota","Pacaembu"),
 ("Libertadores","2016/03/16 19:30", "Trujillanos",1,1,"empate","José Alberto Pérez"),
 ("Paulista","2016/03/20 16:00","Ituano", 1,1,"empate", "Novelli Jr."),
 ("Paulista","2016-03-23 21:45", "Botafogo-SP",1,0,"vitoria", "Pacaembu"),
 ("Paulista","2016-03-27 18:30","Santos", 1,1,"empate", "Vila Belmiro"), 
 ("Paulista","2016-03-30 19:30", "Linense-SP", 1,1,"vitoria","Anisio Haddad")
 ;
select * from resultados_sp;
DELIMITER $$

CREATE PROCEDURE resultados_consecutivos(in v_campeonato char(30), in v_resultado char(10), out estatistica int)
BEGIN
    declare status_atual char(10); -- para guardar cada resultado lido no cursor

    declare cur cursor for 
        select resultado
        from resultados_sp 
        where campeonato = v_campeonato
        order by datajogo desc;

    set estatistica=0;

    open cur;
 
    start_loop: loop
        fetch cur into status_atual;
            if status_atual <> v_resultado then 
                leave start_loop;
            else
                set estatistica = estatistica +1;
            end if;
    end loop;

    close cur;
END
$$

delimiter ;


-- testes
-- houve 2 empates nos últimos jogos da libertadores
select datajogo,resultado 
        from resultados_sp 
        where campeonato = "Libertadores"
        order by datajogo desc;
Set @estatistica = 0;
call resultados_consecutivos("Libertadores","empate",@estatistica);
select @estatistica; 
       
-- houve 1 vitoria no ultimo jogo do paulista
select datajogo,resultado 
        from resultados_sp 
        where campeonato = "Paulista"
        order by datajogo desc;
        
Set @estatistica = 0;
call resultados_consecutivos("Paulista","vitoria",@estatistica);
select @estatistica; 
