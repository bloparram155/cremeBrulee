using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tbl_Direccion")]
    public class Direccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        public int CuentaID { get; set; }  

        [Required]
        [Column("Colonia",TypeName ="varchar")]
        [MaxLength(25)]
        public string Colonia { get; set; }
        [Required]  
        [Column("Calle",TypeName ="varchar")]
        [MaxLength(25)]
        public string Calle { get; set; } 
        [Required]
        [Column("Estado",TypeName ="varchar")]
        [MaxLength(20)]
        public string Estado { get; set; }
        [Required]
        [Column("Ciudad",TypeName ="varchar")]
        [MaxLength(20)]
        public string Ciudad { get; set; }
        [Required]
        [Column("CodigoPostal",TypeName ="int")]
        public int CodigoPostal { get; set; }

        //Navigation Properties
        [ForeignKey("CuentaID")]
        public virtual Cuenta Cuenta { get; set; }

    }
}