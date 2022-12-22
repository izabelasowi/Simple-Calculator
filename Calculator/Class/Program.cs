using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{

    class Program
    {

        static void Main(string[] args)
        {
            
            bool exit = false;

            while (!exit)
            {
                try
                {
                    InputConverter inputConventer = new InputConverter();
                    CalculatorEngine calculatorEngine = new CalculatorEngine();

                    Console.WriteLine("Enter operation type [+, -, *, /]: press x to exit ");
                    string operation = Console.ReadLine();
                    if (operation == "x")
                    { exit = true; break; }
                    Console.WriteLine("Enter First Number: ");
                    double firstNumber = inputConventer.ConvertInputToNumber(Console.ReadLine());
                    Console.WriteLine("Enter Second Number: ");
                    double secondNumber = inputConventer.ConvertInputToNumber(Console.ReadLine());
                    Console.WriteLine("Result:");
                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                    Console.WriteLine(result);
                    Console.ReadKey();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }
            kwadrat a = new kwadrat(5);
            kwadrat b = new kwadrat(2);

            int x = 1;
            int y = 2;
            x = y;

            b = a;

            Console.WriteLine(a.bok.ToString());
            Console.WriteLine(b.bok.ToString());
            Console.ReadKey();
            a.bok=15;
            Console.WriteLine(a.bok.ToString());
            Console.WriteLine(b.bok.ToString());
            Console.ReadKey();
        }
        }

        public class kwadrat
        {
            public int bok;
            public kwadrat(int bok)
            {
                this.bok = bok;
            }

        }


    }


  
