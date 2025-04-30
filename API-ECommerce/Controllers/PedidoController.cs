using API_ECommerce.Context;
using API_ECommerce.Repositories;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ECommerce.Models;
using API_ECommerce.DTO;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private IPedidoRepository _pedidoRepository;

        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        // R - Read
        [HttpGet("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarPedido(CadastrarPedidoDTO pedido)
        {
            _pedidoRepository.Cadastrar(pedido);
            return Created();
        }
    }
}
