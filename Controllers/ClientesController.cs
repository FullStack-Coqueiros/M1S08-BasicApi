using Microsoft.AspNetCore.Mvc;

using Basic_Api.Models;

namespace Basic_Api.Controllers
{
    [Route("clientes")]
    public class ClientesControllers : Controller
    {
        [HttpGet]
        public ActionResult Metodo ([FromQuery]string nome) { 
            return Ok("Olá, "+ nome);
        }
        [HttpGet]
        [Route("{id}")]
        public string ObterClienteComId ([FromQuery]string nome, [FromRoute]int id){
           return  "Olá, "+ nome+ " O Seu id é "+ id;
        }
        [HttpGet]
        [Route("id/{id}")]
         public ActionResult Metodo3 ([FromQuery]string nome, [FromRoute]int id){
            return Ok(new Cliente(id, nome));
         }
    }
}