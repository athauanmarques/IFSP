
/*
4.	Faça uma trigger para atualizar a estatistica de um personagem toda vez que seu nível (levelbase) for atualizado. 
O nível (levelbase) de um personagem deve ser atualizado sempre de 1 em 1.
 As estatísticas são atualizadas de 5 em 5, por exemplo:
 forca = forca +5; sorte=sorte+5; etc.  
 Assim o comando que dispara esta trigger consiste em:
UPDATE personagem SET levelBase = levelBase +1 WHERE idPersonagem = 1;
*/

Delimiter ||
	create trigger tr_estatistica after update on personagem
    for each row
    begin
		if(new.levelBase > old.levelBase) then
        UPDATE Stats SET
           forca = forca + 5,
		   agilidade = agilidade + 5,
		   inteligencia = inteligencia + 5,
		   destreza = destreza + 5,
		   sorte = sorte + 5,
		   vitalidade = vitalidade +5
		where Stats.idPersonagem =new.idPersonagem;
 END IF;
    end;
    
|| delimiter ;