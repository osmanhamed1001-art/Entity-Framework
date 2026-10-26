using Microsoft.EntityFrameworkCore;

namespace EF001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookstoreContext();

            Console.WriteLine(context.Database.CanConnect()
                ? "Database connected successfully!"
                : "Database connection failed!");
        }
    }
}
