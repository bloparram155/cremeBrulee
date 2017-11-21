using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{

    [Table("tbl_Cuenta")]
    public class Cuenta
    {

        public Cuenta()
        {
            this.ListDireccion = new HashSet<Direccion>();
            this.ListOrden = new HashSet<Orden>();
            this.ListCarrito = new HashSet<Carrito>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CuentaID { get; set; }
        public int UsuarioID { get; set; }
        [Column("CuentaVerificada",TypeName ="bit")]
        public bool CuentaVerificada { get; set; }
       


        //Navigation Properties
        [ForeignKey("UsuarioID")]
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Direccion> ListDireccion { get; set; }
        public virtual ICollection<Orden> ListOrden { get; set; }
        public virtual ICollection<Carrito> ListCarrito { get; set; }

    }
}