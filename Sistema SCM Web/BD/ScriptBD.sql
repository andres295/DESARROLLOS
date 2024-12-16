--se agregan las siguientes tablas a la base de datos ya existente
--Tabla Rol
create table Rol(
idRol int primary key identity(1,1),
nombre varchar(50),
fechaRegistro datetime default getdate()
)
go

--Tabla Menu
create table Menu
(
idMenu int primary key identity(1,1),
nombre varchar(50),
icono varchar(50),
url varchar(50)
)
go
--Relacion Menu con Rol
create table MenuRol(
idMenuRol int primary key identity(1,1),
idMenu int references Menu(idMenu),
idRol int references Rol(idRol)
)
go


--Usuarios
create table usuariosWeb(
idUsuario int primary key identity(1,1),
nombreCompleto varchar(100),
correo varchar(40),
idRol int references Rol(idRol),
clave varchar(40),
esAsctivo bit default 1,
fechaRegistro datetime default getdate()
)
go


--Numero de documento
create table numeroDocumento(
idNumeroDocumento int primary key identity(1,1),
ultimo_Numero int not null,
fechaRegistro datetime default getdate()
)
go

create table Venta(
idVenta int primary key identity(1,1),
numeroDocumento varchar(40),
tipoPago varchar(50),
total decimal(10,2),
fechaRegistro datetime default getdate()
)
go

create table idDetalleVenta(
idDetalleVenta int primary key identity(1,1),
idVenta int references Venta(idVenta),
idProducto bigint references Productos(Id),
cantidad int,
precio decimal(10,2),
total decimal(10,2)
)
go





