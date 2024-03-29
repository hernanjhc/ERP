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
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.GruposUsuarios = new HashSet<GruposUsuarios>();
            this.UsuariosItemsMenu = new HashSet<UsuariosItemsMenu>();
            this.EPresupuestos = new HashSet<EPresupuestos>();
            this.ERemitos = new HashSet<ERemitos>();
            this.EVentas = new HashSet<EVentas>();
            this.ECompras = new HashSet<ECompras>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public byte Estado { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string NombreCompleto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GruposUsuarios> GruposUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuariosItemsMenu> UsuariosItemsMenu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EPresupuestos> EPresupuestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ERemitos> ERemitos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVentas> EVentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECompras> ECompras { get; set; }
    }
}
