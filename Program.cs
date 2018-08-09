using System;

namespace measure
{
    class Program
    {
        public enum Unit {cm, inches};
        static void Main(string[] args)
        {
            string userEnteredCM = GetUsersInput();

            //var unit = Unit.item;
            double userInputAsInt = convertCmToInch(userEnteredCM);
            Console.WriteLine($"{userEnteredCM}cm's equals {userInputAsInt} inches");
        }

        private static string GetUsersInput()
        {
            Console.WriteLine("Enter your cm to calculate to inches");
            string userEnteredCM = Console.ReadLine();
            Console.WriteLine($"You entered {userEnteredCM} cm's");
            return userEnteredCM;
        }

        private static double convertCmToInch(string userEnteredCM)
        {
            double userInputAsInt = Convert.ToDouble(value: userEnteredCM);
            return userInputAsInt / 2.54;
        }
    }
}


//https://www.microsoft.com/net/learn/get-started/windows

//https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/interpolated-strings-local

//up to here http://xunit.github.io/docs/getting-started-dotnet-core