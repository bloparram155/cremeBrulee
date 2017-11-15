using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tblCuenta")]
    public class Cuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CuentaID { get; set; }
        private bool CuentaVerificada { get; set; }
        public int UsuarioID { get; set; }


        [ForeignKey("UsuarioID")]
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Direccion> ListDireccion { get; set; }
        public virtual ICollection<Orden> ListOrden { get; set; }
        public virtual ICollection<Carrito> ListCarrito { get; set; }

    }
}