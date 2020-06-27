
--						 -----------------------------------------------------
-- 						 -------------------- Dados Premio -----------------
--						 ---------------------------------------------------
insert into Premiacao values(1,'Billboard music awards',1,5);
insert into Premiacao values(2,'ECHO Awards',4,108);
insert into Premiacao values(3,'Kerrang!Awards',5,150);
insert into Premiacao values(4,'MTV Music Awards',12,542);
insert into Premiacao values(5,'MTV Music Awards',12,12);
insert into Premiacao values(6,'Metal Hammer Golden God Awards',1,611);
insert into Premiacao values(7,'Metal Hammer Golden God Awards',1,211);
insert into Premiacao values(8,'Metal Hammer Golden God Awards',1,658);
insert into Premiacao values(9,'Metal Hammer Golden God Awards',1,774);
insert into Premiacao values(10,'Metal Hammer Golden God Awards',1,448);
insert into Premiacao values(11,'Metal Hammer Golden God Awards',1,30);
insert into Premiacao values(12,'Metal Hammer Golden God Awards',1,253);
insert into Premiacao values(13,'Metal Hammer Golden God Awards',1,10);
insert into Premiacao values(14,'Metal Hammer Golden God Awards',1,87);
insert into Premiacao values(15,'Metal Hammer Golden God Awards',1,91);
insert into Premiacao values(16,'Revolver Golden Gods Awards',3,422);
insert into Premiacao values(17,'Revolver Golden Gods Awards',2,65);
insert into Premiacao values(18,'Revolver Golden Gods Awards',2,909);
insert into Premiacao values(19,'Revolver Golden Gods Awards',3,47);
--						 -----------------------------------------------------
-- 						 -------------------- Dados Albuns -----------------
--						 ---------------------------------------------------
insert into  melhores_albuns Values (1,'Master of Puppets',1986,108);
insert into  melhores_albuns Values (2,'The Number of the Beast',1982,87);
insert into  melhores_albuns Values (3,'Blizzard of Ozz',1980,122);
insert into  melhores_albuns Values (4,'Reign in Blood',1986,157);
insert into  melhores_albuns Values (5,'Led Zeppelin II',1969,97);
--						 -----------------------------------------------------
-- 						 -------------------- Dados Riffs -----------------
--						 ---------------------------------------------------
insert into melhores_riffs(posicao,Musica,idMelhores_Albuns) values (1,'                                                 Stairway To Heaven',5); -- foi feito assim de proposito para executar umas das consulta
insert into melhores_riffs(posicao,Musica,idMelhores_Albuns) values (2,' Master of Puppets',1); 
insert into melhores_riffs(posicao,Musica,idMelhores_Albuns) values (3,'Crazy Train',3);  
insert into melhores_riffs(posicao,Musica,idMelhores_Albuns) values (4,'Raining Blood',4); 
insert into melhores_riffs(posicao,Musica,idMelhores_Albuns) values (5,'Number of the Beast',2);
