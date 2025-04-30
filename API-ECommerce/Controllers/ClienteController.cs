using API_ECommerce.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ECommerce.Controllers;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using API_ECommerce.Models;
using API_ECommerce.DTO;
using API_ECommerce.Services;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        
        
        //Interface
        private IClienteRepository _clienteRepository;


        //Instanciar o PasswordService
        private PasswordService passwordService = new PasswordService();


        //Controller
        //Todo metodo contrutor tem que ter o mesmo nome da classe
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }




        // C - Create
        [HttpPost("Cadastrar")]
        public IActionResult CadastrarCliente(CadastrarClientesDTO cliente)
        {

            _clienteRepository.Cadastrar(cliente);

            return Created();
        }



        // R - Read
        [HttpGet("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_clienteRepository.ListarTodos());
        }

        // U -Update
        [HttpPut("Atualizar/{id}")]
        public IActionResult Atualizar(int id, CadastrarClientesDTO clientes)
        {
            _clienteRepository.Atualizar(id, clientes);
            return Ok();
        }



        // D - Deletar
        [HttpDelete("Deletar/{id}")]

        public IActionResult Deletar(int id)
        {
            _clienteRepository.Deletar(id);
            return NoContent();
        }




        //Post para que nada seja passado via url
        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDto)
        {
            var cliente = _clienteRepository.BuscarPorEmailSenha(loginDto.Email, loginDto.Senha);

            if (cliente == null) { 
                return Unauthorized("Email ou senha invalidos!");
            }
            var tokenService = new TokenService();

            var token = tokenService.GenerateToken(cliente.Email);

            return Ok(token);
        }

        [HttpGet("/buscar{nome}")]
        public IActionResult BuscarPorNome(string nome)
        {
            return Ok(_clienteRepository.BuscarClientePorNome(nome));
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return Ok(_clienteRepository.BuscarPorId(id));
        }

      

        


    }
}
