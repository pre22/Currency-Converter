using System;

namespace Converter
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string UserChoice = string.Empty;
            do
            {
                double usd, ngn, rate;

                // Currency Rate
                Console.Write("Enter an amount of USD: ");
                usd = Int32.Parse(Console.ReadLine());
                rate = 365;
                ngn = usd * rate;

                Console.WriteLine("{0} Dollar == {1} NGN", usd , ngn);

                do
                {
                    Console.Write("Do you want to continue - Yes or No: ");

                    UserChoice = Console.ReadLine();
                    if (UserChoice != "Yes" && UserChoice != "No")
                    {
                        Console.WriteLine("Invalid Choice, Please say Yes or NO");
                    }
                    else if (UserChoice == "No")
                    {
                        Console.WriteLine("Nice Working with you");
                    }
                } while (UserChoice != "Yes" && UserChoice != "No");
            } while (UserChoice == "Yes");
        }
    }
}
