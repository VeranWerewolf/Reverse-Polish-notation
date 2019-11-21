using System;

namespace Reverse_Polish_notation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app is for testing Reverse Polish notation." 
                + System.Environment.NewLine + "Just put your expression below:");
            string expression = Console.ReadLine();
            RPN notation = new RPN(expression);
            Console.WriteLine(@"The expression in RPN: {0}", notation.ConvertExpressionToRPN());
            Console.WriteLine(@"The result is: {0}", notation.GetResult());

            // Wait for exit
            Console.ReadKey();
        }
    }
}
