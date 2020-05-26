using System;

namespace ZotighExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                try
                {
                    Console.WriteLine("Please enter num1: ");
                    string num1str = Console.ReadLine();
                    int num1 = int.Parse(num1str);

                    Console.Write("Please enter num2: ");
                    string num2str = Console.ReadLine();
                    int num2 = int.Parse(num2str);

                    Console.WriteLine("Num1/Num2: {0}", num1 / num2);
                }
                catch
                {
                    Console.WriteLine("There was an error!");
                }
                Console.Write("Do another (y/n): ");
                doAnother = Console.ReadLine();

            } while (doAnother == "y");
        }
    }
}
