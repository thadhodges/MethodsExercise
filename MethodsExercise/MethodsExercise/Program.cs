using System;

namespace MethodsExercise
{
    class Program
    {
        public static int Addition(int num1, int num2)
        {
            int addition = num1 + num2;
            return addition;
        }
        static void Main(string[] args)
        {
            Addition(12, 34);
            Addition(4, 9);
        }
    }
}
