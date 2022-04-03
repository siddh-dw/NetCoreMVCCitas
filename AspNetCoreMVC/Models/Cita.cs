using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVC.Models
{
    public class Cita
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora")]
        public DateTime Hora { get; set; }

    }
}