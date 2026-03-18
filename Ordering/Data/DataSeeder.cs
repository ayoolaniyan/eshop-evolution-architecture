namespace Ordering.Data
{
    public class DataSeeder
    {
        public static void Seed(OrderDbContext dbContext)
        {
            if (dbContext.Orders.Any())
                return;

            dbContext.Orders.AddRange(Orders);
            dbContext.SaveChanges();
        }

        public static IEnumerable<Order> Orders =>
        [
            new Order { UserName = "swn", TotalPrice = 122.99m, FirstName = "test", LastName = "test", EmailAddress = "test@test.com", AddressLine = "Test"  }
        ];
    }
}
