using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManobreFacil.Models
{
    public class Manobrista
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} Precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(11, ErrorMessage = "O Campo {0} Precisa ter {1} caracteres", MinimumLength = 11)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public List<Manobra> Manobras { get; set; }

    }
}
