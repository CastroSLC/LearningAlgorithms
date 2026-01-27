using System.Numerics;

namespace LearningAlgorithms.Algoritmos.Easy {
    public static class Factorial {
        /*
            Given a number, get the factorial of that number. 
            Print the result
        */
        public static void GetNFactorial(int number) {
            BigInteger total = number;

            for(int i = number - 1; i > 0; i--) {
                total *= i;
            }

            Console.WriteLine(total);
        }
    }
}