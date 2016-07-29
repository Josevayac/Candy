using CandyApi.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using static CandyApi.Entity.Elemento;

namespace CandyApi.Controllers
{
    public class PartidaController : ApiController
    {

        [EnableCors(origins: "http://localhost:53075", headers: "*", methods: "*")]
        // POST api/Partida
        public async Task<IHttpActionResult> Post([FromBody] Usuario usuario)
        {

            Array values = Enum.GetValues(typeof(Color));
            Random random = new Random();
            var randomColor = Color.red;

            List <Elemento> listElementos = new List<Elemento>();
            
            for (int i = 0; i < 82; i++)
            {
                randomColor = (Color)values.GetValue(random.Next(values.Length));
                listElementos.Add(new Elemento { id = i, color = randomColor });
            }

            Partida oPartida = new Partida();
            oPartida.id = 1;
            oPartida.elementos = listElementos;
            return Json(oPartida);
        }
    }
}
