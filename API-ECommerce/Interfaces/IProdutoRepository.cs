using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    // Fachada - Somente os metodos que teremos

    public interface IProdutoRepository
    {
        // R - Read (Leitura)
        // Retorno
        List<Produto> ListarTodos();

        // Recebe um ID e retorna o um produto 
        Produto BuscarPorId(int id);

        // C - Create (Cadastro)
        void Cadastrar(Produto produto);

        // U - Update (Atualização)
        //Recebe um identificador para enconrtrar o produto, e recebe o produto novo para substituir o antigo
        void Atualizar(int id, Produto produto);

        void Deletar(int id);
    }
}
