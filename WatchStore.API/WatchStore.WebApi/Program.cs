using WatchStore.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IProductsService, ProductsService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/products", (IProductsService productsService) => productsService.GetProducts()).WithOpenApi();
app.MapGet("/products/{id:int}", (int id, IProductsService productsService) => productsService.GetProductById(id)).WithOpenApi();

app.Run();