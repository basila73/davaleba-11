namespace davaleba_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                User client = new ClientUser("Saba", "12345", "client@gmail.com");

                User admin = new AdminUser("Admin", "admin123", "admin@gmail.com");

                Console.WriteLine("Client Login:");
                client.Authorization();

                Console.WriteLine();

                Console.WriteLine("Admin Login:");
                admin.Authorization();
            }
        }
    }
}
