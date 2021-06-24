using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Models
{
    public class CarroViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public float Quilometragem { get; set; }
    }
}
