using Microsoft.AspNetCore.Mvc;

namespace Kaffee.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {

        public static Kaffee kaffee = new();

        [HttpGet]
        [Route("/GetWasserUndBohnen")]
        public double[] GetWasserUndBohnen()
        {
            return new[] { kaffee.wasser, kaffee.bohnen };
        }

        [HttpPut]
        [Route("/WasserAuffuellen")]
        public double wasserAuffuellen(double menge)
        {
            return kaffee.wasserAuffuellen (menge); 
        }

        [HttpPut]
        [Route("/BohnenAuffuellen")]
        public double bohnenAuffuellen(double menge)
        {
            return kaffee.bohnenAuffuellen(menge);
        }

        [HttpPut]
        [Route("/MachKaffee")]
        public double machKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            return kaffee.machKaffee (menge, verhaeltnisWasserBohnen);
        }

    }
}