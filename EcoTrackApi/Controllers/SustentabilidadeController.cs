using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{

     [ApiController]
     [Route("[Controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private static readonly string[] Dicas = new[]
        {
            "Troque lâmpadas incandescentes por LED: economizam 80% de energia.",
            "Reduza o consumo de carne bovina: economiza milhares de litro de água.",
            "Prefira o transporte público ou bicicleta para reduzir emissões de CO2.",
            "Evite plasticos de uso único (canudos e copos descartáveis).",
        };

        [HttpGet]
        public string Get()
        {
            var random = new Random();
            return Dicas[random.Next(Dicas.Length)];
        }
    }
}