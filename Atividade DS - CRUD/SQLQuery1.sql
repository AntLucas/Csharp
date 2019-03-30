USE master
DROP DATABASE CidadeInteligente

CREATE DATABASE CidadeInteligente
USE CidadeInteligente

create table pessoa (
idPessoa int  ,
nmPessoa varchar(100) not null,
dsEndereco varchar(250) not null,
estCivil varchar(50) not null,
dtNascimento date
)

create table pessoaDoc (
idPessoa int  ,
rgPessoa varchar(100) not null,
cpfPessoa varchar(250) not null,
reservista varchar(50) not null,
carteiraTrabalho varchar(50) not null,
cnh varchar(50) not null
)

create table funcionario (
idFuncionario int  ,
idPessoa int not null,
cargo varchar(250) not null,
salario float,
ramal int
)

create table cliente (
idCliente int  ,
idPessoa int not null,
dtInclusao date not null
)

select * from cliente
select * from funcionario
select * from pessoa
select * from pessoaDoc