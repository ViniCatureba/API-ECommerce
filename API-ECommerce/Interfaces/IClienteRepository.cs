using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> ListarTodos();

        Cliente BuscarPorId(int id);


        void Cadastrar(Cliente cliente);

        void Atualizar(int id, Cliente cliente);

        void Deletar(int id);
    }
}
