using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.CalcActions;
using static System.Console;

// org.tyaa.demo.delagates.calc
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcActions calcActions = new CalcActions();
            Write("Enter an expression: ");
            string expression = ReadLine();            char sign = ' ';
            foreach (var symbol in expression)
            {
                if (symbol == '+' || symbol == '-')
                {
                    sign = symbol;
                    break;
                }
            }
            string[] paramsArray = expression.Split(sign);
            double result = 0;
            // Step 3
            ActionDelegate action = null;
            switch (sign)
            {
                case '+':
                    //result = CalcActions.Add(double.Parse(paramsArray[0]), double.Parse(paramsArray[1]));
                    // Step 4-1
                    action = new ActionDelegate(CalcActions.Add);
                    break;
                case '-':
                    // result = calcActions.Subtr(double.Parse(paramsArray[0]), double.Parse(paramsArray[1]));
                    // Step 4-2
                    action = new ActionDelegate(calcActions.Subtr);
                    break;
                default:
                    break;
            }
            // Step 5. Completion.
            Console.WriteLine(action?.Invoke(double.Parse(paramsArray[0]), double.Parse(paramsArray[1])));
            // Console.WriteLine(result);

        }
    }
}
