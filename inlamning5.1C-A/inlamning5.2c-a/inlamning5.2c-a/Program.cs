using System;
using System.Threading.Channels;

namespace inlamning5._2ac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal vill du skriva in?");
            int numberOfInputs = int.Parse(Console.ReadLine());
            string[] userInput = new string[numberOfInputs];

            Console.WriteLine($"Skriv in {numberOfInputs} heltal");

            for (int i = 0; i < numberOfInputs; i++)
            {
                userInput[i] = Console.ReadLine();

            }

            for (int i = 0;i < numberOfInputs; i++)
            {
                Console.WriteLine($"Tal {i+1}: {userInput[i]}");

            }

            Console.ReadKey();

        }

    }

}
