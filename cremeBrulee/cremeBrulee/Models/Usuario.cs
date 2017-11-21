using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cremeBrulee.Models
{
    [Table("tbl_Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }

        [Required]
        [Column("Nombre",TypeName ="varchar")]
        [MaxLength(25)]
        public string Nombre { get; set; }
        [Required]  
        [Column("Email",TypeName ="varchar")]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [Column("Password",TypeName ="varchar")]
        public string Password { get; set; }
        [Required]
        [Column("TipoUsuario",TypeName ="varchar")]
        [MaxLength(10)]
        public string TipoUsuario { get; set; }


        //NavigationProperties  
        public virtual ICollection<Cuenta> listCuenta { get; set; }

    }
}