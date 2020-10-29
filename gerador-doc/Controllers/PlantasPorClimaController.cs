using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gerador_doc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantasPorClimaController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PlantasPorClimaController> _logger;

        public PlantasPorClimaController(ILogger<PlantasPorClimaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Planta> Get()
        {

            var lista = new List<Planta>();

            lista.Add(new Planta()
            {
                codigo = 1,
                nome = "crisântemo",
                clima = "calor"
            });

            lista.Add(new Planta()
            {
                codigo = 2,
                nome = "lavândula",
                clima = "calor"
            });

            lista.Add(new Planta()
            {
                codigo = 3,
                nome = "azaleia",
                clima = "frio"
            });

            lista.Add(new Planta()
            {
                codigo = 4,
                nome = "carmélias",
                clima = "frio"
            });

            return lista.ToArray();
        }
    }
}
