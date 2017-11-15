using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tblInventario")]
    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventarioID { get; set; }
        public int ProductoID { get; set; }
        [Required]
        private int Cantidad { get; set; }
        [Required]
        private double Precio { get; set; }

        [ForeignKey("ProductoID")]
        public virtual Producto Producto { get; set; }

    }
}