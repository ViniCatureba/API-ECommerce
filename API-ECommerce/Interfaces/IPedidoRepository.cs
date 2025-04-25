using API_ECommerce.DTO;
using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IPedidoRepository
    {
        List<Pedido> ListarTodos();

        Pedido BuscarPorId(int id);

        void Atualizar(int id, Pedido pedido);

        void Deletar(int id);

        void Cadastrar(CadastrarPedidoDTO pedido);
    }
}
