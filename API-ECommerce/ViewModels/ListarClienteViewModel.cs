using API_ECommerce.Models;

namespace API_ECommerce.ViewModels
{
    public class ListarClienteViewModel
    {
        public int IdCliente { get; set; }

        public string? NomeCompleto { get; set; }

        public string? Email { get; set; }

        public string? Telefone { get; set; }

        public string? Endereco { get; set; }

        public DateOnly? DataCadastro { get; set; }
    }
}
