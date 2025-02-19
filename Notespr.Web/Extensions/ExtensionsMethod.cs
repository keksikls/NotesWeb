using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Notespr.Data.AppDbContext;
using Notespr.Data.UnitOfWork.IUnitOfWorks;
using Notespr.Data.UnitOfWorks;
using Notespr.Web.Midleware;

namespace Notespr.Web.Extensions
{
    public static class ExtensionsMethod
    {
        public static WebApplicationBuilder AddData(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            return builder;
        }

        public static IApplicationBuilder AddLoggerMidleware(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<LoggingMidleware>();
        }

        //регистрируем в di время жизни для обьекта unitofwork
        public static WebApplicationBuilder AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            return builder;
        }
    }
}
