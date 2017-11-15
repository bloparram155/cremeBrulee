using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tblDireccion")]
    public class Direccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        public int CuentaID { get; set; }
        [Required]
        private string Colonia { get; set; }
        [Required]
        private string Calle { get; set; }
        [Required]
        private string Estado { get; set; }
        [Required]
        private string Ciudad { get; set; }
        [Required]
        private int CodigoPostal { get; set; }

        [ForeignKey("CuentaID")]
        public virtual Cuenta Cuenta { get; set; }

    }
}