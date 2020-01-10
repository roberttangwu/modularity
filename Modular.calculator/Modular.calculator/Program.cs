using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular.calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();

            Console.WriteLine("##################################################");
            Console.WriteLine("############# C# C A L C U L A T O R #############");
            Console.WriteLine("##################################################");
            bool calcLoop = true;
            while (calcLoop == true)
            {
                Console.Write("Enter your first number: ");
                double inputOne = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number: ");
                double inputTwo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nMenu");
                Console.WriteLine("Enter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4 for division");
                Console.WriteLine("");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        Console.WriteLine("\nYour answer is: " + myCalc.Add(inputOne, inputTwo).ToString());
                        break;
                    case 2:
                        Console.WriteLine("\nYour answer is: " + myCalc.Subtract(inputOne, inputTwo).ToString());
                        break;
                    case 3:
                        Console.WriteLine("\nYour answer is: " + myCalc.Multiply(inputOne, inputTwo).ToString());
                        break;
                    case 4:
                        Console.WriteLine("\nYour answer is: " + myCalc.Divide(inputOne, inputTwo).ToString());
                        break;
                    default:
                        Console.WriteLine("\nYou should enter a number from the menu. ");
                        break;


                }
                Console.WriteLine("");
                Console.Write("\nDo you want to try another sum? Y/N: ");
                string restartChoice = Console.ReadLine().ToUpper();

                if (restartChoice == "Y")
                {
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                
                }
                else
                {
                    Console.WriteLine("press any key to exit");
                    calcLoop = false;

                }
            }
            Console.ReadKey();






        }
    }
}
