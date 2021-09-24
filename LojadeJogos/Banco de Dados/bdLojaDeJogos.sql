create database dbLojaDeGames;

use dbLojaDeGames;

create table tblJogo 
(
gamename varchar (150) not null,
gamegender varchar (50) not null,
gamedev varchar (50) not null,
gamecod int primary key not null,
gamelan int not null,
gameversion varchar (50),
gamesinopse varchar (100) not null,
gameplat varchar (50) not null,
gameidade varchar (50) not null
);

create table tblCliente
(
cliname varchar (50),
cliend varchar (150) not null,
clicpf varchar (14) primary key not null,
clinum varchar (50),
cliemail varchar (50) not null,
clinascdt datetime not null
);

create table tblFunc
(
funcname varchar(50) not null,
funccargo varchar(50) not null,
funccod int primary key not null,
funcemail varchar(50) not null,
funcnum varchar(50) not null,
funcrg varchar(12) not null,
funccpf varchar(14) not null,
funcend varchar(150) not null,
funcnascdt datetime not null
);

ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password
BY 'arthur345';
GRANT ALL PRIVILEGES ON dbLojaDeGames. * TO 'root'@'localhost' WITH GRANT OPTION;