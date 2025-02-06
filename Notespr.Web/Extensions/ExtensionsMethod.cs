using Microsoft.EntityFrameworkCore;
using Notespr.Data.AppDbContext;

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
    }
}
