using Microsoft.EntityFrameworkCore;

namespace Catalog.Data
{
    public static class Extensions
    {
        public static void UseMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<CatalogDbContext>();

            context.Database.Migrate();
            DataSeeder.Seed(context);
        }        
    }
}
