using Microsoft.AspNetCore.Mvc;
using Basic_Api.Models;
using Basic_Api.Services;
using Basic_Api.Interfaces;

namespace Basic_Api.Controllers
{
    [Route("clientes")]
    public class ClientesController : Controller
    {
        IClienteServices _clienteServices;// viu receber de outro lugar, para não me preocupar em saber quem implementa a interface 
        public ClientesController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }
        [HttpGet]
        public ActionResult Metodo ([FromQuery]string nome) { 
            if(string.IsNullOrEmpty(nome))
                return Ok( _clienteServices.ObterTodos());
            return Ok(_clienteServices.ObterPorNome(nome));
        }

        [HttpPost]
        public ActionResult Post ([FromBody]Cliente cliente, [FromQuery] string version){
            _clienteServices.Inserir(cliente);
            return Created(Request.Path,cliente);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete ([FromRoute]int id){  
            _clienteServices.Deletar(id);
            return Ok();
        }
    }
}