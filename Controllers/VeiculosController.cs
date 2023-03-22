
using Microsoft.AspNetCore.Mvc;

namespace Basic_Api.Controllers
{
    [Route("[controller]")] // DOtnet obtem automaticamente o nome da sua controller, no caso usara a veiculos
    public class VeiculosController : Controller
    {
        static List<string> carros = new List<string>(){ {"Gol"}, {"Ferrari"}, {"Fiesta"}};

        [HttpGet]
        public ActionResult GetCarros([FromQuery]string carro){
            if (string.IsNullOrEmpty(carro)){
                return Ok(carros);
            }

            if (carros.Exists(x => x == carro)){
                return Ok("Carro Cadastrado");
            }
            else {
                return NoContent();
            }

        }
        [HttpPost]
        public ActionResult PostCarros ([FromQuery]string carro){
            carros.Add(carro);
            return Ok();
        }

        public ActionResult DeleteCarros([FromQuery]string carro){
            carros.Remove(carro);
            return Ok();
        }
    }
}