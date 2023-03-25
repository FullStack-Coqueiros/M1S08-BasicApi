using Basic_Api.Models;
namespace Basic_Api.Interfaces
{
    public interface IClienteServices
    {
        public List<Cliente> ObterTodos();
        public List<Cliente>  ObterPorNome(string nome);
        public void Inserir(Cliente cliente);
        public void Deletar(int id);
    }
}