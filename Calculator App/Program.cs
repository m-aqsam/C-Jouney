using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{


    internal class Calculator
    {
        static void Main(string[] args)


        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                String operation;
                double result = 0;





                Console.WriteLine("---------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("---------------------");

                Console.WriteLine("Enter 1st Num :");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter 2nd Num :");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select The Operation : \n " +
                    "\t + For Add : \n " +
                    "\t - For Subtract : \n " +
                    "\t * For Multiply : \n " +
                    "\t / For Division : \n "

                    );

                Console.Write("Select Operation : ");
                operation = Console.ReadLine();


                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($" Your Result is {num1} + {num2} =  {result}");
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($" Your Result is {num1} - {num2} =  {result}");
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($" Your Result is {num1} * {num2} =  {result}");
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($" Your Result is {num1} / {num2} =  {result}");
                        break;

                    default:
                        Console.WriteLine("Choose Valid Operations Only.");
                        break;

                }
                Console.WriteLine("Would You Like To Continue ? Y For \"Yes and N For \"No");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");















            Console.ReadLine();
        }
    }
}
