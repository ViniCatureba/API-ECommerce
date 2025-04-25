using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

// O .net cria os objetos ( inejçºao de dependencias)
// AddTransient - O C# cria uma instancia nova, toda vez que um metodo é chamado
//ADDScoped O c# cria uma instancia nova, toda vez que criar um controller
//AddSingleton
builder.Services.AddTransient<EcommerceContext, EcommerceContext>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IItemPedidoRepository, ItemPedidoRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();



app.Run();


