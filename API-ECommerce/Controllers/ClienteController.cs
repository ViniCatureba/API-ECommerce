using API_ECommerce.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ECommerce.Controllers;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using API_ECommerce.Models;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        //Context
        private readonly EcommerceContext _context;
        
        //Interface
        private IClienteRepository _clienteRepository;

        //Controller
        //Todo metodo contrutor tem que ter o mesmo nome da classe
        public ClienteController(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpGet()]
        public IActionResult ListarTodos()
        {
            return Ok(_clienteRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Cliente cliente)
        {
            _clienteRepository.Cadastrar(cliente);
                     
            return Created();
        }


        // /api/cliente/vini@senai.com/senha12342
        [HttpGet("{email}/{senha}")]
        public IActionResult Login(string email, string senha)
        {
            var cliente = _clienteRepository.BuscarPorEmailSenha(email, senha);
            if (cliente == null) { 
            return NotFound();
            }
            return Ok(cliente);
        }

        [HttpGet("/buscar{nome}")]
        public IActionResult BuscarPorNome(string nome)
        {
            return Ok(_clienteRepository.BuscarClientePorNome(nome));
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return Ok(_clienteRepository.BuscarPorId(id));
        }


    }
}
