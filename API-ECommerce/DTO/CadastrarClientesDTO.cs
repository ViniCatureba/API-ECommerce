namespace API_ECommerce.DTO
{
    public class CadastrarClientesDTO
    {
        public string? NomeCompleto { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        public string? Telefone { get; set; }

        public string? Endereco { get; set; }

        public DateOnly? DataCadastro { get; set; }
    }
}
