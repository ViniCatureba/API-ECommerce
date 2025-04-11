using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ClienteRepository : IClienteRepository //Primeiro herda a interface
        //Segundo, implementar a interface ( os metodos da interface)
    {
        
        // Injetar contexto, cria uma variavel do context
        private readonly EcommerceContext _context;

        // colocoar o o construtor (ctor) recebendo o context

    //pega o context de fora e guarda nesse codigo
        public ClienteRepository(EcommerceContext context)
        {
            _context = context;   
        }
        public void Atualizar(int id, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}


//1- Herdar da interface

//2 - Implemenrtar a interface

//3 - Injetar o context