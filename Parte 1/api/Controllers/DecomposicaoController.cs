using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DecomposicaoController : ControllerBase
    {
        [HttpGet("{numero}")]
        public ActionResult<DecomposicaoResult> Get(int numero)
        {
            List<int> divisores = CalcularDivisores(numero);
            List<int> divisoresPrimos = CalcularDivisoresPrimos(divisores);

            DecomposicaoResult result = new DecomposicaoResult
            {
                Numero = numero,
                Divisores = divisores,
                DivisoresPrimos = divisoresPrimos
            };

            return Ok(result);
        }

        private List<int> CalcularDivisores(int numero)
        {
            List<int> divisores = new List<int>();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }
            return divisores;
        }

        private List<int> CalcularDivisoresPrimos(List<int> divisores)
        {
            List<int> divisoresPrimos = new List<int>();
            foreach (int divisor in divisores)
            {
                if (Primo(divisor))
                {
                    divisoresPrimos.Add(divisor);
                }
            }
            return divisoresPrimos;
        }

        private bool Primo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class DecomposicaoResult
    {
        public int Numero { get; set; }
        public List<int> Divisores { get; set; }
        public List<int> DivisoresPrimos { get; set; }
    }
}
