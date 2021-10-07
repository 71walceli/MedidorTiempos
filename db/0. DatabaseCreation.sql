create database MedidorUsoTiempo
go
use MedidorUsoTiempo
go
create table Actor (
	id int primary key identity(0, 1),
	nombre varchar(50) not null unique,
	uri varchar(1024) not null,
)
create table Actividad (
	id int primary key identity(715827883, 1),
	nombre varchar(50) not null,
	inicio datetime not null unique,
	duracion int not null check (duracion between 0 and 1440),
	porcentaje int not null check (porcentaje between 0 and 100),
)
create table ActorActividad (
	actorId int foreign key references Actor(id) not null,
	actividadId int foreign key references Actividad(id) not null,
)
create table Etiqueta (
	id int primary key identity(1431655765,1),
	nombre varchar(25) not null unique,
	color int not null unique check (color between 0x0 and 0xffffff),
	etiquetaDuena int foreign key references Etiqueta(id)
)
create table EtiquetaActividad (
	etiquetaId int foreign key references Etiqueta(id) not null,
	ActividadId int foreign key references Etiqueta(id) not null,
)
go
create or alter function EmptyOrBlank (
	@string varchar
) returns bit
begin
	set @string = REPLACE(@string, ' ', '')
	set @string = REPLACE(@string, '	', '')
	set @string = REPLACE(@string, char(10), '')
	set @string = REPLACE(@string, char(13), '')
	set @string = TRIM(@string)
	return CASE 
		WHEN @string = '' then 1
		WHEN @string is null then 1
		else 0
	END
end
go
alter table Actor add constraint CK_actor_nombre_NotEmptyOrBlank check (dbo.EmptyOrBlank(nombre)=0)
alter table Actor add constraint CK_actor_uri_NotEmptyOrBlank check (dbo.EmptyOrBlank(uri)=0)
alter table Actividad add constraint CK_actividad_nombre_NotEmptyOrBlank 
	check (dbo.EmptyOrBlank(nombre)=0)
alter table Etiqueta add constraint CK_etiqueta_nombre_NotEmptyOrBlank check (dbo.EmptyOrBlank(nombre)=0)
go
