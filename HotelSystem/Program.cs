namespace HotelSystem
{
    internal class Program
    {
        static string input = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Start();
        }

        public static void Start()
        {
            do
            {
                Console.WriteLine("Please choose an option\n1. Admin\n2. Customer\n3. Exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        string email = UserEmail();
                        string password = UserPassword();
                        AuthServices.LogInAdmin(email, password);
                        break;
                    case "2":
                        string email1 = UserEmail();
                        string password1 = UserPassword();
                        AuthServices.LogInCustomer(email1, password1);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }
            }
            while (true);
        }
        
        public static string UserEmail()
        {
            Console.WriteLine("Please insert your email");
            string email = Console.ReadLine();
            return email;
        }
        public static string UserPassword()
        {
            Console.WriteLine("Please insert your password");
            string password = Console.ReadLine();
            return password;
        }
    }
}