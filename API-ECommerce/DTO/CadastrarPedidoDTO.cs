namespace API_ECommerce.DTO
{
    public class CadastrarPedidoDTO
    {
        //Recebo dados do pedido
        //E recebo os produtos comprados
        public int? IdCliente { get; set; }

        public DateOnly? DataPedido { get; set; }

        public string? Status { get; set; }

        public decimal? ValorTotal { get; set; }

        //Produtos comprados
        public List<int> Produtos { get; set; }
    }
}
