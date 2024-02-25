using BookStoreApi.Models;
using BookStoreApi.Services;
using ApiProjectApi.Models;
using ApiProjectApi.Services;
///using BookStoreApi.Services;
///using ApiProjectApi.Services;

namespace ApiProjectApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.Configure<BookStoreDatabaseSettings>(
                builder.Configuration.GetSection("BookStoreDatabase"));

            builder.Services.AddSingleton<BooksService>();

            builder.Services.Configure<ShoppingListDatabaseSettings>(
                builder.Configuration.GetSection("ShoppingListDatabase"));

            builder.Services.AddSingleton<ShoppingListService>();

            builder.Services.AddControllers().AddJsonOptions(
            options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}