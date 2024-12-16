create database BD_BBB
GO
use BD_BBB
go



---tablas catalogo
create table tb_cat_clasificacion_art
(
	idClasificacion int primary key identity(1,1) not null,
	descripcionClasificacion varchar(255) not null,
	fechaRegistro datetime default getdate()
)
go

create table tb_cat_presentacion_art
(
	idPresentacion int primary key identity(1,1) not null,
	descripcionPresentacion varchar(255) not null,
	fechaRegistro datetime default getdate()
)
go

create table tb_cat_articulo
(
	idArticulo int primary key identity(1,1) not null,
	descripcionArticulo varchar(255) not null,
	idClasificacion int foreign key references tb_cat_clasificacion_art(idClasificacion),
	idPresentacion int foreign key references tb_cat_presentacion_art(idPresentacion),
	disponible int not null,
	costoUnitario decimal(10,2) not null,
	precioVenta decimal(10,2) not null,
	fechaRegistro datetime default getdate()
)
go

create table tb_cat_clasificacion_cte
(
	idClasificacion int primary key identity(1,1) not null,
	descripcionClasificacion varchar(255) not null,
	fechaRegistro datetime default getdate()

)
go

--catalogo para clientes y proveedores
create table tb_cat_metodo_pago
(
	
	idPago int primary key identity(1,1) not null,
	descripcionPago varchar(255) not null,
	fechaRegistro datetime default getdate()

)
go


--catalogo para clientes y proveedores
create table tb_cat_tipo_identificacion
(
	
	idIdentificacion int primary key identity(1,1) not null,
	descripcionIdentificacion varchar(255) not null,
	fechaRegistro datetime default getdate()

)
go


--catalogo para clientes y proveedores
create table tb_cat_pais
(
	
	idPais int primary key identity(1,1) not null,
	descripcionPais varchar(50) not null,
	fechaRegistro datetime default getdate()

)
go

--catalogo para clientes y proveedores
create table tb_cat_ciudad
(
	
	idCiudad int primary key identity(1,1) not null,
	descripcionCiudad varchar(50) not null,
	fechaRegistro datetime default getdate()

)
go

create table tb_cat_cliente
(
	idCliente int primary key identity(1,1) not null,
	idClasificacion int foreign key references tb_cat_clasificacion_cte(idClasificacion) not null,
	idPago int foreign key references tb_cat_metodo_pago(idPago) not null,
	idIdentificacion int foreign key references tb_cat_tipo_identificacion(idIdentificacion) not null,
	idPais int foreign key references tb_cat_pais(idPais) not null,
	idCiudad int foreign key references tb_cat_ciudad(idCiudad) not null,
	nombreCliente varchar(255) not null,
	numeroIdentificacion varchar(100)  not null,
	direccion varchar(250)  not null,
	fechaRegistro datetime default getdate()
)
go

create table tb_cat_clasificacion_prov
(
	idClasificacion int primary key identity(1,1) not null,
	descripcionClasificacion varchar(255) not null,
	fechaRegistro datetime default getdate()

)
go

create table tb_cat_proveedor
(
	idProveedor int primary key identity(1,1) not null,
	idClasificacion int foreign key references tb_cat_clasificacion_prov(idClasificacion) not null,
	idPago int foreign key references tb_cat_metodo_pago(idPago) not null,
	idIdentificacion int foreign key references tb_cat_tipo_identificacion(idIdentificacion) not null,
	idPais int foreign key references tb_cat_pais(idPais) not null,
	idCiudad int foreign key references tb_cat_ciudad(idCiudad) not null,
	nombreProveedor varchar(255) not null,
	numeroIdentificacion varchar(100)  not null,
	direccion varchar(250)  not null,
	fechaRegistro datetime default getdate()
)
go


---tablas de venta
create table tb_ventas (
    idVenta int primary key identity(1,1), 
	idCliente int,
    fechaRegistro datetime default getdate(), 
    total decimal(10, 2) 

	foreign key(idCliente) references tb_cat_cliente(idCliente)

)
go

-- Tabla DetalleVentas
create table tb_detalleVentas (
    idDetalleVenta int primary key identity(1,1), 
    idVenta int,
    idArticulo int, 
    cantidad int, 
    precioUnitario decimal(10, 2), 
    subtotal as (cantidad * precioUnitario) persisted, -- Subtotal calculado automáticamente


    foreign key(idVenta) references tb_ventas(idVenta),
	foreign key(idArticulo) references tb_cat_articulo(idArticulo)

)
go



---tablas de venta
create table tb_ventas (
    idVenta int primary key identity(1,1), 
	idArticulo int, 
	idCliente int,
    cantidad int, 
    precioUnitario decimal(10, 2), 
    subtotal as (cantidad * precioUnitario) persisted , 
	total decimal(10, 2),
	fechaRegistro datetime default getdate()

	foreign key(idArticulo) references tb_cat_articulo(idArticulo),
	foreign key(idCliente) references tb_cat_cliente(idCliente)

)
go

