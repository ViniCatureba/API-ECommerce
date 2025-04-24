using API_ECommerce.Context;
using API_ECommerce.DTO;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ECommerce.Repositories
{
    public class ClienteRepository : IClienteRepository //Primeiro herda a interface
        //Segundo, implementar a interface ( os metodos da interface)
    {
        
        // Injetar contexto, cria uma variavel do context
        private readonly EcommerceContext _context;

        // colocoar o o construtor (ctor) recebendo o context

        //pega o context de fora e guarda nesse codigo

        //metodo contrutor ]e um metodo que tem o mesmo nome da classe (ctor)
        public ClienteRepository(EcommerceContext context)
        {
            _context = context;   
        }
        public void Atualizar(int id, Cliente clienteNovo)
        {
            var clienteEncontrado = _context.Clientes.FirstOrDefault(c => c.IdCliente == id);

            if (clienteEncontrado == null) {
                throw new ArgumentNullException("Cliente nao encontrado");
            }

            clienteEncontrado.NomeCompleto = clienteNovo.NomeCompleto;
            clienteEncontrado.Email = clienteNovo.Email;
            clienteEncontrado.Telefone = clienteNovo.Telefone;
            clienteEncontrado.Endereco = clienteNovo.Endereco;
            clienteNovo.DataCadastro = clienteNovo.DataCadastro;

            _context.SaveChanges();

        }

        public List<Cliente> BuscarClientePorNome(string nome)
        {
            var listaCliente = _context.Clientes.Where(c => c.NomeCompleto == nome).ToList();
            return listaCliente;
        }






        /// <summary>
        /// Acessa o db e encontra o cliengte com email e senha fornecidos
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns> Um cliente ou nulo</returns>
        public Cliente? BuscarPorEmailSenha(string email, string senha)
        {

            //encontrar o cliente que possui o email e senha fornecidos
            var clienteEncontrado = _context.Clientes.FirstOrDefault(cliente => cliente.Email == email && cliente.Senha == senha);

            return clienteEncontrado;



        }



        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CadastrarClientesDTO dto)
        {
            Cliente clienteCadastro = new Cliente
            {
                NomeCompleto = dto.NomeCompleto,
                Email = dto.Email,
                Senha = dto.Senha,
                Telefone = dto.Telefone,
                Endereco = dto.Endereco,
                DataCadastro = dto.DataCadastro

            };
            _context.Clientes.Add(clienteCadastro);
        }

        public void Deletar(int id)
        {
            _context.Clientes.ExecuteDelete();
        }

        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.OrderBy(c => c.NomeCompleto).ToList();
        }


    }
}


//1- Herdar da interface

//2 - Implemenrtar a interface

//3 - Injetar o context