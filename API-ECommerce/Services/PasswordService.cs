using API_ECommerce.Models;
using Microsoft.AspNetCore.Identity;

namespace API_ECommerce.Services
{
    public class PasswordService
    {

        // PasswordHasher - Algoritimo: PBKDF2

        private readonly PasswordHasher<Cliente> _hasher = new ();
        // 1 - Gerar Hash 

        public string HashPassword(Cliente cliente)
        {
            return _hasher.HashPassword(cliente, cliente.Senha);
        }
        // 2 - Verificar Hash

        public bool VerificarSenha(Cliente cliente, string senhaInformada) 
        {
            var resultado = _hasher.VerifyHashedPassword(cliente, cliente.Senha, senhaInformada);
            return resultado == PasswordVerificationResult.Success;
            
            //esse metodo da classe retorno verd or false

           // if (resultado == PasswordVerificationResult.Success)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

    }
}
