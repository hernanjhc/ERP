use Ventas

--Agrega usuario jhc
insert into Usuarios
(	Id,				Nombre,		Contraseña, 
	NombreCompleto, FechaAlta,	Estado)
values(
	1,				'jhc',	'6B-F3-72-79-F8-13-1A-F4-86-8B-6A-49-07-F2-17-39-9C-2F-30-9C-26-8C-0A-5D-D0-C5-54-36-70-F1-5D-68-D3-D6-C9-8B-FD-06-96-B9-65-DF-3C-A8-E8-42-66-77-5B-BF-F3-B9-DD-B3-AA-B4-C1-1E-D7-8A-87-B1-A8-87',
	'SGO SISTEMAS',	getdate(),	1)

--carga ItemsMenu
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (1	,0	, 'archivoToolStripMenuItem'							,'Archivo')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (2	,1	, 'salirToolStripMenuItem'								,'&Salir')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (3	,0	, 'ediciónToolStripMenuItem'							,'Edición')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (4	,3	, 'clientesToolStripMenuItem'							,'Clientes')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (5	,3	, 'configuraciónGeneralToolStripMenuItem'				,'Configuración general')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (6	,0	, 'seguridadToolStripMenuItem'							,'Seguridad')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (7	,6	, 'usuariosToolStripMenuItem'							,'Usuarios')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (8	,6	, 'cambiarContraseñaToolStripMenuItem'					,'Cambiar contraseña')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (9	,6	, 'gruposDeUsuariosToolStripMenuItem'					,'Grupos')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (10	,6	, 'asignarUsuariosAGruposToolStripMenuItem'				,'Asignar usuarios a Grupos')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (11	,6	, 'asignarPermisosAGruposYUsuariosToolStripMenuItem'	,'Asignar permisos a Grupos y Usuarios')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (12	,3	, 'productosToolStripMenuItem'							,'Productos')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (13	,12	, 'unidadesToolStripMenuItem'							,'Unidades')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (14	,12	, 'marcasToolStripMenuItem'								,'Marcas')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (15	,12	, 'rubrosToolStripMenuItem'								,'Rubros')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (16	,12	, 'productosToolStripMenuItem1'							,'Productos')
insert into ItemsMenu(id, idpadre,	nombre,	Descripcion) values (17	,3	, 'proveedoresToolStripMenuItem'						,'Proveedores')

--Otorga permisos a los items del menu a usuario jhc
insert into UsuariosItemsMenu(
	Id,			
	IdUsuario,	
	IdItemMenu
)
select
	m.id,	
	usuario = (select id from Usuarios u where u.Nombre = 'jhc'),			
	m.id
from ItemsMenu m