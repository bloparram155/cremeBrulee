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
    
    public partial class tbl_Direccion
    {
        public int DireccionID { get; set; }
        public int CuentaID { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
    
        public virtual tbl_Cuenta tbl_Cuenta { get; set; }
    }
}
