create database zaikay
use zaikay

create table Division(
idDivision int identity,
nom varchar(20),
[description] varchar(100),
constraint pk_division primary key(idDivision)
)

create table Employe(
idEmploye int identity,
email varchar(30),
nom varchar(20),
adresse varchar(50),
dateEmbauche date,
idDivision int,
responsable bit,
constraint pk_Emplye primary key(idEmploye),
constraint fk_Employe_Division foreign key(idDivision) references division(idDivision)
)
