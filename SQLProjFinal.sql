------------------------------------------------------------

--Criação do banco de dados: 
create database dbWiki
use dbWiki

--Criação do login p/ o acesso ao db:
create login dbWiki with password='dbWiki';
create user dbWiki from login dbWiki;

--Criação da tabela instrumentos
create table instrumento
(
	id integer primary key identity not null,
	nome varchar(50) not null,
	marca varchar(50) not null,
	descricao varchar(250),
	cor varchar(20),
	peso integer not null,
	dataFabricado date not null,
	qntdEstoque integer not null,
	sopro bit default 0,
	corda bit default 0,
	percursao bit default 0
)

------------------------------------------------------------