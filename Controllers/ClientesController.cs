using Microsoft.AspNetCore.Mvc;

using Basic_Api.Models;

namespace Basic_Api.Controllers
{
    [Route("clientes")]
    public class ClientesControllers : Controller
    {

        static List<Cliente> _clientes = new List<Cliente>();

        //Métodod antigo        
        // [HttpGet]
        // public ActionResult Metodo ([FromQuery]string nome) { 
        //     return Ok("Olá, "+ nome);
        // }
        
        [HttpGet]
        public ActionResult Metodo ([FromQuery]string nome) { 
            if(string.IsNullOrEmpty(nome))
                return Ok(_clientes);

            var filtroclientes = _clientes.Where(x => x.Nome == nome);
            return Ok(filtroclientes);
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

        [HttpPost]
        public ActionResult Post ([FromBody]Cliente cliente){
            _clientes.Add(cliente);
            return Created(Request.Path,cliente);


        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete ([FromRoute]int id){
            
            var cliente = _clientes.Find(x => x.Id == id);
            _clientes.Remove(cliente);
            return Ok();


        }
    }
}