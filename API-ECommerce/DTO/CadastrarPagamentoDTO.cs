namespace API_ECommerce.DTO
{
    public class CadastrarPagamentoDTO
    {
        //validar o IDpedido e aplicar na interface e outros
        public int IdPedido { get; set; }
        public string FormaPagamento { get; set; } = null!;

        public string Status { get; set; } = null!;

        public DateTime Data { get; set; }
    }
}
