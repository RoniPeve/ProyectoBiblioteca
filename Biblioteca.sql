create database Biblioteca

use Biblioteca

create table usuarios(
id_usuario int not null,
nombre varchar(30),
cuenta varchar(30),
contraseña varchar(30),
status_admin bit
)

insert into usuarios values('1','Pedro','admin','123456',1)
insert into usuarios values('2','Juan','user','123',0)

select*from usuarios

create table Libros(
codigo_de_libro int,
nombre_de_libro varchar(50),
autor_libro varchar(50),
categoria_libro varchar(30),
idioma_libro varchar(30),
tipo_libro varchar(8),
precio_libro float
)


select*from Libros

create procedure Listar
as
select*from Libros

exec Listar

create procedure Insertar(
@codigo_de_libro int,
@nombre_de_libro varchar(50),
@autor_libro varchar(50),
@categoria_libro varchar(30),
@idioma_libro varchar(30),
@tipo_libro varchar(8),
@precio_libro float
)
as
if	not exists (select codigo_de_libro from Libros where codigo_de_libro=@codigo_de_libro)
insert into Libros values(@codigo_de_libro,@nombre_de_libro,@autor_libro,@categoria_libro,@idioma_libro,@tipo_libro,@precio_libro)


create procedure Eliminar(
@codigo_de_libro int)
as 
delete from Libros where codigo_de_libro=@codigo_de_libro

exec Eliminar 2


create procedure ModificarLibro(
@codigo_de_libro int,
@nombre_de_libro varchar(50),
@autor_libro varchar(50),
@categoria_libro varchar(30),
@idioma_libro varchar(30),
@tipo_libro varchar(8),
@precio_libro float
)
as
if exists (select codigo_de_libro from Libros where codigo_de_libro=@codigo_de_libro)
update Libros set codigo_de_libro=@codigo_de_libro, nombre_de_libro=@nombre_de_libro ,autor_libro=@autor_libro,categoria_libro=@categoria_libro, idioma_libro=@idioma_libro, tipo_libro=@tipo_libro, precio_libro=@precio_libro where codigo_de_libro=@codigo_de_libro


create table Prestamos
(
codigo_libro int,
nombre_libro varchar(30),
nombre_persona varchar(30),
DNI char(8),
fecha_salida varchar(10),
estado varchar(200),
)

select*from Prestamos


create procedure InsertarPrestamo(
@codigo_libro int,
@nombre_libro varchar(30),
@nombre_persona varchar(30),
@DNI char(8),
@fecha_salida varchar(10),
@estado varchar(200)
)
as
insert into Prestamos values(@codigo_libro,@nombre_libro,@nombre_persona,@DNI,@fecha_salida,@estado)

create procedure EliminarPrestamo(
@nombre_persona varchar(30),
@nombre_libro varchar(30)
)
as
delete from Prestamos where nombre_persona=@nombre_persona and nombre_libro=@nombre_libro

create table Ventas
(
codigo_libro int,
nombre_libro varchar(30),
nombre_persona varchar(30),
DNI char(8),
precio float,
fecha_venta varchar(10)
)

select*from Ventas

create procedure InsertarVentas(
@codigo_libro int,
@nombre_libro varchar(30),
@nombre_persona varchar(30),
@DNI char(8),
@precio float,
@fecha_venta varchar(10)
)
as
insert into Ventas values(@codigo_libro,@nombre_libro,@nombre_persona,@DNI,@precio,@fecha_venta)


create procedure EliminarVentas(
@nombre_persona varchar(30),
@nombre_libro varchar(30)
)
as 
delete from Ventas where nombre_persona=@nombre_persona and nombre_libro=@nombre_libro

