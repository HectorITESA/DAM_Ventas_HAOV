﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Share.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name= "País")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres." )]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;
    }
}
