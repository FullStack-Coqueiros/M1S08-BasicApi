using Microsoft.AspNetCore.Mvc;

using Basic_Api.Models;

namespace Basic_Api.Controllers
{
    [Route("clientes")]
    public class ClientesControllers : Controller
    {
        static List<Cliente> _clientes = new List<Cliente>();
        
        [HttpGet]
        public ActionResult Metodo ([FromQuery]string nome) { 
            if(string.IsNullOrEmpty(nome))
                return Ok(_clientes);

            var filtroclientes = _clientes.Where(x => x.Nome == nome);
            return Ok(filtroclientes);
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