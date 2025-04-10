using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IPagamentoRepository
    {
        List<Pagamento> ListarTodos();

        Pagamento BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id,Pagamento pagamento);

        void Cadastrar(Pagamento pagamento);
    }
}
