using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tblProducto")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        [Required]
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        [Required]
        private string Categoria { get; set; }
        [Required]
        private string Presentacion { get; set; }
        [Required]
        private int CodigoProducto { get; set; }

        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}