use master
drop database aula13
create database aula13
use aula13

create table tbmicrobio(
idmicrobio int primary key identity(1,1),
microbio varchar(30),
celula int,
funcao varchar(100),
descricao varchar(100),
iddiferenciacao int,
idtipo int,
senha varchar(50)
)


create table tbdiferenciacao(
iddiferenciacao int primary key identity(1,1),
tipo varchar(100),
diferenciacao varchar(30)
)





alter table tbmicrobio
add constraint fk_iddiferenciacao
FOREIGN KEY(iddiferenciacao)
REFERENCES tbdiferenciacao (iddiferenciacao);







insert into tbdiferenciacao(tipo,diferenciacao)
values('Alga','Água doce')



insert into tbdiferenciacao(tipo,diferenciacao)
values('Fungo','Parede')


insert into tbdiferenciacao(tipo,diferenciacao)
values('Bactéria','Áquatico')

insert into tbmicrobio(microbio,celula,funcao,descricao,iddiferenciacao,senha)
values('Micron Alves',3,'Destruir crânios','Amassado',3,'senha')

select c.microbio, 
a.tipo,
b.diferenciacao,
c.senha


from tbtipo a
inner join tbdiferenciacao b
on a.idtipo = b.idtipo
inner join tbmicrobio c
on c.iddiferenciacao = b.iddiferenciacao