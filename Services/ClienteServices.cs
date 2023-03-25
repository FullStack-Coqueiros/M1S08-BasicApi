using Basic_Api.Models;
using Basic_Api.Interfaces;


namespace Basic_Api.Services
{
    public class ClienteServices : IClienteServices
    {
        List<Cliente> _clientes = new List<Cliente>();

        public ClienteServices()
        {
            
        }
        public List<Cliente> ObterTodos(){
            return _clientes;
        }
        public List<Cliente>  ObterPorNome(string nome){
            var filtroclientes = _clientes.Where(x => x.Nome == nome).ToList();
            return filtroclientes;
        }
        public void Inserir(Cliente cliente){
            _clientes.Add(cliente);
        }
        public void Deletar(int id){
            var cliente = _clientes.Find(x => x.Id == id);
            _clientes.Remove(cliente);
        }
    }
}