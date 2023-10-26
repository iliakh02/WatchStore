using Microsoft.EntityFrameworkCore;
using WatchStore.WebApi.Repositories;
using WatchStore.WebApi.Repositories.Abstract;
using WatchStore.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("WatchStoreDbConnection");

builder.Services.AddDbContext<WatchStoreDbContext>(options => 
    options.UseSqlServer(connectionString));
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IProductsService, ProductsService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

var app = builder.Build();


app.UseCors((policy) =>
{
    policy.AllowAnyOrigin();
});
    
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/products", (IProductsService productsService) => productsService.GetProducts()).WithOpenApi();
app.MapGet("/products/{id:int}", (int id, IProductsService productsService) => productsService.GetProductById(id)).WithOpenApi();

app.Run();