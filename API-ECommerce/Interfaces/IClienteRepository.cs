using API_ECommerce.DTO;
using API_ECommerce.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API_ECommerce.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> ListarTodos();

        Cliente BuscarPorId(int id);


        void Cadastrar(CadastrarClientesDTO cliente);

        void Atualizar(int id, CadastrarClientesDTO cliente);


        Cliente? BuscarPorEmailSenha(string email, string senha);

        void Deletar(int id);

        List<Cliente> BuscarClientePorNome(string nome);

    }
}
