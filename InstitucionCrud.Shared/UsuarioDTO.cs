﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitucionCrud.Shared
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Usuario1 { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Correo { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Contra { get; set; } = null!;

    }
}
