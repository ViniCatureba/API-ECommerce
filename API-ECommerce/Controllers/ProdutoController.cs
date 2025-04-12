using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        //context
        private readonly EcommerceContext _context;
        //interface
        private IProdutoRepository _produtoRepository;

       
        //controler
        public ProdutoController(EcommerceContext context)
        {
            _context = context;
            _produtoRepository = new ProdutoRepository(_context);
        }


        // GET
        [HttpGet()]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Produto prod)
        {
            //1 - Coloco o produto no banco de dados
            _produtoRepository.Cadastrar(prod);
            //2- Salvo as alterações
            _context.SaveChanges();
            //3- Retorno o resultado
            //201 Created
            return Created();
        }
    }
}
