CREATE DATABASE TestDatabase;

create table empleados(
documento char(8) primary key,
nombre varchar(50),
sueldo float
);

insert into empleados(documento,nombre,sueldo) values ('3000000', 'Rodriguez Pablo', 20000)
