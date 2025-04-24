using API_ECommerce.Context;
using API_ECommerce.DTO;
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
        public ProdutoController(ProdutoRepository produtoRepository)
        {
            //iNJEÇÃO DE DEPENDENCIAS
            _produtoRepository = produtoRepository;
        }


        // GET
        [HttpGet()]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarProduto(CadastrarProdutoDTO prod)
        {
            //1 - Coloco o produto no banco de dados
            _produtoRepository.Cadastrar(prod);
            //2- Salvo as alterações
            _context.SaveChanges();
            //3- Retorno o resultado
            //201 Created
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, CadastrarProdutoDTO prod)
        {
            try
            {
                _produtoRepository.Atualizar(id, prod);
                return Ok(prod);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }



        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _produtoRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado!");
            }
        }
    }
}
