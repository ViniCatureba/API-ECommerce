using API_ECommerce.Context;
using API_ECommerce.Repositories;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ECommerce.Models;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IPedidoRepository _pedidoRepository;

        public PedidoController(EcommerceContext context)
        {
            _context = context;
            _pedidoRepository = new PedidoRepository(_context);
        }
        [HttpGet()]
        public IActionResult ListarTodos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarPedido(Pedido pedido)
        {
            _pedidoRepository.Cadastrar(pedido);
            
            _context.SaveChanges();

            return Created();
        }
    }
}
