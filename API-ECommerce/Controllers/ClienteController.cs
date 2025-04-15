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
    }
}
