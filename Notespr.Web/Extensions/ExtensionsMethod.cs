using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Notespr.Data.AppDbContext;
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
    }
}
