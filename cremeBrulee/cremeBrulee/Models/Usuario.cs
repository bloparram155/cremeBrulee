using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tblUsuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        [Required]
        private string Nombre { get; set; }
        [Required]
        private string Email { get; set; }
        [Required]
        private string Password { get; set; }
        private string tipoUsuario { get; set; }


        public virtual ICollection<Cuenta> listCuenta { get; set; }

    }
}