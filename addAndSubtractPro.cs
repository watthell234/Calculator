using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MeghanCalc
{
    class DamCalc
    {

        #region calc
        static void Main(string[] args)
        {

            bool Exit = false;
            while (!Exit)
            {

                Console.Write("Enter Your Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("I Am Your Personal Calculator, Press Enter " + name);
                Console.ReadKey();


                Console.WriteLine("Number: ");
                int number;
                string numberAsAString = Console.ReadLine();
                if (!int.TryParse(numberAsAString, out number))
                {
                    Console.WriteLine("Not an integer");
                    return;
                }
                double number1 = Convert.ToDouble(number);


                Console.WriteLine("To this number Add/Subtract/Multiply/Divided: ");
                int number2;
                string number2AsAString = Console.ReadLine();
                if (!int.TryParse(number2AsAString, out number2))
                {
                    Console.WriteLine("Not an integer");
                }
                double number2d = Convert.ToDouble(number2);

                double sum = number1 + number2d;
                double subtract = number1 - number2d;
                double multiply = number1 * number2d;
                double dividend = number1 / number2d;

                Console.WriteLine("The sum of the numbers is = " + sum);
                Console.WriteLine("The difference of the numbers is = " + subtract);
                Console.WriteLine("The product of the numbers is = " + multiply);
                Console.WriteLine("The dividend of the numbers is = " + dividend);

                Console.ReadKey();

                Console.WriteLine("If you'd like to exit press x");
                string i = Console.ReadLine();
                if (i == "x" )
                {
                    Exit = true;
                }
                

            }

            
            
        }        
        #endregion
    }
}
