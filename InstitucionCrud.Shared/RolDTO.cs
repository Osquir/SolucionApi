﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace InstitucionCrud.Shared
{
    public class RolDTO
    {
        public int IdRol { get; set; }

      
        public string Nombre { get; set; } = null!;
    }
}
