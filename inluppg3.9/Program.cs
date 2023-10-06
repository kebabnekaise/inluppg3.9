using System;

namespace inluppg3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition");
            string input = Console.ReadLine();

            int indexPlus1 = input.IndexOf('+');
            int number1 = int.Parse(input[..indexPlus1]);

            if (input[(indexPlus1+1)..].Contains('+'))
            {
                int indexPlus2 = input[(indexPlus1 + 1)..].IndexOf('+') + indexPlus1;

                int number2 = int.Parse(input[indexPlus1..(indexPlus2+1)]);
                int number3 = int.Parse(input[(indexPlus2+1)..]);
                Console.WriteLine(number1 + number2 + number3);
            }
            else
            {
                int number2 = int.Parse(input[(indexPlus1 + 1)..]);
                Console.WriteLine(number1 + number2);
            }
        }
    }
}