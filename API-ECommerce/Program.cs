using System.Text;
using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

// O .net cria os objetos ( inej�ao de dependencias)
// AddTransient - O C# cria uma instancia nova, toda vez que um metodo � chamado
//ADDScoped O c# cria uma instancia nova, toda vez que criar um controller
//AddSingleton
builder.Services.AddTransient<EcommerceContext, EcommerceContext>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IItemPedidoRepository, ItemPedidoRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();

builder.Services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters //Validar o token
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "ecommerce",
        ValidAudience = "ecommerce",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minhas-chave-ultra-mega-secreta-senai"))
    };
}); //Instalar o pacote JWTBearer


builder.Services.AddAuthorization();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();

app.UseAuthentication();

app.UseAuthorization();



app.Run();


