use master;

drop database Prova;

create database Prova;

use Prova;

	create table tbFuncao(
	idfuncao int IDENTITY(1,1) PRIMARY KEY,
	funcao varchar(100),
	);
	
	create table tbEspecialidade(
	idespecialidade int IDENTITY(1,1) PRIMARY KEY,
	especialidade varchar(100),
	idfuncao int
	);

	 create table tbFuncionario(
	 idfuncionario int IDENTITY(1,1) PRIMARY KEY,
	 nome varchar(150),
	 endereco varchar (500),
	 telefone varchar(15),
	 idCidades int,
	 idfuncao int,
	 idespecialidade int
	 );

	 create table tbCidades (
	 idCidades int IDENTITY(1,1) PRIMARY KEY,
	 cidades varchar(52),
	 estados varchar(52)
	 );
	 go

	
	 create table tbCliente (
	 idcliente int IDENTITY(1,1) PRIMARY KEY,
	 nome varchar(150),
	 endereco varchar (500),	
	 telefone varchar(15),
	 idCidades int  
	 );
	 
	 
	 
	alter table tbCliente
	add constraint fk_idcidade
	FOREIGN KEY(idCidades)
	REFERENCES tbCidades (idCidades);
	
	alter table tbFuncionario
	add constraint fk_idcidade2
	FOREIGN KEY(idCidades)
	REFERENCES tbCidades (idCidades);
	
	alter table tbFuncionario
	add constraint fk_idfuncao
	FOREIGN KEY(idfuncao)
	REFERENCES tbFuncao (idfuncao);
	
	alter table tbFuncionario
	add constraint fk_idespecialidade
	FOREIGN KEY(idespecialidade)
	REFERENCES tbEspecialidade (idespecialidade);
	
	alter table tbEspecialidade
	add constraint fk_idfuncao2
	FOREIGN KEY(idfuncao)
	REFERENCES tbFuncao (idfuncao);
	 
	
	INSERT INTO tbCidades (cidades, estados) values 
	('Porto seguro','BA'),
	('Florianópolis','SC'),
	('Rio Branco','AC'),
	('São Paulo','SP')
	
	INSERT INTO tbCliente (nome,endereco,telefone,idCidades) 
	values ('Antonio','Rua Avenida','2547-9865',1),
	('Douglas','Rua Robo','2654-9874',2),
	('Bruno','Rua Almeida ','2171-1717',3),
	('Vitão','Rua Lua','2131-1313',4)
	



insert into tbFuncao(funcao)
values('Atendente'),
('Barbeiro')

insert into tbEspecialidade(especialidade,idfuncao)
values('Mulher',1),
('Homem',1),
('Barbas',2),
('Cabelo',2)

insert into tbFuncionario(nome,endereco,telefone,idCidades,idfuncao,idespecialidade)
values('Ronaldo','Rua das avenidas','192168',1,1,1)



create procedure sp_RetornarFuncionario
@nmFuncionario varchar(100) = null
as select a.nome,
a.endereco,
a.telefone,
b.estados as Estado,
b.cidades as Cidade,
c.funcao as Função,
d.especialidade as Especialidade

 from tbFuncionario a
 inner join tbCidades b
 on a.idCidades = b.idCidades
 inner join tbFuncao c
 on a.idfuncao = c.idfuncao
 inner join tbEspecialidade d
 on d.idespecialidade = a.idespecialidade
where @nmFuncionario is null or nome like '%'+ @nmFuncionario +'%'

sp_RetornarFuncionario 'A'


create procedure sp_RetornarCliente
@nmCliente varchar(100) = null
as select a.nome,
a.endereco,
a.telefone,
b.estados as Estado,
b.cidades as Cidade

 from tbCliente a
 inner join tbCidades b
 on a.idCidades = b.idCidades
where @nmCliente is null or nome like '%'+ @nmCliente +'%'

sp_RetornarCliente 'Aio'


select * from tbFuncionario
select * from tbEspecialidade
select *from tbCliente	
select * from tbCidades
select * from tbLogin
select * from tbFuncao