using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        //Dentro do repository ficam os metodos que acessam o banco de dados
        // Injetar o Context  no repository
        private readonly EcommerceContext _context;

        //ctor - Metodo Construtor
        // Quando criar um objeto o que eu preciso ter?
        public ProdutoRepository(EcommerceContext context)
        {
            _context = context;
        }
        // Injeção de dependência
        public void Atualizar(int id, CadastrarProdutoDTO produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CadastrarProdutoDTO dto)
        {
            Produto produtoCadastro = new Produto 
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Preco = dto.Preco,
                EstoqueDisponivel = dto.EstoqueDisponivel,
                Categoria = dto.Categoria,
                Imagem = dto.Imagem
            };


            _context.Produtos.Add(produtoCadastro);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {

            //1 Encontrar o que eu quero excluir
            // Find - Procura pela chave primaria
            Produto produtoEncontrado = _context.Produtos.Find(id);
            //caso nao encontre o produto
            if (produtoEncontrado == null) {
                throw new Exception();
            }

            //caso  eu encontre o produto, removo ele
            _context.Produtos.Remove(produtoEncontrado);

            //salvo as alteracoes

            _context.SaveChanges();

        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
