using System;

namespace _3_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.Write("Ведите число: ");
            userInput = Console.ReadLine();

            ConvertToNamber(userInput);
        }
        static void ConvertToNamber(string varible)
        {
            bool resultOperation;
            bool continueFunction = true;

            while (continueFunction == true)
            {
                resultOperation = int.TryParse(varible, out int result);
                if (resultOperation == true)
                {
                    Console.WriteLine(result);
                    continueFunction = false;
                }
                else 
                {
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Ведите число: ");
                    varible = Console.ReadLine();
                }
            }
        }
    }
}
