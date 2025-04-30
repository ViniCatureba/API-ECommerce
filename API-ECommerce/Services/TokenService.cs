using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace API_ECommerce.Services
{
    public class TokenService
    {
        

        public string GenerateToken(string email)
        {// Claims - Informações do user que eu quero guardar no Token

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email)
            };

            //Criar uma chave de seguranca e criptografar ela
            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minhas-chave-ultra-mega-secreta-senai"));

            // Criptografar a chave de seguranca
            var creds = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            // Montar o token    //issuer: nome do sistema que gerou o token
            var token = new JwtSecurityToken(
                issuer: "ecommerce",
                audience: "ecommerce",
                claims: claims, //info do user que quero guardar
                expires: DateTime.Now.AddMinutes(30)  //DateTime.Now pega o horario de agora e o ADDMinutes, quanto tempo vai ser valido
             );

            return new JwtSecurityTokenHandler().WriteToken(token);



        }


    }

}
