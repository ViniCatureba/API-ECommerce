using API_ECommerce.DTO;
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
        void Cadastrar(CadastrarProdutoDTO produto);

        // U - Update (Atualização)
        //Recebe um identificador para enconrtrar o produto, e recebe o produto novo para substituir o antigo
        void Atualizar(int id, CadastrarProdutoDTO produto);

        void Deletar(int id);
    }
}
