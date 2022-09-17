using System;

namespace _3_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadingTheNumber();
        }

        static void ReadingTheNumber()
        {
            bool resultOperation;
            bool isFunctionContinue = true;
            string userInput;

            while (isFunctionContinue == true)
            {
                Console.Write("Ведите число: ");
                userInput = Console.ReadLine();

                resultOperation = int.TryParse(userInput, out int result);

                if (resultOperation == true)
                {
                    Console.WriteLine(result);
                    isFunctionContinue = false;
                }
                else 
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
        }
    }
}
