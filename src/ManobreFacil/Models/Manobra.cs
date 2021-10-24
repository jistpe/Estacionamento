using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManobreFacil.Models
{
    public class Manobra
    {
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        public int ManobristaId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        public int CarroId { get; set; }

        public Manobrista Manobrista { get; set; }

        public Carro Carro { get; set; }
    }
}
