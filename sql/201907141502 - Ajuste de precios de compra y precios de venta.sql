use Ventas

/*	Ajustes de precios de compra	*/

alter table EArticulos drop column CostoAdicional1
alter table EArticulos drop column CostoAdicional2

alter table earticulos
	add Descuento1 numeric(17,2) null	
alter table earticulos
	add Descuento2 numeric(17,2) null	
alter table earticulos
	add Descuento3 numeric(17,2) null	

alter table earticulos
	add DescuentoPorc1 numeric(3,2) null
alter table earticulos
	add DescuentoPorc2 numeric(3,2) null
alter table earticulos
	add DescuentoPorc3 numeric(3,2) null
go
	
/*	Ajustes de precios de venta		*/
alter table earticulos
	add PrecioPorcL1 numeric(3,2) null
alter table earticulos
	add PrecioPorcL2 numeric(3,2) null
alter table earticulos
	add PrecioPorcL3 numeric(3,2) null

/*	Agrego campo IVA*/
alter table earticulos
	add IVA numeric(3,2) null

--alter table Carreras drop column Importe
go