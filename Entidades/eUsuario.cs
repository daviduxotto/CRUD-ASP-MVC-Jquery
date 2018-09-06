using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Entidades
{
    public class eUsuario
    {
      [Required]
      [DisplayName("Username")]
      [StringLength(15)]
      public string codUsuario { get; set; }

      [Required]
      [DisplayName("Contraseña")]
      [StringLength(15)]
      public string clave { get; set; }

      [Required]
      [DisplayName("Nombres")]
      [StringLength(45)]
      public string nombre { get; set; }

      [Required]
      [DisplayName("Apellidos")]
      [StringLength(45)]
      public string apellidos { get; set; }

      [DisplayName("# Telefonico")]
      [StringLength(10)]
      public string telefono { get; set; }

      [Required]
      [DisplayName("Edad")]
      [Range(0, 120, ErrorMessage = "Inrese una edad valida")]
      public int edad { get; set; }
   }
}
