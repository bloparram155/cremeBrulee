//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cremeBrulee
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Cuenta()
        {
            this.tbl_Carrito = new HashSet<tbl_Carrito>();
            this.tbl_Direccion = new HashSet<tbl_Direccion>();
            this.tbl_Orden = new HashSet<tbl_Orden>();
        }
    
        public int CuentaID { get; set; }
        public int UsuarioID { get; set; }
        public bool CuentaVerificada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Carrito> tbl_Carrito { get; set; }
        public virtual tbl_Usuario tbl_Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Direccion> tbl_Direccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Orden> tbl_Orden { get; set; }
    }
}