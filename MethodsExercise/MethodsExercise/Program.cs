using System;

namespace MethodsExercise
{
    class Program
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;

        }
        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public static decimal Mulitiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Square(int number)
        {
            return number * number;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static bool IsEven(int number)
        {
            if ((number % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static decimal Percentage(int num1, int num2)
        {
            return (num1 / num2) * 100;
        }
        public static string SayHello(string name)
        {
            return ($"Hello, {name}, how are you today?");



        }
        static void Main(string[] args)
        {
            Console.WriteLine(Percentage(1,2));
            //Need to research how to display a %//
            Console.WriteLine(Addition(12, -34));
            Console.WriteLine(Addition(4, 9));
            Console.WriteLine(Subtraction(234, 43));
            Console.WriteLine(Subtraction(-345567, 22345));
            Console.WriteLine(Mulitiply(2, 90));
            Console.WriteLine(Mulitiply(456, 33457));
            Console.WriteLine(Square(45));
            Console.WriteLine(Square(-123456));
            Console.WriteLine(Divide(123456789, 1234));
            Console.WriteLine(Divide(45, 9));
            Console.WriteLine(Modulus(123456789, 1234));
            Console.WriteLine(Modulus(45, 9));
            Console.WriteLine(IsEven(345));
            Console.WriteLine(SayHello("thad"));


            
        }
    }
}
