using APBD_09.Data;
using Microsoft.EntityFrameworkCore;

namespace APBD_09;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();
        builder.Services.AddOpenApi();

        builder.Services.AddDbContext<ClinicDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseAuthorization();

        app.Run();
    }
}