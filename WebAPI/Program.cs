
using DataAccessLayer.Repository;
using DataAccessLayer;
using BusinessLayer.Contracts;
using BusinessLayer.Services;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Repository
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            
            //Services
            builder.Services.AddScoped(typeof(ITestService), typeof(TestService));
            builder.Services.AddScoped(typeof(IProductService), typeof(ProductService));
            //Database
            builder.Services.AddDbContext<MyDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
