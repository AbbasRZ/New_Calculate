using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculate Calc = new SimpleCalculate();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Choose on of the operation : \n 1. addition  \n 2. subtraction" +
                    " \n 3. multiplication \n 4. division \n 5. square root     ");

                switch(Console.ReadLine())
                {
                    case "1":
                        try
                        {
                            Calc.Menyu();
                            Console.WriteLine($"Result:{Calc.Sum(Calc.a, Calc.b)}");
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine($"Error{exp.Message}");
                        }
                        break;
                    case "2":
                        try
                        {
                            Calc.Menyu();
                            Console.WriteLine($"Result:{Calc.Min(Calc.a, Calc.b)}");
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine($"Error{exp.Message}");
                        }
                        break;
                    case "3":
                        try
                        {
                            Calc.Menyu();
                            Console.WriteLine($"Result:{Calc.Mult(Calc.a, Calc.b)}");
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine($"Error{exp.Message}");
                        }
                        break;
                    case "4":
                        try
                        {
                            Calc.Menyu();
                            Console.WriteLine($"Result:{Calc.Div(Calc.a, Calc.b)}");
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine($"Error{exp.Message}");
                        }
                        break;
                    case "5":
                        try
                        {
                            Console.WriteLine("Введите число");
                            Calc.a = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Result: {Calc.Sqrt(Calc.a)}");
                        }
                        catch (Exception Exp)
                        {
                            Console.WriteLine($"Error {Exp.Message}");
                        }
                        break;

                       
                }
                Console.ReadKey();

            }
        }
    }
}
