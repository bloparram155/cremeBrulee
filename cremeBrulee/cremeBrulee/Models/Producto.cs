using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tbl_Producto")]
    public class Producto
    {
        public Producto()
        {
            this.Inventario = new HashSet<Inventario>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        [Required]
        [Column("Nombre",TypeName ="varchar")]
        [MaxLength(25)]
        public string Nombre { get; set; }
        [Required]      
        [Column("Categoria",TypeName ="varchar")]
        [MaxLength(25)]
        public string Categoria { get; set; }
        [Required]
        [Column("Presentacion",TypeName ="varchar")]
        [MaxLength(25)]
        public string Presentacion { get; set; }
        [Required]
        [Column("CodigoProducto",TypeName ="int")]
        public int CodigoProducto { get; set; }


        //Navigation Properties
        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}