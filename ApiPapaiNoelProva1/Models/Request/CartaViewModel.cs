using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ApiPapaiNoelProva1.Models.Request
{
    public class CartaViewModel
    {

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(255, ErrorMessage = "O nome tem que ser no máximo 255 letras")]
        [MinLength(3, ErrorMessage = "O nome tem que ser no mínimo 3 letras")]
        public string nomeCrianca { get; set; }

        public string endereco { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public int idade { get; set; } //em anos, nao aceita menor de 15 anos
        [MaxLength(500, ErrorMessage = "O texto pode ter no máximo 500 caracteres")] // verificar se isso serve somente para uma palavra
        public string textoCarta { get; set; } // maximo 500 caracteres
      


        
        //[Required(ErrorMessage = "O nome é obrigatório")]
        
        //[MaxLength(255, ErrorMessage = "O nome pode ser no máximo 255 letras")]
     
        //[Range(18, 110, ErrorMessage = "A idade mínima deve ser 18 anos.")]
        
        //[CpfValidation]
        //public string Cpf { get; set; }
        //[Required(ErrorMessage = "O número é obrigatório")]
        //[Range(1, 60, ErrorMessage = "O número deve estar entre 1 e 60.")]
        

        //public string dataJogo { get; set; }
        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    // Validar se os números não são iguais
        //    if (!NumerosValidos())
        //    {
        //        yield return new ValidationResult("Os números não podem ser iguais.");
        //    }

        //}

        //public bool NumerosValidos()
        //{
        //    if (primeiroNro == segundoNro || primeiroNro == terceiroNro || primeiroNro == quartoNro || primeiroNro == quintoNro || primeiroNro == sextoNro ||
        //        segundoNro == terceiroNro || segundoNro == quartoNro || segundoNro == quintoNro || segundoNro == sextoNro ||
        //        terceiroNro == quartoNro || terceiroNro == quintoNro || terceiroNro == sextoNro ||
        //        quartoNro == quintoNro || quartoNro == sextoNro ||
        //        quintoNro == sextoNro)
        //        return false;
        //    return true;
        //}
    }
}

