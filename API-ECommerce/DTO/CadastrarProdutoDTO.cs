namespace API_ECommerce.DTO
{
    public class CadastrarProdutoDTO
    {
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public decimal? Preco { get; set; }

        public int? EstoqueDisponivel { get; set; }

        public string? Categoria { get; set; }

        public string? Imagem { get; set; }
    }
}
