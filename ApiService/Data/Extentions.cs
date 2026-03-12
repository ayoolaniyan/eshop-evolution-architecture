using Microsoft.EntityFrameworkCore;

namespace ApiService.Data
{
    public static class Extentions
    {
        public static void UseMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<EShopDbContext>();

            context.Database.Migrate();
            DataSeeder.Seed(context);
        }
    }
}
