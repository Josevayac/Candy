using CandyApi.Models;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace CandyApi.Controllers
{
    public class MovimientoController : ApiController
    {
        // POST api/values
        public string Post([FromBody] Movimiento movimiento)
        {
            if ((movimiento.movimiento1[0] == '0') && (movimiento.movimiento1[1] == '1'))
            {
                return "todo esta bien <p> hola mundo</p>";
            }
            else
                return "todo esta mal <p> hola mundo</p>";
        }

      
    }
}
