using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("basic calculator");
            char symbol;
            int num1, num2,result;
            Console.WriteLine("Choose 1 operation (+,-,*,/)");
            symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the two numbers");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            if(symbol=='+')
            {
                result = num1 + num2;
                Console.WriteLine($"result={result}");
            }
            else if(symbol == '-')
            {
                result = num1 + num2;
                Console.WriteLine($"result={result}");
            }
            else if (symbol == '*')
            {
                result = num1 * num2;
                Console.WriteLine($"result={result}");
            }
            else if (symbol == '/')
            {
                result = num1 / num2;
                Console.WriteLine($"result={result}");
            }
           
        }
    }
}
