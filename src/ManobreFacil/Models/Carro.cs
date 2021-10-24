using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManobreFacil.Models
{
    public class Carro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} Precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} Precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(7, ErrorMessage = "O Campo {0} Precisa ter entre {1} caracteres", MinimumLength = 7)]
        public string Placa { get; set; }

        public List<Manobra> Manobras { get; set; }
    }
}
