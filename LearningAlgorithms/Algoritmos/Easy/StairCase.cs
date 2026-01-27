using System.Text;

namespace LearningAlgorithms.Algoritmos.Easy {
    /*
        StairCase
        https://www.hackerrank.com/challenges/staircase/problem
        Given a positive integer n, print a staircase of size n.
        Example
        n = 4 
        print:
            #
           ##
          ###
         ####
        Note: The last line has 0 spaces before it.
        Key Note: All lines are right-aligned.
     */

    public static class StairCase {
        //staircase(6);
        static void staircase(int n) {
            char character = '#';

            //StringBuilder nos puede ayudar cuando tenemos que construir strings de forma iterativa
            //Ya que son mutables pueden ahorrarnos memoria y tiempo de procesamiento
            StringBuilder stair = new StringBuilder();

            for(int i = 1; i <= n; i++) {
                stair.AppendLine($"{"".PadLeft(n - i)}{new string(character, i)}");
            }

            Console.Write(stair.ToString());
        }
    }
}
