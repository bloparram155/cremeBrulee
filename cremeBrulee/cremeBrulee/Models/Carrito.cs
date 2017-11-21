using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tbl_Carrito")]
    public class Carrito
    {
        
        public Carrito()
        {
            this.ListProducto = new HashSet<Producto>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoID { get; set; }
        public int CuentaID { get; set; }
        [Column("SubTotal", TypeName ="decimal")]
        public decimal SubTotal { get; set; }
        [Column("Total", TypeName = "decimal")]
        public decimal Total { get; set; }

        //Navigation Properties
        public virtual ICollection<Producto> ListProducto { get; set; }

        [ForeignKey("CuentaID")]
        public virtual Cuenta Cuenta { get; set; }

    }
}