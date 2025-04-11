using API_ECommerce.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ECommerce.Controllers;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;

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
        public ClienteController(EcommerceContext context)
        {
            _context = context;
            _clienteRepository = new ClienteRepository(_context);
        }
    }
}
