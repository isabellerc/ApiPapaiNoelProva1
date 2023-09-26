using System.ComponentModel.DataAnnotations;

namespace ApiPapaiNoelProva1.Models.Request
{
    public class NovaCartaViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string nomeCrianca { get; set; }

        public string endereco { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public int idade { get; set; } 
        [MaxLength(500, ErrorMessage = "O texto pode ter no máximo 500 caracteres")] 
        public string textoCarta { get; set; } // maximo 500 caracteres


    }
}

