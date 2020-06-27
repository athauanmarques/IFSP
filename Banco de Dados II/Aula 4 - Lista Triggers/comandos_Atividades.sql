-- Exercios Lista 2
-- A)

delimiter |
create function media (n1 float, n2 float) 
returns float return ((n1*0.4)+(n2*0.6));
|
-- create function nome_da_função(parametro1 tipo_variavel, parametro1 tipo_variavel)
-- vai retornar valores tipo_valor retornar o resultado (calculo);

-- Teste - precisamos ver isso atulizando a tabela do resultado veja abaixo

update BOLETIM set media = media(nota1, nota2);
select * from boletim;

-- B)
delimiter |

create trigger excluir_aluno before delete on aluno -- criando um
for each row
begin
insert into ex_alunos values (old.ra, old.rg, old.nome, old.codcurso);

end|

-- C)
|
create trigger atualizar_aluno before delete on boletim
for each row
begin
update boletim set media=media(nota1,nota2);

end|

-- D)

create procedure buasca_aluno

call aumentaCurso('as','0.5'); -- chama a função


-- D)

create table Reprovados
(

Ra char(3) not null,
codDisc char(5) not null,
media float not null,
primary key (ra),
foreign key (codDisc) references CURSO (codDisc)

);


