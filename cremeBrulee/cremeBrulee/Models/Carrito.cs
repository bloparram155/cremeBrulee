using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tblCarrito")]
    public class Carrito
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoID { get; set; }
        [ForeignKey("Cuenta")]
        public int CuentaID { get; set; }
        private double SubTotal { get; set; }
        private double Total { get; set; }


        public virtual ICollection<Producto> ListProducto { get; set; }
        public virtual Cuenta Cuenta { get; set; }

    }
}