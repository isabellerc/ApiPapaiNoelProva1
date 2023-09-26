using ApiPapaiNoelProva1.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using ApiPapaiNoelProva1.Controllers;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using ApiPapaiNoelProva1.Models.Response;


namespace ApiPapaiNoelProva1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartasController : PrincipalController
    {
        
            private readonly string _RegistroCartaCaminhoArquivo;

            public CartasController()
            {
                _RegistroCartaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "Data", "cartas.json");
            }

            #region Métodos arquivo
    
        private List<CartaViewModel> LerCartasDoArquivo()
            {
                if (!System.IO.File.Exists(_RegistroCartaCaminhoArquivo))
                {
                    return new List<CartaViewModel>();
                }



            string json = System.IO.File.ReadAllText(_RegistroCartaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<CartaViewModel>>(json);
            
          

        }


        private void EscreverCartasNoArquivo(List<CartaViewModel> cartas)
            {
                string json = JsonConvert.SerializeObject(cartas);
                System.IO.File.WriteAllText(_RegistroCartaCaminhoArquivo, json);
            }

            #endregion


            #region Operações do crud
            [HttpGet]
            public IActionResult Get()
            {
                List<CartaViewModel> cartas = LerCartasDoArquivo();
                return Ok(cartas);
            }

      

        [HttpPost]
        public IActionResult Post([FromBody] CartaViewModel carta)
        {
            if (!ModelState.IsValid)
            {
                return ApiBadRequestResponse(ModelState, "Dados Inválidos");
            }

            List<CartaViewModel> cartas = LerCartasDoArquivo();

            cartas.Add(carta);

            EscreverCartasNoArquivo(cartas);

            return ApiResponse(carta, "Carta registrada com sucesso");
        }

      
            #endregion
    }
}

