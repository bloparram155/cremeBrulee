using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tbl_Inventario")]
    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventarioID { get; set; }
        public int ProductoID { get; set; }
        [Required]
        [Column("Cantidad",TypeName="int")]
        public int Cantidad { get; set; }
        [Required]
        [Column("Precio",TypeName ="decimal")]
        public decimal Precio { get; set; } 
        

        //Navigation Properties
        [ForeignKey("ProductoID")]
        public virtual Producto Producto { get; set; }

    }
}