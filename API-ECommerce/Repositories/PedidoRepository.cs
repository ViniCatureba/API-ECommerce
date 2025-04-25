using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly EcommerceContext _context;
        
        public PedidoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CadastrarPedidoDTO pedidoDTO)
        {
            var cadastrarPedido = new Pedido
            {
                IdCliente = pedidoDTO.IdCliente,
                DataPedido = pedidoDTO.DataPedido,
                Status = pedidoDTO.Status,
                ValorTotal = pedidoDTO.ValorTotal,
            };
            _context.Pedidos.Add(cadastrarPedido);
            _context.SaveChanges();

            //Cadastrar o item pedido
            //Para cada produto eu crio um item pedido

            for (int i = 0; i < pedidoDTO.Produtos.Count; i++)
            {
                var produto = _context.Produtos.Find(pedidoDTO.Produtos[i]);

                //TODO: Lancar erro se produto nao existe

                var itemPedido = new ItemPedido
                {
                    IdPedido = cadastrarPedido.IdPedido,
                    IdProduto = produto.IdProduto,
                    Quantidade = 0
                };
                _context.ItemPedidos.Add(itemPedido);
                _context.SaveChanges();
            }
            ;

           

        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ListarTodos()
        {
            return _context.Pedidos.ToList();
        }
    }
}
