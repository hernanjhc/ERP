//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EArticulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EArticulos()
        {
            this.EComprasDetalles = new HashSet<EComprasDetalles>();
            this.EPresupuestosDetalles = new HashSet<EPresupuestosDetalles>();
            this.ERemitosDetalles = new HashSet<ERemitosDetalles>();
            this.EVentasDetalles = new HashSet<EVentasDetalles>();
        }
    
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string CodBarra { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdMarca { get; set; }
        public Nullable<int> IdRubro { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdUnidad { get; set; }
        public Nullable<decimal> CostoInicial { get; set; }
        public Nullable<decimal> Descuento1 { get; set; }
        public Nullable<decimal> DescuentoPorc1 { get; set; }
        public Nullable<decimal> Descuento2 { get; set; }
        public Nullable<decimal> DescuentoPorc2 { get; set; }
        public Nullable<decimal> Descuento3 { get; set; }
        public Nullable<decimal> DescuentoPorc3 { get; set; }
        public decimal Costo { get; set; }
        public Nullable<decimal> Stock { get; set; }
        public decimal StockMinimo { get; set; }
        public Nullable<decimal> PrecioL1 { get; set; }
        public Nullable<decimal> PrecioPorcL1 { get; set; }
        public Nullable<decimal> PrecioL2 { get; set; }
        public Nullable<decimal> PrecioPorcL2 { get; set; }
        public Nullable<decimal> PrecioL3 { get; set; }
        public Nullable<decimal> PrecioPorcL3 { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        public virtual EMarcas EMarcas { get; set; }
        public virtual Proveedores Proveedores { get; set; }
        public virtual ERubros ERubros { get; set; }
        public virtual Unidades Unidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EComprasDetalles> EComprasDetalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EPresupuestosDetalles> EPresupuestosDetalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ERemitosDetalles> ERemitosDetalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVentasDetalles> EVentasDetalles { get; set; }
    }
}
