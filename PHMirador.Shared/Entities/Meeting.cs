using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHMirador.Shared.Entities
{
    public class Meeting
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Asamble")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede superar los {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Date { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Time { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Place { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Diary { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}
