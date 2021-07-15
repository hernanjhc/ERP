﻿using FileHelpers;

namespace ERP.Models
{
    [DelimitedRecord("\t")]
    public class EArticulosImport
    {
        public int Id;

        public int IdEmpresa;

        public string CodBarra;

        public string Descripcion;

        public string Marca;

        public string Rubro;

        public string Proveedor;

        public string Unidad;

        public decimal Costo;
        
        /*Los descuentos y costo inicial se cargarán en 0*/

        public decimal PrecioL1;

        public decimal PrecioL2;

        public decimal PrecioL3;
        
        /*Los porcentajes de utilidad en lista de precios se cargarán en 0*/

        public decimal Stock;

        public decimal StockMinimo;

        public decimal IvaVentas;

        public string Observaciones;
    }
}
