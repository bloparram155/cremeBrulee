using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tblOrden")]
    public class Orden
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdenID{ get; set; }
        public int CuentaID { get; set; }
        public int CarritoID { get; set; }
        private DateTime FechaOrden { get; set; }

        [ForeignKey("CarritoID")]
        public virtual Carrito Carrito{get;set;}
        [ForeignKey("CuentaID")]
        public virtual Cuenta Cuenta { get; set; }

    }
}