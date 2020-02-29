using System;

namespace Validations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double quotient;
            bool isValid;

            do
            {
                try
                {
                    isValid = true;

                    Console.WriteLine("Enter the 1 number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the 2 number: ");
                    num2 = int.Parse(Console.ReadLine());

                    quotient = Divide(num1, num2);

                }
                catch (ArithmeticException myError)
                {
                    Console.WriteLine(myError.Message);
                    isValid = false;

                }
                catch (FormatException myError)
                {
                    Console.WriteLine(myError.Message);
                    isValid = false;

                }
                finally
                {
                    Console.WriteLine("OK");


                }




            }
            while (isValid == false);

        }
        public static double Divide(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArithmeticException("Fuck off");
            else
                return (double)numerator / denominator;
        }
    }
}
