using Microsoft.EntityFrameworkCore;
using WatchStore.WebApi.Entities;
using WatchStore.WebApi.Repositories;
using WatchStore.WebApi.Repositories.Abstract;
using WatchStore.WebApi.Services;
using WatchStore.WebApi.Services.Abstract;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("WatchStoreDbConnection");

builder.Services.AddDbContext<WatchStoreDbContext>(options => 
    options.UseSqlServer(connectionString));
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ICartItemRepository, CartItemRepository>();
builder.Services.AddTransient<CartRepository, CartRepository>();
builder.Services.AddTransient<IProductsService, ProductsService>();
builder.Services.AddTransient<ICartService, CartService>();


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

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetService<WatchStoreDbContext>();
    if (db is not null && !db.Products.Any())
    {
        db.Database.MigrateAsync();
    }
}


app.MapGet("/products", (IProductsService productsService) => productsService.GetProducts()).WithOpenApi();
app.MapGet("/products/{id:int}", (int id, IProductsService productsService) => productsService.GetProductById(id)).WithOpenApi();

app.MapGet("/cart", (ICartService cartService) => cartService.GetCartItems()).WithOpenApi();
app.MapPost("/cart", (int productId, ICartService cartService) => cartService.AddItem(new CartItem
{
    ProductId = productId,
    CartId = 1
})).WithOpenApi();


app.Run();